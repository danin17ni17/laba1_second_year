using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_one
{
    class TwoLists_Strings : Second_Two.TwoLists
    {
        string[] source_items;
        string[] selected_items;
        const int max_items = 20;

        public TwoLists_Strings()
        {
            source_items = new string[max_items];
            selected_items = new string[max_items];
            InitList1();
        }

        void InitList1()
        {
            // Задание элементов источника и инициализация списка формы
            source_items[0] = "Бертран Мейер: Методы программирования";
            // Аналогично заполняются другие элементы массива
            // Перенос массива в список ListBox1
            int i = 0;
            while (source_items[i] != null)
            {
                this.listBox1.Items.Add(source_items[i]);
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string item in listBox2.Items)
            {
                selected_items[i] = item;
                Debug.WriteLine(selected_items[i]);
                i++;
            }
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox2.Items)
            {
                Debug.WriteLine(item);
            }
            this.Hide();
        }
    }
}