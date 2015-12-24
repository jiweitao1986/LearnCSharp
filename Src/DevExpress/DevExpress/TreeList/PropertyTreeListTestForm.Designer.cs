namespace DevExpress.TreeListTest
{
    partial class PropertyTreeListTestForm
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
            this.propertyTreeList = new DevExpress.XtraTreeList.TreeList();
            this.propertyNameCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.propertyTypeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.propertyTreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyTreeList
            // 
            this.propertyTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.propertyNameCol,
            this.propertyTypeCol});
            this.propertyTreeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertyTreeList.Location = new System.Drawing.Point(0, 0);
            this.propertyTreeList.Name = "propertyTreeList";
            this.propertyTreeList.Size = new System.Drawing.Size(733, 461);
            this.propertyTreeList.TabIndex = 0;
            this.propertyTreeList.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.propertyTreeList_BeforeExpand);
            // 
            // propertyNameCol
            // 
            this.propertyNameCol.Caption = "属性名";
            this.propertyNameCol.FieldName = "propertyName";
            this.propertyNameCol.Name = "propertyNameCol";
            this.propertyNameCol.Visible = true;
            this.propertyNameCol.VisibleIndex = 0;
            this.propertyNameCol.Width = 150;
            // 
            // propertyTypeCol
            // 
            this.propertyTypeCol.Caption = "属性类型";
            this.propertyTypeCol.FieldName = "propertyType";
            this.propertyTypeCol.Name = "propertyTypeCol";
            this.propertyTypeCol.Visible = true;
            this.propertyTypeCol.VisibleIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(225, 486);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "确认";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(395, 486);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // PropertyTreeListTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 527);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.propertyTreeList);
            this.Name = "PropertyTreeListTestForm";
            this.Text = "PropertyTreeListTestForm";
            this.Load += new System.EventHandler(this.PropertyTreeListTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyTreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraTreeList.TreeList propertyTreeList;
        private XtraTreeList.Columns.TreeListColumn propertyNameCol;
        private XtraTreeList.Columns.TreeListColumn propertyTypeCol;
        private XtraEditors.SimpleButton okBtn;
        private XtraEditors.SimpleButton cancelBtn;
    }
}