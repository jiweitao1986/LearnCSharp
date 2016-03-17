using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest
{
    public class DataBindingBag : PropertyBag
    {
        public DataBindingBag(DataBinding dataBinding) : base(dataBinding)
        {
            AddProperty("ModelId", "模型ID", "控件ID描述",
                "基本信息", false, true,
                typeof(string), dataBinding, null, null, null);

            AddProperty("InstanceId", "实例ID", "实例ID描述",
                "基本信息", false, true,
                typeof(string), dataBinding, null, null, null);

        }

        
    }


    public class DataBinding
    {
        public string ModelId { get; set; }

        public string InstanceId { get; set; }

        public string TableName { get; set; }


        public string FieldName { get; set; }

    }
}
