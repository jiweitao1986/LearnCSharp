using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace DevExpress
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public void TestForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 双击加载图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void coverEdit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string picPath = string.Empty;
            if (e.Button == MouseButtons.Left)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "image files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picPath = dialog.FileName;
                    picStringEdit.Text = ImageToBase64String(picPath);
                }

                //获取图片二进制

                //picEdit.Image.
                //FileStream fs = new FileStream(picPath, FileMode.Open);
                //byte[] byData = new byte[fs.Length];
                //fs.Read(byData, 0, byData.Length);

                //string picString = Convert.ToBase64String(byData);
                //picStringEdit.Text = picString;
            }
        }


        /// <summary>
        /// 获取图片Base64编码
        /// </summary>
        /// <param name="Imagefilename"></param>
        /// <returns></returns>
        private string ImageToBase64String(string picPath)
        {
            try
            {
                Bitmap bmp = new Bitmap(picPath);

                //将图片保存到MemoryStream中
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();

                String base64String = Convert.ToBase64String(arr);
                return base64String;
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取失败");
                return string.Empty;
            }
        }

        /// <summary>
        /// 将base64编码的字符串，转换为图片
        /// </summary>
        /// <param name="picBase64String"></param>
        private Bitmap Base64StringToImage(string picBase64String)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(picBase64String);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);
                ms.Close();

                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base64StringToImage 转换失败\nException：" + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 显示图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showPicEdit_Click(object sender, EventArgs e)
        {
            Bitmap picBitmap = Base64StringToImage(picStringEdit.Text);
            picEdit.Image = picBitmap;
        }
    }
}
