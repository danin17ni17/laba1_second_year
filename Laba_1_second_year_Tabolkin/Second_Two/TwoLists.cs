using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Two
{
    public partial class TwoLists : Form
    {
        //protected ListBox listBox1;
        //protected ListBox listBox2;
        public TwoLists()
        {
            InitializeComponent();
            //InitializeLists();
        }

        //private void InitializeLists()
        //{
        //    // Заполнение начальными данными
        //    listBox1.Items.AddRange(new object[] { "Виски", "Водка", "Коньяк", "Вино" });
        //    listBox2.Items.AddRange(new object[] { "Огурцы", "Хлеб", "Виноград", "Лимон" });
        //}

        private void listBox1_Enter(object sender, EventArgs e)
        {
            button1.Text = ">";
            button2.Text = ">>";
        }

        private void listBox2_Enter(object sender, EventArgs e)
        {
            button1.Text = "<";
            button2.Text = "<<";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == ">")
                MoveSelectedItems(listBox1, listBox2);
            else
                MoveSelectedItems(listBox2, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == ">>")
                MoveAllItems(listBox1, listBox2);
            else
                MoveAllItems(listBox2, listBox1);
        }

        private void MoveSelectedItems(ListBox list1, ListBox list2)
        {
            // Выделенные элементы списка list1 помещаются в конец списка List2 
            // и удаляются из списка list1			
            list2.BeginUpdate();
            foreach (object item in list1.SelectedItems)
            {
                list2.Items.Add(item);
            }
            list2.EndUpdate();
            ListBox.SelectedIndexCollection indeces = list1.SelectedIndices;
            list1.BeginUpdate();
            for (int i = indeces.Count - 1; i >= 0; i--)
            {
                list1.Items.RemoveAt(indeces[i]);
            }
            list1.EndUpdate();
        }

        private void MoveAllItems(ListBox list1, ListBox list2)
        {
            // Все элементы списка list1 переносятся в конец списка list2 
            // список list1 очищается 
            list2.Items.AddRange(list1.Items);
            list1.Items.Clear();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItems(listBox1, listBox2);
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItems(listBox2, listBox1);
        }
    }
}