using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Other
{
    public static class StringTest
    {
        public static void Run()
        {
            //string[] strArray = {"", "c,d", "", "e"};
            //string str = ConvertArrayToString(strArray, ",", false);
            //Console.WriteLine(str);


            var str =
                @"[{&quot;Lbracket&quot;:&quot;&quot;,&quot;Compare&quot;:&quot; =&quot;,&quot;Field&quot;:&quot;MgrID_Name&quot;,&quot;DataType&quot;:&quot;String&quot;,&quot;Value&quot;:&quot;\'{SESSION~UserID}'\&quot;,&quot;Rbracket&quot;:&quot;         &quot;,&quot;Relation&quot;:&quot;&quot;,&quot;IsCanChange&quot;:true,&quot;ConvertUpperToCompare&quot;:false,&quot;Expresstype&quot;:1,&quot;FieldCaption&quot;:&quot;&quot;,&quot;InnerFormula&quot;:&quot;&quot;,&quot;Owner&quot;:&quot;&quot;,&quot;DisplayValue&quot;:&quot; &quot;,&quot;Description&quot;:&quot;&quot;}]";
            str = str.Replace("\\'", "&apos;");
            Console.WriteLine(str);

        }

        /// <summary>
        /// 
        /// </summary>
        public static string ConvertArrayToString(string[] strArray, string separator, bool filterEmpty = true)
        {

            if (filterEmpty == true)
            {
                strArray = strArray.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            }
            return string.Join(separator, strArray);
        }

    }
}
