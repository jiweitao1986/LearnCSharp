using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.ResponsibilityChain.Price
{
    class SaleMan : PriceHandler
    {
        public override void ProcessDiscount(float discount)
        {
            if (discount <= 0.1)
            {
                Console.WriteLine("销售人员批准了" + discount + "的折扣。");
            }
            else
            {
                successor.ProcessDiscount(discount);
            }
        }
    }
}
