using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new DataGrid.View.CardViewTestForm());
            //Application.Run(new DataGrid.View.LayoutViewTestForm());
            //Application.Run(new DataGrid.DataGridPopContainerTestForm());
            //Application.Run(new Editors.LookUpEditTestForm());
            //Application.Run(new TestForm());
            //Application.Run(new TreeListTest.RecursiveTreeListTestForm());

            Application.Run(new TestForm());
        }
    }
}
