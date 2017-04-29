namespace LearningCSharp.WinForm.Other.ICSharpCodeTextEditor
{
    partial class SimpleTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleTest));
            this.simpleTextEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.simpleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // simpleTextEditor
            // 
            this.simpleTextEditor.AllowDrop = true;
            this.simpleTextEditor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.simpleTextEditor.IsReadOnly = false;
            this.simpleTextEditor.Location = new System.Drawing.Point(80, 88);
            this.simpleTextEditor.Name = "simpleTextEditor";
            this.simpleTextEditor.Size = new System.Drawing.Size(348, 145);
            this.simpleTextEditor.TabIndex = 0;
            this.simpleTextEditor.Text = "1234567890-1234567890-1234567890-1234567890-1234567890-1234567890-1234567890-1234" +
    "567890-1234567890-1234567890";
            // 
            // simpleRichTextBox
            // 
            this.simpleRichTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.simpleRichTextBox.Location = new System.Drawing.Point(92, 249);
            this.simpleRichTextBox.Name = "simpleRichTextBox";
            this.simpleRichTextBox.Size = new System.Drawing.Size(293, 96);
            this.simpleRichTextBox.TabIndex = 1;
            this.simpleRichTextBox.Text = resources.GetString("simpleRichTextBox.Text");
            // 
            // SimpleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 549);
            this.Controls.Add(this.simpleRichTextBox);
            this.Controls.Add(this.simpleTextEditor);
            this.Name = "SimpleTest";
            this.Text = "SimpleTest";
            this.Load += new System.EventHandler(this.SimpleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl simpleTextEditor;
        private System.Windows.Forms.RichTextBox simpleRichTextBox;
    }
}