using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl.Control.MyList
{
    [TypeConverter(typeof(ScopeConverter))]
    public class Scope
    {
        private int _min;

        private int _max;

        public Scope()
        {

        }

        public Scope(int min, int max)
        {
            this._min = min;
            this._max = max;
        }

        [Browsable(true)]
        public int Min
        {
            get
            {
                return this._min;
            }
            set
            {
                this._min = value;
            }
        }

        [Browsable(true)]
        public int Max
        {
            get
            {
                return this._max;
            }
            set
            {
                this._max = value;
            }
        }
    }
}
