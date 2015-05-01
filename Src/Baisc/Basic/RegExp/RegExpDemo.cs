using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningCSharp.Basic
{
    class RegExpDemo
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
    }
}
