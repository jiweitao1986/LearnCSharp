using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.TemplateMethod.Beverage
{
    abstract class Beverage
    {
        /// <summary>
        /// 提神饮料制作模板方法
        /// 该方法为私有，防止子类复写，改变固定的泡制流程。
        /// </summary>
        private void PrepareBeverage()
        {
            this.BoilWater();
            this.Brew();
            this.PourInCup();
            
            this.AddCondiments();
        }

        /// <summary>
        /// 第1步：把水煮沸
        /// 所有饮料均需要沸水，该步骤固定，禁止子类复写，
        /// 向下屏蔽细节。
        /// </summary>
        private void BoilWater()
        {
            Console.WriteLine("用沸水冲泡咖啡");
        }

        /// <summary>
        /// 第2步：泡制饮料
        /// 延迟到子类具体实现
        /// </summary>
        protected abstract void Brew();

        /// <summary>
        /// 第3步：倒入杯中
        /// </summary>
        protected void PourInCup()
        {
            Console.WriteLine("用饮料倒入杯中");
        }

        /// <summary>
        /// 第4步：添加调味品
        /// 延迟到子类具体实现
        /// </summary>
        protected abstract void AddCondiments();

        /// <summary>
        /// 询问客户是否需要调料
        /// 这是一个钩子（Hook）方法
        /// 基类提供一个默认或空的实现
        /// 子类自行决定是否挂钩及如何挂钩
        /// </summary>
        /// <returns></returns>
        protected bool ifCustomerWantsCondiments()
        {
            return true;
        }
    }
}
