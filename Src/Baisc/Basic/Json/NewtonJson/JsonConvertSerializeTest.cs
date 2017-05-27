using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnCSharp.Basic.Json.NewtonJson
{
    class JsonConvertSerializeTest
    {
        public static void Run()
        {

            var employee = new Employee()
            {
                Name = "ZhangSan",
                Gender = Gender.Female,
                Nation = Nation.Han
            };

            Console.WriteLine(JsonConvert.SerializeObject(employee));

        }



    }


    
}
