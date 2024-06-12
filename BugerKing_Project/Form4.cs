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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Form5 fom5 = new Form5();

        public static string string_string3 = "";

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            string strOrder = "";

            if (rbCard.Checked)
            {
                strOrder = rbCard.Text;
            }
            else if (rbCash.Checked)
            {
                strOrder = rbCash.Text;
            }
            else
            {
                MessageBox.Show("선택해주세요.");
                return;
            }

            string_string3 = strOrder;

            fom5.Show();
            this.Hide();
        }
    }
}
