namespace DevExpress.TreeListTest
{
    partial class RecursiveTreeListTestForm
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
            this.topBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.topBar = new DevExpress.XtraBars.Bar();
            this.AddBtn = new DevExpress.XtraBars.BarButtonItem();
            this.AddChildBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ExpandBtn = new DevExpress.XtraBars.BarButtonItem();
            this.CollapseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.CloseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.CateTreeList = new DevExpress.XtraTreeList.TreeList();
            this.NameCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IDCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.DescCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.catePanel = new DevExpress.XtraEditors.PanelControl();
            this.FIDCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.topBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CateTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catePanel)).BeginInit();
            this.catePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBarManager
            // 
            this.topBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.topBar});
            this.topBarManager.DockControls.Add(this.barDockControlTop);
            this.topBarManager.DockControls.Add(this.barDockControlBottom);
            this.topBarManager.DockControls.Add(this.barDockControlLeft);
            this.topBarManager.DockControls.Add(this.barDockControlRight);
            this.topBarManager.Form = this;
            this.topBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.AddBtn,
            this.AddChildBtn,
            this.DelBtn,
            this.ExpandBtn,
            this.CollapseBtn,
            this.SaveBtn,
            this.CloseBtn});
            this.topBarManager.MainMenu = this.topBar;
            this.topBarManager.MaxItemId = 7;
            // 
            // topBar
            // 
            this.topBar.BarName = "Main menu";
            this.topBar.DockCol = 0;
            this.topBar.DockRow = 0;
            this.topBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.topBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.AddBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.AddChildBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.DelBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.ExpandBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.CollapseBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.SaveBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.CloseBtn)});
            this.topBar.OptionsBar.MultiLine = true;
            this.topBar.OptionsBar.UseWholeRow = true;
            this.topBar.Text = "Main menu";
            // 
            // AddBtn
            // 
            this.AddBtn.Caption = "添加节点";
            this.AddBtn.Id = 0;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddBtn_ItemClick);
            // 
            // AddChildBtn
            // 
            this.AddChildBtn.Caption = "添加子节点";
            this.AddChildBtn.Id = 1;
            this.AddChildBtn.Name = "AddChildBtn";
            this.AddChildBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddChildBtn_ItemClick);
            // 
            // DelBtn
            // 
            this.DelBtn.Caption = "删除节点";
            this.DelBtn.Id = 2;
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DelBtn_ItemClick);
            // 
            // ExpandBtn
            // 
            this.ExpandBtn.Caption = "全部展开";
            this.ExpandBtn.Id = 3;
            this.ExpandBtn.Name = "ExpandBtn";
            this.ExpandBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExpandBtn_ItemClick);
            // 
            // CollapseBtn
            // 
            this.CollapseBtn.Caption = "全部折叠";
            this.CollapseBtn.Id = 4;
            this.CollapseBtn.Name = "CollapseBtn";
            this.CollapseBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CollapseBtn_ItemClick);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Caption = "保存";
            this.SaveBtn.Id = 5;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBtn_ItemClick);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Caption = "关闭";
            this.CloseBtn.Id = 6;
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(884, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 442);
            this.barDockControlBottom.Size = new System.Drawing.Size(884, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 415);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(884, 27);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 415);
            // 
            // CateTreeList
            // 
            this.CateTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.NameCol,
            this.IDCol,
            this.FIDCol,
            this.DescCol});
            this.CateTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CateTreeList.Location = new System.Drawing.Point(0, 3);
            this.CateTreeList.Name = "CateTreeList";
            this.CateTreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.CateTreeList.OptionsSelection.MultiSelect = true;
            this.CateTreeList.OptionsView.ShowCheckBoxes = true;
            this.CateTreeList.Size = new System.Drawing.Size(884, 412);
            this.CateTreeList.TabIndex = 4;
            this.CateTreeList.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.CateTreeList_BeforeCheckNode);
            this.CateTreeList.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.CateTreeList_AfterCheckNode);
            // 
            // NameCol
            // 
            this.NameCol.Caption = "分类名称";
            this.NameCol.FieldName = "Name";
            this.NameCol.MinWidth = 32;
            this.NameCol.Name = "NameCol";
            this.NameCol.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.NameCol.Visible = true;
            this.NameCol.VisibleIndex = 0;
            this.NameCol.Width = 300;
            // 
            // IDCol
            // 
            this.IDCol.Caption = "分类ID";
            this.IDCol.FieldName = "ID";
            this.IDCol.MinWidth = 32;
            this.IDCol.Name = "IDCol";
            this.IDCol.Visible = true;
            this.IDCol.VisibleIndex = 1;
            this.IDCol.Width = 150;
            // 
            // DescCol
            // 
            this.DescCol.Caption = "分类描述";
            this.DescCol.FieldName = "Desc";
            this.DescCol.MinWidth = 32;
            this.DescCol.Name = "DescCol";
            this.DescCol.Visible = true;
            this.DescCol.VisibleIndex = 3;
            this.DescCol.Width = 300;
            // 
            // catePanel
            // 
            this.catePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.catePanel.Controls.Add(this.CateTreeList);
            this.catePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catePanel.Location = new System.Drawing.Point(0, 27);
            this.catePanel.Name = "catePanel";
            this.catePanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.catePanel.Size = new System.Drawing.Size(884, 415);
            this.catePanel.TabIndex = 9;
            // 
            // FIDCol
            // 
            this.FIDCol.Caption = "分类父ID";
            this.FIDCol.FieldName = "FID";
            this.FIDCol.Name = "FIDCol";
            this.FIDCol.Visible = true;
            this.FIDCol.VisibleIndex = 2;
            this.FIDCol.Width = 150;
            // 
            // RecursiveTreeListTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 442);
            this.Controls.Add(this.catePanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RecursiveTreeListTestForm";
            this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Text = "递归树测试表单";
            this.Load += new System.EventHandler(this.RecursiveTreeListTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CateTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catePanel)).EndInit();
            this.catePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.BarManager topBarManager;
        private XtraBars.Bar topBar;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarButtonItem AddBtn;
        private XtraBars.BarButtonItem AddChildBtn;
        private XtraBars.BarButtonItem DelBtn;
        private XtraBars.BarButtonItem ExpandBtn;
        private XtraBars.BarButtonItem CollapseBtn;
        private XtraBars.BarButtonItem SaveBtn;
        private XtraBars.BarButtonItem CloseBtn;
        private XtraTreeList.TreeList CateTreeList;
        private XtraTreeList.Columns.TreeListColumn NameCol;
        private XtraTreeList.Columns.TreeListColumn DescCol;
        private XtraEditors.PanelControl catePanel;
        private XtraTreeList.Columns.TreeListColumn IDCol;
        private XtraTreeList.Columns.TreeListColumn FIDCol;
    }
}