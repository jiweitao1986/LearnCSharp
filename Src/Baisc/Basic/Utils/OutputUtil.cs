using System;

namespace LearnCSharp.Basic
{
    public static class OutputUtil
    {

        /// <summary>
        /// 显示标题
        /// </summary>
        /// <param name="title"></param>
        public static void  ShowTitle(string title)
        {
            title = "////////////////////" + title + "////////////////////";

            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine();
        }

        /// <summary>
        /// 显示分割线
        /// </summary>
        public static void ShowLine()
        {
            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.WriteLine();
        }
    }
}
