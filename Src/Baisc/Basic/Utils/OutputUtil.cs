using System;

namespace LearnCSharp.Basic.Utils
{
    public static class OutputUtil
    {
        public static void  ShowTitle(string title)
        {
            title = "////////////////////" + title + "////////////////////";
            Console.WriteLine();
            Console.WriteLine(title);
        }
    }
}
