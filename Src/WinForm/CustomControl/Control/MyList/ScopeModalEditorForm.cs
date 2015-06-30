using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl.Control.MyList
{
    public partial class ScopeModalEditorForm : Form
    {
        private Scope _scope = null;

        public ScopeModalEditorForm()
        {
            InitializeComponent();
        }

        public ScopeModalEditorForm(Scope scope)
        {
            InitializeComponent();
            _scope = scope;
        }

        public Scope Scope
        {
            get
            {
                return this._scope;
            }
            set
            {
                this._scope = value;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this._scope.Min = Convert.ToInt32(this.minEdit.Text);
            this._scope.Max = Convert.ToInt32(this.maxEdit.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ScopeModalEditorForm_Load(object sender, EventArgs e)
        {
            if (this._scope == null)
            {
                return;
            }
            this.minEdit.Text = this._scope.Min.ToString();
            this.maxEdit.Text = this._scope.Max.ToString();
        }
    }
}
