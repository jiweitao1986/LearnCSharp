using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LearnCSharp.Basic.Xml
{
    /// <summary>
    /// Xml测试类
    /// </summary>
    class XmlTest
    {
        /// <summary>
        /// 运行测试
        /// </summary>
        public static void Run()
        {

            createXmlTest();
        }

        /// <summary>
        /// 加载Xml文件测试
        /// </summary>
        public static void LoadXmlFileTest()
        {
            //从文件中加载Xml文档
            string xmlFile = @"D:\Var\c#\LearningCSharp\Learning\Xml\XmlFiles\XmlTest.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFile);

            //获取学生列表
            XmlNodeList studentsList = xmlDoc.GetElementsByTagName("students");
            XmlElement studentsElem = (XmlElement)studentsList[0];

            //追加一个学生3
            XmlElement newStElem = xmlDoc.CreateElement("student");
            XmlElement newStNameElem = xmlDoc.CreateElement("name");
            XmlText newStNameText = xmlDoc.CreateTextNode("学生3");
            newStNameElem.AppendChild(newStNameText);
            newStElem.AppendChild(newStNameElem);
            studentsElem.AppendChild(newStElem);

            //给students元素设置总数属性
            studentsElem.SetAttribute("count", "15");
            Console.WriteLine(studentsElem.GetAttribute("count"));

            Console.WriteLine(studentsElem.OuterXml);
        }


        /// <summary>
        /// 创建XML文档测试
        /// </summary>
        public static void createXmlTest()
        {
            XmlDocument personDoc = new XmlDocument();
            XmlDeclaration persionDeclaration = personDoc.CreateXmlDeclaration("1.0", "UTF-8", "");

            //创建根节点
            XmlElement personsElem = personDoc.CreateElement("Persons");

            //张三
            XmlElement zhangSanElem = personDoc.CreateElement("Person");
            XmlElement zhangSanNameElem = personDoc.CreateElement("Name");
            zhangSanNameElem.InnerText = "张三";
            zhangSanElem.AppendChild(zhangSanNameElem);

            personsElem.AppendChild(zhangSanElem);
            personDoc.AppendChild(personsElem);

            //李四
            XmlElement liSiElem = personDoc.CreateElement("Person");
            XmlElement liSiNameElem = personDoc.CreateElement("Name");
            liSiNameElem.InnerText = "李四";
            liSiElem.AppendChild(liSiNameElem);
            personsElem.AppendChild(liSiElem);

            Console.WriteLine(personDoc.OuterXml);
        }

    }
}
