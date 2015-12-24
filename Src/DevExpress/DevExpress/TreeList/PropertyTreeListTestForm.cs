using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.TreeListTest
{
    public partial class PropertyTreeListTestForm : XtraForm
    {
        private readonly Type[] excludedTypes = new Type[]
        {
            typeof(string),
            typeof(Color),
            typeof(Image),
            typeof(Padding),
            typeof(object),
            typeof(Rectangle),
            typeof(Point)
        };

        public string SeletedProperty
        {
            get;
            private set;
        }

        public PropertyTreeListTestForm()
        {
            InitializeComponent();
        }

        private void PropertyTreeListTestForm_Load(object sender, EventArgs e)
        {
            Type type = Type.GetType("DevExpress.XtraEditors.TextEdit,DevExpress.XtraEditors.v10.2");
            PropertyInfo[] properties = type.GetProperties();

            TreeListNode typeNode = this.propertyTreeList.AppendNode(
                new string[] { type.FullName, "Control Type" }, null);
            this.AppendTypePropertyNodes(type, typeNode);
            typeNode.Expanded = true;
        }

        /// <summary>
        /// 节点展开前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void propertyTreeList_BeforeExpand(object sender, XtraTreeList.BeforeExpandEventArgs e)
        {
            //判断子节点是否已经加载
            TreeListNode selectedNode = e.Node;

            bool childrenLoaded = selectedNode.Nodes.Count > 0;
            if (childrenLoaded)
            {
                return;
            }

            //未加载时，生成子节点
            PropertyInfo propertyInfo = e.Node.Tag as PropertyInfo;
            if (propertyInfo == null)
            {
                return;
            }

            Type propertyType = propertyInfo.PropertyType;
            this.AppendTypePropertyNodes(propertyType, selectedNode);
        }

        /// <summary>
        /// 添加指定类型的所有属性节点
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parentNode"></param>
        private void AppendTypePropertyNodes(Type type, TreeListNode parentNode)
        {
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo propertyItem in properties)
            {
                this.AppendPropertyNode(propertyItem, parentNode);
            }
        }

        /// <summary>
        /// 添加一个属性节点
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <param name="parentNode"></param>
        private void AppendPropertyNode(PropertyInfo propertyInfo, TreeListNode parentNode)
        {
            TreeListNode propertyNode = this.propertyTreeList.AppendNode(
                new string[] {propertyInfo.Name, propertyInfo.PropertyType.Name},
                parentNode
            );

            propertyNode.Tag = propertyInfo;

            bool hasChildren = !propertyInfo.PropertyType.IsPrimitive &&
                !this.excludedTypes.Contains(propertyInfo.PropertyType) &&
                !propertyInfo.PropertyType.IsEnum;
            if (hasChildren == true)
            {
                propertyNode.HasChildren = true;
            }
        }

        /// <summary>
        /// 点击“确认”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            TreeListNode focusedNode = this.propertyTreeList.FocusedNode;
            if (focusedNode != null)
            {
                this.SeletedProperty = this.GetPropertyFullName(focusedNode);
                MessageBox.Show(this.SeletedProperty);
            }
        }

        /// <summary>
        /// 点击“取消”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private string GetPropertyFullName(TreeListNode propertyNode)
        {
            if (propertyNode == null)
            {
                return string.Empty;
            }

            string result = this.GetPropertyFullName(propertyNode.ParentNode);
            if (string.IsNullOrEmpty(result) == false)
            {
                result += ".";
            }
            MemberInfo memberInfo = propertyNode.Tag as MemberInfo;
            result = result + ((memberInfo != null) ? memberInfo.Name : null);
            return result;
        }

    }
}
