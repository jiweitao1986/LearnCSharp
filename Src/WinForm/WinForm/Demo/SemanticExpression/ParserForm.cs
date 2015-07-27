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

            if (semanticCode.StartsWith("{表达式") == false)
            {
                this.jsEdit.Text = "不是语义表达式";
                return;
            }

            semanticCode = semanticCode.Replace("{表达式", "").Replace("表达式}", "");
            
            //获取英文表达式
            XmlDocument semanticDoc = new XmlDocument();
            semanticDoc.LoadXml(semanticCode);
            XmlElement exprEntityElem = (XmlElement)semanticDoc.GetElementsByTagName("ExprEntity")[0];
            semanticCode = exprEntityElem.GetAttribute("EnExpr");

            //获取
            if (string.IsNullOrEmpty(semanticCode) == false)
            {
                //移除外侧的function test(){ }test();
                if (semanticCode.StartsWith("function test(){") == true)
                {
                    semanticCode = semanticCode.Substring(16, semanticCode.Length - 24);
                }


                //替换data
                string fieldPattern = "DefaultFunction.GetDefaultFieldValue\\(\\\"(.*?)\\\"\\)";
                Regex fieldRegex = new Regex(fieldPattern);
                semanticCode = fieldRegex.Replace(semanticCode,
                    "this.getValue(\"{data:$1}\")"
                );

                //替换SESSION变量
                string sessionPattern = "DefaultFunction.GetSessionValue\\(\\\"(.*?)\\\"\\)";
                Regex sessionRegex = new Regex(sessionPattern);
                semanticCode = sessionRegex.Replace(
                    semanticCode,
                    "this.getSession(\"{SESSION~$1}\")"
                );

            }

            this.jsEdit.Text = semanticCode;
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
