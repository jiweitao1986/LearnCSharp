namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest
{
    partial class PropertyBagTestForm
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
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.propertyGridPanel = new System.Windows.Forms.Panel();
            this.logPanel = new System.Windows.Forms.Panel();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.propertyGridPanel.SuspendLayout();
            this.logPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(200, 421);
            this.propertyGrid.TabIndex = 0;
            // 
            // propertyGridPanel
            // 
            this.propertyGridPanel.Controls.Add(this.propertyGrid);
            this.propertyGridPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGridPanel.Location = new System.Drawing.Point(500, 0);
            this.propertyGridPanel.Name = "propertyGridPanel";
            this.propertyGridPanel.Size = new System.Drawing.Size(200, 421);
            this.propertyGridPanel.TabIndex = 1;
            // 
            // logPanel
            // 
            this.logPanel.Controls.Add(this.logRichTextBox);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPanel.Location = new System.Drawing.Point(0, 0);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(500, 421);
            this.logPanel.TabIndex = 2;
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(500, 421);
            this.logRichTextBox.TabIndex = 0;
            this.logRichTextBox.Text = "";
            // 
            // PropertyBagTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 421);
            this.Controls.Add(this.logPanel);
            this.Controls.Add(this.propertyGridPanel);
            this.Name = "PropertyBagTestForm";
            this.Text = "PropertyBagTestForm";
            this.propertyGridPanel.ResumeLayout(false);
            this.logPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Panel propertyGridPanel;
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.RichTextBox logRichTextBox;
    }
}