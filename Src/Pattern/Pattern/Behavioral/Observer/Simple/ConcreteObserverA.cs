using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.Observer.Simple
{
    class ConcreteObserverA : Observer
    {
        public void Update()
        {
            Console.WriteLine("ConcreteObserver A is Updating ...");
        }
    }
}
