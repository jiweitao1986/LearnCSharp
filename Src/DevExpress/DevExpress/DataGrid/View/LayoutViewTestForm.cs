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
    public partial class LayoutViewTestForm : Form
    {
        public LayoutViewTestForm()
        {
            InitializeComponent();
        }

        private void LayoutViewTestForm_Load(object sender, EventArgs e)
        {
            DataTable adpEmpDt = Data.EmployeeData.GetEmpDt();
            this.empGrid.DataSource = adpEmpDt;
        }
    
    }
}
