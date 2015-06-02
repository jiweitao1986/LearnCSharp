using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters; 

namespace LearningCSharp.Basic.Json
{


    class JsonTest
    {
        public static void Run()
        {
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
        }


    }


}
