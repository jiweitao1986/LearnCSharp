using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCSharp.WinForm.Demo.DesignTime
{
    public partial class DesignTimeTestForm : Form
    {
        public DesignTimeTestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表单加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DesignTimeTestForm_Load(object sender, EventArgs e)
        {
            DesignSurfaceManager surfaceManager = new DesignSurfaceManager();
            DesignSurface surface = surfaceManager.CreateDesignSurface();
            IDesignerHost host = (IDesignerHost)surface.GetService(typeof(IDesignerHost));

            Control view = surface.View as Control;
            view.BackColor = Color.Gray;
            view.Dock = DockStyle.Fill;

            

            this.designTimePage.Controls.Add(view);

        }
    }
}
