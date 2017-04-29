using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Types
{
    public static class ConvertTest
    {
        /// <summary>
        /// run test
        /// </summary>
        public static void Run()
        {
            ToBooleanTest();
        }

        /// <summary>
        /// 布尔类型转换
        /// </summary>
        public static void ToBooleanTest()
        {
            //false
            bool intZero = Convert.ToBoolean(0);
            Console.WriteLine(intZero.ToString());

            //true
            bool intOne = Convert.ToBoolean(1);
            Console.WriteLine(intOne.ToString());

            //true
            bool intOther = Convert.ToBoolean(99);
            Console.WriteLine(intOther.ToString());

            //false
            bool floatZero = Convert.ToBoolean(0.00);
            Console.WriteLine(floatZero.ToString());

            //true
            bool floatOne = Convert.ToBoolean(1.00);
            Console.WriteLine(floatOne.ToString());

            //true
            bool floatOther = Convert.ToBoolean(99.99);
            Console.WriteLine(floatOther.ToString());

            //true
            bool strUpperTrue = Convert.ToBoolean("True");
            Console.WriteLine(strUpperTrue.ToString());

            //false
            bool strUpperFalse = Convert.ToBoolean("False");
            Console.WriteLine(strUpperFalse.ToString());

            //true
            bool strLowerTrue = Convert.ToBoolean("true");
            Console.WriteLine(strLowerTrue.ToString());

            //false
            bool strLowerFalse = Convert.ToBoolean("false");
            Console.WriteLine(strLowerFalse.ToString());

            //error
            //bool strOther = Convert.ToBoolean("Other");
            //Console.WriteLine(strOther.ToString());

        }


        


        public static void OtherTest()
        {
            string src = "123";
            int dest = 0;
            dest = Convert.ToInt32(src);
            Console.WriteLine("source val:{0}", src);
            Console.WriteLine("dest val:{0}", dest);
        }

    }

}
