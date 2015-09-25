using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic
{
    class ConvertDemo
    {
        public static void BasicDemo()
        {
            string src = "123";
            int dest = 0;
            dest = Convert.ToInt32(src);
            Console.WriteLine("source val:{0}", src);
            Console.WriteLine("dest val:{0}", dest);

        }

    }

}
