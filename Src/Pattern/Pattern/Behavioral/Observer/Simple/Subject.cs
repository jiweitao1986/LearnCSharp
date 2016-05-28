using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Behavioral.Observer.Simple
{
    abstract class Subject
    {
        protected List<Observer> observers = new List<Observer>();

        public abstract void Attach(Observer observer);

        public abstract void Detach(Observer observer);

        public abstract void Notify();

    }
}
