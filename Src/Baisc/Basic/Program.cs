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

namespace LearningCSharp.Basic
{

    class Program
    {
        static void Main(string[] args)
        {
            Lambda.LambdaDemo.Run();

            Console.ReadKey();
        }
    }
}
