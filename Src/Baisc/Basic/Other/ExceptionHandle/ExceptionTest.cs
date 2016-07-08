using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Other.ExceptionHandle
{
    public class ExceptionTest
    {
        public static void Run()
        {

            //try
            //{
            //    Console.WriteLine("异常发生前");
            //    throw new Exception("发生异常，请处理");
            //    Console.WriteLine("异常发生后");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("finally handle");
            //}

            //
            Console.WriteLine("================================================================================");
            Console.WriteLine("直接转发原始异常");
            Console.WriteLine("================================================================================");
            try
            {
                ThrowOriginalExceptionAgain();
            }
            catch (WrapperException we)
            {
                Console.WriteLine("//////////Catch WrapperException//////////");
                Console.WriteLine(we.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("//////////Catch Exception//////////");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("================================================================================");
            Console.WriteLine("捕获原始异常，转发包装之后的异常");
            Console.WriteLine("================================================================================");
            try
            {
                ThrowWrapperException();
            }
            catch (WrapperException we)
            {
                Console.WriteLine("//////////Catch WrapperException//////////");
                Console.WriteLine(we.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("//////////Catch Exception//////////");
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// 转发包装后的异常
        /// </summary>
        public static void ThrowWrapperException()
        {
            try
            {
                ThrowOriginalException();
            }
            catch(Exception e)
            {
                throw new WrapperException("The original message : " + e.Message);
            }
        }

        /// <summary>
        /// 转发原始异常
        /// </summary>
        public static void ThrowOriginalExceptionAgain()
        {
            try
            {
                ThrowOriginalException();
            }
            catch (Exception e)
            {
                throw;
            }
        }


        /// <summary>
        /// 抛出原始异常
        /// </summary>
        public static void ThrowOriginalException()
        {
            throw new Exception("This is original exception !");
        }
    }


    /// <summary>
    /// 包装之后的异常
    /// </summary>
    public class WrapperException : Exception
    {
        public WrapperException(string message) : base(message)
        {

        }
    }

}
