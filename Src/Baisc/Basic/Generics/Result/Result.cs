using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Generics.Result
{
    public class Result
    {
        public int Code { get; set; }

        public string Msg { get; set; }
    }

    public class ListResult<T> : Result
    {
        public List<T> Data { get; set; }
    }


    public class InfoResult<T> : Result
    {
        public T Data { get; set; }
    }


    /// <summary>
    /// 人
    /// </summary>
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }


    /// <summary>
    /// 汽车
    /// </summary>
    public class Car
    {
        public string Brand { get; set; }

        public int Wheels { get; set; }
    }
}
