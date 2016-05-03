using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Data;
using System.Data.SqlClient;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace LearnCSharp.Basic
{

    class Program
    {
        static void Main(string[] args)
        {
            //Collection.ListTest.Run();
            //Types.EnumTest.Run();
            //IoC.Autofac.AutofacTest.Run();

            //File.FileTest.Run();

            string strF = "10000.4343";

            Console.WriteLine(Single.Parse(strF).ToString("P#,#.00S"));

            Console.ReadKey();
        }
    }
}
