using System.ComponentModel;
using System.Drawing;
using LearningCSharp.CustomControl.Converters;

namespace LearningCSharp.CustomControl.Entities
{
    [TypeConverter(typeof(CssStyleConverter))]
    public class CssStyle
    {
        public CssStyle()
        {
        }

        public CssStyle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        [Browsable(true)]
        public string Position { get; set; }

        [Browsable(true)]
        public Float Float { get; set; }

        [Browsable(true)]
        public int Width { get; set; }

        [Browsable(true)]
        public int Height { get; set; }

        [Browsable(true)]
        public Color Color { get; set; }
    }

    /// <summary>
    /// 浮动枚举
    /// </summary>
    public enum Float {
        [Description("左浮动")]
        Left = 0,

        [Description("右浮动")]
        Right = 1,

        [Description("不浮动")]
        None = 2
    }
}

