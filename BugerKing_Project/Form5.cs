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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public string string_input3 = "";
        public string string_input2 = "";
        public string string_input = "";
        public int total;

        private void btnPayLast_Click(object sender, EventArgs e)
        {
            string_input2 = Form3.string_string2;
            string_input3 = Form4.string_string3;

            MessageBox.Show("총 금액은 " + total + "원 입니다." + "\n" + "식사방법은 " + string_input2 + ", " + "결재방법은 " + string_input3 + " 입니다.") ;
            this.Hide();
        }

        private void btnOrderLast_Click(object sender, EventArgs e)
        {
            string_input = Form1.string_string;
            total = Form1.string_int;;

            lbPaySum.Text = string_input + "메뉴를 주문하였습니다." + "\n" + "총 금액은 " + total + "원 입니다.";
        }
    }
}
