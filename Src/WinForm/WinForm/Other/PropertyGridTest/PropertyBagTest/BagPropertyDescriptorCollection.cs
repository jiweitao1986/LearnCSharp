using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest
{
    /// <summary>
    /// 属性包属性描述集合
    /// </summary>
    public class BagPropertyDescriptorCollection : List<BagPropertyDescriptor>
    {
        /// <summary>
        /// 根据指定的属性名称获取属性
        /// </summary>
        /// <param name="name">属性名称</param>
        /// <returns>属性描述的封装类</returns>
        public BagPropertyDescriptor this[string name]
        {
            get
            {
                foreach (BagPropertyDescriptor p in this)
                {
                    if (p.Name == name) return p;
                }
                return null;
            }
        }

        /// <summary>
        /// 移除指定名称的项
        /// </summary>
        /// <param name="name"></param>
        public BagPropertyDescriptor Remove(string name)
        {
            BagPropertyDescriptor item = this[name];
            if (item != null)
            {
                base.Remove(item);
            }
            return item;
        }
    }
}
