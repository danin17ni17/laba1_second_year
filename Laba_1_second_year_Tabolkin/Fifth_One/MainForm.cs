using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifth_One
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BezierWeb bezier_form = new BezierWeb();
            bezier_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandomShapes rndshap = new RandomShapes();
            rndshap.Show();
        }
    }
}
