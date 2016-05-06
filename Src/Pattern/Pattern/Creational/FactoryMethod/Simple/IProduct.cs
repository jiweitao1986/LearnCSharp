using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.FactoryMethod.Simple
{
    /// <summary>
    /// 产品抽象类
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 打印产品信息
        /// </summary>
        /// <returns></returns>
        void Print();
    }
}
