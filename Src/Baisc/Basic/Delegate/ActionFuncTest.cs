using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Delegate
{
    public delegate void SayHiDelegate(string name);

    public delegate string GetFullNameDelegate(string firstName, string lastName);

    /// <summary>
    /// Action、Func测试
    /// </summary>
    public static class ActionFuncTest
    {
        /// <summary>
        /// 运行测试
        /// </summary>
        public static void Run()
        {
            ActionTest();
            FuncTest();
        }

        #region Action测试

        /// <summary>
        /// Action测试
        /// </summary>
        public static void ActionTest()
        {
            Utils.OutputUtil.ShowTitle("Action Test");

            SayHiDelegate hi = new SayHiDelegate(SayHi);
            hi("Zhang San（Delegate）");

            SayHiDelegate otherHi = SayHi;
            otherHi("Li Si（Delegate）");

            Action<string> sayHiAction = SayHi;
            sayHiAction("Wang Wu （Action）");
        }

        /// <summary>
        /// 打招呼
        /// </summary>
        /// <param name="name"></param>
        public static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name + " !!!");
        }

        #endregion


        #region Func测试

        /// <summary>
        /// Func测试
        /// </summary>
        public static void FuncTest()
        {
            Utils.OutputUtil.ShowTitle("Func Test");

            // 委托构造函数
            GetFullNameDelegate getFullName = new GetFullNameDelegate(GetFullName);
            Console.WriteLine("Delegate：" + getFullName("Zhang", "San"));

            //直接给委托赋值

            GetFullNameDelegate otherGetFullName = GetFullName;
            Console.WriteLine("Delegate：" + otherGetFullName("Li", "Si"));

            //使用Func委托
            Func<string, string, string> getFullNameFunc = GetFullName;
            Console.WriteLine("Func：" + getFullNameFunc("Wang", "Wu"));
        }

        /// <summary>
        /// 获取全名
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        #endregion

    }
}
