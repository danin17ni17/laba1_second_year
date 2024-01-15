using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_second_year
{
    public partial class Main_Forma : Form
    {
        Podch_Forma perehod1;
        Ris_Forma perehod2;
        Files_Forma perehod3;
        Graf_Forma perehod4;

        public Main_Forma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            perehod1 = new Podch_Forma();
            perehod2 = new Ris_Forma();
            perehod3 = new Files_Forma();
            perehod4 = new Graf_Forma();
        }

        private void btn_podch_form_Click(object sender, EventArgs e)
        {
            // Обработчик нажатия кнопки для открытия подчиненной формы
            this.Hide();
            perehod1.ShowDialog();
            this.Show();
        }

        private void btn_ris_form_Click(object sender, EventArgs e)
        {
            // Обработчик нажатия кнопки для открытия формы рисования фигур
            this.Hide();
            perehod2.ShowDialog();
            this.Show();
        }

        private void btn_graf_form_Click(object sender, EventArgs e)
        {
            // Обработчик нажатия кнопки для открытия формы работы с файлами
            this.Hide();
            perehod3.ShowDialog();
            this.Show();
        }

        private void btn_files_form_Click(object sender, EventArgs e)
        {
            // Обработчик нажатия кнопки для открытия формы работы с графикой
            this.Hide();
            perehod4.ShowDialog();
            this.Show();
        }
    }
}
