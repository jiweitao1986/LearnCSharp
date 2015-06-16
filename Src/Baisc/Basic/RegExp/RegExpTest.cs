using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningCSharp.Basic.RegExp
{
    class RegExpTest
    {

        public static void Run()
        {
            string pattern = @"\${[^\n\r}]+}";
            string text = "<li class=\"list-group-item\"><span>${name}${age}</span><p>${name}:${age}</p></li>";
            MatchCollection matches;

            Regex defaultRegex = new Regex(pattern);
            // Get matches of pattern in text
            matches = defaultRegex.Matches(text);
            Console.WriteLine("Parsing '{0}'", text);

           
            // Iterate matches   
            for (int ctr = 0; ctr < matches.Count; ctr++)
                Console.WriteLine("{0}. {1}", ctr, matches[ctr].Value);
        }

        /// <summary>
        /// 数字
        /// </summary>
        public static void NumberTest()
        {
            string sizeString = "0 10px 100% 0";
            string[] sizeArray = sizeString.Split(' ');
            int sizeArrayLength = sizeArray.Length;
            string[,] sizeLenUnitArray = new string[sizeArray.Length, 2];
            for (int i = 0; i < sizeArrayLength; i++)
            {
                string size = sizeArray[i];
                Regex reg = new Regex(@"-?\d+(\.\d+)?");
                Match m = reg.Match(size);
                string len = m.Value;
                string unit = size.Substring(m.Index + m.Value.Length);
                sizeLenUnitArray[i, 0] = len;
                sizeLenUnitArray[i, 1] = unit;
            }


            for (int j = 0; j < sizeArrayLength; j++)
            {
                Console.WriteLine(j.ToString());
                string len = sizeLenUnitArray[j, 0];
                string unit = sizeLenUnitArray[j, 1];
                Console.WriteLine(len + "-" + unit);
            }


        }


        public static void IsNumber()
        { 
            
        }

        
    }
}
