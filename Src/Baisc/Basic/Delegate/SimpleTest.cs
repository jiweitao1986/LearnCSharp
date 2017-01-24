using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Other
{
    delegate double ProcessDelegate(double param1, double param2);

    class DelegateTest
    {

        public static void Run()
        {
            ProcessDelegate process;

            process = new ProcessDelegate(Multiply);

            process(1, 2);

        }

        public static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        public static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }

    }
}
