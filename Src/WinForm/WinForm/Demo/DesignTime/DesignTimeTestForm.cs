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
        private DesignSurfaceManager surfaceManager;

        private DesignSurface surface;

        private IDesignerHost host;

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
            //初始化
            this.surfaceManager = new DesignSurfaceManager();
            this.surface = surfaceManager.CreateDesignSurface();
            this.surfaceManager.ActiveDesignSurface = this.surface;
            this.host = (IDesignerHost)surface.GetService(typeof(IDesignerHost));

            //添加到TabPage
            this.surface.BeginLoad(typeof(TabPage));
            Control view = this.surface.View as Control;
            view.BackColor = Color.LightGray;
            view.Dock = DockStyle.Fill;
            this.designTimePage.Controls.Add(view);

            //this.Refresh();

        }

        /// <summary>
        /// 创建Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addLabelBtn_Click(object sender, EventArgs e)
        {
            this.host.CreateComponent(typeof(Label), "HelloLabel");
            
        }

        /// <summary>
        /// 创建TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTextBoxBtn_Click(object sender, EventArgs e)
        {
            TextBox tb = this.host.CreateComponent(typeof(TextBox), "HelloTextBox") as TextBox;
            tb.Width = 100;
        }
    }
}
