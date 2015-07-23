using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace LearningCSharp.WinForm.Demo.SemanticExpression
{
    public partial class ParserForm : Form
    {
        public ParserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 解析语义表达式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void parseSemanticBtn_Click(object sender, EventArgs e)
        {
            string semanticCode = this.semanticEdit.Text;
            string jsCode = string.Empty;

            semanticCode = semanticCode.Replace("{表达式", "").Replace("表达式}", "");
            
            //获取英文表达式
            XmlDocument semanticDoc = new XmlDocument();
            semanticDoc.LoadXml(semanticCode);
            XmlElement exprEntityElem = (XmlElement)semanticDoc.GetElementsByTagName("ExprEntity")[0];
            string enExpr = exprEntityElem.GetAttribute("EnExpr");

            //获取
            if (string.IsNullOrEmpty(enExpr) == false)
            {
                string fieldPattern = "DefaultFunction.GetDefaultFieldValue\\(\\\"(.*?)\\\"\\)";
                Regex fieldregex = new Regex(fieldPattern);

                
                //Match fieldMatch = fieldregex.Match(enExpr);
                //if (fieldMatch.Success == true)
                //{
                //    jsCode = fieldMatch.Groups[1].Value;
                //}
            }

            this.jsEdit.Text = jsCode;
        }

        public static string ReplaceTest()
        {
            return "hahha";
        }


        /// <summary>
        /// 解析Web表达式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void parseWebBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
