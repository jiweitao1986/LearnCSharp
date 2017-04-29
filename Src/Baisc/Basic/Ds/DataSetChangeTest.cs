using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LearnCSharp.Basic.Ds
{
    /// <summary>
    /// DataSet变更测试
    /// </summary>
    public class DataSetChangeTest
    {
        public static void Run()
        {
            //MergeTest();
            var deptEmpDs = MockDataUtil.GetDeptEmpDataSet();
            var deptEmpDsChanges = ReadChangesJson();
            //ApplyDsChanges(deptEmpDs, deptEmpDsChanges);
        }



        /// <summary>
        /// 获取解析之后的Ds
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, List<DataRowChange>> ReadChangesJson()
        {
            var path = @"../../Ds/DeptEmpChanges.json";
            string strJson = File.ReadAllText(path);
            Console.WriteLine(strJson);

            var dsChanges = JsonConvert.DeserializeObject<Dictionary<string, List<DataRowChange>>>(strJson);

            //foreach (var dsChangePair in dsChanges)
            //{
            //    Console.WriteLine("|----" + dsChangePair.Key);

            //    var rowChanges = dsChangePair.Value;
            //    foreach (var rowChange in rowChanges)
            //    {
            //        Console.WriteLine("|--------" + rowChange.State);
            //        foreach (var keyValuePair in rowChange.Data)
            //        {
            //            Console.WriteLine("|------------" + keyValuePair.Key + "=" + keyValuePair.Value);
            //        }
            //    }
            //}

            return dsChanges;
        }

        /// <summary>
        /// 应用DS变更
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="dsChanges"></param>
        public static void ApplyDsChanges(DataSet ds, Dictionary<string, List<DataRowChange>> dsChanges)
        {
            //foreach (var dsChangePair in dsChanges)
            //{
            //    var tableName = dsChangePair.Key;
            //    var dt = ds.Tables[tableName];
            //    Console.WriteLine("|----" + tableName);

            //    //处理变更
            //    var tableChanges = dsChangePair.Value;
            //    foreach (var rowChange in tableChanges)
            //    {
            //        switch (rowChange.State)
            //        {
            //            case "added":
            //                AddRow(dt, rowChange.Data);
            //                break;

            //            case "deleted":
            //                DeleteRow(dt, rowChange.Data);
            //                break;

            //            case "modified":
            //                ModifyRow(dt, rowChange.Data);
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //}

        }


        /// <summary>
        /// 新增行
        /// </summary>
        public static void AddRow(DataTable dt, JObject rowData)
        {
            Console.WriteLine("|--------" + "Added");
            foreach (var columnPair in rowData)
            {
                var columnName = columnPair.Key;
                var columnValue = columnPair.Value;

                var column = dt.Columns[columnName];
                Console.WriteLine("|------------" + columnName + "=" + columnValue);
            }

        }

        /// <summary>
        /// 删除行
        /// </summary>
        public static void DeleteRow(DataTable dt, JObject rowData)
        {
            Console.WriteLine("|--------" + "Deleted");
        }


        /// <summary>
        /// 修改字段
        /// </summary>
        public static void ModifyRow(DataTable dt, JObject rowData)
        {
            Console.WriteLine("|--------" + "Modified");

            foreach (var columnPair in rowData)
            {
                var columnName = columnPair.Key;
                var columnValue = columnPair.Value;
                Console.WriteLine("|------------" + columnName + "=" + columnValue);
            }
        }














        public static void MergeTest()
        {
            // Create a DataSet with one table, two columns, 
            // and three rows.
            DataSet dataSet = new DataSet("dataSet");
            DataTable table = new DataTable("Items");
            DataColumn idColumn = new DataColumn("id",
                Type.GetType("System.Int32"), "");
            idColumn.AutoIncrement = true;
            DataColumn itemColumn = new DataColumn("Item",
                Type.GetType("System.Int32"), "");

            // DataColumn array to set primary key.
            DataColumn[] keyColumn = new DataColumn[1];
            DataRow row;

            // Create variable for temporary DataSet. 
            DataSet changesDataSet;

            // Add RowChanged event handler for the table.
            table.RowChanged += new DataRowChangeEventHandler(
                Row_Changed);
            dataSet.Tables.Add(table);
            table.Columns.Add(idColumn);
            table.Columns.Add(itemColumn);

            // Set primary key column.
            keyColumn[0] = idColumn;
            table.PrimaryKey = keyColumn;



            // Add ten rows.
            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row["Item"] = i;
                table.Rows.Add(row);
            }
            // Accept changes.
            dataSet.AcceptChanges();

            Console.WriteLine("//////////Original values//////////");
            PrintValues(dataSet, "Original values");

            // Change row values.
            table.Rows[0]["Item"] = 50;
            table.Rows[1]["Item"] = 111;

            // Add one row.
            row = table.NewRow();
            row["Item"] = 74;
            table.Rows.Add(row);


            // Insert code for error checking. Set one row in error.
            Console.WriteLine();
            Console.WriteLine("//////////Modified and New Values//////////");
            table.Rows[1].RowError = "over 100";
            PrintValues(dataSet, "Modified and New Values");

            // If the table has changes or errors, 
            // create a subset DataSet.
            if (dataSet.HasChanges(DataRowState.Modified | DataRowState.Added) && dataSet.HasErrors)
            {
                // Use GetChanges to extract subset.
                changesDataSet = dataSet.GetChanges(DataRowState.Modified | DataRowState.Added);

                Console.WriteLine();
                Console.WriteLine("//////////Subset values//////////");
                PrintValues(changesDataSet, "Subset values");




                // Insert code to reconcile errors. In this case, reject changes.
                foreach (DataTable changesTable in changesDataSet.Tables)
                {
                    if (changesTable.HasErrors)
                    {
                        foreach (DataRow changesRow in changesTable.Rows)
                        {
                            //Console.WriteLine(changesRow["Item"]);
                            if ((int)changesRow["Item", DataRowVersion.Current] > 100)
                            {
                                changesRow.RejectChanges();
                                changesRow.ClearErrors();
                            }
                        }
                    }
                }
                // Add a column to the changesDataSet.
                changesDataSet.Tables["Items"].Columns.Add(new DataColumn("newColumn"));
                Console.WriteLine("//////////Reconciled subset values//////////");
                PrintValues(changesDataSet, "Reconciled subset values");
 
                // Merge changes back to first DataSet.
                dataSet.Merge(changesDataSet, false, System.Data.MissingSchemaAction.Add);
            }

            Console.WriteLine();
            Console.WriteLine("//////////Merged values//////////");
            PrintValues(dataSet, "Merged Values");
        }

        public static void Row_Changed(object sender, DataRowChangeEventArgs e)
        {
            Console.WriteLine("Row Changed " + e.Action.ToString()+ "\table" + e.Row.ItemArray[0]);
        }

        public static void PrintValues(DataSet dataSet, string label)
        {
            Console.WriteLine(label + "\n");
            foreach (DataTable table in dataSet.Tables)
            {
                Console.WriteLine("TableName: " + table.TableName);
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        Console.Write("\table " + row[column]);
                    }
                    Console.WriteLine();
                }
            }
        }


    }

    public class DataRowChange
    {
        public string State { get; set; }

        public DataRowChangeData Data { get; set; }
    }

    public class DataRowChangeData : JObject
    {
    }
}
