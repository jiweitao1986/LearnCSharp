using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Fs
{
    class FileTest
    {
        public static void Run()
        {
            /*
            FileStream fs = new FileStream("Log.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter("Log.txt", true);
            sw.WriteLine("你好");
            sw.Flush();
            sw.Close();
             */

            //Person p1 = new Person("张三");
            //Console.WriteLine(p1.GetType());
            //ReadAllTextTest

            //PathTest();

            PushQdMessage();
            PushHkMessage();
        }



        public static void PushQdMessage()
        {
            //解析签单日期
            Console.WriteLine("上次签单日期");

            string lastQdPushDateFile = @"../../Xml/LastQdPushDate.txt";
            if (File.Exists(lastQdPushDateFile) == false)
            {
                File.WriteAllText(lastQdPushDateFile, DateTime.Now.ToString("yyyy-M-d"));
                return;
            }

            string lastQdPushDate = File.ReadAllText(lastQdPushDateFile);
            string[] lastQdPushDateParts = lastQdPushDate.Split('-');

            //var startYear = lastQdPushDateParts[0];
            //var startMonth = lastQdPushDateParts[1];
            //var startDay = lastQdPushDateParts[2];

            var startYear = 2017;
            var startMonth = 4;
            var startDay = 1;

            var endDate = DateTime.Now;
            var endYear = endDate.Year;
            var endMonth = endDate.Month;
            var endDay = endDate.Day;

            var sql = "select COUNT(QDCODE) from MODEL_QD_QDBB_DAY";
            sql += " where";
            sql += " (";
            sql +=     " QDNF > " + startYear;
            sql +=     " OR (QDNF = " + startYear + " AND QDYF > " + startMonth + ")";
            sql +=     " OR (QDNF = " + startYear + " AND QDYF = " + startMonth + " AND QDRQ >= " + startDay + ")";
            sql += " )";
            sql += " and (";
            sql += " QDNF < " + endYear;
            sql += " OR (QDNF = " + endYear + " AND QDYF < " + endMonth + ")";
            sql += " OR (QDNF = " + endYear + " AND QDYF = " + endMonth + " AND QDRQ <= " + endDay + ")";
            sql += " )";

            Console.WriteLine(sql);

            //获取签单数量
            int qdCount = 0;
            if (qdCount > 0)
            {
                //推送签单消息

                //更新日期
                File.WriteAllText(lastQdPushDateFile, DateTime.Now.ToString("yyyy-M-d"));
            }
        }


        public static void PushHkMessage()
        {
            Console.WriteLine("上次回款日期");

            string lastHkPushDateFile = @"../../Xml/LastHkPushDate.txt";
            if (File.Exists(lastHkPushDateFile) == false)
            {
                File.WriteAllText(lastHkPushDateFile, DateTime.Now.ToString("yyyy-M-d"));
            }

            //解析回款日期
            var lastHkPushDate = File.ReadAllText(lastHkPushDateFile);
            var lastHkPushDateParts = lastHkPushDate.Split('-');

            //var startYear = lastHkPushDateParts[0];
            //var startMonth = lastHkPushDateParts[1];
            //var startDay = lastHkPushDateParts[2];

            var startYear = 2017;
            var startMonth = 4;
            var startDay = 1;

            var endDate = DateTime.Now;
            var endYear = endDate.Year;
            var endMonth = endDate.Month;
            var endDay = endDate.Day;

            var sql  = "select COUNT(HKCODE) from MODEL_HK_HKBB_DAY";
                sql += " where";
                sql += " (";
                sql += " HKNF > " + startYear;
                sql += " OR (HKNF = " + startYear + " AND HKYF > " + startMonth + ")";
                sql += " OR (HKNF = " + startYear + " AND HKYF = " + startMonth + " AND HKRQ >= " + startDay + ")";
                sql += " )";
                sql += " and (";
                sql += " HKNF < " + endYear;
                sql += " OR (HKNF = " + endYear + " AND HKYF < " + endMonth + ")";
                sql += " OR (HKNF = " + endYear + " AND HKYF = " + endMonth + " AND HKRQ <= " + endDay + ")";
                sql += " )";

            Console.WriteLine(sql);


            int hkCount = 0;
            if (hkCount > 0)
            {
                //推送回款消息


                //更新日期
                File.WriteAllText(lastHkPushDateFile, DateTime.Now.ToString("yyyy-M-d"));
            }

        }












        public static void ReadAllTextTest()
        {
            //string path = @"E:\Var\C#\LearnCSharp\Src\Baisc\Basic\Xml\XmlDemo.xml";
            string path = @"../../Xml/XmlDemo.xml";
            string str = System.IO.File.ReadAllText(path);

            Console.Write(str);
        }


        public static void PathTest()
        {
            string pathString = @"C:\Windows\System32\drivers\etc\hosts";
            Console.WriteLine(Path.GetFileName(pathString));
        }

        public static void FileStreamReadTest()
        {
        }

    }





    public class Person
    {
        public string personName;

        public Person(string name)
        {
            this.personName = name;
        }

        public override string ToString()
        {
            return this.personName;
        }
    }

}
