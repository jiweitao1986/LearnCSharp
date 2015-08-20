namespace DevExpress.Editors
{
    partial class ScrollableTestForm
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
            this.testRadio = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.testRadio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // testRadio
            // 
            this.testRadio.Location = new System.Drawing.Point(36, 23);
            this.testRadio.Name = "testRadio";
            this.testRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "2"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(3)), "3"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(4)), "4"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "5"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "6"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "7"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "8"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "9"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "10")});
            this.testRadio.Size = new System.Drawing.Size(159, 172);
            this.testRadio.TabIndex = 0;
            // 
            // ScrollableTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(255, 232);
            this.Controls.Add(this.testRadio);
            this.Name = "ScrollableTestForm";
            this.Text = "ScrollableTestForm";
            this.Load += new System.EventHandler(this.ScrollableTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testRadio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.RadioGroup testRadio;
    }
}