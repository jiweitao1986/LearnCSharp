using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControl.Control
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



    }
}