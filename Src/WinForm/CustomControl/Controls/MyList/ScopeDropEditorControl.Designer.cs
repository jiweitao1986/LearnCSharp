namespace LearningCSharp.CustomControl.Controls.MyList
{
    partial class ScopeDropEditorControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.minLabel = new System.Windows.Forms.Label();
            this.minEdit = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(18, 27);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(23, 12);
            this.minLabel.TabIndex = 0;
            this.minLabel.Text = "Min";
            // 
            // minEdit
            // 
            this.minEdit.Location = new System.Drawing.Point(54, 24);
            this.minEdit.Name = "minEdit";
            this.minEdit.Size = new System.Drawing.Size(163, 21);
            this.minEdit.TabIndex = 1;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(18, 61);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(23, 12);
            this.maxLabel.TabIndex = 2;
            this.maxLabel.Text = "Max";
            // 
            // maxEdit
            // 
            this.maxEdit.Location = new System.Drawing.Point(54, 58);
            this.maxEdit.Name = "maxEdit";
            this.maxEdit.Size = new System.Drawing.Size(163, 21);
            this.maxEdit.TabIndex = 3;
            // 
            // ScopeDropEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxEdit);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minEdit);
            this.Controls.Add(this.minLabel);
            this.Name = "ScopeDropEditorControl";
            this.Size = new System.Drawing.Size(241, 98);
            this.Load += new System.EventHandler(this.ScopeDropEditorControl_Load);
            this.Leave += new System.EventHandler(this.ScopeDropEditorControl_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minEdit;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxEdit;
    }
}
