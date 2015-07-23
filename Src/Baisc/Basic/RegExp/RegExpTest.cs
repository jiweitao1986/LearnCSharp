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

            //string pattern = @"\${[^\n\r}]+}";
            //string text = "<li class=\"list-group-item\"><span>${name}${age}</span><p>${name}:${age}</p></li>";
            //MatchCollection matches;

            //Regex defaultRegex = new Regex(pattern);
            //// Get matches of pattern in text
            //matches = defaultRegex.Matches(text);
            //Console.WriteLine("Parsing '{0}'", text);


            //// Iterate matches   
            //for (int ctr = 0; ctr < matches.Count; ctr++)
            //    Console.WriteLine("{0}. {1}", ctr, matches[ctr].Value);

            CaptureTest();

            //string url = "htt://www.baidu.com:80";
            //ParseUrl(url);
        }


        public static void CaptureTest()
        {
            string subject = "This is a sentence. This is another sentence.";
            string pattern = @"\b(\w+\s*)+\.";
            Match match = Regex.Match(subject, pattern);

            if (match.Success)
            {
                foreach (Group group in match.Groups)
                {
                    Console.WriteLine("////////////////////group////////////////////");
                    Console.WriteLine("Value: " + group.Value);
                    Console.WriteLine("Index: " + group.Index);
                    Console.WriteLine("Length: " + group.Length);
                    Console.WriteLine("Capture: " + group.Captures.Count);

                    foreach (Capture capture in group.Captures)
                    {
                        Console.WriteLine("//////////capture//////////");

                        Console.WriteLine("Value: " + capture.Value);
                        Console.WriteLine("Index: " + capture.Index);
                        Console.WriteLine("Length: " + capture.Length);
                    }
                }
            }
        }


        public static void GroupTest()
        {
                
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


        public static bool isUrl(string url)
        {
            string pattern = @"\b(\S+)://([^:]+)(:\S+)?";
            Regex urlRegex = new Regex(pattern);
            return urlRegex.IsMatch(url);
        }

        public static Dictionary<string, string> ParseUrl(string url)
        {
            Dictionary<string, string> urlDict = new Dictionary<string, string>();

            string pattern = @"\b(\S+)://([^:]+)(:\S+)?\b";
            Regex urlRegex = new Regex(pattern);
            Match urlMatch = urlRegex.Match(url);

            while (urlMatch.Success)
            {
                Console.WriteLine("Index: " + urlMatch.Index);
                Console.WriteLine("Value: " + urlMatch.Value);
                Console.WriteLine("Length: " + urlMatch.Length);
                urlMatch = urlMatch.NextMatch();
            }
            return urlDict;
        }

        
    }
}
