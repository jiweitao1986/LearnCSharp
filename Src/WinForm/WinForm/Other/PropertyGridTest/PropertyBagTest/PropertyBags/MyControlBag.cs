using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.Converters;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.PropertyBags
{
    [SourceType(typeof(MyControl))]

    public class MyControlBag : PropertyBag
    {
        public MyControlBag(MyControl myControl) : base(myControl)
        {

            this.NestedBagTypes.Add(typeof(DataBindingBag));


            //AddProperty("ID", "控件ID", "控件ID描述",
            //    "基本信息", false, true,
            //    typeof(string), myControl, null, null, null
            //);

            //AddProperty("Name", "控件名称", "控件名称描述",
            //    "基本信息", false, true,
            //    typeof(string), myControl, null, null, null
            //);

            //AddProperty("Color", "控件颜色", "控件颜色描述",
            //    "外观样式", false, true,
            //    typeof(Color), myControl, null, null, null
            //);

            //AddProperty("Visible", "是否显示", "是否显示描述",
            //    "外观样式", false, true,
            //    typeof(Boolean), myControl, null, null, null
            //);

            AddProperty("DataBinding", "数据绑定", "数据绑定描述",
                "外观样式", false, true,
                typeof(DataBindingBag), myControl.DataBinding, new DataBindingConverter(), null, null
            );

        }
    }

    /// <summary>
    /// 我的控件
    /// </summary>
    public class MyControl
    {
        public string Name { get; set; }

        public DataBinding DataBinding { get; set; }

    }

}
