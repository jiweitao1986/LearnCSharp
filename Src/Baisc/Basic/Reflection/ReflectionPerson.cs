using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Reflection
{
    class ReflectionPerson
    {
        private string name;

        private string sex;

        private DateTime birthday;

        private int height;

        private float weight;

        public ReflectionPerson()
        {
            this.name = "未命名";
        }

        public ReflectionPerson(string name)
        {
            this.name = name;
        }

        public ReflectionPerson(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public string GetName()
        {
            return this.name;
        }


    }
}
