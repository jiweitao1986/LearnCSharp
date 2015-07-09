namespace DevExpress.ColorEdit
{
    partial class RepositoryItemColorEditTestForm
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
            this.goodGridControl = new DevExpress.XtraGrid.GridControl();
            this.goodGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorRepositoryItemColorEdit = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.fontRepositoryItemFontEdit = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            ((System.ComponentModel.ISupportInitialize)(this.goodGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRepositoryItemColorEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontRepositoryItemFontEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // goodGridControl
            // 
            this.goodGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodGridControl.Location = new System.Drawing.Point(0, 0);
            this.goodGridControl.MainView = this.goodGridView;
            this.goodGridControl.Name = "goodGridControl";
            this.goodGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colorRepositoryItemColorEdit,
            this.fontRepositoryItemFontEdit});
            this.goodGridControl.Size = new System.Drawing.Size(507, 391);
            this.goodGridControl.TabIndex = 0;
            this.goodGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.goodGridView});
            // 
            // goodGridView
            // 
            this.goodGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCol,
            this.nameCol,
            this.colorCol});
            this.goodGridView.GridControl = this.goodGridControl;
            this.goodGridView.Name = "goodGridView";
            this.goodGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.goodGridView_RowClick);
            this.goodGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.goodGridView_RowCellClick);
            this.goodGridView.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.goodGridView_CustomRowCellEdit);
            this.goodGridView.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.goodGridView_CustomRowCellEditForEditing);
            this.goodGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.goodGridView_ShowingEditor);
            // 
            // idCol
            // 
            this.idCol.Caption = "商品ID";
            this.idCol.FieldName = "ID";
            this.idCol.Name = "idCol";
            this.idCol.Visible = true;
            this.idCol.VisibleIndex = 0;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "商品名称";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            // 
            // colorCol
            // 
            this.colorCol.Caption = "商品颜色";
            this.colorCol.FieldName = "Color";
            this.colorCol.Name = "colorCol";
            this.colorCol.Visible = true;
            this.colorCol.VisibleIndex = 2;
            // 
            // colorRepositoryItemColorEdit
            // 
            this.colorRepositoryItemColorEdit.AutoHeight = false;
            this.colorRepositoryItemColorEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorRepositoryItemColorEdit.Name = "colorRepositoryItemColorEdit";
            // 
            // fontRepositoryItemFontEdit
            // 
            this.fontRepositoryItemFontEdit.AutoHeight = false;
            this.fontRepositoryItemFontEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fontRepositoryItemFontEdit.Name = "fontRepositoryItemFontEdit";
            // 
            // RepositoryItemColorEditTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 391);
            this.Controls.Add(this.goodGridControl);
            this.Name = "RepositoryItemColorEditTestForm";
            this.Text = "RepositoryItemColorEdit";
            ((System.ComponentModel.ISupportInitialize)(this.goodGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRepositoryItemColorEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontRepositoryItemFontEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl goodGridControl;
        private XtraGrid.Views.Grid.GridView goodGridView;
        private XtraGrid.Columns.GridColumn idCol;
        private XtraGrid.Columns.GridColumn nameCol;
        private XtraGrid.Columns.GridColumn colorCol;
        private XtraEditors.Repository.RepositoryItemColorEdit colorRepositoryItemColorEdit;
        private XtraEditors.Repository.RepositoryItemFontEdit fontRepositoryItemFontEdit;
    }
}