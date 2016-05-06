using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.FactoryMethod.Simple
{
    public class Test
    {
        public static void Run()
        {
            Console.WriteLine("////////////////////Test Simple FactoryMethod////////////////////");

            //ProductA
            IFactory factoryA = new FactoryA();
            IProduct productA = factoryA.CreateProduct();
            productA.Print();

            //ProductB
            IFactory factoryB = new FactoryB();
            IProduct productB = factoryB.CreateProduct();
            productB.Print();

            Console.ReadKey();
        }
    }
}
