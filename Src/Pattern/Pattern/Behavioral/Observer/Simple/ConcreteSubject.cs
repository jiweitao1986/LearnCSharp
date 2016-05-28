using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.Observer.Simple
{
    class ConcreteSubject : Subject
    {
        public override void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public override void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public override void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
