using System;
using System.Xml;

namespace LearnCSharp.Basic.Xml
{
    public static class XPathTest
    {
        public static void Run()
        {
            string xmlFile = @"../../Xml/Files\Bookstore.xml";
            XmlDocument bookstoreDoc = new XmlDocument();
            bookstoreDoc.Load(xmlFile);

            string xPath = "/Book";
            XmlNodeList bookNodeList =  bookstoreDoc.SelectNodes(xPath);
            foreach (var bookNode in bookNodeList)
            {
                Console.WriteLine(bookNode.ToString());
            }

            Console.WriteLine("ceshi");
        }
    }
}
