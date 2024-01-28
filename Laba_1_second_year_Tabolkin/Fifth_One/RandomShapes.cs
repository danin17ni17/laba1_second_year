using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Этот проект разработан
 для работы с графическими примитивами, такими как "Паутина Безье"
 и "Кисти и краски"
 */

namespace Fifth_One
{
    public partial class RandomShapes : Form
    {
        private int cx, cy;
        private Graphics graph;
        private Brush brush;
        private Color color;
        private Random rnd;

        public RandomShapes()
        {
            InitializeComponent();
            MyInit();
        }

        void MyInit()
        {
            cx = ClientSize.Width;
            cy = ClientSize.Height;
            graph = CreateGraphics();
            rnd = new Random();
        }

        void DrawShapes()
        {
            for (int i = 0; i < 3; i++)
            {
                //выбирается цвет - красный, желтый, голубой
                int numcolor = rnd.Next(3);
                switch (numcolor)
                {
                    case 0: color = Color.Blue; break;
                    case 1: color = Color.Yellow; break;
                    case 2: color = Color.Red; break;
                }
                //градиентной кистью рисуется эллипс,
                //местоположение случайно
                Point top = new Point(rnd.Next(cx), rnd.Next(cy));
                Size sz = new Size(rnd.Next(cx - top.X), rnd.Next(cy - top.Y));
                Rectangle rct = new Rectangle(top, sz);
                Point bottom = top + sz;
                brush = new LinearGradientBrush(top, bottom, Color.White, color);
                graph.FillEllipse(brush, rct);
                //сплошной кистью рисуется сектор (местоположение случайно)		
                top = new Point(rnd.Next(cx), rnd.Next(cy));
                sz = new Size(rnd.Next(cx - top.X), rnd.Next(cy - top.Y));
                rct = new Rectangle(top, sz);
                brush = new SolidBrush(color);
                graph.FillPie(brush, rct, 30f, 60f);
                //узорной кистью рисуется прямоугольник (местоположение случайно)
                top = new Point(rnd.Next(cx), rnd.Next(cy));
                sz = new Size(rnd.Next(cx - top.X), rnd.Next(cy - top.Y));
                rct = new Rectangle(top, sz);
                HatchStyle hs = (HatchStyle)rnd.Next(52);
                brush = new HatchBrush(hs, Color.White, Color.Black);
                graph.FillRectangle(brush, rct);
            }
        }

        private void RandomShapes_Click(object sender, EventArgs e)
        {
            DrawShapes();
        }
    }
}
