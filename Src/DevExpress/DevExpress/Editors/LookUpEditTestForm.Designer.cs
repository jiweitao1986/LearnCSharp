namespace DevExpress.Editors
{
    partial class LookUpEditTestForm
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
            this.simpleLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleLookUpEdit
            // 
            this.simpleLookUpEdit.Location = new System.Drawing.Point(32, 24);
            this.simpleLookUpEdit.Name = "simpleLookUpEdit";
            this.simpleLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.simpleLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "部门ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "部门名称")});
            this.simpleLookUpEdit.Size = new System.Drawing.Size(260, 21);
            this.simpleLookUpEdit.TabIndex = 0;
            // 
            // LookUpEditTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.simpleLookUpEdit);
            this.Name = "LookUpEditTestForm";
            this.Text = "LookUpEditTestForm";
            this.Load += new System.EventHandler(this.LookUpEditTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simpleLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.LookUpEdit simpleLookUpEdit;
    }
}