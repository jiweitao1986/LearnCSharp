namespace DevExpress.TreeListTest
{
    partial class TreeListTestForm
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
            this.EmpTreeList = new DevExpress.XtraTreeList.TreeList();
            this.NameCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpTreeList
            // 
            this.EmpTreeList.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.EmpTreeList.Appearance.FocusedCell.Options.UseFont = true;
            this.EmpTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.NameCol});
            this.EmpTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpTreeList.Location = new System.Drawing.Point(0, 0);
            this.EmpTreeList.Name = "EmpTreeList";
            this.EmpTreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.EmpTreeList.OptionsView.ShowCheckBoxes = true;
            this.EmpTreeList.ParentFieldName = "MgrID";
            this.EmpTreeList.Size = new System.Drawing.Size(534, 440);
            this.EmpTreeList.TabIndex = 0;
            this.EmpTreeList.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.EmpTreeList_AfterCheckNode);
            // 
            // NameCol
            // 
            this.NameCol.Caption = "姓名";
            this.NameCol.FieldName = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.NameCol.Visible = true;
            this.NameCol.VisibleIndex = 1;
            this.NameCol.Width = 177;
            // 
            // TreeListTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(534, 440);
            this.Controls.Add(this.EmpTreeList);
            this.Name = "TreeListTestForm";
            this.Text = "TreeListTest";
            this.Load += new System.EventHandler(this.TreeListTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpTreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraTreeList.TreeList EmpTreeList;
        private XtraTreeList.Columns.TreeListColumn NameCol;
    }
}