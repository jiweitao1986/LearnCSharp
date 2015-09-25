using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace LearnCSharp.Basic
{
    class DebugDemo
    {

        public static void Run()
        {
            int[][] TwoArr = new int[3][]{new int[] {1,2,3}, new int[] {4,5,6}, new int[] {7,8,9}};

            foreach (int[] arr in TwoArr)
            {
                foreach (int i in arr)
                {
                    Console.Write(i+"\t");
                }
                Console.WriteLine("");
            }

        }
    }
}
