using System;

namespace LearnCSharp.Basic
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public DateTime Birthday { get; set; }

        public Nation Nation { get; set; }

        public bool IsMarried { get; set; }
    }


    /// <summary>
    /// 性别枚举
    /// </summary>
    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    //民族枚举
    public enum Nation
    {
        Han = 0,
        Other = 1
    }
}
