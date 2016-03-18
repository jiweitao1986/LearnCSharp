using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.PropertyBags
{
    public class BagPropertyDescriptor : PropertyDescriptor
    {
        #region 字段

        private PropertyBag _propertyBag = null;
        private string _name;
        private string _displayName;
        private string _category;
        private string _discription;
        private Type _componentType;
        private object _component;
        private Type _propertyType;
        private TypeConverter _converter;
        private Type _eidtorType;
        private bool _isBrowsable;
        private bool _isReadOnly;
        private Attribute[] _attributes;

        #endregion


        #region 构造函数

        /// <summary>
        /// 构造一个新的属性描述器
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
        /// <param name="attributes">该属性的特性集合</param>
        /// <param name="propertyBag">所在的属性封装包</param>
        public BagPropertyDescriptor(
            string name, string displayName, string discription,
            string category, bool isReadOnly, bool isBrowsable,
            Type propertyType, Type componentType, TypeConverter converter, Type editorType,
            Attribute[] attributes, PropertyBag propertyBag
            ) : base(name, attributes)
        {
            _propertyBag = propertyBag;
            _name = name;
            _displayName = displayName;
            _discription = discription;
            _category = category;
            _isReadOnly = isReadOnly;
            _isBrowsable = isBrowsable;
            _propertyType = propertyType;
            _componentType = componentType;
            _converter = converter;
            _eidtorType = editorType;
            _attributes = attributes;
        }

        /// <summary>
        /// 构造一个新的属性描述器
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
        /// <param name="attributes">该属性的特性集合</param>
        /// <param name="propertyBag">所在的属性封装包</param>
        public BagPropertyDescriptor(
            string name, string displayName, string discription,
            string category, bool isReadOnly, bool isBrowsable,
            Type propertyType, object component, TypeConverter converter, Type editorType,
            Attribute[] attributes, PropertyBag propertyBag
            ) : base(name, attributes)
        {
            _propertyBag = propertyBag;
            _name = name;
            _displayName = displayName;
            _discription = discription;
            _category = category;
            _isReadOnly = isReadOnly;
            _isBrowsable = isBrowsable;
            _propertyType = propertyType;
            _component = component;
            _componentType = component == null ? null : _component.GetType();
            _converter = converter;
            _eidtorType = editorType;
            _attributes = attributes;
        }

        #endregion


        #region 字段

        public override string Name
        {
            get { return _name; }
        }

        public override string DisplayName
        {
            get { return _displayName; }
        }

        public override string Description
        {
            get { return _discription; }
        }

        public override string Category
        {
            get { return _category; }
        }

        public override bool IsReadOnly
        {
            get { return _isReadOnly; }
        }

        public override bool IsBrowsable
        {
            get { return _isBrowsable; }
        }

        public override Type PropertyType
        {
            get { return _propertyType; }
        }

        public override Type ComponentType
        {
            get { return _componentType; }
        }

        public override TypeConverter Converter
        {
            get { return _converter; }
        }

        #endregion

        public void SetBrowsable(bool value)
        {
            this._isBrowsable = value;
        }

        public void SetReadOnly(bool value)
        {
            this._isReadOnly = value;
        }


        /// <summary>
        /// 获取属性值
        /// 调用所在属性包的“获取属性值”方法
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public override object GetValue(object component)
        {
            if (this._component == null)
            {
                //对参数传递过来的component进行赋值
                return this._propertyBag.InternelGetValue(component, Name);
            }
            else
            {
                return this._propertyBag.InternelGetValue(this._component, Name);
            }
        }


        /// <summary>
        /// 给属性复制
        /// </summary>
        /// <param name="component"></param>
        /// <param name="value"></param>
        public override void SetValue(object component, object value)
        {
            // 值是属性封装包时，检测是否是嵌套包的类型，是不处理赋值
            if ((_converter != null) && (value is PropertyBag) &&
                (_propertyBag.NestedBagTypes.Contains(value.GetType())))
            {
                return;
            }


            PropertyChangedEventArgs e = new PropertyChangedEventArgs(Name);
            bool cancel = false;
            if (_component == null)
            {
                _propertyBag.OnPropertyChanging(component, Name, value, ref cancel);
                if (!cancel)
                {
                    _propertyBag.InternelSetValue(component, Name, value);
                    _propertyBag.OnPropertyChanged(component, Name, value);
                }
            }
            else
            {
                _propertyBag.OnPropertyChanging(_component, Name, value, ref cancel);
                if (!cancel)
                {
                    _propertyBag.InternelSetValue(_component, Name, value);
                    _propertyBag.OnPropertyChanged(_component, Name, value);
                }
            }
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override void ResetValue(object component)
        {
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
