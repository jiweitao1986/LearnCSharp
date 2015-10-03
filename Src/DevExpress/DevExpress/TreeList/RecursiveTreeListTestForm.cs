using DevExpress.XtraTreeList.Columns;
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

        private XmlDocument cateDoc;

        public RecursiveTreeListTestForm()
        {
            InitializeComponent();
        }


        public void InitTreeList()
        {
            string cateXmlPath = @"D:\Var\C#\LearnCSharp\Src\DevExpress\DevExpress\TreeList\Category.xml";
            this.cateDoc = new XmlDocument();
            this.cateDoc.Load(cateXmlPath);

            XmlElement docElem = this.cateDoc.DocumentElement;
            XmlNodeList cateXmlNodes = docElem.ChildNodes;
            this.AppendTreeNodes(cateXmlNodes, null);
            this.CateTreeList.ExpandAll();

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
                    cateXmlElem.GetAttribute("FID"),
                    cateXmlElem.GetAttribute("Description")

                },
                parentTreeNode,
                null
            );
            cateTreeNode.Tag = cateXmlElem;

            this.AppendTreeNodes(cateXmlElem.ChildNodes, cateTreeNode);

        }

        private void RecursiveTreeListTestForm_Load(object sender, EventArgs e)
        {
            this.InitTreeList();
        }



        /// <summary>
        /// 选中节点前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CateTreeList_BeforeCheckNode(object sender, XtraTreeList.CheckNodeEventArgs e)
        {
            SetChildNodesCheckState(e.Node.Nodes, e.Node.CheckState);
            SetParentNodeCheckState(e.Node.ParentNode, e.Node.CheckState);
        }

        /// <summary>
        /// 选中节点后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CateTreeList_AfterCheckNode(object sender, XtraTreeList.NodeEventArgs e)
        {
            SetChildNodesCheckState(e.Node.Nodes, e.Node.CheckState);
            SetParentNodeCheckState(e.Node.ParentNode, e.Node.CheckState);
        }

        private void SetChildNodesCheckState(TreeListNodes childNodes, CheckState checkState)
        {
            if (childNodes == null)
            {
                return;
            }
            foreach (TreeListNode childNode in childNodes)
            {
                childNode.CheckState = checkState;
            }
        }

        /// <summary>
        /// 设置父节点的checkState
        /// 当所有兄弟节点和当前节点一致时，设置父节点和当前节点状态一致，否则设置为Indeterminate
        /// </summary>
        private void SetParentNodeCheckState(TreeListNode parentNode, CheckState checkState)
        {
            if (parentNode == null)
            {
                return;
            }

            //检测兄弟节点是否为相同的状态
            bool isSameCheckSate = true;
            foreach (TreeListNode childNode in parentNode.Nodes)
            {
                if (checkState.Equals(childNode.CheckState) == false)
                {
                    isSameCheckSate = false;
                }
            }
            parentNode.CheckState = isSameCheckSate ? checkState : CheckState.Indeterminate;
        }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            TreeListNode focusedNode = this.CateTreeList.FocusedNode;
            TreeListNode parentNode = null;

            TreeListColumn fidCol = this.CateTreeList.Columns["FID"];
            string id = Guid.NewGuid().ToString();
            string fid = string.Empty;

            if (focusedNode != null)
            {
                parentNode = focusedNode.ParentNode;
                fid = focusedNode.GetValue(fidCol).ToString();
            }

            TreeListNode newNode = this.CateTreeList.AppendNode(
                new Object[]
                {
                    string.Empty,
                    id,
                    fid,
                    string.Empty
                },
                parentNode,
                null
            );
            
        }

        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChildBtn_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            TreeListNode focusedNode = this.CateTreeList.FocusedNode;
            TreeListColumn idCol = this.CateTreeList.Columns["ID"];

            string id = Guid.NewGuid().ToString();
            string fid = focusedNode.GetValue(idCol).ToString();

            TreeListNode newNode = this.CateTreeList.AppendNode(
                new Object[]
                {
                    string.Empty,
                    id,
                    fid,
                    string.Empty,
                },
                focusedNode,
                null
            );
            focusedNode.Expanded = true; ;
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelBtn_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < this.CateTreeList.Selection.Count; i++)
            {
                this.CateTreeList.DeleteNode(this.CateTreeList.Selection[i]);
            }
        }

        /// <summary>
        /// 展开所选节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpandBtn_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            this.CateTreeList.ExpandAll();
        }

        /// <summary>
        /// 全部关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseBtn_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            this.CateTreeList.CollapseAll();
        }

        /// <summary>
        /// 保存结果到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            this.SaveAsXml();
        }

        private void CloseBtn_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void SaveAsXml()
        {
            XmlDocument doc = new XmlDocument();

            //创建根节点
            XmlElement catesElem = doc.CreateElement("Categories");
            doc.AppendChild(catesElem);
            this.CreateCateXmlElements(this.CateTreeList.Nodes, doc, catesElem);
            MessageBox.Show(doc.OuterXml);
        }

        private void CreateCateXmlElements(TreeListNodes treeNodes, XmlDocument doc, XmlElement parentXmlElem)
        {
            if (treeNodes == null)
            {
                return;
            }

            TreeListColumn idCol = this.CateTreeList.Columns["ID"];
            TreeListColumn fidCol = this.CateTreeList.Columns["FID"];
            TreeListColumn nameCol = this.CateTreeList.Columns["Name"];
            TreeListColumn descCol = this.CateTreeList.Columns["Desc"];

            foreach (TreeListNode treeNode in treeNodes)
            {
                if (treeNode == null)
                {
                    continue;
                }
                XmlElement cateElem = doc.CreateElement("Category");
                cateElem.SetAttribute("ID", treeNode.GetValue(idCol).ToString());
                cateElem.SetAttribute("FID", treeNode.GetValue(fidCol).ToString());
                cateElem.SetAttribute("Name", treeNode.GetValue(nameCol).ToString());
                cateElem.SetAttribute("Desc", treeNode.GetValue(descCol).ToString());
                parentXmlElem.AppendChild(cateElem);
                this.CreateCateXmlElements(treeNode.Nodes, doc, cateElem);
            }
        }
    }



}
