using DevExpress.XtraGrid.Views.Card;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.DataGrid
{
    public partial class DataGridCardTestForm : Form
    {
        public DataGridCardTestForm()
        {
            InitializeComponent();
        }

        private void DataGridCardTest_Load(object sender, EventArgs e)
        {
            this.empGrid.DataSource = this.GetEmployees();
        }

        /// <summary>
        /// 获取员工列表
        /// </summary>
        /// <returns></returns>
        private DataTable GetEmployees()
        {
            DataTable empDt = new DataTable();

            empDt.Columns.Add(new DataColumn("ID") { Caption = "ID" });
            empDt.Columns.Add(new DataColumn("Name") { Caption = "Name" });
            empDt.Columns.Add(new DataColumn("DeptID") { Caption = "DeptID" });
            empDt.Columns.Add(new DataColumn("Remark") { Caption = "Remark" });

            //Rows
            DataRow jiwt = empDt.NewRow();
            jiwt["ID"] = "jiwt";
            jiwt["Name"] = "季维涛";
            jiwt["DeptID"] = "gsp";
            jiwt["Remark"] = "暂无";
            empDt.Rows.Add(jiwt);

            empDt.Rows.Add("chshj", "陈圣杰", "gsp", "暂无");
            empDt.Rows.Add(new string[] { "fanxsh", "范潇生", "gsp", "暂无" });
            empDt.Rows.Add("huangxl", "黄秀岭", "gsp", "暂无");
            return empDt;
        }

        private void empCardView_CustomDrawCardFieldValue(object sender, XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            CardView view = sender as CardView;
            int focusedHandle = view.FocusedRowHandle;
            if (e.RowHandle == focusedHandle)
            {
                Color focusedBackColor = Color.FromArgb(200, 224, 250);
                e.Appearance.BackColor = focusedBackColor;

            }
            //bool isJiwt = view.GetRowCellValue(e.RowHandle, "ID").ToString() == "jiwt";
            //if (isJiwt)
            //{
            //    e.Appearance.BackColor = Color.Red;
            //}
        }
    }
}
