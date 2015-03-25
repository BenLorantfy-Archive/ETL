using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etl
{
    class Favourite
    {
        public string IP = "";
        public string DMS = "";
        public string Username = "";
        public string Password = "";
        public string DBName = "";

        public Favourite(){ }

        public Favourite(string ip, string dms, string username, string password, string dbName)
        {
            IP = ip;
            DMS = dms;
            Username = username;
            Password = password;
            DBName = dbName;
        }
    }
}
