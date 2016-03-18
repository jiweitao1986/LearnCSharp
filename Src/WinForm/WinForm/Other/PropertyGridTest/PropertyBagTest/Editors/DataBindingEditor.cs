using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.PropertyBagTest.Editors
{
    class DataBindingEditor : UITypeEditor
    {
        /// <summary>
        /// 
        /// </summary>
        private IWindowsFormsEditorService _edSvc = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DataBindingEditor()
        {
        }


        /// <summary>
        /// 值编辑
        /// </summary>
        /// <param name="context"></param>
        /// <param name="provider"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (context != null && context.Instance != null && provider != null)
            {
                _edSvc = (IWindowsFormsEditorService)provider.GetService(
                    typeof(IWindowsFormsEditorService));

                if (_edSvc != null)
                {
                    return null;
                }
            }
            return base.EditValue(context, provider, value);
        }

        /// <summary>
        /// 编辑器样式
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if (context != null && context.Instance != null)
            {
                return UITypeEditorEditStyle.Modal;
            }
            return base.GetEditStyle(context);
        }
    }
}
