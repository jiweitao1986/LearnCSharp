namespace LearningCSharp.CustomControl.Controls.MyUserControl
{
    partial class MyUserControl
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lastNameEdit = new System.Windows.Forms.TextBox();
            this.firstNameEdit = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameEdit
            // 
            this.lastNameEdit.Location = new System.Drawing.Point(42, 14);
            this.lastNameEdit.Name = "lastNameEdit";
            this.lastNameEdit.Size = new System.Drawing.Size(186, 21);
            this.lastNameEdit.TabIndex = 0;
            // 
            // firstNameEdit
            // 
            this.firstNameEdit.Location = new System.Drawing.Point(42, 57);
            this.firstNameEdit.Name = "firstNameEdit";
            this.firstNameEdit.Size = new System.Drawing.Size(186, 21);
            this.firstNameEdit.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(19, 17);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(17, 12);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "姓";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(19, 60);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(17, 12);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "名";
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameEdit);
            this.Controls.Add(this.lastNameEdit);
            this.Name = "MyUserControl";
            this.Size = new System.Drawing.Size(250, 106);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameEdit;
        private System.Windows.Forms.TextBox firstNameEdit;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
    }
}
