using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.FactoryMethod.Simple
{
    class FactoryB : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
