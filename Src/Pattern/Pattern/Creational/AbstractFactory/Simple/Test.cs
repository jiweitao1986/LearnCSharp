using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.AbstractFactory.Simple
{
    public class Test
    {
        public static void Run()
        {

            //产品族1
            Console.WriteLine("////////////////////产品族1////////////////////");
            IFactory factory1 = new Factory1();
            IProductA productA1 = factory1.CreateProductA();
            productA1.Print();
            IProductB productB1 = factory1.CreateProductB();
            productB1.Print();

            //ProductB
            Console.WriteLine("////////////////////产品族2////////////////////");
            IFactory factory2 = new Factory2();
            IProductA productA2 = factory2.CreateProductA();
            productA2.Print();
            IProductB productB2 = factory2.CreateProductB();
            productB2.Print();

            Console.ReadKey();
        }
    }
}
