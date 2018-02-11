using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Promowork
{
    public static class LoadImageFromText
    {
        public static Image LoadImage(string text)
        {
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(1, 1);
            System.Drawing.Graphics graphic = System.Drawing.Graphics.FromImage(bmp);
            System.Drawing.Font font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            int width = Convert.ToInt32(graphic.MeasureString(text, font).Width);
            int height = Convert.ToInt32(graphic.MeasureString(text, font).Height);
            bmp = new System.Drawing.Bitmap(height, width);
            graphic = System.Drawing.Graphics.FromImage(bmp);
            graphic.Clear(System.Drawing.Color.White);
            graphic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            graphic.TranslateTransform(0, width);
            graphic.RotateTransform(270);
            graphic.DrawString(text, font, new System.Drawing.SolidBrush(System.Drawing.Color.Fuchsia), 0, 0);
            graphic.Flush();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            // return ms.ToArray();

            Image returnImage = Image.FromStream(ms);
            return returnImage;


        }
    }
}