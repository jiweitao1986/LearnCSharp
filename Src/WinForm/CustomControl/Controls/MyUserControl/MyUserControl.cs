using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LearningCSharp.CustomControl.Converters;
using LearningCSharp.CustomControl.Entities;

namespace LearningCSharp.CustomControl.Controls.MyUserControl
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            //CssStyle属性只有初始化后，在设计时的属性栏里才能分别对属性进行编辑
            //如果不进行初始化，属性只显示一个文本输入框。
            this.CssStyle = new CssStyle(300, 200);

            InitializeComponent();

        }


        [Browsable(true),Category("样式信息"), Description("控件的CSS样式"),]
        public CssStyle CssStyle { get; set; }

    }
}
