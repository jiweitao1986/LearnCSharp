namespace DevExpress.DataGrid
{
    partial class DataGridCardTestForm
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
            this.empCardView = new DevExpress.XtraGrid.Views.Card.CardView();
            this.idColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCardView)).BeginInit();
            this.SuspendLayout();
            // 
            // empGrid
            // 
            this.empGrid.Location = new System.Drawing.Point(45, 78);
            this.empGrid.MainView = this.empCardView;
            this.empGrid.Name = "empGrid";
            this.empGrid.Size = new System.Drawing.Size(602, 383);
            this.empGrid.TabIndex = 0;
            this.empGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.empCardView});
            // 
            // empCardView
            // 
            this.empCardView.CardCaptionFormat = "卡片标题：{1}";
            this.empCardView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idColumn,
            this.nameColumn});
            this.empCardView.FocusedCardTopFieldIndex = 0;
            this.empCardView.GridControl = this.empGrid;
            this.empCardView.Name = "empCardView";
            this.empCardView.CustomDrawCardFieldValue += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.empCardView_CustomDrawCardFieldValue);
            // 
            // idColumn
            // 
            this.idColumn.Caption = "ID";
            this.idColumn.FieldName = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = true;
            this.idColumn.VisibleIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "姓名";
            this.nameColumn.FieldName = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 1;
            // 
            // DataGridCardTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 486);
            this.Controls.Add(this.empGrid);
            this.Name = "DataGridCardTestForm";
            this.Text = "DataGridCardTest";
            this.Load += new System.EventHandler(this.DataGridCardTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCardView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl empGrid;
        private XtraGrid.Views.Card.CardView empCardView;
        private XtraGrid.Columns.GridColumn idColumn;
        private XtraGrid.Columns.GridColumn nameColumn;
    }
}