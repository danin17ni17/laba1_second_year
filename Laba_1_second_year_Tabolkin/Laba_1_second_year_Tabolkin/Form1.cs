using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_second_year_Tabolkin
{
    public partial class Form1 : Form
    {
        private List<string> array = new List<string>(); // массив
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(array); // передаем массив в Form2
            form2.ShowDialog(); // открываем Form2
            UpdateListBox(); // обновляем содержимое Listbox после закрытия Form2
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear(); // очищаем Listbox
            listBox1.Items.AddRange(array.ToArray()); // добавляем элементы массива в Listbox
        }
    }
}
