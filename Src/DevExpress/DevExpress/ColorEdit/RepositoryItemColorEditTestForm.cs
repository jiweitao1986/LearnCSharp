using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.ColorEdit
{
    public partial class RepositoryItemColorEditTestForm : Form
    {
        public RepositoryItemColorEditTestForm()
        {
            InitializeComponent();
            this.goodGridControl.DataSource = GetGoods();
        }

        public DataTable GetGoods()
        {
            DataTable goodDt = new DataTable();
            DataColumn idDc = new DataColumn("ID", Type.GetType("System.String"));
            DataColumn nameDc = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn colorDc = new DataColumn("Color", Type.GetType("System.String"));
            goodDt.Columns.Add(idDc);
            goodDt.Columns.Add(nameDc);
            goodDt.Columns.Add(colorDc);

            //Rows
            DataRow ipad = goodDt.NewRow();
            ipad["ID"] = "ipad";
            ipad["Name"] = "苹果平板";
            ipad["Color"] = "#ff0000";
            goodDt.Rows.Add(ipad);
            return goodDt;
        }

        private void goodGridView_CustomRowCellEdit(object sender, XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

        }

        private void goodGridView_RowClick(object sender, XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MessageBox.Show("行点击");
        }

        private void goodGridView_CustomRowCellEditForEditing(object sender, XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //MessageBox.Show("CustomRowCellEditForEditing");

        }

        private void goodGridView_RowCellClick(object sender, XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            MessageBox.Show("RowCellClick");
            //this.colorCol.ColumnEdit = this.colorRepositoryItemColorEdit;
        }

        private void goodGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            this.colorCol.ColumnEdit = this.colorRepositoryItemColorEdit;
        }
    }
}
