using System.ComponentModel;

namespace LearningCSharp.CustomControl.Controls.MyList
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
