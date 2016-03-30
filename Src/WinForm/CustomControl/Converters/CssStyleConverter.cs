using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LearningCSharp.CustomControl.Entities;

namespace LearningCSharp.CustomControl.Converters
{
    class CssStyleConverter : TypeConverter
    {
        #region ConvertFrom

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof (string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                CssStyle cssStyle = new CssStyle()
                {
                    Position = "static",
                    Float = Float.Left,
                    Width = 300,
                    Height = 200,
                    Color = Color.Red
                };
                return cssStyle;
            }
            return base.ConvertFrom(context, culture, value);
        }

        #endregion


        #region ConvertTo

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return true;
            }

            if (destinationType == typeof(InstanceDescriptor))
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof (string))
            {
                return "position: static; float: left; width: 300px; height: 200px; color：#f00";
            }

            //TODO: 以下均不起作用，暂时注释掉，待验证！！！
            //if (destinationType == typeof(InstanceDescriptor))
            //{
            //    //ConstructorInfo ci = typeof(CssStyle).GetConstructor(Type.EmptyTypes);
            //    //return new InstanceDescriptor(ci, null);

            //    ConstructorInfo ci = typeof (CssStyle).GetConstructor(new Type[] { typeof(Int32), typeof(Int32) });
            //    CssStyle cssStyle = (CssStyle)value;
            //    return new InstanceDescriptor(ci, new object[] { cssStyle.Width, cssStyle.Height });
            //}
            return base.ConvertTo(context, culture, value, destinationType);
        }

        #endregion


        #region GetProperties

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            //return base.GetPropertiesSupported(context);
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(CssStyle), attributes);
        }

        #endregion

    }
}
