using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.SimpleFactory.Simple
{
    class ProductB : IProduct
    {
        private string name;

        public ProductB()
        {
            this.name = "Product B";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Print()
        {
            Console.WriteLine("Hello, I'm " + name + " !");
        }
    }
}
