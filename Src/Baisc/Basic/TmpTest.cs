using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Basic
{
    class TmpTest
    {
        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i.ToString() + ":");
                for (int j = i; j < 10; j++)
                {
                    Console.Write(j + "");
                    i++;
                }
                Console.WriteLine(" ");
            }

            /*
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(1, 111);
            dic.Add(2, 222);
            dic.Add(3, 333);
            dic.Add(4, 444);

            dic[3] = 333333;

            int height = 0;
            if (dic.TryGetValue(3, out height))
            {
                Console.WriteLine(height);
            }
            else
            {

                Console.WriteLine("Not found !");
            }
            */
        }
    }
}
