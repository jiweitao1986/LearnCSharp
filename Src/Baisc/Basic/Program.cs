using System;

namespace LearnCSharp.Basic
{

    class Program
    {
        static void Main(string[] args)
        {

            ////////////////////临时测试////////////////////
            //OutputUtil.ShowTitle("Tmp Test");
            //TmpTest.Run();

            ////////////////////文件相关////////////////////
            //File.FileTest.Run();
            //File.Stream.StreamTest.Run();

            ////////////////////图像处理////////////////////

            //GDI.Thumbnail.ThumbnailTest.Run();


            ////////////////////集合相关////////////////////
            //Collection.Deck.DeckTest.Run();
            //Collection.ListTest.Run();
            //Types.EnumTest.Run();

            //Collection.ListTest.Run();


            ////////////////////反射相关////////////////////
            //Reflection
            //Reflection.AssemblyTest.Run();
            //Reflection.TypeTest.Run();
            //IoC.Autofac.AutofacTest.Run();


            ////////////////////XML相关////////////////////
            //Xml.XmlTest.Run();

            ////////////////////数据库相关////////////////////
            //Db.SqlServerTest.Run();

            ////////////////////Linq相关////////////////////
            //Linq.SimpleTest.Run();

            ////////////////////DataSet相关////////////////////
            //Ds.DataSetTest.Run();
            //Ds.DataSetChangeTest.Run();
            //DataColumnTest.Run();
            //Ds.DataRowCollectionTest.Run();

            ////////////////////JSON相关////////////////////
            //Json.JsonTest.Run();
            //Json.NewtonJson.JObjectTest.Run();
            //Json.NewtonJson.JsonConvertSerializeTest.Run();


            ////////////////////Type相关////////////////////
            Types.ConvertTest.Run();


            ////////////////////其他测试////////////////////
            //Types.EnumTest.Run();
            //OOP.Constructor.StaticConstructorTest.Run();
            //Other.ExceptionHandle.ExceptionTest.Run();
            //Linq.Simple.SimpleTest.Run();
            //Other.DateTimeTest.Run();
            //Db.SqlServerTest.Run();
            //Linq.SimpleTest.Run();
            //Other.StringTest.Run();

            Console.ReadKey();
        }


    }
}
