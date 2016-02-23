using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;


namespace ConsoleApplication3
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 1; i++)
        DrawParabolas01(1000, String.Format("parabola{0}", i));
    }

    private static void DrawParabolas01(int a, string fileName)
    {
      Random rnd = new Random();
      Bitmap bitmap = new Bitmap(a, a);
      Graphics g = Graphics.FromImage(bitmap);

      Color color = new Color();
      Pen pen = new Pen(color);

      // fill background
      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      SolidBrush brush = new SolidBrush(color);
      g.FillRectangle(brush, 0, 0, a / 2, a / 2);

      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      brush.Color = color;
      g.FillRectangle(brush, a / 2, 0, a / 2, a / 2);

      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      brush.Color = color;
      g.FillRectangle(brush, 0, a / 2, a / 2, a / 2);

      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      brush.Color = color;
      g.FillRectangle(brush, a / 2, a / 2, a / 2, a / 2);


        for (int i = 0; i < a; i += 10)
        {
          color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
          pen.Color = color;
          g.DrawLine(pen, 0, i, i, a); // bottom-left
          g.DrawLine(pen, i, 0, a, i); // top-right
          g.DrawLine(pen, i, a, a, a - i); //bottom-right
          g.DrawLine(pen, 0, a - i, i, 0); //top-left
        }

      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      pen.Color = color;
      for (int i = 0; i < a / 2; i += 5)
        g.DrawLine(pen, i, a / 2, a / 2, a / 2 - i); //top-left

      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      pen.Color = color;
      for (int i = 0; i < a / 2; i += 5)
        g.DrawLine(pen, a / 2, a - i, a / 2 + i, a / 2); //bottom-right

      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      pen.Color = color;
      for (int i = 0; i < a / 2; i += 5)
        g.DrawLine(pen, a / 2, i, a / 2 + i, a / 2); //top-right

      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      pen.Color = color;
      for (int i = 0; i < a / 2; i += 5)
        g.DrawLine(pen, i, a / 2, a / 2, a / 2 + i); //bottom-left

      bitmap.Save(String.Format("{0}.png", fileName), System.Drawing.Imaging.ImageFormat.Png);
    }
  }
}
