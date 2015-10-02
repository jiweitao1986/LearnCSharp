using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DevExpress.TreeListTest
{
    public partial class RecursiveTreeListTestForm : Form
    {
        public RecursiveTreeListTestForm()
        {
            InitializeComponent();
        }


        public void InitTreeList()
        {
            string cateXmlPath = @"D:\Var\C#\LearnCSharp\Src\DevExpress\DevExpress\TreeList\Category.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(cateXmlPath);

            XmlElement docElem = doc.DocumentElement;
            XmlNodeList cateXmlNodes = docElem.ChildNodes;
            this.AppendTreeNodes(cateXmlNodes, null);

        }

        public void AppendTreeNodes(XmlNodeList cateXmlNodes, TreeListNode parentTreeNode)
        {
            if (cateXmlNodes == null || cateXmlNodes.Count == 0)
            {
                return;
            }

            foreach (XmlNode cateXmlNode in cateXmlNodes)
            {
                this.AppendTreeNode(cateXmlNode as XmlElement, parentTreeNode);
            }
        }

        public void AppendTreeNode(XmlElement cateXmlElem, TreeListNode parentTreeNode)
        {
            if (cateXmlElem == null)
            {
                return;
            }

            TreeListNode cateTreeNode = this.CateTreeList.AppendNode(
                new Object[]
                {
                    cateXmlElem.GetAttribute("Name"),
                    cateXmlElem.GetAttribute("ID"),
                    cateXmlElem.GetAttribute("Description")
                },
                parentTreeNode,
                null
            );

            this.AppendTreeNodes(cateXmlElem.ChildNodes, cateTreeNode);

        }

        private void RecursiveTreeListTestForm_Load(object sender, EventArgs e)
        {
            this.InitTreeList();
        }

        /// <summary>
        /// 展开所选节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpandBtn_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {

        }

        /// <summary>
        /// 选中节点前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CateTreeList_BeforeCheckNode(object sender, XtraTreeList.CheckNodeEventArgs e)
        {

        }

        /// <summary>
        /// 选中节点后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CateTreeList_AfterCheckNode(object sender, XtraTreeList.NodeEventArgs e)
        {

        }

        private void SetChildNodesChecked()
        {
        
        }

        private void SetChildNodesUnChecked()
        {
            
        }

        private void SetParentNodeChecked()
        {
        
        }

        private void SetParentNodeUnChecked()
        {
        
        }
    }
}
