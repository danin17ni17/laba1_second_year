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
  и подчененная форма, работающими с двумя списками
 */

namespace Second_Two
{
    public partial class MainForma : Form
    {
        public MainForma()
        {
            InitializeComponent();
        }

        private void btn_podch_forma_Click(object sender, EventArgs e)
        {
            TwoLists podchForma = new TwoLists();
            podchForma.ShowDialog();
        }
    }
}
