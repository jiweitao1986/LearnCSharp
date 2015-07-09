namespace DevExpress.ColorEdit
{
    partial class ColorEditTestForm
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
            this.colorColorEdit = new DevExpress.XtraEditors.ColorEdit();
            this.fontEdit1 = new DevExpress.XtraEditors.FontEdit();
            ((System.ComponentModel.ISupportInitialize)(this.colorColorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colorColorEdit
            // 
            this.colorColorEdit.EditValue = System.Drawing.Color.Empty;
            this.colorColorEdit.Location = new System.Drawing.Point(12, 25);
            this.colorColorEdit.Name = "colorColorEdit";
            this.colorColorEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.colorColorEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.colorColorEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorColorEdit.Properties.ColorText = DevExpress.XtraEditors.Controls.ColorText.Integer;
            this.colorColorEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.colorColorEdit.Size = new System.Drawing.Size(100, 21);
            this.colorColorEdit.TabIndex = 0;
            // 
            // fontEdit1
            // 
            this.fontEdit1.Location = new System.Drawing.Point(12, 74);
            this.fontEdit1.Name = "fontEdit1";
            this.fontEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fontEdit1.Size = new System.Drawing.Size(100, 21);
            this.fontEdit1.TabIndex = 1;
            // 
            // ColorEditTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.fontEdit1);
            this.Controls.Add(this.colorColorEdit);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "ColorEditTestForm";
            this.Text = "ColorEdit";
            this.Load += new System.EventHandler(this.ColorEditTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorColorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.ColorEdit colorColorEdit;
        private XtraEditors.FontEdit fontEdit1;
    }
}