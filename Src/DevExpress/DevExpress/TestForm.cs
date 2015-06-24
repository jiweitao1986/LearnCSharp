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
            //TreeListNode node = new TreeListNode();
            treeList1.AppendNode(new object[] { "根节点", 1 }, null);
        }
    }
}
