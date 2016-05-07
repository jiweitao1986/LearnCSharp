using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.AbstractFactory.Simple
{
    class ProductB1 : IProductB
    {
        public void Print()
        {
            Console.WriteLine("Hello, I'm ProductB1 !");
        }
    }
}
