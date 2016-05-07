using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.AbstractFactory.Simple
{
    /// <summary>
    /// 抽象产品类
    /// </summary>
    interface IFactory
    {
        IProductA CreateProductA();

        IProductB CreateProductB();
    }
}
