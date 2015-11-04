using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Other.ExtendMethod
{

    public static class StringExtension
    {
        public static bool isEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }

    class StringExtensionTest
    {
        public static void Run()
        {
            IsEmptyTest();
        }

        public static void IsEmptyTest()
        {
            string hello = "Hello World";
            string empty = "";
            string white = "  \t\v\n\r";
            string nu = null;


            bool isHelloEmpty = hello.isEmpty();
            bool isEmptyEmpty = empty.isEmpty();
            bool isWhiteEmppty = white.isEmpty();
            bool isNullEmpty = nu.isEmpty();

            Console.WriteLine("////////////////////IsEmptyTest////////////////////");
            Console.WriteLine("Is Hello Empty：" + isHelloEmpty.ToString());
            Console.WriteLine("Is Empty Empty：" + isEmptyEmpty.ToString());
            Console.WriteLine("Is White Empty：" + isWhiteEmppty.ToString());
            Console.WriteLine("Is Null：" + isNullEmpty.ToString());
        }
    }
}
