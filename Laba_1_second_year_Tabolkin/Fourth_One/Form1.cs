using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 В данном приложении реализована 
 работа с меню на главной форме
 */

namespace Fourth_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            //код, показывающий, что делать с открытым файлом
            textBox1.Text = "Открытие Файла!";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            //код, анализирующий результат операции сохранения файла
            textBox1.Text = "Сохранение Файла!";
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.textBox1.BackColor = colorDialog1.Color;
        }

        private void circleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Рисование круга!";
        }

        private void rectangleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Рисование прямоугольника!";
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Рисование прямой!";
        }
    }
}
