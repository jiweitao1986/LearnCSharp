using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;

namespace LearningCSharp.WinForm.Other.ICSharpCodeTextEditor
{
    public partial class SimpleTest : Form
    {
        public SimpleTest()
        {
            InitializeComponent();
        }

        private void SimpleTest_Load(object sender, EventArgs e)
        {
            this.simpleTextEditor.ActiveTextAreaControl.HScrollBar.Dock
                = DockStyle.Top;
            this.simpleTextEditor.ActiveTextAreaControl.VScrollBar.Dock
                = DockStyle.Right;

            //this.simpleTextEditor.IsReadOnly = true;

            this.simpleTextEditor.ActiveTextAreaControl.TextArea.BackColor = Color.Purple;

            Color color = Color.Black;
            Color backColor = Color.LightGray;
            HighlightColor highlightColor = new HighlightColor(color, backColor, false, false);



            simpleTextEditor.Document.HighlightingStrategy
                = HighlightingStrategyFactory.CreateHighlightingStrategy("HTML");



            DefaultHighlightingStrategy highlightingStrategy
                = simpleTextEditor.Document.HighlightingStrategy as DefaultHighlightingStrategy;
            highlightingStrategy.SetColorFor("Default", highlightColor);
            //highlightingStrategy.SetColorFor("LineNumbers", highlightColor);
            //highlightingStrategy.SetColorFor("FoldLine", highlightColor);

            DefaultHighlightingStrategy s = null;
            s?.SetColorFor("Default", highlightColor);



            //多行文本框
            this.simpleRichTextBox.ReadOnly = true;

        }
    }
}
