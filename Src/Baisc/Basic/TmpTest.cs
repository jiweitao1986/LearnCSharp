using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;

namespace LearnCSharp.Basic
{
    class TmpTest
    {
        public static void Run()
        {
            /*
            string borderString = "-35.11em      #f00   solid ";

            string[] borderArray = borderString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (borderArray.Length == 0)
            {
                Console.WriteLine("不是合法的border缩写");
            }

            string borderWidthLen = string.Empty;
            string borderWidthUnit = string.Empty;
            string borderStyle = string.Empty;
            string borderColor = string.Empty;

            foreach (string borderArrayItem in borderArray)
            {
                if (isSize(borderArrayItem))
                {
                    string[] borderWidthArray = parseSize(borderArrayItem);
                    borderWidthLen = borderWidthArray[0];
                    borderWidthUnit = borderWidthArray[1];
                }
                else if (isBorderStyle(borderArrayItem))
                {
                    borderStyle = borderArrayItem;
                }
                else if (isHexColor(borderArrayItem))
                {
                    borderColor = borderArrayItem;
                }
            }

            Console.WriteLine("width size:" + borderWidthLen);
            Console.WriteLine("width unit:" + borderWidthUnit);
            Console.WriteLine("style:" + borderStyle);
            Console.WriteLine("color:" + borderColor);
            */

            string color = "#0000FF";
            Console.WriteLine(isHexColor(color));
        }

        public static bool isBorderStyle(string borderStyle)
        {
            borderStyle.ToLower();
            string[] borderStyles = new string[]
            {
                "none", "hidden", "dotted", "dashed", "solid",
                "double", "groove", "ridge", "inset", "outset",
                "initial", "inherit"
            };
            return borderStyles.Contains(borderStyle);
        }

        /// <summary>
        /// 是否为尺寸
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static bool isSize(string size)
        {
            string pattern = @"^-?\d+(\.\d+)?(px|em|%)$";
            Regex sizeRegex = new Regex(pattern);
            return sizeRegex.IsMatch(size);
        }

        public static string[] parseSize(string size)
        {
            Regex reg = new Regex(@"-?\d+(\.\d+)?");
            Match match = reg.Match(size);
            return new string[]
            {
                match.Value,
                size.Substring(match.Index + match.Value.Length)
            };
            
        }

        public static bool isHexColor(string color)
        {
            color = color.ToLower();
            string pattern = @"^#([0-9a-f]{3}){1,2}$";
            Regex hexColorRegex = new Regex(pattern);
            return hexColorRegex.IsMatch(color);
        }

        public static Color parseHexColor(string color)
        {
            return ColorTranslator.FromHtml(color);
        }


    }
}
