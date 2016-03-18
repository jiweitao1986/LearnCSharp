using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.PropertyBags
{
    /// <summary>
    /// 属性封装包所支持的封装对象类型特性类
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class SourceTypeAttribute : Attribute
    {
        private Type _type;

        /// <summary>
        /// 指定一个所能支持的类型构造一个特性
        /// </summary>
        /// <param name="type"></param>
        public SourceTypeAttribute(Type type)
        {
            _type = type;
        }

        /// <summary>
        /// 支持的类型
        /// </summary>
        public Type SourceType
        {
            get { return _type; }
        }
    }
}
