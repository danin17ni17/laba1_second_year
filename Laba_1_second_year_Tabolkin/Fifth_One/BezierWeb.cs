using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifth_One
{
    public partial class BezierWeb : Form
    {
        Point center;
        Point[] points = new Point[10];
        Pen pen;
        Graphics graph;
        int count;
        public BezierWeb()
        {
            InitializeComponent();
            MyInit();
        }

        private void MyInit()
        {
            int cx = ClientSize.Width;
            int cy = ClientSize.Height;
            points[0] = new Point(0, 0);
            points[1] = new Point(cx / 2, 0);
            points[2] = new Point(cx, 0);
            points[3] = new Point(0, cy / 2);
            points[4] = new Point(cx, cy / 2);
            points[5] = new Point(0, cy);
            points[6] = new Point(cx / 2, cy);
            points[7] = new Point(cx, cy);
            points[8] = new Point(0, 0);
            points[9] = new Point(cx / 2, 0);
            graph = CreateGraphics();
            center = new Point(cx / 2, cy / 2);
            count = 1;
        }

        private void DrawWeb()
        {
            for (int i = 0; i < 8; i++)
                graph.DrawBezier(pen, center, points[i], points[i + 2], points[i + 1]);
        }

        private void BezierWeb_MouseMove(object sender, MouseEventArgs e)
        {
            pen = SystemPens.Control;
            DrawWeb();
            center.X = e.X; center.Y = e.Y;
            pen = SystemPens.ControlText;
            DrawWeb();
        }
    }
}
