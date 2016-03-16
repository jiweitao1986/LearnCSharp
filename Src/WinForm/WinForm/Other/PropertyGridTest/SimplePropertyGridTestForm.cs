using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCSharp.WinForm.Other.PropertyGridTest
{
    public partial class SimplePropertyGridTestForm : Form
    {
        public SimplePropertyGridTestForm()
        {
            InitializeComponent();

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
        }

        /// <summary>
        /// 关联对象发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightPropertyGrid_SelectedObjectsChanged(object sender, EventArgs e)
        {
            Person person = ((PropertyGrid) sender).SelectedObject as Person;
            this.resultRichTextBox.Text = person.Name;
        }

        /// <summary>
        /// 属性值发生变化
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void rightPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Person person = ((PropertyGrid)s).SelectedObject as Person;
            this.resultRichTextBox.Text = person.Name;
        }
    }
}
