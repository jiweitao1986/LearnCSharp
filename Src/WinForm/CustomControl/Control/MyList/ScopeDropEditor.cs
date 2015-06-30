using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CustomControl.Control.MyList
{
    public class ScopeDropEditor : UITypeEditor
    {
        /// <summary>
        /// 编辑器样式
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if (context != null && context.Instance != null)
            {
                return UITypeEditorEditStyle.DropDown;
            }
            return base.GetEditStyle(context);
        }

        /// <summary>
        /// 编辑值
        /// </summary>
        /// <param name="context"></param>
        /// <param name="provider"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService editorService = null;
            if (context != null && context.Instance != null && provider != null)
            {
                editorService = (IWindowsFormsEditorService)provider
                    .GetService(typeof(IWindowsFormsEditorService));
                if (editorService != null)
                {
                    MyList control = (MyList)context.Instance;
                    ScopeDropEditorControl editorControl = new ScopeDropEditorControl(control.ScopeDrop);
                    editorService.DropDownControl(editorControl);
                    value = editorControl.Scope;
                    return value;
                }
            }
            return base.EditValue(context, provider, value);
        }
    }
}
