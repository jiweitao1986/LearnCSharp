using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Generics.Result
{
    public static class ResultTest
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("//////////ListResult//////////");
            Console.WriteLine();

            var personListResult = new ListResult<Person>();
            personListResult.Code = -1;
            personListResult.Msg = "有错误";
            personListResult.Data = new List<Person>() {
                new Person { Name = "ZhangSan", Age = 33},
                new Person { Name = "LiSi",     Age = 44}
            };
            string personListJson = JsonConvert.SerializeObject(personListResult);
            Console.WriteLine(personListJson);

            Console.WriteLine();
            Console.WriteLine("//////////InfoResult//////////");
            Console.WriteLine();

            var carInfoResult = new InfoResult<Car>();
            carInfoResult.Code = 1;
            carInfoResult.Msg = "没有错误";
            carInfoResult.Data = new Car
            {
                Brand = "Mercedes-Ben",
                Wheels = 4
            };
            string cardInfoJson = JsonConvert.SerializeObject(carInfoResult);
            Console.WriteLine(carInfoResult);
        }
    }
}
