using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.ResponsibilityChain.Price
{
    class CEO : PriceHandler
    {
        public void ProcessDiscount(float discount)
        {
            if (discount <= 0.5)
            {
                Console.WriteLine("CEO批准了" + discount + "的折扣。");
            }
            else
            {
                Console.WriteLine("无法满足" + discount + "的折扣。");
            }
        }
    }
}
