using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.SimpleFactory.Simple
{
    public static class Factory
    {
        public static IProduct CreateProduct(string name)
        {
            IProduct product = null;
            switch (name)
            {
                case "ProductA":
                {
                    product = new ProductA();
                    break;

                }
                case "ProductB":
                {
                    product = new ProductB();
                    break;
                }
                default:
                {
                    break;
                }
            }

            return product;
        }
    }
}
