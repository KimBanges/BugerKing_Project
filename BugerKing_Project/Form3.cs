using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BugerKing_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Form4 fom4 = new Form4();

        public static string string_string2 = "";

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string strOrder = "";

            if (rbStore.Checked)
            {
                strOrder = rbStore.Text;
            }
            else if (rbPack.Checked)
            {
                strOrder = rbPack.Text;
            }
            else
            {
                MessageBox.Show("선택해주세요.");
                return; 
            }

            string_string2 = strOrder;

            fom4.Show();
            this.Hide();
        }

        private void rbStore_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbPack_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
