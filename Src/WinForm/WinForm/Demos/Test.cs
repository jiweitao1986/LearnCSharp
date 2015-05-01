using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCSharp.WinForm.Demos
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
            //MessageBox.Show("Width : " + this.flowLayoutPanel.Width.ToString());
            //MessageBox.Show("Height : " + this.flowLayoutPanel.Height.ToString());
            //MessageBox.Show("Location : " + this.flowLayoutPanel.Location.ToString());
            //MessageBox.Show("DisplayRectangle : " + this.flowLayoutPanel.DisplayRectangle.ToString());
            //MessageBox.Show("ClientRectangle : " + this.flowLayoutPanel.ClientRectangle.ToString());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create pen.
            Pen blackPen = new Pen(Color.Red, 3);

            //绘制直线
            Point point1 = new Point(400, 100);
            Point point2 = new Point(400, 300);
            e.Graphics.DrawLine(blackPen, point1, point2);

            //绘制矩形
            Rectangle rectangle = new Rectangle(100, 400, 200, 100);
            e.Graphics.DrawRectangle(blackPen, rectangle);

            //绘制Pie
            float startAngle = 0.0F;
            float sweepAngle = 360.0F;
            e.Graphics.DrawPie(blackPen, rectangle, startAngle, sweepAngle);

            //绘制文字
            string drawString = "Hello World !";
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            RectangleF drawRect = new RectangleF(150, 450, 200, 100);
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect);
        
        }

        private void Test_Click(object sender, EventArgs e)
        {
            
        }
    
    }
}
