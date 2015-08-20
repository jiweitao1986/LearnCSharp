using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraTreeList.Nodes;

namespace DevExpress
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public void TestForm_Load(object sender, EventArgs e)
        {
        }

        private void testButtonEdit_ButtonClick(object sender, XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == XtraEditors.Controls.ButtonPredefines.Delete)
            {
                MessageBox.Show("删除按钮被点击");
                return;
            }

            MessageBox.Show("省略号按钮被点击");

        }
    }
}
