using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.ResponsibilityChain.Price
{
    class Director : PriceHandler
    {
        public void ProcessDiscount(float discount)
        {
            if (discount <= 0.3)
            {
                Console.WriteLine("销售经理" + discount + "的折扣。");
            }
            else
            {
                successor.ProcessDiscount(discount);
            }
        }
    }
}
