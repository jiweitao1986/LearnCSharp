using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.ResponsibilityChain.Price
{
    class Manager : PriceHandler
    {
        public void ProcessDiscount(float discount)
        {
            if (discount <= 0.2)
            {
                Console.WriteLine("销售经理批准了" + discount + "的折扣。");
            }
            else
            {
                successor.ProcessDiscount(discount);
            }
        }
    }
}
