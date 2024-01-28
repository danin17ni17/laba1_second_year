using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2_second_year_Tabolkin
{
    public enum DrawMode
    {
        ByPoint,
        Ribbon
    }
    public partial class Form1 : Form
    {
        private List<Point> PointsList;
        private Point oldCursor;
        private DrawMode drMode;

        public Form1()
        {
            InitializeComponent();
            PointsList = new List<Point>();
            oldCursor = new Point(0, 0);
            drMode = DrawMode.ByPoint;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            Point pnt;

            switch (drMode)
            {
                case DrawMode.ByPoint:
                    if (e.Button == MouseButtons.Left)
                    {
                        if (PointsList.Count > 0)
                        {
                            g.DrawLine(pen, PointsList[PointsList.Count - 1], e.Location);
                        }
                        pnt = new Point(e.X, e.Y);
                        PointsList.Add(pnt);
                    }
                    else
                    {
                        if (PointsList.Count > 1)
                        {
                            g.DrawLine(pen, PointsList[0], PointsList[PointsList.Count - 1]);
                        }
                        PointsList.Clear();
                    }
                    break;
                case DrawMode.Ribbon:
                    if (e.Button == MouseButtons.Left)
                    {
                        pnt = new Point(e.X, e.Y);
                        PointsList.Add(pnt);
                    }
                    else
                    {
                        if (PointsList.Count > 0)
                        {
                            pictureBox1.Refresh();
                            g.DrawLine(pen, PointsList[0], PointsList[PointsList.Count - 1]);
                            PointsList.Clear();
                        }
                    }
                    break;
            }

            oldCursor.X = e.X;
            oldCursor.Y = e.Y;
            pen.Dispose();
            g.Dispose();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drMode == DrawMode.Ribbon)
            {
                if (e.Button == MouseButtons.Left && PointsList.Count > 0)
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    Pen pen = new Pen(Color.Black, 1);
                    pictureBox1.Refresh();
                    g.DrawLine(pen, PointsList[PointsList.Count - 1], e.Location);
                    pen.Dispose();
                    g.Dispose();
                }
            }
        }
    }
}