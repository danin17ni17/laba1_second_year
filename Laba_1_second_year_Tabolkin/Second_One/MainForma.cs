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
  В данном приложении используется главная форма
  с двумя кнопками для открытия модальной и немодальной подчиненных форм
 */

namespace Second_One
{
    public partial class MainForma : Form
    {
        private Books myBooks;
        public MainForma()
        {
            InitializeComponent();
            myBooks = new Books(10); // Создание объекта Books с максимальным количеством книг
        }

        private void btn_modal_Click(object sender, EventArgs e)
        {
            // Открытие модальной формы
            ModalForma modalForma = new ModalForma(myBooks);
            modalForma.ShowDialog();
        }

        private void btn_nemodal_Click(object sender, EventArgs e)
        {
            // Открытие немодальной формы
            NeModalForma neModalForma = new NeModalForma(myBooks);
            neModalForma.Show();
        }
    }
}
