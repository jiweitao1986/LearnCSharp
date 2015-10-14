namespace LearningCSharp.WinForm.Demo.DesignTime
{
    partial class DesignTimeTestForm
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
            this.designerToobarPanel = new System.Windows.Forms.Panel();
            this.delBtn = new System.Windows.Forms.Button();
            this.addLabelBtn = new System.Windows.Forms.Button();
            this.designTimeTab = new System.Windows.Forms.TabControl();
            this.designTimePage = new System.Windows.Forms.TabPage();
            this.designTimeXmlPage = new System.Windows.Forms.TabPage();
            this.xmlEdit = new System.Windows.Forms.RichTextBox();
            this.designTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addRichTextBox = new System.Windows.Forms.Button();
            this.addTextBoxBtn = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.designTimeTab.SuspendLayout();
            this.designTimeXmlPage.SuspendLayout();
            this.designTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // designerToobarPanel
            // 
            this.designerToobarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.designerToobarPanel.Location = new System.Drawing.Point(0, 0);
            this.designerToobarPanel.Name = "designerToobarPanel";
            this.designerToobarPanel.Size = new System.Drawing.Size(964, 10);
            this.designerToobarPanel.TabIndex = 0;
            // 
            // delBtn
            // 
            this.delBtn.ForeColor = System.Drawing.Color.Red;
            this.delBtn.Location = new System.Drawing.Point(28, 497);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(120, 40);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // addLabelBtn
            // 
            this.addLabelBtn.Location = new System.Drawing.Point(28, 27);
            this.addLabelBtn.Name = "addLabelBtn";
            this.addLabelBtn.Size = new System.Drawing.Size(120, 40);
            this.addLabelBtn.TabIndex = 0;
            this.addLabelBtn.Text = "Label";
            this.addLabelBtn.UseVisualStyleBackColor = true;
            this.addLabelBtn.Click += new System.EventHandler(this.addLabelBtn_Click);
            // 
            // designTimeTab
            // 
            this.designTimeTab.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.designTimeTab.Controls.Add(this.designTimePage);
            this.designTimeTab.Controls.Add(this.designTimeXmlPage);
            this.designTimeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designTimeTab.Location = new System.Drawing.Point(195, 3);
            this.designTimeTab.Name = "designTimeTab";
            this.designTimeTab.SelectedIndex = 0;
            this.designTimeTab.Size = new System.Drawing.Size(572, 546);
            this.designTimeTab.TabIndex = 1;
            // 
            // designTimePage
            // 
            this.designTimePage.Location = new System.Drawing.Point(4, 4);
            this.designTimePage.Name = "designTimePage";
            this.designTimePage.Padding = new System.Windows.Forms.Padding(3);
            this.designTimePage.Size = new System.Drawing.Size(564, 520);
            this.designTimePage.TabIndex = 0;
            this.designTimePage.Text = "设计器";
            this.designTimePage.UseVisualStyleBackColor = true;
            // 
            // designTimeXmlPage
            // 
            this.designTimeXmlPage.Controls.Add(this.xmlEdit);
            this.designTimeXmlPage.Location = new System.Drawing.Point(4, 4);
            this.designTimeXmlPage.Name = "designTimeXmlPage";
            this.designTimeXmlPage.Padding = new System.Windows.Forms.Padding(3);
            this.designTimeXmlPage.Size = new System.Drawing.Size(564, 520);
            this.designTimeXmlPage.TabIndex = 1;
            this.designTimeXmlPage.Text = "表单代码";
            this.designTimeXmlPage.UseVisualStyleBackColor = true;
            // 
            // xmlEdit
            // 
            this.xmlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlEdit.Location = new System.Drawing.Point(3, 3);
            this.xmlEdit.Name = "xmlEdit";
            this.xmlEdit.Size = new System.Drawing.Size(558, 514);
            this.xmlEdit.TabIndex = 0;
            this.xmlEdit.Text = "这里是表单代码";
            // 
            // designTableLayoutPanel
            // 
            this.designTableLayoutPanel.ColumnCount = 3;
            this.designTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.designTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.designTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.designTableLayoutPanel.Controls.Add(this.designTimeTab, 1, 0);
            this.designTableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.designTableLayoutPanel.Controls.Add(this.propertyGrid1, 2, 0);
            this.designTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designTableLayoutPanel.Location = new System.Drawing.Point(0, 10);
            this.designTableLayoutPanel.Name = "designTableLayoutPanel";
            this.designTableLayoutPanel.RowCount = 1;
            this.designTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.designTableLayoutPanel.Size = new System.Drawing.Size(964, 552);
            this.designTableLayoutPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.addRichTextBox);
            this.panel1.Controls.Add(this.addTextBoxBtn);
            this.panel1.Controls.Add(this.addLabelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 546);
            this.panel1.TabIndex = 2;
            // 
            // addRichTextBox
            // 
            this.addRichTextBox.Location = new System.Drawing.Point(28, 177);
            this.addRichTextBox.Name = "addRichTextBox";
            this.addRichTextBox.Size = new System.Drawing.Size(120, 40);
            this.addRichTextBox.TabIndex = 3;
            this.addRichTextBox.Text = "RichTextBox";
            this.addRichTextBox.UseVisualStyleBackColor = true;
            // 
            // addTextBoxBtn
            // 
            this.addTextBoxBtn.Location = new System.Drawing.Point(28, 102);
            this.addTextBoxBtn.Name = "addTextBoxBtn";
            this.addTextBoxBtn.Size = new System.Drawing.Size(120, 40);
            this.addTextBoxBtn.TabIndex = 2;
            this.addTextBoxBtn.Text = "TextBox";
            this.addTextBoxBtn.UseVisualStyleBackColor = true;
            this.addTextBoxBtn.Click += new System.EventHandler(this.addTextBoxBtn_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(773, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(188, 546);
            this.propertyGrid1.TabIndex = 3;
            // 
            // DesignTimeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 562);
            this.Controls.Add(this.designTableLayoutPanel);
            this.Controls.Add(this.designerToobarPanel);
            this.Name = "DesignTimeTestForm";
            this.Text = "DesignTimeTestForm";
            this.Load += new System.EventHandler(this.DesignTimeTestForm_Load);
            this.designTimeTab.ResumeLayout(false);
            this.designTimeXmlPage.ResumeLayout(false);
            this.designTableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel designerToobarPanel;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addLabelBtn;
        private System.Windows.Forms.TabControl designTimeTab;
        private System.Windows.Forms.TabPage designTimePage;
        private System.Windows.Forms.TabPage designTimeXmlPage;
        private System.Windows.Forms.TableLayoutPanel designTableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addRichTextBox;
        private System.Windows.Forms.Button addTextBoxBtn;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.RichTextBox xmlEdit;
    }
}