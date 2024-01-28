using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fourth_Three
{
    enum DrawMode { None, DrawPoin, Ribbon };

    public partial class Form1 : Form
    {
        private List<Point> Points;
        private Point oldCursor;
        private DrawMode drMode;

        public Form1()
        {
            InitializeComponent();
            Points = new List<Point>();
            oldCursor = new Point(0, 0);
            drMode = DrawMode.None;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Проверяем, нажата ли левая кнопка мыши
            {
                // Сохраняем начальные координаты при нажатии левой кнопки мыши
                oldCursor = e.Location;
            }

            Graphics g = pictureBox1.CreateGraphics(); // Создаем объект Graphics для pictureBox1
            Pen pen = new Pen(Color.Black, 1); // Создаем объект "пера"

            switch (drMode)
            {
                case DrawMode.DrawPoin:
                    // Если нажата левая клавиша мыши
                    if (e.Button == MouseButtons.Left)
                    {
                        if (Points.Count > 0) // Если есть хотя бы одна вершина
                        {
                            // Соединяем последнюю вершину с координатами курсора
                            g.DrawLine(pen, Points[Points.Count - 1], e.Location);
                        }
                        Point pnt = e.Location; // Создаем объект вершины
                        Points.Add(pnt); // Добавляем ее в список вершин
                    }
                    else // Если нажата правая клавиша мыши
                    {
                        if (Points.Count > 1) // Если есть хотя бы одна вершина
                        {
                            // Соединяем первую вершину с последней
                            g.DrawLine(pen, Points[0], Points[Points.Count - 1]);
                        }
                        // Очистка списка вершин с целью его подготовки к работе
                        Points.Clear(); // со следующей фигурой
                    }
                    break;

                case DrawMode.Ribbon:
                    if (e.Button == MouseButtons.Left) // Если нажата левая клавиша мыши
                    {
                        Points.Add(e.Location); // Добавляем текущее положение курсора в список вершин
                        g.DrawLine(pen, Points[Points.Count - 1], e.Location); // Рисуем линию
                    }
                    else // Если нажата правая клавиша мыши
                    {
                        if (Points.Count > 0) // Если есть хотя бы одна вершина
                        {
                            Refresh(); // Перерисовка pictureBox1 с рисованием незамкнутой фигуры
                            // Соединяем первую вершину с последней
                            g.DrawLine(pen, Points[0], Points[Points.Count - 1]);
                            // Очистка списка вершин с целью его подготовки к работе со следующей фигурой
                            Points.Clear();
                        }
                    }
                    break;
            }

            oldCursor = e.Location; // Запоминаем координаты курсора
            pen.Dispose(); // Освобождаем ресурсы пера
            g.Dispose(); // Освобождаем ресурсы объекта Graphics
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drMode == DrawMode.Ribbon && Points.Count > 0) // Если выбран режим рисования "резинкой" и есть вершины
            {
                Graphics g = pictureBox1.CreateGraphics(); // Создаем объект Graphics для pictureBox1
                Pen pen = new Pen(Color.Black, 1); // Создаем объект "пера"
                Refresh(); // Перерисовываем pictureBox1
                // Рисуем линию от последней вершины до текущего положения курсора
                g.DrawLine(pen, Points[Points.Count - 1], e.Location);
                pen.Dispose(); // Освобождаем ресурсы пера
                g.Dispose(); // Освобождаем ресурсы объекта Graphics
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void неРисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drMode = DrawMode.None;
        }

        private void поТочкамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drMode = DrawMode.DrawPoin;
        }

        private void резинкойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drMode = DrawMode.Ribbon;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            drMode = DrawMode.None;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            drMode = DrawMode.DrawPoin;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            drMode = DrawMode.Ribbon;
        }
    }
}