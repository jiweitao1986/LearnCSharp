using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace LearnCSharp.Basic.GDI.Thumbnail
{
    public static class ThumbnailTest
    {
        public static void Run()
        {
            RunThumbnailTest();
        }


        public static void RunThumbnailTest()
        {
            var srcDir = @"../../GDI/Thumbnail/srcPics/";
            var dstDir = @"../../GDI/Thumbnail/dstPics/";

            var srcWideImg = GetImage(srcDir + "wide.png");
            var srcLongImg = GetImage(srcDir + "long.png");

            var maxWidth = 800;
            var maxHeight = 800;

            //宽图等比缩放
            var wideRatioDstImg = ThumbnailUtil.GetThumbnail(srcWideImg, maxWidth, maxHeight, false);
            var wideRatioDstPath = dstDir + "wideRatio.png";
            wideRatioDstImg.Save(wideRatioDstPath, ImageFormat.Jpeg);

            //高图等比缩放
            var longRatioDstImg = ThumbnailUtil.GetThumbnail(srcLongImg, maxWidth, maxHeight, false);
            var longRatioDstPath = dstDir + "longRatio.png";
            longRatioDstImg.Save(longRatioDstPath, ImageFormat.Jpeg);

            //宽图裁剪
            var wideCropDstImg = ThumbnailUtil.GetThumbnail(srcWideImg, maxWidth, maxHeight, true);
            var wideCropDstPath = dstDir + "wideCrop.png";
            wideCropDstImg.Save(wideCropDstPath, ImageFormat.Jpeg);

            //高图裁剪
            var longCropDstImg = ThumbnailUtil.GetThumbnail(srcLongImg, maxWidth, maxHeight, true);
            var longCropDstPath = dstDir + "longCrop.png";
            longCropDstImg.Save(longCropDstPath, ImageFormat.Jpeg);
        }

        /// <summary>
        /// 获取原始图片
        /// </summary>
        /// <param name="srcPath"></param>
        /// <returns></returns>
        public static Image GetImage(string srcPath)
        {
            //获取原始图片的二进制
            FileStream srcPicFs = System.IO.File.OpenRead(srcPath);
            byte[] srcPicBytes = new byte[srcPicFs.Length];
            srcPicFs.Read(srcPicBytes, 0, (int)srcPicFs.Length);

            //转换为Ms
            MemoryStream srcMs = new MemoryStream(srcPicBytes);
            Image srcImage = Image.FromStream(srcMs);

            return srcImage;
        }


        /// <summary>
        /// 参考代码测试
        /// </summary>
        public static void RefCodeTest()
        {
            var width = 200;
            var height = 200;
            var originalImagePath = @"../../GDI/Thumbnail/OriginalPics/wide.png";
            var thumbnailPath = @"../../GDI/Thumbnail/ThumbnailPics/wide.png"; ;
            var mode = "Cut";



            //获取原始图片的二进制
            FileStream srcPicFs = System.IO.File.OpenRead(originalImagePath);
            byte[] srcPicBytes = new byte[srcPicFs.Length];
            srcPicFs.Read(srcPicBytes, 0, (int)srcPicFs.Length);

            //转换为Ms
            MemoryStream srcMs = new MemoryStream(srcPicBytes);
            Image originalImage = Image.FromStream(srcMs);

            #region 图像处理

            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                //指定高宽缩放（可能变形）
                case "HW":
                    break;

                //指定宽，高按比例
                case "W":
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;

                //指定高，宽按比例 
                case "H":
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;

                //指定高宽裁减（不变形）
                case "Cut":
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片 
            Image bitmap = new Bitmap(towidth, toheight);

            //新建一个画板 
            Graphics g = Graphics.FromImage(bitmap);

            //设置高质量插值法 
            g.InterpolationMode = InterpolationMode.High;

            //设置高质量,低速度呈现平滑程度 
            g.SmoothingMode = SmoothingMode.HighQuality;

            //清空画布并以透明背景色填充 
            g.Clear(Color.Transparent);

            //在指定位置并且按指定大小绘制原图片的指定部分 
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
                new Rectangle(x, y, ow, oh),
                GraphicsUnit.Pixel);

            #endregion

            try
            {
                //以jpg格式保存缩略图 
                bitmap.Save(thumbnailPath, ImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }
    }
}
