namespace DevExpress.DataGrid.View
{
    partial class DataGridPopContainerTestForm
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
            this.components = new System.ComponentModel.Container();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.empGridControl = new DevExpress.XtraGrid.GridControl();
            this.empGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deptCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deptRepositoryItemSearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.remarkCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remarkRepositoryItemPopupContainerEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.remarkPopupContainerControl = new DevExpress.XtraEditors.PopupContainerControl();
            this.remarkRepositoryItemColorEdit = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.deptRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.deptRepositoryItemGridLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.empBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.delBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.closeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptRepositoryItemSearchLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkRepositoryItemPopupContainerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkPopupContainerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkRepositoryItemColorEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptRepositoryItemGridLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBarManager)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // empGridControl
            // 
            this.empGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empGridControl.Location = new System.Drawing.Point(0, 24);
            this.empGridControl.MainView = this.empGridView;
            this.empGridControl.Name = "empGridControl";
            this.empGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.remarkRepositoryItemPopupContainerEdit,
            this.remarkRepositoryItemColorEdit,
            this.deptRepositoryItemLookUpEdit,
            this.deptRepositoryItemSearchLookUpEdit,
            this.deptRepositoryItemGridLookUpEdit});
            this.empGridControl.Size = new System.Drawing.Size(532, 344);
            this.empGridControl.TabIndex = 0;
            this.empGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.empGridView});
            // 
            // empGridView
            // 
            this.empGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCol,
            this.nameCol,
            this.deptCol,
            this.remarkCol});
            this.empGridView.GridControl = this.empGridControl;
            this.empGridView.Name = "empGridView";
            this.empGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.empGridView_InitNewRow);
            // 
            // idCol
            // 
            this.idCol.Caption = "ID";
            this.idCol.FieldName = "ID";
            this.idCol.Name = "idCol";
            this.idCol.Visible = true;
            this.idCol.VisibleIndex = 0;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "名称";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            // 
            // deptCol
            // 
            this.deptCol.Caption = "部门";
            this.deptCol.ColumnEdit = this.deptRepositoryItemSearchLookUpEdit;
            this.deptCol.FieldName = "DeptID";
            this.deptCol.Name = "deptCol";
            this.deptCol.Visible = true;
            this.deptCol.VisibleIndex = 2;
            // 
            // deptRepositoryItemSearchLookUpEdit
            // 
            this.deptRepositoryItemSearchLookUpEdit.AutoHeight = false;
            this.deptRepositoryItemSearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deptRepositoryItemSearchLookUpEdit.Name = "deptRepositoryItemSearchLookUpEdit";
            this.deptRepositoryItemSearchLookUpEdit.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // remarkCol
            // 
            this.remarkCol.Caption = "备注";
            this.remarkCol.ColumnEdit = this.remarkRepositoryItemPopupContainerEdit;
            this.remarkCol.FieldName = "Remark";
            this.remarkCol.Name = "remarkCol";
            this.remarkCol.Visible = true;
            this.remarkCol.VisibleIndex = 3;
            // 
            // remarkRepositoryItemPopupContainerEdit
            // 
            this.remarkRepositoryItemPopupContainerEdit.AutoHeight = false;
            this.remarkRepositoryItemPopupContainerEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.remarkRepositoryItemPopupContainerEdit.Name = "remarkRepositoryItemPopupContainerEdit";
            this.remarkRepositoryItemPopupContainerEdit.PopupControl = this.remarkPopupContainerControl;
            this.remarkRepositoryItemPopupContainerEdit.PopupSizeable = false;
            this.remarkRepositoryItemPopupContainerEdit.ShowPopupCloseButton = false;
            this.remarkRepositoryItemPopupContainerEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.remarkRepositoryItemPopupContainerEdit_QueryPopUp);
            // 
            // remarkPopupContainerControl
            // 
            this.remarkPopupContainerControl.Location = new System.Drawing.Point(356, 123);
            this.remarkPopupContainerControl.Name = "remarkPopupContainerControl";
            this.remarkPopupContainerControl.Size = new System.Drawing.Size(200, 100);
            this.remarkPopupContainerControl.TabIndex = 6;
            // 
            // remarkRepositoryItemColorEdit
            // 
            this.remarkRepositoryItemColorEdit.AutoHeight = false;
            this.remarkRepositoryItemColorEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.remarkRepositoryItemColorEdit.Name = "remarkRepositoryItemColorEdit";
            // 
            // deptRepositoryItemLookUpEdit
            // 
            this.deptRepositoryItemLookUpEdit.AutoHeight = false;
            this.deptRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deptRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "部门ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "部门名称")});
            this.deptRepositoryItemLookUpEdit.Name = "deptRepositoryItemLookUpEdit";
            // 
            // deptRepositoryItemGridLookUpEdit
            // 
            this.deptRepositoryItemGridLookUpEdit.AutoHeight = false;
            this.deptRepositoryItemGridLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deptRepositoryItemGridLookUpEdit.Name = "deptRepositoryItemGridLookUpEdit";
            this.deptRepositoryItemGridLookUpEdit.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // empBarManager
            // 
            this.empBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.empBarManager.DockControls.Add(this.barDockControlTop);
            this.empBarManager.DockControls.Add(this.barDockControlBottom);
            this.empBarManager.DockControls.Add(this.barDockControlLeft);
            this.empBarManager.DockControls.Add(this.barDockControlRight);
            this.empBarManager.Form = this;
            this.empBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBarButtonItem,
            this.delBarButtonItem,
            this.closeBarButtonItem});
            this.empBarManager.MainMenu = this.bar2;
            this.empBarManager.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.delBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.closeBarButtonItem)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addBarButtonItem
            // 
            this.addBarButtonItem.Caption = "新增";
            this.addBarButtonItem.Id = 0;
            this.addBarButtonItem.Name = "addBarButtonItem";
            this.addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarButtonItem_ItemClick);
            // 
            // delBarButtonItem
            // 
            this.delBarButtonItem.Caption = "删除";
            this.delBarButtonItem.Id = 1;
            this.delBarButtonItem.Name = "delBarButtonItem";
            this.delBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.delBarButtonItem_ItemClick);
            // 
            // closeBarButtonItem
            // 
            this.closeBarButtonItem.Caption = "关闭";
            this.closeBarButtonItem.Id = 2;
            this.closeBarButtonItem.Name = "closeBarButtonItem";
            this.closeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.closeBarButtonItem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(532, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 368);
            this.barDockControlBottom.Size = new System.Drawing.Size(532, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 344);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(532, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 344);
            // 
            // DataGridPopContainerTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 368);
            this.Controls.Add(this.remarkPopupContainerControl);
            this.Controls.Add(this.empGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DataGridPopContainerTestForm";
            this.Text = "DataGridPopContainerTestForm";
            this.Load += new System.EventHandler(this.DataGridPopContainerTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptRepositoryItemSearchLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkRepositoryItemPopupContainerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkPopupContainerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkRepositoryItemColorEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptRepositoryItemGridLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBarManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl empGridControl;
        private XtraGrid.Views.Grid.GridView empGridView;
        private XtraGrid.Columns.GridColumn idCol;
        private XtraGrid.Columns.GridColumn nameCol;
        private XtraGrid.Columns.GridColumn remarkCol;
        private XtraBars.BarManager empBarManager;
        private XtraBars.Bar bar2;
        private XtraBars.BarButtonItem addBarButtonItem;
        private XtraBars.BarButtonItem delBarButtonItem;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraEditors.PopupContainerControl remarkPopupContainerControl;
        private XtraEditors.Repository.RepositoryItemPopupContainerEdit remarkRepositoryItemPopupContainerEdit;
        private XtraEditors.Repository.RepositoryItemColorEdit remarkRepositoryItemColorEdit;
        private XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private XtraGrid.Columns.GridColumn deptCol;
        private XtraEditors.Repository.RepositoryItemLookUpEdit deptRepositoryItemLookUpEdit;
        private XtraEditors.Repository.RepositoryItemSearchLookUpEdit deptRepositoryItemSearchLookUpEdit;
        private XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private XtraEditors.Repository.RepositoryItemGridLookUpEdit deptRepositoryItemGridLookUpEdit;
        private XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private XtraBars.BarButtonItem closeBarButtonItem;
    }
}