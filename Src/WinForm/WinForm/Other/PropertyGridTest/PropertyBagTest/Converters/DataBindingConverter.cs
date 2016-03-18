using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.PropertyBags;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.Converters
{
    [SourceType(typeof(DataBinding))]
    public class DataBindingConverter : ExpandableObjectConverter
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {

            return true;
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            object value, Type destinationType)
        {
            if (destinationType.Equals(typeof(string)) && value is DataBindingBag)
            {
                return "ConvertToResult";
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        //public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
        //    object value)
        //{

        //    if (value is string)
        //    {
        //        DataBinding dataBinding = new DataBinding()
        //        {
        //            ModelId = "123456",
        //            InstanceId = "ListInstanceId",
        //            TableName = "MyTableName",
        //            FieldName = "MyFieldName"
        //        };
        //        return dataBinding;
        //    }
        //    return base.ConvertFrom(context, culture, value);
        //}


        //public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        //{
        //    return true;
        //}

        //public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value,
        //    Attribute[] attributes)
        //{
        //    return TypeDescriptor.GetProperties(typeof(DataBindingBag), attributes);
        //}
    }
}
