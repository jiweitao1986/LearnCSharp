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
            this.designTimeTab = new System.Windows.Forms.TabControl();
            this.designTimePage = new System.Windows.Forms.TabPage();
            this.designTimeXmlPage = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.designerToobarPanel.SuspendLayout();
            this.designTimeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // designerToobarPanel
            // 
            this.designerToobarPanel.Controls.Add(this.delBtn);
            this.designerToobarPanel.Controls.Add(this.addBtn);
            this.designerToobarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.designerToobarPanel.Location = new System.Drawing.Point(0, 0);
            this.designerToobarPanel.Name = "designerToobarPanel";
            this.designerToobarPanel.Size = new System.Drawing.Size(1000, 70);
            this.designerToobarPanel.TabIndex = 0;
            // 
            // designTimeTab
            // 
            this.designTimeTab.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.designTimeTab.Controls.Add(this.designTimePage);
            this.designTimeTab.Controls.Add(this.designTimeXmlPage);
            this.designTimeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designTimeTab.Location = new System.Drawing.Point(0, 70);
            this.designTimeTab.Name = "designTimeTab";
            this.designTimeTab.SelectedIndex = 0;
            this.designTimeTab.Size = new System.Drawing.Size(1000, 388);
            this.designTimeTab.TabIndex = 1;
            // 
            // designTimePage
            // 
            this.designTimePage.Location = new System.Drawing.Point(4, 4);
            this.designTimePage.Name = "designTimePage";
            this.designTimePage.Padding = new System.Windows.Forms.Padding(3);
            this.designTimePage.Size = new System.Drawing.Size(992, 362);
            this.designTimePage.TabIndex = 0;
            this.designTimePage.Text = "设计器";
            this.designTimePage.UseVisualStyleBackColor = true;
            // 
            // designTimeXmlPage
            // 
            this.designTimeXmlPage.Location = new System.Drawing.Point(4, 4);
            this.designTimeXmlPage.Name = "designTimeXmlPage";
            this.designTimeXmlPage.Padding = new System.Windows.Forms.Padding(3);
            this.designTimeXmlPage.Size = new System.Drawing.Size(992, 362);
            this.designTimeXmlPage.TabIndex = 1;
            this.designTimeXmlPage.Text = "表单代码";
            this.designTimeXmlPage.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(22, 26);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "添加控件";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(116, 26);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "删除控件";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // DesignTimeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 458);
            this.Controls.Add(this.designTimeTab);
            this.Controls.Add(this.designerToobarPanel);
            this.Name = "DesignTimeTestForm";
            this.Text = "DesignTimeTestForm";
            this.Load += new System.EventHandler(this.DesignTimeTestForm_Load);
            this.designerToobarPanel.ResumeLayout(false);
            this.designTimeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel designerToobarPanel;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TabControl designTimeTab;
        private System.Windows.Forms.TabPage designTimePage;
        private System.Windows.Forms.TabPage designTimeXmlPage;
    }
}