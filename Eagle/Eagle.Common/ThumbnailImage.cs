using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Eagle.Common
{
    public class ThumbnailImage
    {
        /// <summary>
        /// 压缩图片
        /// </summary>
        /// <param name="originalImagePath">原始图像路径</param>
        /// <param name="thumbnailPath">缩略图路径</param>
        /// <param name="width">缩略图宽</param>
        /// <param name="height">缩略图高</param>
        /// <param name="mode">缩略方式：HW,指定高度缩放 W,指定宽 H,指定高 Cut,裁剪</param>
        /// <param name="imageType">图片格式</param>
        public void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode, string imageType)
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);
            int towidth = width;
            int toheight = height;
            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;
            switch (mode)
            {
                case "HW": ; break; //指定高宽缩放（可能变形）
                case "W": toheight = originalImage.Height * width / originalImage.Width; break; //指定宽，高按比例
                case "H": towidth = originalImage.Width * height / originalImage.Height; break; //指定高，宽按比例
                case "Cut":
                    //指定高宽裁减（不变形）　　　　　　　　 
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    { oh = originalImage.Height; ow = originalImage.Height * towidth / toheight; y = 0; x = (originalImage.Width - ow) / 2; }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    } break;
                default: break;
            } //新建一个bmp图片 

            //获取水印图地址
            string str = System.Web.HttpContext.Current.Request.PhysicalApplicationPath; //"~/Office.Web/Watermark/office.png";
            System.Drawing.Image waterImage = System.Drawing.Image.FromFile(str + "Watermark/office.png");


            if (towidth <= waterImage.Width)
            {
                double doub = waterImage.Width / towidth;
                towidth = int.Parse((waterImage.Width * doub).ToString());
                toheight = int.Parse((waterImage.Height * doub).ToString());
            }
            if (toheight <= waterImage.Height)
            {
                double doub = waterImage.Height / toheight;
                towidth = int.Parse((waterImage.Width * doub).ToString());
                toheight = int.Parse((waterImage.Height * doub).ToString());
            }
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight); //新建一个画板 
            Graphics g = System.Drawing.Graphics.FromImage(bitmap); //设置高质量插值法 
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High; //设置高质量,低速度呈现平滑程度 
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //清空画布并以透明背景色填充 
            g.Clear(Color.Transparent); //在指定位置并且按指定大小绘制原图片的指定部分 
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight), new Rectangle(x, y, ow, oh), GraphicsUnit.Pixel);

            //添加水印
            g.DrawImage(waterImage, new System.Drawing.Rectangle(towidth - waterImage.Width, toheight - waterImage.Height, waterImage.Width, waterImage.Height), 0, 0, waterImage.Width, waterImage.Height, System.Drawing.GraphicsUnit.Pixel);
            
            try
            {
                //以jpg格式保存缩略图 
                switch (imageType.ToLower())
                {
                    case "gif": bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Gif); break;
                    case "jpg": bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                    case "bmp": bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Bmp); break;
                    case "png": bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Png); break;
                    default: bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                }
            }
            catch (System.Exception e)
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

        /// <summary>
        /// 压缩图片
        /// </summary>
        /// <param name="originalImagePath">原始图像路径</param>
        /// <param name="thumbnailPath">缩略图路径</param>
        /// <param name="width">缩略图宽</param>
        /// <param name="height">缩略图高</param>
        /// <param name="mode">缩略方式：HW,指定高度缩放 W,指定宽 H,指定高 Cut,裁剪</param>
        /// <param name="imageType">图片格式</param>
        /// <param name="watermarkAddress">水印地址 为空/null以及水印地址不正确则不加水印</param>
        /// <param name="watermarkPosition">水印在图片中的位置[默认右下角] topleft,左上 topright,右上 tailleft,左下 tailright,右下 center,居中</param>
        public void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode, string imageType, string watermarkAddress, string watermarkPosition)
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);
            double towidth = width;
            double toheight = height;
            double x = 0;
            double y = 0;
            double ow = originalImage.Width;
            double oh = originalImage.Height;
            switch (mode)
            {
                case "HW":
                    if (originalImage.Width > width)
                    {
                        towidth = towidth / originalImage.Width * originalImage.Width;
                        toheight = towidth / originalImage.Width * originalImage.Height;
                    }
                    if (originalImage.Height > height)
                    {
                        towidth = toheight / originalImage.Height * originalImage.Width;
                        toheight = toheight / originalImage.Height * originalImage.Height;
                    }
                    ; break; //指定高宽缩放（可能变形）
                case "W": toheight = originalImage.Height * width / originalImage.Width; break; //指定宽，高按比例
                case "H": towidth = originalImage.Width * height / originalImage.Height; break; //指定高，宽按比例
                case "Cut":
                    //指定高宽裁减（不变形）　　　　　　　　 
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    { oh = originalImage.Height; ow = originalImage.Height * towidth / toheight; y = 0; x = (originalImage.Width - ow) / 2; }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    } break;
                default: break;
            } //新建一个bmp图片 
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(Convert.ToInt32(towidth), Convert.ToInt32(toheight)); //新建一个画板 
            Graphics g = System.Drawing.Graphics.FromImage(bitmap); //设置高质量插值法 
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High; //设置高质量,低速度呈现平滑程度 
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //清空画布并以透明背景色填充 
            g.Clear(Color.Transparent); //在指定位置并且按指定大小绘制原图片的指定部分 
            g.DrawImage(originalImage, new Rectangle(0, 0, Convert.ToInt32(towidth),Convert.ToInt32(toheight)), new Rectangle(Convert.ToInt32(x),Convert.ToInt32(y), Convert.ToInt32(ow), Convert.ToInt32(oh)), GraphicsUnit.Pixel);

            string str = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;

            /*加水印*/
            if (!string.IsNullOrEmpty(watermarkAddress))
            {
                System.Drawing.Image waterImage = System.Drawing.Image.FromFile(watermarkAddress);

                switch (watermarkPosition)
                {
                    case "topleft": g.DrawImage(waterImage, new System.Drawing.Rectangle(0, 0, waterImage.Width, waterImage.Height), 0, 0, waterImage.Width, waterImage.Height, System.Drawing.GraphicsUnit.Pixel); break;
                    case "topright": g.DrawImage(waterImage, new System.Drawing.Rectangle(Convert.ToInt32(towidth - waterImage.Width), 0, waterImage.Width, waterImage.Height), 0, 0, waterImage.Width, waterImage.Height, System.Drawing.GraphicsUnit.Pixel); break;
                    case "tailleft": g.DrawImage(waterImage, new System.Drawing.Rectangle(0, Convert.ToInt32(toheight - waterImage.Height), waterImage.Width, waterImage.Height), 0, 0, waterImage.Width, waterImage.Height, System.Drawing.GraphicsUnit.Pixel); break;
                    case "tailright": g.DrawImage(waterImage, new System.Drawing.Rectangle(Convert.ToInt32(towidth - waterImage.Width), Convert.ToInt32(toheight - waterImage.Height), waterImage.Width, waterImage.Height), 0, 0, waterImage.Width, waterImage.Height, System.Drawing.GraphicsUnit.Pixel); break;
                    case "center": g.DrawImage(waterImage, new System.Drawing.Rectangle(Convert.ToInt32((towidth - waterImage.Width) / 2), Convert.ToInt32((toheight - waterImage.Height) / 2), waterImage.Width, waterImage.Height), 0, 0, waterImage.Width, waterImage.Height, System.Drawing.GraphicsUnit.Pixel); break;
                    default: g.DrawImage(waterImage, new System.Drawing.Rectangle(Convert.ToInt32(towidth - waterImage.Width), Convert.ToInt32(toheight - waterImage.Height), waterImage.Width, waterImage.Height), 0, 0, waterImage.Width, waterImage.Height, System.Drawing.GraphicsUnit.Pixel); break;
                }
            }

            try
            {
                //以jpg格式保存缩略图 
                switch (imageType.ToLower())
                {
                    case "gif": bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Gif); break;
                    case "jpg": bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                    case "bmp": bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Bmp); break;
                    case "png": bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Png); break;
                    default: bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                }
            }
            catch (System.Exception e)
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