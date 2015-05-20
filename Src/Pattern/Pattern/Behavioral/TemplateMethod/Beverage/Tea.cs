using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.TemplateMethod.Beverage
{
    class Tea : Beverage
    {
        /// <summary>
        /// 第2步：泡制饮料
        /// 由子类具体实现
        /// </summary>
        protected override void Brew()
        {
            Console.WriteLine("用80度热水冲泡茶叶5分钟");
        }

        /// <summary>
        /// 第4步：添加调味品
        /// 由子类具体实现
        /// </summary>
        protected override void AddCondiments()
        {
            Console.WriteLine("加入柠檬");
        }
    }
}
