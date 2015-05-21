using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.ResponsibilityChain.Price
{
    class VicePresident : PriceHandler
    {
        public void ProcessDiscount(float discount)
        {
            if (discount <= 0.4)
            {
                Console.WriteLine("副总裁" + discount + "的折扣。");
            }
            else
            {
                successor.ProcessDiscount(discount);
            }
        }
    }
}
