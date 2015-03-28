/*
 * FILE         |   Changes.cs
 * PROJECT      |   ASQL Assignment #3
 * DATE         |   27-03-2015
 * AUTHOR       |   Greg Kozyrev & Ben Lorantfy
 * DESCRIPTION  |   Purpose of this file is to prompt user about changes and ask for permission.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etl
{
    public partial class Changes : Form
    {
        public Boolean Apply { get; set; }

        public Changes(List<MyTable> tables, Dictionary<String, MyTable> columns)
        {
            InitializeComponent();
            Apply = false;

            DisplayMissingTables(tables);
            DisplayMissingColumns(columns);
        }

        private void DisplayMissingTables(List<MyTable> missingTables)
        {
            tablesBox.Items.Clear();

            foreach (MyTable table in missingTables)
            {
                tablesBox.Items.Add("*" + table.Name);

                foreach (MyColumn column in table.GetColumns())
                {
                    tablesBox.Items.Add("\t-" + column.Name + "(" + column.Type + "|" + column.Size + ")");
                }
            }
        }

        private void DisplayMissingColumns(Dictionary<String, MyTable> missingColumns)
        {
            columnsBox.Items.Clear();

            foreach (KeyValuePair<String, MyTable> pair in missingColumns)
            {
                if (pair.Value.GetColumns().Count > 0)
                {
                    columnsBox.Items.Add("*" + pair.Value.Name);

                    foreach (MyColumn column in pair.Value.GetColumns())
                    {
                        columnsBox.Items.Add("\t-" + column.Name + "(" + column.Type + "|" + column.Size + ")");
                    }
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Apply = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Apply = false;
            this.Close();
        }
    }
}
