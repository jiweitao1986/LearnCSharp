using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControl.Control.FirstControl
{
    public class FirstControl : System.Windows.Forms.Control
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public FirstControl()
        {

        }

        private ContentAlignment textAlignment = ContentAlignment.MiddleLeft;

        [Browsable(true)]
        [Category("设计")]
        [Description("Specifies the alignment of text.")]
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

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(
                Point.Empty, new Size(this.Size.Width - 1, this.Size.Height - 1)
            ));
        }


    }
}