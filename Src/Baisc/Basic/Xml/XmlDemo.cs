using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace LearnCSharp.Basic
{
    class XmlDemo
    {
        public static void Run()
        {
            LoadXmlFile();
        }

        public static void LoadXmlFile()
        {
            //从文件中加载Xml文档
            string xmlFile = @"D:\Var\c#\LearningCSharp\Learning\Xml\XmlDemo.xml";
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


        //创建学生列表的XML文档
        //刘一、陈二、张三、李四、王五、赵六、孙七、周八、吴九、郑十
        public static void createClassXml()
        {
            XmlDocument stDoc = new XmlDocument();
            XmlDeclaration stDeclaration = stDoc.CreateXmlDeclaration("1.0", "UTF-8", "");
            //班级
            XmlElement classElem = stDoc.CreateElement("class");
            //老师
            XmlElement teachersElem = stDoc.CreateElement("teachers");

            //陈老师
            XmlElement firstTeacherElem = stDoc.CreateElement("teacher");
            XmlElement firstTNameElement = stDoc.CreateElement("tname");
            firstTNameElement.InnerText = "陈老师";
            XmlElement firstTSubjectElem = stDoc.CreateElement("tsubject");
            firstTSubjectElem.InnerText = "语文";
            firstTeacherElem.AppendChild(firstTNameElement);
            firstTeacherElem.AppendChild(firstTSubjectElem);

            teachersElem.AppendChild(firstTeacherElem);
            classElem.AppendChild(teachersElem);

            stDoc.AppendChild(stDeclaration);
            stDoc.AppendChild(classElem);
            Console.WriteLine(stDoc.OuterXml);
        }

        public void AppendCDataNode()
        {
            
        }
    }
}
