using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugerKing_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 fom1 = new Form1();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fom1.Show();
            this.Hide();
        }
    }
}
