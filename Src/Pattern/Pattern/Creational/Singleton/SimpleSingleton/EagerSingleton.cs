using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Pattern.Creational.Singleton.SimpleSingleton
{
    class EagerSingleton
    {
        /// <summary>
        /// 类实例
        /// </summary>
        private static EagerSingleton instance = new EagerSingleton();

        /// <summary>
        /// 构造函数
        /// </summary>
        private EagerSingleton()
        {
            
        }

        /// <summary>
        /// 获取类实例
        /// </summary>
        /// <returns></returns>
        public static EagerSingleton GetInstance()
        {
            return instance;
        }
    }
}
