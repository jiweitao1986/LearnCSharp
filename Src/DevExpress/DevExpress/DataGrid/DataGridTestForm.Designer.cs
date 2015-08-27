namespace DevExpress.DataGrid
{
    partial class DataGridTestForm
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
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.empGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.empGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.idColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.empGrid;
            this.cardView1.Name = "cardView1";
            // 
            // empGrid
            // 
            this.empGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empGrid.Location = new System.Drawing.Point(0, 0);
            this.empGrid.MainView = this.empGridView;
            this.empGrid.Name = "empGrid";
            this.empGrid.Size = new System.Drawing.Size(719, 446);
            this.empGrid.TabIndex = 0;
            this.empGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.advBandedGridView1,
            this.layoutView1,
            this.empGridView,
            this.bandedGridView1,
            this.cardView1});
            this.empGrid.Load += new System.EventHandler(this.empGrid_Load);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.empGrid;
            this.gridView2.Name = "gridView2";
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2});
            this.advBandedGridView1.GridControl = this.empGrid;
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand1";
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.empGrid;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = null;
            // 
            // empGridView
            // 
            this.empGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.empGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.empGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.empGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.empGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.empGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idColumn,
            this.nameColumn});
            this.empGridView.GridControl = this.empGrid;
            this.empGridView.Name = "empGridView";
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.GridControl = this.empGrid;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            // 
            // idColumn
            // 
            this.idColumn.Caption = "ID";
            this.idColumn.FieldName = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.OptionsColumn.AllowEdit = false;
            this.idColumn.Visible = true;
            this.idColumn.VisibleIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "姓名";
            this.nameColumn.FieldName = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.OptionsColumn.AllowEdit = false;
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 1;
            // 
            // DataGridTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 446);
            this.Controls.Add(this.empGrid);
            this.Name = "DataGridTestForm";
            this.Text = "DataGridTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl empGrid;
        private XtraGrid.Views.Card.CardView cardView1;
        private XtraGrid.Views.Grid.GridView gridView2;
        private XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private XtraGrid.Views.Layout.LayoutView layoutView1;
        private XtraGrid.Views.Grid.GridView empGridView;
        private XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private XtraGrid.Columns.GridColumn idColumn;
        private XtraGrid.Columns.GridColumn nameColumn;
    }
}