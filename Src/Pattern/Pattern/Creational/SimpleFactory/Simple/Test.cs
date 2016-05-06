using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.SimpleFactory.Simple
{
    public class Test
    {
        public static void Run()
        {
            Console.WriteLine("////////////////////Test Simple SimpleFactory////////////////////");

            //ProductA
            IProduct productA = Factory.CreateProduct("ProductA");
            productA.Print();

            //ProductB
            IProduct productB = Factory.CreateProduct("ProductB");
            productB.Print();

            Console.ReadKey();
        }
    }
}
