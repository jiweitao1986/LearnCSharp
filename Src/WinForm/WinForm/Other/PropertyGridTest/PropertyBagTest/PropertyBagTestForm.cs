using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.Converters;
using LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.Editors;
using LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.PropertyBags;


namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest
{
    public partial class PropertyBagTestForm : Form
    {
        
        public PropertyBagTestForm()
        {
            InitializeComponent();

            DataBinding dataBinding = new DataBinding()
            {
                ModelId = "123456",
                InstanceId = "ListInstanceId",
                TableName = "MyTableName",
                FieldName = "MyFieldName"
            };
            MyControl myControl = new MyControl()
            {
                Name = "我的控件",
                DataBinding = dataBinding
            };


            MyControlBag myControlBag = new MyControlBag(myControl);

            this.propertyGrid.SelectedObject = myControlBag;

        }

        public void WriteLog(string message)
        {
            this.logRichTextBox.Text += message + "\n";
        }

        public void ClearLog()
        {

            this.logRichTextBox.Text = string.Empty;
        }
    }
}
