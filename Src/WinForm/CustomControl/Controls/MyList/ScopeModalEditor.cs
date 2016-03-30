using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace LearningCSharp.CustomControl.Controls.MyList
{
    public class ScopeModalEditor : UITypeEditor
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
                return UITypeEditorEditStyle.Modal;
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
                    ScopeModalEditorForm form = new ScopeModalEditorForm(control.ScopeModal);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        value = form.Scope;
                        return value;
                    }
                }
            }
            return base.EditValue(context, provider, value);
        }
    }
}
