using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Basic.Lambda
{
    class LambdaDemo
    {
        delegate int intDel(int i);

        delegate string strDel(string firstName, string SecondName);

        public static void Run()
        {
            intDel myIntDel = x => x * x;

            strDel myStrDel = (fName, sName) =>
            {
                string fullName = fName + sName;
                return fullName;
            };

            

            Console.WriteLine(myIntDel(5).ToString());
            Console.WriteLine(myStrDel("ji", "weitao").ToString());

        }


    }
}
