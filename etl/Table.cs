using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etl
{
    class MyTable
    {
        public String Name { get; set; }
        private List<MyColumn> columns;

        public MyTable(String newName)
        {
            Name = newName;
            columns = new List<MyColumn>();
        }

        public void AddColumn(MyColumn newColumn)
        {
            columns.Add(newColumn);
        }

        public List<MyColumn> GetColumns()
        {
            return columns;
        }
    }

    class MyColumn
    {
        public String Name { get; set; }
        public String Type { get; set; }

        public MyColumn(String newName, String newType)
        {
            Name = newName;
            Type = newType;
        }
    }
}
