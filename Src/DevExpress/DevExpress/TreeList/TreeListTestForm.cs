using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.TreeList
{
    public partial class TreeListTestForm : Form
    {
        public TreeListTestForm()
        {
            InitializeComponent();
        }

        private void TreeListTestForm_Load(object sender, EventArgs e)
        {

            this.EmpTreeList.DataSource = GetTreeListTable();
            this.EmpTreeList.ExpandAll();
            string name = string.Empty;
            //TreeListNode focusedNode = this.EmpTreeList.FindNodeByKeyID(4);
            TreeListNode focusedNode = this.EmpTreeList.FindNodeByFieldValue("Name", "季维涛");
            this.EmpTreeList.SetFocusedNode(focusedNode);


            MessageBox.Show(name);
        }



        /// <summary>
        /// 员工树
        /// </summary>
        private DataTable GetTreeListTable()
        {
            DataTable empDt = new DataTable();
            
            //Columns
            DataColumn idCol = new DataColumn("ID", Type.GetType("System.Int32"));
            DataColumn mgrIdCol = new DataColumn("MgrID", Type.GetType("System.Int32"));
            DataColumn nameCol = new DataColumn("Name", Type.GetType("System.String"));
            empDt.Columns.Add(idCol);
            empDt.Columns.Add(mgrIdCol);
            empDt.Columns.Add(nameCol);

            //Rows
            DataRow zhengwb = empDt.NewRow();
            zhengwb["ID"] = 1;
            zhengwb["MgrID"] = 0;
            zhengwb["Name"] = "郑伟波";

            DataRow sunlx = empDt.NewRow();
            sunlx["ID"] = 2;
            sunlx["MgrID"] = 1;
            sunlx["Name"] = "孙立新";

            DataRow weil = empDt.NewRow();
            weil["ID"] = 3;
            weil["MgrID"] = 1;
            weil["Name"] = "魏亮";

            DataRow chenshj = empDt.NewRow();
            chenshj["ID"] = 4;
            chenshj["MgrID"] = 3;
            chenshj["Name"] = "陈圣杰";

            DataRow gongbj = empDt.NewRow();
            gongbj["ID"] = 5;
            gongbj["MgrID"] = 3;
            gongbj["Name"] = "宫宝金";

            DataRow huangxl = empDt.NewRow();
            huangxl["ID"] = 6;
            huangxl["MgrID"] = 4;
            huangxl["Name"] = "黄秀玲";

            DataRow jiwt = empDt.NewRow();
            jiwt["ID"] = 7;
            jiwt["MgrID"] = 4;
            jiwt["Name"] = "季维涛";

            empDt.Rows.Add(zhengwb);
            empDt.Rows.Add(sunlx);
            empDt.Rows.Add(weil);
            empDt.Rows.Add(chenshj);
            empDt.Rows.Add(gongbj);
            empDt.Rows.Add(huangxl);
            empDt.Rows.Add(jiwt);
            return empDt;
        }

        private void EmpTreeList_AfterCheckNode(object sender, XtraTreeList.NodeEventArgs e)
        {
            SetChildrenState(e.Node, e.Node.CheckState);

        }

        private void SetChildrenState(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;

                SetChildrenState(node.Nodes[i], check);
            }
        }


    }
}
