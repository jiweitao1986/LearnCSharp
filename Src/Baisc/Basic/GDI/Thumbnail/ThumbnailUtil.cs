using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.GDI.Thumbnail
{
    internal static class ThumbnailUtil
    {
        /**
         * 获取缩略图
         */
        public static Image GetThumbnail(Image srcImage, int dstMaxWidth, int dstMaxHeight, bool ifCrop)
        {
            //初始化
            int srcWidth = srcImage.Width;
            int srcHeight = srcImage.Height;

            int dstWidth = dstMaxWidth;
            int dstHeight = dstMaxHeight;

            int dstX = 0;
            int dstY = 0;

            //宽高比
            double srcAspectRatio = (double) srcImage.Width/(double) srcImage.Height;
            double dstMaxAspectRatio = (double) dstMaxWidth/(double) dstMaxHeight;

            if (ifCrop == true)
            {
                if (srcAspectRatio >= dstMaxAspectRatio)
                {
                    //原图宽高比较大
                    //对原图宽度进行裁剪，裁剪区域最小

                    //计算裁剪后原图宽度
                    srcWidth = dstMaxWidth * srcHeight / dstMaxHeight;

                    //计算原图X方向裁剪起始位置
                    dstX = (srcImage.Width - srcWidth) / 2;
                }
                else
                {
                    //原图宽高比较小
                    //对原图高度进行裁剪，裁剪区域最小

                    //计算裁剪后原图高度
                    srcHeight = srcImage.Width * dstMaxHeight / dstWidth;

                    //计算原图Y方向裁剪起始位置
                    dstY = (srcImage.Height - srcHeight) / 2;
                }
            }
            else
            {
                if (srcAspectRatio >= dstMaxAspectRatio)
                {
                    //原图宽高比较大
                    //按 "缩略图宽=最大宽" 进行等比缩放，才能保证高度不会超过最大高度
                    dstHeight = srcHeight * dstWidth / srcWidth;
                }
                else
                {
                    //原图宽高比较小
                    //按 "缩略图高=最大高" 进行等比缩放，才能保证宽度不会超过最大宽度
                    dstWidth = srcWidth * dstHeight / srcHeight;
                }
            }

            //重新绘制图片
            Image dstImage = new Bitmap(dstWidth, dstHeight);
            Graphics g = Graphics.FromImage(dstImage);
            g.InterpolationMode = InterpolationMode.High;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.Transparent);
            g.DrawImage(srcImage,
                new Rectangle(0, 0, dstWidth, dstHeight),
                new Rectangle(dstX, dstY, srcWidth, srcHeight),
                GraphicsUnit.Pixel
            );

            return dstImage;
        }
    }
}