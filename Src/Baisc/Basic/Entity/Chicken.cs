using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic
{
    class Chicken : Animal
    {
        public Chicken(string newName) : base(newName)
        {
            name = newName;
        }

        public void LayLegs()
        {

        }
    }
}
