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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myUserControl1
            // 
            this.myUserControl1.Location = new System.Drawing.Point(41, 103);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(250, 106);
            this.myUserControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 235);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(713, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myUserControl1);
            this.Name = "TestForm";
            this.Text = "测试表单";
            this.Load += new System.EventHandler(this.Test_Load);
            this.Click += new System.EventHandler(this.Test_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Test_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



















        #endregion

        private CustomControl.Controls.MyUserControl.MyUserControl myUserControl1;
        private System.Windows.Forms.Label label1;
    }
}