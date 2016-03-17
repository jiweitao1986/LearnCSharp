using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest
{
    public partial class PropertyBagTestForm : Form
    {
        public PropertyBagTestForm()
        {
            InitializeComponent();
            MyControl myControl = new MyControl()
            {
                Name = "我的控件"
            };
            MyControlBag myControlBag = new MyControlBag(myControl);

            this.propertyGrid.SelectedObject = myControlBag;
        }
    }
}
