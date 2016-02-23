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
      DrawParabola01(2900);
    }

    private static void DrawParabola01(int a)
    {
      Random rnd = new Random();
      Bitmap bitmap = new Bitmap(a, a);
      Graphics g = Graphics.FromImage(bitmap);

      // create new random pen
      Color color = new Color();
      Pen pen = new Pen(color);
      g.FillRectangle(Brushes.Black, 0, 0, a, a); // fill background
      for (int i = 0; i < a / 10; i++)
      {
        color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
        pen.Color = color;
        g.DrawLine(pen, 0, i * 10, 10 + ((i + 1) * 10), a); // bottom-left
        g.DrawLine(pen, i * 10, 0, a, 10 + ((i + 1) * 10)); // top-right
      }
      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      pen.Color = color; 
      
      for (int i = 0; i < a / 2; i += 5)
      {
        g.DrawLine(pen, i, a / 2, a / 2, a / 2 - i); //top-left
      }
      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      pen.Color = color;
      for (int i = 0; i < a / 2; i += 5)
      {
        g.DrawLine(pen, a / 2, a - i, a / 2 + i, a / 2); //bottom-right
      }
      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      pen.Color = color; 
      for (int i = 0; i < a / 2; i += 5)
      {

        g.DrawLine(pen, a / 2, i, a / 2 + i, a / 2); //top-right
      }
      color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
      pen.Color = color; 
      for (int i = 0; i < a / 2; i += 5)
      {

        g.DrawLine(pen, i, a / 2, a / 2, a / 2 + i); //bottom-left
      }




      bitmap.Save("parabola01.png", System.Drawing.Imaging.ImageFormat.Png);
    }
  }
}
