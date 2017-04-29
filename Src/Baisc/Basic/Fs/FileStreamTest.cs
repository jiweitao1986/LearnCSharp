using System;
using System.IO;
using System.Text;

namespace LearnCSharp.Basic
{
    public static class FileStreamTest
    {
        public static void Run()
        {
            WriteTest();
        }
        #region 读取测试

        public static void ReadTest()
        {
            OutputUtil.ShowTitle("FileStrea Read");

            var fs = GetReadFileStream();
            var byteData = new byte[200];
            var charData = new char[200];

            try
            {
                fs.Seek(6, SeekOrigin.Begin);
                fs.Read(byteData, 0, 200);

                var d = Encoding.UTF8.GetDecoder();
                d.GetChars(byteData, 0, byteData.Length, charData, 0);
                Console.Write(charData);
            }
            catch (IOException e)
            {
                Console.Write(e.ToString());
            }
        }

        /// <summary>
        /// 获取用于读取文件的FileStream实例
        /// </summary>
        /// <returns></returns>
        public static FileStream GetReadFileStream()
        {
            FileStream fs = null;
            var path = "C:/temp/read.txt";

            //构造函数
            //fs = new FileStream("C:/temp/temp.txt", FileMode.Open, FileAccess.Read);

            //通过File获取
            //fs = File.OpenRead(path);

            //通过FileInfo获取
            var finfo = new FileInfo(path);
            fs = finfo.OpenRead();

            return fs;
        }

        #endregion


        #region 写测试

        /// <summary>
        /// 按字节块写入
        /// </summary>
        public static void WriteTest()
        {
            var byteData = new byte[200];
            var charData = @"abcdefg\r\n123456".ToCharArray();
            var fs = GetWriteFileStream();
            var d = Encoding.UTF8.GetEncoder();

            try
            {
                d.GetBytes(charData, 0, charData.Length, byteData, 0, true);

                fs.Seek(0, SeekOrigin.Begin);
                fs.Write(byteData, 0, byteData.Length);
            }
            catch (IOException e)
            {
                Console.Write(e.ToString());
            }
        }

        /// <summary>
        /// 按字节写入
        /// </summary>
        public static void WriteByteTest()
        {

        }

        /// <summary>
        /// 获取用于写入文件的FileStream实例
        /// </summary>
        /// <returns></returns>
        public static FileStream GetWriteFileStream()
        {
            try
            {
                FileStream fs;
                var path = "C:/temp/write.txt";
                
                //方式1：通过构造函数构造
                //fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                //方式2：通过File获取
                //fs = File.OpenWrite(path);

                //方式3：通过FileInfo获取
                var finfo = new FileInfo(path);
                fs = finfo.OpenWrite();

                return fs;
            }
            catch (IOException e)
            {
                Console.Write(e.ToString());
                throw e;
            }
        }

        #endregion
    }
}
