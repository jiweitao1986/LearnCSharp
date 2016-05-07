using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.AbstractFactory.Simple
{
    class ProductA1 : IProductA
    {
        public void Print()
        {
            Console.WriteLine("Hello, I'm ProductA1 !");
        }
    }
}
