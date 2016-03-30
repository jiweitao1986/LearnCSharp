using LearningCSharp.CustomControl.Entities;

namespace LearningCSharp.WinForm
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myUserControl1 = new LearningCSharp.CustomControl.Controls.MyUserControl.MyUserControl();
            this.SuspendLayout();
            // 
            // myUserControl1
            // 
            this.myUserControl1.CssStyle = ((CssStyle)(new CssStyle()));
            this.myUserControl1.Location = new System.Drawing.Point(41, 103);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(250, 106);
            this.myUserControl1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(713, 441);
            this.Controls.Add(this.myUserControl1);
            this.Name = "TestForm";
            this.Text = "测试表单";
            this.Load += new System.EventHandler(this.Test_Load);
            this.Click += new System.EventHandler(this.Test_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Test_MouseMove);
            this.ResumeLayout(false);

        }



















        #endregion

        private CustomControl.Controls.MyUserControl.MyUserControl myUserControl1;
    }
}