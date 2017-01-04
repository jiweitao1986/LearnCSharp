using System;

namespace LearnCSharp.Basic
{

    class Program
    {
        static void Main(string[] args)
        {
            //临时测试
            OutputUtil.ShowTitle("Tmp Test");
            TmpTest.Run();

            //Collection.ListTest.Run();
            //Types.EnumTest.Run();
            //IoC.Autofac.AutofacTest.Run();

            //File.FileTest.Run();
            //Types.EnumTest.Run();

            //Reflection
            //Reflection.AssemblyTest.Run();
            //Reflection.TypeTest.Run();
            //OOP.Constructor.StaticConstructorTest.Run();
            //Other.ExceptionHandle.ExceptionTest.Run();
            //Linq.Simple.SimpleTest.Run();
            //Xml.XmlTest.Run();
            //Other.DateTimeTest.Run();
            //Db.SqlServerTest.Run();

            Xml.XPathTest.Run();

            Console.ReadKey();
        }


    }
}
