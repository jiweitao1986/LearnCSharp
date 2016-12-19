namespace DevExpress
{
    partial class TestForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picEdit = new DevExpress.XtraEditors.PictureEdit();
            this.picStringEdit = new DevExpress.XtraEditors.MemoEdit();
            this.showPicEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStringEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picEdit
            // 
            this.picEdit.Location = new System.Drawing.Point(12, 26);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(211, 287);
            this.picEdit.TabIndex = 0;
            this.picEdit.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.coverEdit_MouseDoubleClick);
            // 
            // picStringEdit
            // 
            this.picStringEdit.Location = new System.Drawing.Point(241, 26);
            this.picStringEdit.Name = "picStringEdit";
            this.picStringEdit.Size = new System.Drawing.Size(531, 523);
            this.picStringEdit.TabIndex = 1;
            // 
            // showPicEdit
            // 
            this.showPicEdit.Location = new System.Drawing.Point(12, 332);
            this.showPicEdit.Name = "showPicEdit";
            this.showPicEdit.Size = new System.Drawing.Size(75, 23);
            this.showPicEdit.TabIndex = 2;
            this.showPicEdit.Text = "显示图片";
            this.showPicEdit.Click += new System.EventHandler(this.showPicEdit_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.showPicEdit);
            this.Controls.Add(this.picStringEdit);
            this.Controls.Add(this.picEdit);
            this.Name = "TestForm";
            this.Text = "测试窗体";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStringEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private XtraEditors.PictureEdit picEdit;
        private XtraEditors.MemoEdit picStringEdit;
        private XtraEditors.SimpleButton showPicEdit;
    }
}

