using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LearningCSharp.CustomControl.Controls.MyUserControl;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.SimpleTest
{
    public partial class SimpleTestForm : Form
    {
        public SimpleTestForm()
        {
            InitializeComponent();
            this.SetUserControl();
        }

        private void SetUserControl()
        {
            MyUserControl userControl = new MyUserControl();
            this.rightPropertyGrid.SelectedObject = userControl;
        }


        private void SetPerson()
        {

            Person person = new Person()
            {
                Name = "季维涛",
                Gender = Gender.male,
                Birthday = DateTime.Now,
                IsSignle = false,
                FavColor = Color.Red,
                FavDay = DayOfWeek.Saturday
            };
            this.rightPropertyGrid.SelectedObject = person;

            //PropertyDescriptorCollection propDescriptors =  TypeDescriptor.GetProperties(person, true);
            //string result = string.Empty;

            //获取基本信息相关的属性
            //foreach (PropertyDescriptor propDescriptor in propDescriptors)
            //{
            //    foreach (Attribute attr in propDescriptor.Attributes)
            //    {
            //        if (attr.GetType() == typeof(CategoryAttribute))
            //        {
            //            if (((CategoryAttribute)(attr)).Category.Equals("兴趣爱好"))
            //            {
            //                result += propDescriptor.Name + "\n";
            //            }

            //        }
            //    }
            //}

            //Type t = person.GetType();
            //FieldInfo[] fields = t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            //foreach (FieldInfo field in fields)
            //{
            //    result += field.Name + "\n";
            //}

            //this.resultRichTextBox.Text = result;
        }

        /// <summary>
        /// 关联对象发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightPropertyGrid_SelectedObjectsChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 属性值发生变化
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void rightPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
        }
    }
}
