using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
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
            ReadChangesJson();
        }


        public static void ReadChangesJson()
        {
            var path = @"../../Ds/DeptEmpChanges.json";
            string strJson = File.ReadAllText(path);
            Console.WriteLine(strJson);

            var dsChanges = JsonConvert.DeserializeObject<Dictionary<string, List<RowChange>>>(strJson);
            foreach (var dsChangePair in dsChanges)
            {
                Console.WriteLine("|----" + dsChangePair.Key);

                var rowChanges = dsChangePair.Value;
                foreach (var rowChange in rowChanges)
                {
                    Console.WriteLine("|--------" + rowChange.State);
                    foreach (var keyValuePair in rowChange.RowData)
                    {
                        Console.WriteLine("|------------" + keyValuePair.Key + "=" + keyValuePair.Value);
                    }
                }

            }
        }
    }

    public class RowChange
    {
        public string State { get; set; }

        public JObject RowData { get; set; }
    }
}
