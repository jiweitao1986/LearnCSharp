namespace LearningCSharp.WinForm.Test
{
    partial class Test
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
            this.firstControl1 = new CustomControl.Control.FirstControl();
            this.SuspendLayout();
            // 
            // firstControl1
            // 
            this.firstControl1.Location = new System.Drawing.Point(85, 100);
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.Size = new System.Drawing.Size(75, 23);
            this.firstControl1.TabIndex = 0;
            this.firstControl1.Text = "firstControl1";
            this.firstControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(800, 800);
            this.ClientSize = new System.Drawing.Size(524, 471);
            this.Controls.Add(this.firstControl1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.Click += new System.EventHandler(this.Test_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Test_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.Control.FirstControl firstControl1;










    }
}