using LearningCSharp.WinForm.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.PropertyBags
{

    #region 委托声明

    /// <summary>
    /// 属性值变化前处理委托声明
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="cancel"></param>
    public delegate void PropertyChangingHandler(object sender, string name, object value, ref bool cancel);

    /// <summary>
    /// 属性值变化后处理委托声明
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    public delegate void PropertyChangedHandler(object sender, string name, object value);

    #endregion


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
        private CustomPropertyDescriptorCollection _properties;

        /// <summary>
        /// 嵌套属性包类型集合
        /// </summary>
        List<Type> _bagTypes = null;

        /// <summary>
        /// 嵌套属性包集合
        /// </summary>
        List<PropertyBag> _bags = null;

        /// <summary>
        /// 父属性包集合
        /// </summary>
        internal PropertyBag _parentBag = null;

        /// <summary>
        /// 父属性名称
        /// </summary>
        internal string _parentPropertyName = null;

        #endregion


        #region 构造函数

        public PropertyBag()
        {
            this._properties = new CustomPropertyDescriptorCollection();
            this._bagTypes = new List<Type>();
            this._bags = new List<PropertyBag>();
        }

        /// <summary>
        /// 指定一个封装的对象来构造封装包
        /// </summary>
        /// <param name="source">需要封装的对象</param>
        public PropertyBag(object source) : this()
        {
            this._source = source;
        }

        #endregion


        #region 属性

        /// <summary>
        /// 属性集合
        /// </summary>
        public CustomPropertyDescriptorCollection Properties
        {
            get
            {
                return this._properties;
            }
        }

        /// <summary>
        /// SourceObject
        /// </summary>
        public Object SourceObject
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }

        /// <summary>
        /// Owner
        /// </summary>
        public virtual Object Owner
        {
            get
            {
                return this._source;
            }
        }


        /// <summary>
        /// 获取嵌套的封装包类型的集合。
        /// 如果封装的对象内的某个属性也需要封装，
        /// 请将能封装该类型的属性包的类型添加到这个集合
        /// </summary>
        public List<Type> NestedBagTypes
        {
            get
            {
                return this._bagTypes;
            }
        }

        /// <summary>
        /// 嵌套的封装包的集合。
        /// 经过封装的嵌套包会添加到这个集合中
        /// </summary>
        public List<PropertyBag> NestedBags
        {
            get
            {
                return this._bags;
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
            return TypeDescriptor.GetAttributes(this._source, true);
        }

        /// <summary>
        /// 获取类名
        /// </summary>
        /// <returns></returns>
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this._source, true);
        }

        /// <summary>
        /// 获取组件名
        /// </summary>
        /// <returns></returns>
        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this._source, true);
        }

        /// <summary>
        /// 获取转换器
        /// </summary>
        /// <returns></returns>
        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this._source, true);
        }

        /// <summary>
        /// 获取默认事件
        /// </summary>
        /// <returns></returns>
        public EventDescriptor GetDefaultEvent()
        {
            //return TypeDescriptor.GetDefaultEvent(this, true);
            return TypeDescriptor.GetDefaultEvent(true);
        }

        /// <summary>
        /// 获取默认属性
        /// </summary>
        /// <returns></returns>
        public PropertyDescriptor GetDefaultProperty()
        {
            //return TypeDescriptor.GetDefaultProperty(this, true);
            return TypeDescriptor.GetDefaultProperty(this._source);
        }

        /// <summary>
        /// 获取类型编辑器
        /// </summary>
        /// <param name="editorBaseType"></param>
        /// <returns></returns>
        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this._source, editorBaseType, true);
        }

        /// <summary>
        /// 获取事件集合
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public EventDescriptorCollection  GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this._source, attributes, true);
        }

        /// <summary>
        /// 获取事件集合
        /// </summary>
        /// <returns></returns>
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this._source, true);
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
            return Owner ;
        }

        #endregion


        #region 添加属性相关方法

        /// <summary>
        /// 添加一个属性
        /// 传递componentType
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
        public CustomPropertyDescriptor AddProperty(string name,
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
            CustomPropertyDescriptor property = new CustomPropertyDescriptor(name, displayName, discription,
                category, isReadOnly, isBrowsable,
                propertyType, componentType, converter, editorType,
                attributes, this
            );
            _properties.Add(property);
            return property;
        }

        /// <summary>
        /// 添加一个属性
        /// 传递component对象
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
        public CustomPropertyDescriptor AddProperty(string name,
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
            CustomPropertyDescriptor property = new CustomPropertyDescriptor(name, displayName, discription,
                category, isReadOnly, isBrowsable,
                propertyType, component, converter, editorType,
                attributes, this
            );
            _properties.Add(property);
            return property;
        }

        #endregion


        #region 设置属性值、获取属性值

        /// <summary>
        /// 设置属性值
        /// </summary>
        /// <param name="source"></param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        protected virtual void SetValue(object source, string propertyName, object value)
        {
            LogWriter.WriteLog("PropertyBag -- SetValue");

            PropertyInfo pi = source.GetType().GetProperty(propertyName);
            if (pi.CanWrite)
            {
                pi.SetValue(source, value, null);
            }
        }

        /// <summary>
        /// 内部设置属性值
        /// </summary>
        /// <param name="source"></param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        internal void InternelSetValue(object source, string propertyName, object value)
        {
            this.SetValue(source, propertyName, value);
        }

        protected virtual object GetValue(object source, string propertyName)
        {
            LogWriter.WriteLog("PropertyBag -- GetValue");

            object obj = null;
            PropertyInfo pi = source.GetType().GetProperty(propertyName);
            if (pi != null && pi.CanRead)
            {
                try
                {
                    obj = pi.GetValue(source, null);
                }
                catch
                {
                    
                }

                if (obj != null)
                {
                    Type t = NestedType(obj);
                    if (t != null)
                    {
                        return NestedBag(obj, t, propertyName);
                    }
                }
            }
            return obj;
        }

        internal object InternelGetValue(object source, string propertyName)
        {

            object obj = GetValue(source, propertyName);
            if (obj != null)
            {
                Type t = NestedType(obj);
                if (t != null)
                {
                    return NestedBag(obj, t, propertyName);
                }
            }
            return obj;
        }



        // 判断是否当前对象是否在嵌套的类型包的支持列表中
        private Type NestedType(object obj)
        {
            foreach (Type t in this.NestedBagTypes)
            {
                object[] objects = t.GetCustomAttributes(typeof(SourceTypeAttribute), false);
                if (objects != null && objects.Length > 0)
                {
                    SourceTypeAttribute st = objects[0] as SourceTypeAttribute;
                    if (st.SourceType == obj.GetType())
                    {
                        return t;
                    }
                }
            }
            return null;
        }

        // 获取嵌套类型的属性封装包
        private PropertyBag NestedBag(object obj, Type bagType, string propertyName)
        {
            foreach (PropertyBag bag in this.NestedBags)
            {
                if (bag.SourceObject == obj)
                {
                    return bag;
                }
            }
            PropertyBag b = bagType.Assembly.CreateInstance(bagType.FullName, false, BindingFlags.Public | BindingFlags.Instance, null, new object[] { obj }, null, null) as PropertyBag;
            b._parentBag = this;
            b._parentPropertyName = propertyName;
            this.NestedBags.Add(b);
            return b;
        }


        /// <summary>
        /// 获取属性类型
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private Type GetPropertyType(string propertyName)
        {

            PropertyInfo pi = SourceObject.GetType().GetProperty(propertyName);
            if (pi != null)
            {
                return pi.PropertyType;
            }

            return typeof (object);
        }


        #endregion


        #region 事件相关

        PropertyChangedHandler _changed;

        PropertyChangingHandler _changing;

        /// <summary>
        /// 更改属性值时。
        /// 可以在这里实现输入有效值的判断。
        /// </summary>
        public event PropertyChangingHandler PropertyChanging
        {
            add
            {
                this._changing += value;
            }
            remove
            {
               this._changing -= value;
            }
        }

        /// <summary>
        /// 更改属性值后
        /// </summary>
        public event PropertyChangedHandler PropertyChanged
        {
            add
            {
                this._changed += value;
            }
            remove
            {
                this._changed -= value;
            }
        }

        /// <summary>
        /// 属性值变化前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="cancel"></param>
        internal void OnPropertyChanging(object sender, string name, object value, ref bool cancel)
        {
            if (this._changing != null)
            {
                this._changing(sender, name, value, ref cancel);
            }
            if (this._parentBag != null && (!cancel))
            {
                this._parentBag.OnPropertyChanging(this._parentBag.SourceObject, this._parentPropertyName, this.SourceObject, ref cancel);
            }
        }

        /// <summary>
        /// 属性值变化后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        internal void OnPropertyChanged(object sender, string name, object value)
        {
            if (this._changed != null)
            {
                this._changed(sender, name, value);
            }
            if (this._parentBag != null)
            {
                this._parentBag.OnPropertyChanged(this._parentBag.SourceObject, this._parentPropertyName, this.SourceObject);
                this._parentBag.OnPropertyChanged(this._parentBag.SourceObject, this._parentPropertyName + "." + name, value);
            }
        }

        #endregion

    }



}
