using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Reflection
{
    /// <summary>
    /// 人
    /// </summary>
    class Person
    {
        #region 私有字段

        /// <summary>
        /// 姓名
        /// </summary>
        private string name = "无名氏";

        /// <summary>
        /// 性别
        /// </summary>
        private string sex = "未知";

        /// <summary>
        /// 生日
        /// </summary>
        private DateTime birthday = DateTime.Now;

        /// <summary>
        /// 身高
        /// </summary>
        private int height = 180;

        /// <summary>
        /// 体重
        /// </summary>
        private double weight = 87.5;

        #endregion


        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name"></param>
        public Person(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        public Person(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        #endregion


        #region 方法

        /// <summary>
        /// 获取姓名
        /// </summary>
        /// <returns></returns>
        public void Say()
        {
            Console.WriteLine("姓名：" + name);
            Console.WriteLine("性别：" + sex);
            Console.WriteLine("生日：" + birthday.ToString());

        }

        #endregion

    }
}
