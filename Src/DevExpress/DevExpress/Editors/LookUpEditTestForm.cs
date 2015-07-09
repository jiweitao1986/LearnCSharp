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
    public partial class LookUpEditTestForm : Form
    {
        public LookUpEditTestForm()
        {
            InitializeComponent();
        }

        private void LookUpEditTestForm_Load(object sender, EventArgs e)
        {
            this.simpleLookUpEdit.EditValue = "gsp";
            this.simpleLookUpEdit.Properties.DisplayMember = "ID";
            this.simpleLookUpEdit.Properties.ValueMember = "Name";
            this.simpleLookUpEdit.Properties.DataSource = this.GetDepartments();

        }

        private DataTable GetDepartments()
        {
            DataTable deptDt = new DataTable();
            DataColumn idDc = new DataColumn("ID", Type.GetType("System.String"));
            DataColumn nameDc = new DataColumn("Name", Type.GetType("System.String"));
            deptDt.Columns.Add(idDc);
            deptDt.Columns.Add(nameDc);

            //Rows
            DataRow gspDr = deptDt.NewRow();
            gspDr["ID"] = "gsp";
            gspDr["Name"] = "平台与技术部";
            deptDt.Rows.Add(gspDr);
            return deptDt;
        }
    }
}
