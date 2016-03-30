using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Reflection;

namespace LearningCSharp.CustomControl.Controls.MyList
{
    public class ScopeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// 从其他类型转换为Scope类型
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                string[] v = ((String)value).Split(',');
                if (v.GetLength(0) != 2)
                {
                    throw new ArgumentException("参数不正确");
                }
                Scope scope = new Scope();
                scope.Min = Convert.ToInt32(v[0]);
                scope.Max = Convert.ToInt32(v[1]);
                return scope;
            }

            return base.ConvertFrom(context, culture, value);
        }

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

        /// <summary>
        /// 从Scope类型转换为destinationType指定的类型
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            string result = string.Empty;

            //字符串
            if (destinationType == typeof(string))
            {
                Scope scope = (Scope)value;
                result = scope.Min.ToString() + "," + scope.Max.ToString();
                return result;
            }

            //实例描述符
            if (destinationType == typeof(InstanceDescriptor))
            {
                ConstructorInfo ci = typeof(Scope).GetConstructor(new Type[] { typeof(int), typeof(int) });
                Scope scope = (Scope)value;
                return new InstanceDescriptor(ci, new Object[] { scope.Min, scope.Max });
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(Scope), attributes);
        }

    }
}
