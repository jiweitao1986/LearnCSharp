using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Xml;
using Newtonsoft.Json;

namespace LearnCSharp.Basic
{
    class TmpTest
    {
        public static void Run()
        {
            List<String> names = new List<String>();
            names.Add("Bruce");
            names.Add("Alfred");
            names.Add("Tim");
            names.Add("Richard");

            names.ForEach(name =>
            {
                Console.WriteLine(name);
            });

        }
    }


}
