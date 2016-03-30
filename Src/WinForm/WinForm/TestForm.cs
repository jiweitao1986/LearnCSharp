using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCSharp.WinForm
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            /*
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 1);
            Pen redPen = new Pen(Color.Red, 1);
            Pen greenPen = new Pen(Color.Green, 1);
            Pen bluePen = new Pen(Color.Blue, 1);

            //Poin
            Point point = new Point(200, 200);

            //绘制直线
            //Point point1 = new Point(400, 100);
            //Point point2 = new Point(400, 300);
            //e.Graphics.DrawLine(blackPen, point1, point2);

            //绘制矩形
            Rectangle blackRect = new Rectangle(0, 0, 500, 500);
            Point offset = this.LTRFlowLayout.PointToScreen(new Point(0, 0));
            blackRect.Offset(offset.X, offset.Y);
            e.Graphics.DrawRectangle(blackPen, blackRect);

            
            Rectangle redRect = new Rectangle(0, 0, 100, 100);
            //redRect.Offset(100, 100);
            //redRect.Offset(point);
            redRect.Inflate(200, 200);
            //e.Graphics.DrawRectangle(redPen, redRect);


            //绘制Pie
            //float startAngle = 0.0F;
            //float sweepAngle = 360.0F;
            //e.Graphics.DrawPie(blackPen, rectangle, startAngle, sweepAngle);

            //绘制文字
            //string drawString = "Hello World !";
            //Font drawFont = new Font("Arial", 16);
            //SolidBrush drawBrush = new SolidBrush(Color.Blue);
            //RectangleF drawRect = new RectangleF(150, 450, 200, 100);
            //e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect);
            */
        }

        private void Test_Click(object sender, EventArgs e)
        {

        }

        private void Test_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void myUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
