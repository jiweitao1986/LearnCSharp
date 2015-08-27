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

namespace DevExpress.DataGrid.View
{
    public partial class CardViewTestForm : Form
    {
        public CardViewTestForm()
        {
            InitializeComponent();
        }

        private void DataGridCardTest_Load(object sender, EventArgs e)
        {
            DataTable empDt = Data.EmployeeData.GetEmpDt();
            this.empGrid.DataSource = empDt;
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
