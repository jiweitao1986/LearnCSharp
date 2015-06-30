using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl.Control.MyList
{
    public partial class ScopeDropEditorControl : UserControl
    {
        private Scope _scope = null;

        public ScopeDropEditorControl()
        {
            InitializeComponent();
        }

        public ScopeDropEditorControl(Scope scope)
        {
            InitializeComponent();
            this._scope = scope;
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

        private void ScopeDropEditorControl_Leave(object sender, EventArgs e)
        {
            this._scope.Min = Convert.ToInt32(this.minEdit.Text);
            this._scope.Max = Convert.ToInt32(this.maxEdit.Text);
        }

        private void ScopeDropEditorControl_Load(object sender, EventArgs e)
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
