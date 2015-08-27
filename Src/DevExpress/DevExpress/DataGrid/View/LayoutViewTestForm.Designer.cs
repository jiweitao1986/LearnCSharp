namespace DevExpress.DataGrid.View
{
    partial class LayoutViewTestForm
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
            this.empGrid = new DevExpress.XtraGrid.GridControl();
            this.empLayoutView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.idColumn = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.nameColumn = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.empLayoutViewCard = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empLayoutView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empLayoutViewCard)).BeginInit();
            this.SuspendLayout();
            // 
            // empGrid
            // 
            this.empGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empGrid.Location = new System.Drawing.Point(0, 0);
            this.empGrid.MainView = this.empLayoutView;
            this.empGrid.Name = "empGrid";
            this.empGrid.Size = new System.Drawing.Size(655, 416);
            this.empGrid.TabIndex = 0;
            this.empGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.empLayoutView});
            // 
            // empLayoutView
            // 
            this.empLayoutView.CardHorzInterval = 1;
            this.empLayoutView.CardVertInterval = 1;
            this.empLayoutView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.idColumn,
            this.nameColumn});
            this.empLayoutView.GridControl = this.empGrid;
            this.empLayoutView.Name = "empLayoutView";
            this.empLayoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row;
            this.empLayoutView.TemplateCard = this.empLayoutViewCard;
            // 
            // idColumn
            // 
            this.idColumn.Caption = "ID";
            this.idColumn.FieldName = "ID";
            this.idColumn.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.idColumn.Name = "idColumn";
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 50, 50, 50);
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(129, 20);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(35, 14);
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "Name";
            this.nameColumn.FieldName = "Name";
            this.nameColumn.LayoutViewField = this.layoutViewField_layoutViewColumn1_1;
            this.nameColumn.Name = "nameColumn";
            // 
            // layoutViewField_layoutViewColumn1_1
            // 
            this.layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            this.layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size(129, 20);
            this.layoutViewField_layoutViewColumn1_1.TextSize = new System.Drawing.Size(35, 14);
            // 
            // empLayoutViewCard
            // 
            this.empLayoutViewCard.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.empLayoutViewCard.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn1_1});
            this.empLayoutViewCard.Name = "layoutViewCard1";
            // 
            // LayoutViewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 416);
            this.Controls.Add(this.empGrid);
            this.Name = "LayoutViewTestForm";
            this.Text = "LayoutViewTestForm";
            this.Load += new System.EventHandler(this.LayoutViewTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empLayoutView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empLayoutViewCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl empGrid;
        private XtraGrid.Views.Layout.LayoutView empLayoutView;
        private XtraGrid.Views.Layout.LayoutViewCard empLayoutViewCard;
        private XtraGrid.Columns.LayoutViewColumn idColumn;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private XtraGrid.Columns.LayoutViewColumn nameColumn;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
    }
}