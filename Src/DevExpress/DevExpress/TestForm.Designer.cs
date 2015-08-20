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
            this.testButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.testButtonEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // testButtonEdit
            // 
            this.testButtonEdit.EditValue = "";
            this.testButtonEdit.Location = new System.Drawing.Point(12, 70);
            this.testButtonEdit.Name = "testButtonEdit";
            this.testButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.testButtonEdit.Properties.NullText = "请选择";
            this.testButtonEdit.Properties.NullValuePrompt = "请选择";
            this.testButtonEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.testButtonEdit.Properties.ReadOnly = true;
            this.testButtonEdit.Size = new System.Drawing.Size(254, 21);
            this.testButtonEdit.TabIndex = 0;
            this.testButtonEdit.ToolTip = "提示内容提示内容提示内容提示内容提示内容提示内容提示内容提示内容提示内容提示内容。";
            this.testButtonEdit.ToolTipTitle = "提示标题";
            this.testButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.testButtonEdit_ButtonClick);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 401);
            this.Controls.Add(this.testButtonEdit);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testButtonEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.ButtonEdit testButtonEdit;


    }
}

