using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest
{
    /// <summary>
    /// 属性包
    /// </summary>
    public class PropertyBag : ICustomTypeDescriptor
    {
        #region 字段

        /// <summary>
        /// 关联对象
        /// </summary>
        private object _source = null;


        /// <summary>
        /// 属性集合
        /// </summary>
        /// <param name="_properties"></param>
        private BagPropertyDescriptorCollection _properties;

        #endregion


        #region 构造函数

        public PropertyBag(object source)
        {
            this._source = source;
            this._properties = new BagPropertyDescriptorCollection();
        }

        #endregion

        #region 属性

        /// <summary>
        /// 属性集合
        /// </summary>
        public BagPropertyDescriptorCollection Properties
        {
            get
            {
                return _properties;
            }
        }

        /// <summary>
        /// SourceObject
        /// </summary>
        public Object SourceObject
        {
            get
            {
                return _source;
            }
            set
            {
                _source = value;
            }
        }

        /// <summary>
        /// Owner
        /// </summary>
        public virtual Object Owner
        {
            get
            {
                return _source;
            }
        }

        #endregion


        #region ICustomTypeDescriptor实现

        /// <summary>
        /// 获取特性集合
        /// </summary>
        /// <returns></returns>
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        /// <summary>
        /// 获取类名
        /// </summary>
        /// <returns></returns>
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        /// <summary>
        /// 获取组件名
        /// </summary>
        /// <returns></returns>
        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        /// <summary>
        /// 获取转换器
        /// </summary>
        /// <returns></returns>
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        /// <summary>
        /// 获取默认事件
        /// </summary>
        /// <returns></returns>
        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        /// <summary>
        /// 获取默认属性
        /// </summary>
        /// <returns></returns>
        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        /// <summary>
        /// 获取类型编辑器
        /// </summary>
        /// <param name="editorBaseType"></param>
        /// <returns></returns>
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        /// <summary>
        /// 获取事件集合
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public EventDescriptorCollection  GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        /// <summary>
        /// 获取事件集合
        /// </summary>
        /// <returns></returns>
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        /// <summary>
        /// 获取属性集合
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return new PropertyDescriptorCollection(this._properties.ToArray());
        }

        /// <summary>
        /// 获取属性集合
        /// </summary>
        /// <returns></returns>
        public PropertyDescriptorCollection GetProperties()
        {
            return new PropertyDescriptorCollection(this._properties.ToArray());
        }

        /// <summary>
        /// 获取属性所有者
        /// </summary>
        /// <param name="pd"></param>
        /// <returns></returns>
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this.Owner;
        }

        #endregion


        #region 添加属性相关方法
        /// <summary>
        /// 添加一个属性
        /// </summary>
        /// <param name="name">属性名称</param>
        /// <param name="displayName">属性显示的名称</param>
        /// <param name="discription">属性的描述</param>
        /// <param name="category">属性的种类(PropertyGrid里面用它来分组)</param>
        /// <param name="isReadOnly">是否只读</param>
        /// <param name="isBrowsable">是否可被浏览</param>
        /// <param name="propertyType">属性的类型</param>
        /// <param name="componentType">属性所属对象的类型</param>
        /// <param name="converter">转换器</param>
        /// <param name="editorType">编辑器</param>
        /// <param name="attributes">该属性的特性集合</param>
        public BagPropertyDescriptor AddProperty(string name,
            string displayName,
            string discription,
            string category,
            bool isReadOnly,
            bool isBrowsable,
            Type propertyType,
            Type componentType,
            TypeConverter converter,
            Type editorType,
            Attribute[] attributes)
        {
            BagPropertyDescriptor property = new BagPropertyDescriptor(name, displayName, discription,
                category, isReadOnly, isBrowsable,
                propertyType, componentType, converter, editorType,
                attributes, this
            );
            _properties.Add(property);
            return property;
        }

        /// <summary>
        /// 添加一个属性
        /// </summary>
        /// <param name="name">属性名称</param>
        /// <param name="displayName">属性显示的名称</param>
        /// <param name="discription">属性的描述</param>
        /// <param name="category">属性的种类(PropertyGrid里面用它来分组)</param>
        /// <param name="isReadOnly">是否只读</param>
        /// <param name="isBrowsable">是否可被浏览</param>
        /// <param name="propertyType">属性的类型</param>
        /// <param name="component">属性所属对象</param>
        /// <param name="converter">转换器</param>
        /// <param name="editorType">编辑器</param>
        /// <param name="attributes">该属性的特性集合</param>
        public BagPropertyDescriptor AddProperty(string name,
            string displayName,
            string discription,
            string category,
            bool isReadOnly,
            bool isBrowsable,
            Type propertyType,
            object component,
            TypeConverter converter,
            Type editorType,
            Attribute[] attributes)
        {
            BagPropertyDescriptor property = new BagPropertyDescriptor(name, displayName, discription,
                category, isReadOnly, isBrowsable,
                propertyType, component, converter, editorType,
                attributes, this
            );
            _properties.Add(property);
            return property;
        }



        #endregion


    }



}
