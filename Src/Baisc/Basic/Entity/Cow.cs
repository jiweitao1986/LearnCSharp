using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic
{
    class Cow : Animal
    {
        public Cow(string newName) : base(newName)
        {
        }

        public void Milk()
        {
            Console.WriteLine("{0} has been milked.", name);
        }
    }
}
