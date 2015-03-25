﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Odbc;
using System.Xml;

namespace etl
{
    public partial class ETLUtility : Form
    {

        OdbcConnection con;
        OdbcConnection local;

        Dictionary<String, MyTable> originalSchema = new Dictionary<String, MyTable>();
        Dictionary<String, MyTable> localSchema = new Dictionary<String, MyTable>();
        
        private Dictionary<string, Favourite> favourites = new Dictionary<string, Favourite>();
        private string lastSourceFavourite = "";
        private string lastDestinationFavourite = "";

        public ETLUtility()
        {
            InitializeComponent();
        }

        private void ETLUtility_Load(object sender, EventArgs e)
        {
            favourites = LoadFavourites();
            foreach (KeyValuePair<string, Favourite> favourite in favourites)
            {
                lstFavourites.Items.Add(favourite.Key);
            }
        }

        private Dictionary<string, Favourite> LoadFavourites()
        {
            Dictionary<string, Favourite> favourites = new Dictionary<string, Favourite>();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.CloseInput = true;
            XmlReader reader = null;

            try
            {
                reader = XmlReader.Create("favourites.xml", settings);

                Favourite favourite = null;
                string favouriteName = "";
                string name = "";

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        name = reader.Name;
                        if (name == "favourite")
                        {
                            //
                            // Add old favourite to dictionary of favourites
                            //
                            if (favourite != null)
                            {
                                favourites.Add(favouriteName, favourite);
                            }

                            //
                            // Create object for new favourite and save favourite name
                            //
                            favourite = new Favourite();
                            favouriteName = reader.GetAttribute("name");
                        }
                    }

                    if (reader.HasValue)
                    {
                        string value = reader.Value;
                        switch (name)
                        {
                            case "ip":
                                favourite.IP = value;
                                break;
                            case "dms":
                                favourite.DMS = value;
                                break;
                            case "username":
                                favourite.Username = value;
                                break;
                            case "password":
                                favourite.Password = value;
                                break;
                            case "dbname":
                                favourite.DBName = value;
                                break;
                        }
                    }

                }

                favourites.Add(favouriteName, favourite);
            }
            catch { }
            finally{
                reader.Dispose();
                reader = null;
            }

            return favourites;
        }

        private string GetSourceConStr()
        {
            string conStr = "";
            string ip = txtSourceIP.Text;
            string dms = (cmbSourceDMS.SelectedItem == null) ? "" : cmbSourceDMS.SelectedItem.ToString();
            string username = txtSourceUsername.Text;
            string password = txtSourcePassword.Text;
            string dbName = txtSourceDBName.Text;
            string driver = "";

            if(dms == "MySQL"){
                driver = "MySQL ODBC 3.51 Driver";
            }else if(dms == "MSSQL"){

            }

            bool valid = ip != "" && driver != "" && username != "" && password != "" && dbName != "";

            if (valid)
            {
                conStr = "DRIVER={" + driver + "}; SERVER=" + ip + "; DATABASE=" + dbName + "; USER=" + username + "; PASSWORD=" + password + "; OPTION=0;";
            }
            else
            {
                conStr = null;
            }

            return conStr;
        }

        private void btnSetSource_Click(object sender, EventArgs e)
        {
            if (lstFavourites.SelectedItem != null)
            {
                string name = lstFavourites.SelectedItem.ToString();
                Favourite favourite = favourites[name];
                txtSourceIP.Text = favourite.IP;
                cmbSourceDMS.SelectedItem = favourite.DMS;
                txtSourceUsername.Text = favourite.Username;
                txtSourcePassword.Text = favourite.Password;
                txtSourceDBName.Text = favourite.DBName;
                lastSourceFavourite = name;
            }
        }

        private void btnSetDestination_Click(object sender, EventArgs e)
        {
            if (lstFavourites.SelectedItem != null)
            {
                string name = lstFavourites.SelectedItem.ToString();
                Favourite favourite = favourites[name];
                txtDestinationIP.Text = favourite.IP;
                cmbDestinationDMS.SelectedItem = favourite.DMS;
                txtDestinationUsername.Text = favourite.Username;
                txtDestinationPassword.Text = favourite.Password;
                txtDestinationDBName.Text = favourite.DBName;
                lastDestinationFavourite = name;
            }
        }

        private void saveSource_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter a name for this connection information favourite", "Add favourite", lastSourceFavourite, -1, -1);
            if (name != null && name != "")
            {
                string dms = (cmbSourceDMS.SelectedItem == null) ? "" : cmbSourceDMS.SelectedItem.ToString();
                Favourite favourite = new Favourite(txtSourceIP.Text, dms, txtSourceUsername.Text, txtSourcePassword.Text, txtSourceDBName.Text);
                if (favourites.ContainsKey(name))
                {
                    favourites[name] = favourite;
                }
                else
                {
                    favourites.Add(name, favourite);
                    lstFavourites.Items.Add(name);
                }
                
                

                if (!SaveFavourites())
                {
                    favourites.Remove(name);
                    lstFavourites.Items.Remove(name);
                    MessageBox.Show("Failed to save favourite");
                }
            }
        }

        private void saveDestination_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter a name for this connection information favourite", "Add favourite", lastDestinationFavourite, -1, -1);
            if (name != null && name != "")
            {
                string dms = (cmbDestinationDMS.SelectedItem == null) ? "" : cmbDestinationDMS.SelectedItem.ToString();
                Favourite favourite = new Favourite(txtDestinationIP.Text, dms, txtDestinationUsername.Text, txtDestinationPassword.Text, txtDestinationDBName.Text);
                if (favourites.ContainsKey(name))
                {
                    favourites[name] = favourite;
                }
                else
                {
                    favourites.Add(name, favourite);
                    lstFavourites.Items.Add(name);
                }


                if (!SaveFavourites())
                {
                    favourites.Remove(name);
                    lstFavourites.Items.Remove(name);
                    MessageBox.Show("Failed to save favourite");
                }
            }
        }

        private bool SaveFavourites()
        {
            bool success = false;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.CloseOutput = true;
            settings.Indent = true;
            XmlWriter writer = null;
            try
            {
                writer = XmlWriter.Create("favourites.xml",settings);
                writer.WriteStartDocument();
                writer.WriteStartElement("favourites");
                foreach (KeyValuePair<string, Favourite> favouritePair in favourites)
                {
                    Favourite favourite = favouritePair.Value;
                    string name = favouritePair.Key;

                    writer.WriteStartElement("favourite");
                    writer.WriteAttributeString("name", name);

                    writer.WriteElementString("ip", favourite.IP);
                    writer.WriteElementString("dms", favourite.DMS);
                    writer.WriteElementString("username", favourite.Username);
                    writer.WriteElementString("password", favourite.Password);
                    writer.WriteElementString("dbname", favourite.DBName);

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();

                success = true;
            }
            catch {
                success = false;
            }
            finally
            {
                writer.Dispose();
                writer = null;
            }

            return success;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = lstFavourites.SelectedItem.ToString();
            favourites.Remove(name);
            lstFavourites.Items.Remove(name);

            if (!SaveFavourites())
            {
                MessageBox.Show("Failed to delete favourite");
            }
        }

        private void beginTransfer_Click(object sender, EventArgs e)
        {
            con = new OdbcConnection("DRIVER={MySQL ODBC 3.51 Driver}; SERVER=107.180.0.245; DATABASE=ASQL-A3; USER=set_student; PASSWORD=123456; OPTION=0;");
            local = new OdbcConnection("DRIVER={MySQL ODBC 3.51 Driver}; SERVER=127.0.0.1; DATABASE=test; USER=root; PASSWORD=Conestoga1; OPTION=0;");

            con.Open();
            local.Open();

            List<String> tables = GetTables(con, originalSchema);
            List<String> localTables = GetTables(local, localSchema);

            List<MyTable> missingTables = FindMissingTables(originalSchema, localSchema);
            Dictionary<String, MyTable> missingColumns = FindMissingColumns(originalSchema, localSchema);

            con.Close();

            DisplayMissingTables(missingTables);
            DisplayMissingColumns(missingColumns);
        }

        private List<String> GetTables(OdbcConnection con, Dictionary<String, MyTable> schema)
        {
            List<String> retTables = new List<String>();

            DataTable tables = con.GetSchema("TABLES");
            DataTable columns = con.GetSchema("COLUMNS");

            foreach (DataRow row in tables.Rows)
            {
                String tableName = row["TABLE_NAME"].ToString().ToLower();
                schema.Add(tableName, new MyTable(tableName));
            }

            foreach (DataRow row in columns.Rows)
            {
                String tableName = row["TABLE_NAME"].ToString().ToLower();
                schema[tableName].AddColumn(new MyColumn(row["COLUMN_NAME"].ToString(), row[5].ToString()));
            }

            return retTables;
        }

        private List<MyTable> FindMissingTables(Dictionary<String, MyTable> original, Dictionary<String, MyTable> toCheck)
        {
            List<MyTable> missingTables = new List<MyTable>();

            foreach (KeyValuePair<String, MyTable> pair in original)
            {
                if (toCheck.ContainsKey(pair.Key) == false)
                {
                    missingTables.Add(original[pair.Key]);
                }
            }

            return missingTables;
        }

        private Dictionary<String, MyTable> FindMissingColumns(Dictionary<String, MyTable> original, Dictionary<String, MyTable> toCheck)
        {
            Dictionary<String, MyTable> missingColumns = new Dictionary<String, MyTable>();

            foreach (KeyValuePair<String, MyTable> pair in original)
            {
                if (toCheck.ContainsKey(pair.Key) == true)
                {
                    missingColumns.Add(pair.Key, new MyTable(pair.Key));

                    List<MyColumn> originalColumns = pair.Value.GetColumns();
                    List<MyColumn> localColumns = toCheck[pair.Key].GetColumns();

                    foreach (MyColumn column in originalColumns)
                    {
                        bool contains = false;

                        for (int i = 0; i < localColumns.Count && contains == false; i++)
                        {
                            if (originalColumns[i].Equals(column) == true)
                            {
                                contains = true;
                            }
                        }

                        if (contains == false)
                        {
                            missingColumns[pair.Key].AddColumn(column);
                        }
                    }
                }
            }

            return missingColumns;
        }


        private void DisplayMissingTables(List<MyTable> missingTables)
        {
            /*
            listBox1.Items.Clear();

            foreach (MyTable table in missingTables)
            {
                listBox1.Items.Add("*" + table.Name);

                foreach (MyColumn column in table.GetColumns())
                {
                    listBox1.Items.Add("\t-" + column.Name + "(" + column.Type + ")");
                }
            }
            */
        }

        private void DisplayMissingColumns(Dictionary<String, MyTable> missingColumns)
        {
            /*
            listBox2.Items.Clear();

            foreach (KeyValuePair<String, MyTable> pair in missingColumns)
            {
                if (pair.Value.GetColumns().Count > 0)
                {
                    listBox2.Items.Add("*" + pair.Value.Name);

                    foreach (MyColumn column in pair.Value.GetColumns())
                    {
                        listBox2.Items.Add("\t-" + column.Name + "(" + column.Type + ")");
                    }
                }
            }
            */
        }

    }
}