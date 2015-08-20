using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.Editors
{
    public partial class ScrollableTestForm : Form
    {
        public ScrollableTestForm()
        {
            InitializeComponent();
        }

        private void ScrollableTestForm_Load(object sender, EventArgs e)
        {
            this.testRadio.Height = this.testRadio.Properties.Items.Count * 50;
        }
    }
}
