using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.Singleton.SimpleSingleton
{
    class LazySingleton
    {
        /// <summary>
        /// 类实例
        /// </summary>
        private static LazySingleton instance = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        private LazySingleton()
        {
        }

        /// <summary>
        /// 获取类实例
        /// </summary>
        /// <returns></returns>
        public static LazySingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new LazySingleton();
            }
            return instance;
        }
    }
}
