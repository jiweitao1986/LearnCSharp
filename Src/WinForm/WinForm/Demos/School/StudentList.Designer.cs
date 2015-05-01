namespace LearningCSharp.WinForm
{
    partial class StudentList
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBigIcon = new System.Windows.Forms.RadioButton();
            this.RadioButtonSmallIcon = new System.Windows.Forms.RadioButton();
            this.RadioButtonList = new System.Windows.Forms.RadioButton();
            this.imageListBig = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(422, 377);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonList);
            this.groupBox1.Controls.Add(this.RadioButtonSmallIcon);
            this.groupBox1.Controls.Add(this.radioButtonBigIcon);
            this.groupBox1.Location = new System.Drawing.Point(452, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "显示方式";
            // 
            // radioButtonBigIcon
            // 
            this.radioButtonBigIcon.AutoSize = true;
            this.radioButtonBigIcon.Location = new System.Drawing.Point(21, 31);
            this.radioButtonBigIcon.Name = "radioButtonBigIcon";
            this.radioButtonBigIcon.Size = new System.Drawing.Size(59, 16);
            this.radioButtonBigIcon.TabIndex = 0;
            this.radioButtonBigIcon.Text = "大图标";
            this.radioButtonBigIcon.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSmallIcon
            // 
            this.RadioButtonSmallIcon.AutoSize = true;
            this.RadioButtonSmallIcon.Location = new System.Drawing.Point(21, 75);
            this.RadioButtonSmallIcon.Name = "RadioButtonSmallIcon";
            this.RadioButtonSmallIcon.Size = new System.Drawing.Size(59, 16);
            this.RadioButtonSmallIcon.TabIndex = 1;
            this.RadioButtonSmallIcon.Text = "小图标";
            this.RadioButtonSmallIcon.UseVisualStyleBackColor = true;
            // 
            // RadioButtonList
            // 
            this.RadioButtonList.AutoSize = true;
            this.RadioButtonList.Checked = true;
            this.RadioButtonList.Location = new System.Drawing.Point(21, 119);
            this.RadioButtonList.Name = "RadioButtonList";
            this.RadioButtonList.Size = new System.Drawing.Size(47, 16);
            this.RadioButtonList.TabIndex = 2;
            this.RadioButtonList.TabStop = true;
            this.RadioButtonList.Text = "列表";
            this.RadioButtonList.UseVisualStyleBackColor = true;
            // 
            // imageListBig
            // 
            this.imageListBig.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListBig.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListBig.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "StudentList";
            this.Text = "ListView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonList;
        private System.Windows.Forms.RadioButton RadioButtonSmallIcon;
        private System.Windows.Forms.RadioButton radioButtonBigIcon;
        private System.Windows.Forms.ImageList imageListBig;
        private System.Windows.Forms.ImageList imageListSmall;

    }
}