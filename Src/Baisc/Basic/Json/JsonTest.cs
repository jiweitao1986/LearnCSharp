using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters; 

namespace LearnCSharp.Basic.Json
{


    class JsonTest
    {
        public static void Run()
        {

            string strJson = @"{
                'ID': 1,
                'Name': '张三',
                'Age': 33,
                'Birthday': '2017-04-22',
                'IsMarried': true,
                'Salary': 
            }";

            Object obj  = JsonConvert.DeserializeObject<Object>(strJson);



            //string jsonString = "{ \"photoDir\":\"jiwt\",\"userId\":\"a314b7a1-d951-47a4-8c2e-a43b3e2b5442\",\"appInstanceId\":\"001\"}";
            //var jsonDic = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
            //Console.WriteLine("解析成功");

            //List<Dictionary<string, string>> listBarItemList = new List<Dictionary<string, string>>();
            //Dictionary<string, string> listbarItemDic = new Dictionary<string, string>
            //{
            //    {"id", "idididididid"},
            //    {"text", "texttexttexttexttext"},
            //    {"icon", "iconiconiconiconicon"}
            //};
            //listBarItemList.Add(listbarItemDic);
            //string jsonStr = JsonConvert.SerializeObject(listBarItemList);

            ////if (isDisabledBuiltinFuncs == true)
            ////{
            ////    Console.WriteLine("It is true !");
            ////}

            ////if (isDisabledBuiltinFuncs = false)
            ////{
            ////    Console.WriteLine("It is false !");
            ////}
            //Book b = new Book();


            DeserializeDataSetTest();


        }

        public static void Test(string name = "jiweitao")
        {
            Console.WriteLine(name);
        }


        public static void DeserializeDataSetTest()
        {
            string dsJson = @"{
               'Dept': [
                    {'id': 1, 'Code': 'Dept0001', 'Name': '部门0001'},
                    {'id': 2, 'Code': 'Dept0002', 'Name': '部门0002'}
                ],
               'Emp': [
                    {'id': 1, 'Code': 'Emp0001', 'Name': '员工0001', 'Age': 31, 'Birthday': '1901-01-01 01:01:01', 'IsMarried': true},
                    {'id': 2, 'Code': 'Emp0002', 'Name': '员工0001', 'Age': 32, 'Birthday': '1901-02-02 02:02:02', 'IsMarried': false}
                ]
            }";

            DataSet ds = JsonConvert.DeserializeObject<DataSet>(dsJson);
            DataTable dt = ds.Tables["Emp"];

            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine(row["Name"]);
            }
        }




        /// <summary>
        /// 图书实体类
        /// </summary>
        public class Book
        {
            public string BookID { get; set; }
            public DateTime PublishDate { get; set; }
            public decimal Price { get; set; }

            public override string ToString()
            {
                return "ID:" + BookID + "; Date:" + PublishDate.ToShortDateString() + "; Price" + Price.ToString("n");
            }

            public Book(string name="js")
            {
                Console.WriteLine(name);
            }
        }

        public void SerializeObject()
        {
            /*
            Book bk = new Book() { BookID = "12111", PublishDate = DateTime.Parse("2012-2-1 22:12:11"), Price = 433.12M };
            Console.WriteLine(JsonConvert.SerializeObject(bk));

            Console.WriteLine("/////////////////////////");

            string jsonBook = "{'BookID':'123', 'PublishDate':'2011-1-2', 'Price':23.5}";
            Book bk1 = JsonConvert.DeserializeObject<Book>(jsonBook);
            Console.WriteLine(bk1.ToString());
            */
            string jsonBook = "{'BookID':'123', 'PublishDate':'2011-1-2', 'Price':23.5}";
            Dictionary<string, string> bk1 = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonBook);
            Console.WriteLine(bk1["Price"]);


            JObject MyJObject = new JObject();
            MyJObject.Add("1st", 1);
            MyJObject.Add("2st", "second...");
            MyJObject.Add("3rd", DateTime.Now);
            MyJObject.Add("4th", "to be deleted...");
            MyJObject.Remove("4th");
            MyJObject["myobj"] = new JObject();

            Console.WriteLine(MyJObject["myobj"].GetType());

            Console.WriteLine(MyJObject.ToString());
        }
    }


}
