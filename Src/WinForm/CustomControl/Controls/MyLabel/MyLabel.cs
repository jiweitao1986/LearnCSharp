using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LearningCSharp.CustomControl.Controls.MyLabel
{
    public class MyLabel : System.Windows.Forms.Control
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public MyLabel()
        {

        }

        private ContentAlignment textAlignment = ContentAlignment.MiddleLeft;

        [Browsable(true)]
        [Category("设计")]
        [Description("指定文本对齐方式")]
        [DefaultValue(ContentAlignment.TopLeft)]
        public ContentAlignment TextAlignment
        {
            get
            {
                return textAlignment;
            }
            set
            {
                this.textAlignment = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            StringFormat style = new StringFormat();
            style.Alignment = StringAlignment.Near;
            switch (textAlignment)
            {
                case ContentAlignment.MiddleLeft:
                    style.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleRight:
                    style.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.MiddleCenter:
                    style.Alignment = StringAlignment.Center;
                    break;
            }

            //绘制矩形
            Pen p = new Pen(Color.Red, 2);
            e.Graphics.DrawRectangle(p, ClientRectangle); 

            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, style);
        }

    }
}