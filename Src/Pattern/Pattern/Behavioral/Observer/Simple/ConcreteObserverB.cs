using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.Observer.Simple
{
    class ConcreteObserverB : Observer
    {
        public void Update()
        {
            Console.WriteLine("ConcreteObserver B is Updating ...");

        }
    }
}