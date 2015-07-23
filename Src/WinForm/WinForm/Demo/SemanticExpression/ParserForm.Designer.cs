namespace LearningCSharp.WinForm.Demo.SemanticExpression
{
    partial class ParserForm
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
            this.semanticEdit = new System.Windows.Forms.RichTextBox();
            this.semanticLabel = new System.Windows.Forms.Label();
            this.webLabel = new System.Windows.Forms.Label();
            this.webEdit = new System.Windows.Forms.RichTextBox();
            this.jsEdit = new System.Windows.Forms.RichTextBox();
            this.jsLabel = new System.Windows.Forms.Label();
            this.parseSemanticBtn = new System.Windows.Forms.Button();
            this.parseWebBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // semanticEdit
            // 
            this.semanticEdit.Location = new System.Drawing.Point(12, 40);
            this.semanticEdit.Name = "semanticEdit";
            this.semanticEdit.Size = new System.Drawing.Size(600, 150);
            this.semanticEdit.TabIndex = 0;
            this.semanticEdit.Text = "";
            // 
            // semanticLabel
            // 
            this.semanticLabel.AutoSize = true;
            this.semanticLabel.Location = new System.Drawing.Point(10, 14);
            this.semanticLabel.Name = "semanticLabel";
            this.semanticLabel.Size = new System.Drawing.Size(77, 12);
            this.semanticLabel.TabIndex = 1;
            this.semanticLabel.Text = "语义化表达式";
            // 
            // webLabel
            // 
            this.webLabel.AutoSize = true;
            this.webLabel.Location = new System.Drawing.Point(10, 206);
            this.webLabel.Name = "webLabel";
            this.webLabel.Size = new System.Drawing.Size(59, 12);
            this.webLabel.TabIndex = 2;
            this.webLabel.Text = "Web表达式";
            // 
            // webEdit
            // 
            this.webEdit.Location = new System.Drawing.Point(12, 233);
            this.webEdit.Name = "webEdit";
            this.webEdit.Size = new System.Drawing.Size(600, 150);
            this.webEdit.TabIndex = 3;
            this.webEdit.Text = "";
            // 
            // jsEdit
            // 
            this.jsEdit.Location = new System.Drawing.Point(12, 432);
            this.jsEdit.Name = "jsEdit";
            this.jsEdit.Size = new System.Drawing.Size(600, 150);
            this.jsEdit.TabIndex = 4;
            this.jsEdit.Text = "";
            // 
            // jsLabel
            // 
            this.jsLabel.AutoSize = true;
            this.jsLabel.Location = new System.Drawing.Point(10, 402);
            this.jsLabel.Name = "jsLabel";
            this.jsLabel.Size = new System.Drawing.Size(89, 12);
            this.jsLabel.TabIndex = 5;
            this.jsLabel.Text = "JavaScript代码";
            // 
            // parseSemanticBtn
            // 
            this.parseSemanticBtn.Location = new System.Drawing.Point(108, 599);
            this.parseSemanticBtn.Name = "parseSemanticBtn";
            this.parseSemanticBtn.Size = new System.Drawing.Size(180, 40);
            this.parseSemanticBtn.TabIndex = 6;
            this.parseSemanticBtn.Text = "解析Semantic表达式";
            this.parseSemanticBtn.UseVisualStyleBackColor = true;
            this.parseSemanticBtn.Click += new System.EventHandler(this.parseSemanticBtn_Click);
            // 
            // parseWebBtn
            // 
            this.parseWebBtn.Location = new System.Drawing.Point(317, 599);
            this.parseWebBtn.Name = "parseWebBtn";
            this.parseWebBtn.Size = new System.Drawing.Size(180, 40);
            this.parseWebBtn.TabIndex = 7;
            this.parseWebBtn.Text = "解析Web表达式";
            this.parseWebBtn.UseVisualStyleBackColor = true;
            this.parseWebBtn.Click += new System.EventHandler(this.parseWebBtn_Click);
            // 
            // ParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 651);
            this.Controls.Add(this.parseWebBtn);
            this.Controls.Add(this.parseSemanticBtn);
            this.Controls.Add(this.jsLabel);
            this.Controls.Add(this.jsEdit);
            this.Controls.Add(this.webEdit);
            this.Controls.Add(this.webLabel);
            this.Controls.Add(this.semanticLabel);
            this.Controls.Add(this.semanticEdit);
            this.Name = "ParserForm";
            this.Text = "Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox semanticEdit;
        private System.Windows.Forms.Label semanticLabel;
        private System.Windows.Forms.Label webLabel;
        private System.Windows.Forms.RichTextBox webEdit;
        private System.Windows.Forms.RichTextBox jsEdit;
        private System.Windows.Forms.Label jsLabel;
        private System.Windows.Forms.Button parseSemanticBtn;
        private System.Windows.Forms.Button parseWebBtn;
    }
}