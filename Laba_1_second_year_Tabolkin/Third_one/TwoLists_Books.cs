using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_one
{
    class TwoLists_Books : Second_Two.TwoLists
    {
        private Book[] source_items;
        private Book[] selected_items;
        private const int max_items = 20;

        public TwoLists_Books()
        {
            source_items = new Book[max_items];
            selected_items = new Book[max_items];
            InitList1();
        }

        private void InitList1()
        {
            Book newbook = new Book("Бертран Мейер", "Методы программирования", 3, 1980);
            source_items[0] = newbook;

            // Остальные элементы массива заполняются аналогичным образом
            // Перенос массива в список listBox1
            int i = 0;
            while (source_items[i] != null)
            {
                listBox1.Items.Add(source_items[i]);
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (object item in listBox2.Items)
            {
                selected_items[i] = (Book)item;
                selected_items[i].PrintBook();
                i++;
            }
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Book book;
            foreach (object item in listBox2.Items)
            {
                book = (Book)item;
                book.PrintBook();
            }
            this.Hide();
        }
    }
}