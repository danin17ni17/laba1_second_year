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
    public partial class Form2 : Form
    {
        private List<string> array;
        public Form2(List<string> array)
        {
            InitializeComponent();
            this.array = array; // сохраняем ссылку на массив
            listBox1.Items.AddRange(array.ToArray()); // добавляем элементы массива в Listbox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text; // получаем текст из TextBox
            if (!string.IsNullOrWhiteSpace(item))
            {
                array.Add(item); // добавляем элемент в массив
            }
            textBox1.Clear(); // очищаем TextBox
            listBox1.Items.Clear(); // очищаем Listbox
            listBox1.Items.AddRange(array.ToArray()); // добавляем элементы массива в Listbox
        }
        // Обработчик события при нажатии на кнопку "Удалить"
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                array.Remove(listBox1.SelectedItem.ToString()); // удаляем выбранный элемент из массива
                listBox1.Items.Clear(); // очищаем Listbox
                listBox1.Items.AddRange(array.ToArray()); // добавляем элементы массива в Listbox
            }
        }
    }
}

