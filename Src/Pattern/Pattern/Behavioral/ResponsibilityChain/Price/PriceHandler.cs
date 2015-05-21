using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.ResponsibilityChain.Price
{
    abstract class PriceHandler
    {
        protected PriceHandler successor;

        public abstract void ProcessDiscount(float discount);
    }
}
