using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etl
{
    public class MyTable
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

    public class MyColumn
    {
        public String Name { get; set; }
        public String Type { get; set; }
        public String Size { get; set; }

        public MyColumn(String newName, String newType, String newSize)
        {
            Name = newName;
            Type = newType;
            Size = newSize;
        }
        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            MyColumn p = obj as MyColumn;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (Name.Equals(p.Name)) && (Type.Equals(p.Type)) && (Size.Equals(p.Size));
        }
    }
}
