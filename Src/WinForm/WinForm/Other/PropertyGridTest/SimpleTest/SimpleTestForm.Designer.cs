namespace LearningCSharp.WinForm.Other.PropertyGridTest.SimpleTest
{
    partial class SimpleTestForm
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
            this.rightPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPropertyGrid
            // 
            this.rightPropertyGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rightPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.rightPropertyGrid.Name = "rightPropertyGrid";
            this.rightPropertyGrid.Size = new System.Drawing.Size(200, 529);
            this.rightPropertyGrid.TabIndex = 0;
            this.rightPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.rightPropertyGrid_PropertyValueChanged);
            this.rightPropertyGrid.SelectedObjectsChanged += new System.EventHandler(this.rightPropertyGrid_SelectedObjectsChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rightPropertyGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(488, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 529);
            this.panel1.TabIndex = 1;
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(488, 529);
            this.resultRichTextBox.TabIndex = 2;
            this.resultRichTextBox.Text = "";
            // 
            // SimpleTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 529);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "SimpleTestForm";
            this.Text = "SimpleTestForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid rightPropertyGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
    }
}