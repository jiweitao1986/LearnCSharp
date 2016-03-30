using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace LearningCSharp.CustomControl.Controls.MyList
{
    public class MyList : System.Windows.Forms.Control
    {

        private List<int> _list = new List<int>();

        private Scope _scope;

        private Scope _scopeModal;

        private Scope _scopeDrop;

        public MyList()
        {
            
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<int> Items
        {
            get
            {
                return this._list;
            }
            set
            {
                this._list = value;
            }
        }

        [Browsable(true)]
        public Scope Scope
        {
            get
            {
                return this._scope;
            }
            set
            {
                this._scope = value;
            }
        }

        [Browsable(true)]
        [Editor(typeof(ScopeModalEditor), typeof(UITypeEditor))]
        public Scope ScopeModal
        {
            get
            {
                return this._scopeModal;
            }
            set
            {
                this._scopeModal = value;
            }
        }

        [Browsable(true)]
        [Editor(typeof(ScopeDropEditor), typeof(UITypeEditor))]
        public Scope ScopeDrop
        {
            get
            {
                return this._scopeDrop;
            }
            set
            {
                this._scopeDrop = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(
                Point.Empty, new Size(this.Size.Width - 1, this.Size.Height - 1)
            ));

            for (int i = 0; i < this._list.Count; i++)
            {
                e.Graphics.DrawString(this._list[i].ToString(), this.Font, Brushes.Black,
                    1, i*this.FontHeight);
            }

        }
    }



}
