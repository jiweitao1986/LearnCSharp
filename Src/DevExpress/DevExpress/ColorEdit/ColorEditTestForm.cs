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
    public partial class ColorEditTestForm : Form
    {
        public ColorEditTestForm()
        {
            InitializeComponent();
        }

        private void ColorEditTestForm_Load(object sender, EventArgs e)
        {
            this.colorColorEdit.ShowPopup();
        }


    }
}
