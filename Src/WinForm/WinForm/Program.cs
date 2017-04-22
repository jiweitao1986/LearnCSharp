﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCSharp.WinForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new StudentList());
            //Application.Run(new Test.Test());
            //Application.Run(new Other.PropertyGridTest.SimpleTest.SimpleTestForm());

            Application.Run(new Other.ICSharpCodeTextEditor.SimpleTest());

        }
    }
}
