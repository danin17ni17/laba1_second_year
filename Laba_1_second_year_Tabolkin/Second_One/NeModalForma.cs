using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_One
{
    public partial class NeModalForma : Form
    {
        private Books books;
        public NeModalForma(Books myBooks)
        {
            InitializeComponent();
            books = myBooks;
        }

        private void btn_Dobav_Books_Click(object sender, EventArgs e)
        {
            // Добавление книги и вывод списка книг
            string bookTitle = tb_Books.Text;
            books.AddBook(bookTitle);

            // Вывод списка книг в немодальной форме
            string[] bookList = books.GetBooks();
            lb_Books.Items.Clear();
            lb_Books.Items.AddRange(bookList);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
