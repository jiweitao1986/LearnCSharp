using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Ds
{
    public static class DataTableTest
    {
        public static void Run()
        {

        }


        public static void SetPrimaryKeyTest()
        {
            // Create a new DataTable and set two DataColumn objects as primary keys.
            DataTable table = new DataTable();
            DataColumn[] keys = new DataColumn[2];
            DataColumn column;

            // Create column 1.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FirstName";
            table.Columns.Add(column);

            // Create column 2 and add it to the array.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LastName";
            table.Columns.Add(column);

            // Add the column 1 and column 2  to the array.
            keys[1] = column;
            keys[0] = column;

            // Set the PrimaryKeys property to the array.
            table.PrimaryKey = keys;
        }

        public static void GetPrimaryKeyTest()
        {
            /*
            // Create the array for the columns.
            DataColumn[] columns;
            columns = table.PrimaryKey;

            // Get the number of elements in the array.
            Console.WriteLine("Column Count: " + columns.Length);
            for (int i = 0; i < columns.Length; i++)
            {
                Console.WriteLine(columns[i].ColumnName + columns[i].DataType);
            }
            */
        }
    }
}
