using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.Observer.Simple
{
    internal class Test
    {
        public static void Run()
        {
            Subject subject = new ConcreteSubject();
            Observer observerA = new ConcreteObserverA();
            Observer observerB = new ConcreteObserverB();
            subject.Attach(observerA);
            subject.Attach(observerB);

            subject.Notify();

            Console.ReadKey();

        }
    }
}
