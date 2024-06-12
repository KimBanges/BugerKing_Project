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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form3 fom3 = new Form3();

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pbWa_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        public int totalPrice = 0;

        private void ckbWa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbWa.Checked)
            {
                totalPrice += 8000;
            }
            else
                totalPrice -= 8000;
        }

        private void ckbChi_Click(object sender, EventArgs e)
        {

        }

        private void ckbBul_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBul.Checked)
            {
                totalPrice += 8000;
            }
            else
                totalPrice -= 8000;
        }

        private void ckbChi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbChi.Checked)
            {
                totalPrice += 8600;
            }
            else
                totalPrice -= 8600;
        }

        private void ckbGar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGar.Checked)
            {
                totalPrice += 8300;
            }
            else
                totalPrice -= 8300;
        }

        private void ckbKwa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKwa.Checked)
            {
                totalPrice += 8800;
            }
            else
                totalPrice -= 8800;
        }

        private void ckbTong_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTong.Checked)
            {
                totalPrice += 8800;
            }
            else
                totalPrice -= 8800;
        }

        private void ckbMon_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMon.Checked)
            {
                totalPrice += 10200;
            }
            else
                totalPrice -= 1020;
        }

        private void ckbBeul_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBeul.Checked)
            {
                totalPrice += 10200;
            }
            else
                totalPrice -= 10200;
        }

        private void ckbBuelKwa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBuelKwa.Checked)
            {
                totalPrice += 10200;
            }
            else
                totalPrice -= 10200;
        }

        private void ckbNeo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNeo.Checked)
            {
                totalPrice += 3100;
            }
            else
                totalPrice -= 3100;
        }

        private void ckbHa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHa.Checked)
            {
                totalPrice += 2700;
            }
            else
                totalPrice -= 2700;
        }

        private void chb21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOnion.Checked)
            {
                totalPrice += 3300;
            }
            else
                totalPrice -= 3300;
        }

        private void ckbBa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBa.Checked)
            {
                totalPrice += 4100;
            }
            else
                totalPrice -= 4100;
        }

        private void ckbShae_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShae.Checked)
            {
                totalPrice += 3300;
            }
            else
                totalPrice -= 3300;
        }

        private void ckbKeu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKeu.Checked)
            {
                totalPrice += 3500;
            }
            else
                totalPrice -= 3500;
        }

        private void ckbPeu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPeu.Checked)
            {
                totalPrice += 3500;
            }
            else
                totalPrice -= 3500;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb21_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb21.Checked)
            {
                totalPrice += 3400;
            }
            else
                totalPrice -= 3400;
        }

        private void btnOrder2_Click(object sender, EventArgs e)
        {

        }

        private void ckbCo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCo.Checked)
            {
                totalPrice += 3000;
            }
            else
                totalPrice -= 3000;
        }

        private void btnPay2_Click(object sender, EventArgs e)
        {

        }

        public static int string_int;
        public static string string_string = "";

        private void btnOrder3_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lbTotal.Text = "";

            if (ckbWa.Checked == true)
                strOrder += ckbWa.Text + "\n";
            if (ckbChi.Checked == true)
                strOrder += ckbChi.Text + "\n";
            if (ckbBul.Checked == true)
                strOrder += ckbBul.Text + "\n";
            if (ckbGar.Checked == true)
                strOrder += ckbGar.Text + "\n";
            if (ckbKwa.Checked == true)
                strOrder += ckbKwa.Text + "\n";
            if (ckbTong.Checked == true)
                strOrder += ckbTong.Text + "\n";
            if (ckbMon.Checked == true)
                strOrder += ckbMon.Text + "\n";
            if (ckbBeul.Checked == true)
                strOrder += ckbBeul.Text + "\n";
            if (ckbBuelKwa.Checked == true)
                strOrder += ckbBuelKwa.Text + "\n";
            if (ckbNeo.Checked == true)
                strOrder += ckbNeo.Text + "\n";
            if (ckbHa.Checked == true)
                strOrder += ckbHa.Text + "\n";
            if (ckb21.Checked == true)
                strOrder += ckb21.Text + "\n";
            if (ckbOnion.Checked == true)
                strOrder += ckbOnion.Text + "\n";
            if (ckbBa.Checked == true)
                strOrder += ckbBa.Text + "\n";
            if (ckbShae.Checked == true)
                strOrder += ckbShae.Text + "\n";
            if (ckbKeu.Checked == true)
                strOrder += ckbKeu.Text + "\n";
            if (ckbPeu.Checked == true)
                strOrder += ckbPeu.Text + "\n";
            if (ckbCo.Checked == true)
                strOrder += ckbCo.Text + "\n";
            if (ckbCol.Checked == true)
                strOrder += ckbCol.Text + "\n";
            if (ckbZCol.Checked == true)
                strOrder += ckbZCol.Text + "\n";
            if (ckbSprite.Checked == true)
                strOrder += ckbSprite.Text + "\n";
            if (ckbZSprite.Checked == true)
                strOrder += ckbZSprite.Text + "\n";

            lbTotal.Text = strOrder + "메뉴를 주문하였습니다." + "\n" + "총 금액은 " + totalPrice + "원 입니다.";

            string_int = totalPrice;
            string_string = strOrder;
        }

        private void btnPay3_Click(object sender, EventArgs e)
        {
            fom3.Show();
            this.Hide();
        }

        private void nudCol_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudWa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btResult_Click(object sender, EventArgs e)
        {
            lbTotal.Text = "";
            ckbWa.Checked = false;
            ckbChi.Checked = false;
            ckbBul.Checked = false;
            ckbGar.Checked = false;
            ckbKwa.Checked = false;
            ckbTong.Checked = false;
            ckbMon.Checked = false;
            ckbBeul.Checked = false;
            ckbBuelKwa.Checked = false;
            ckbNeo.Checked = false;
            ckbHa.Checked = false;
            ckb21.Checked = false;
            ckbOnion.Checked = false;
            ckbBa.Checked = false;
            ckbShae.Checked = false;
            ckbKeu.Checked = false;
            ckbPeu.Checked = false;
            ckbCo.Checked = false;
            ckbCol.Checked = false;
            ckbZCol.Checked = false;
            ckbSprite.Checked = false;
            ckbZSprite.Checked = false;
        }

        private void ckbCol_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCol.Checked)
            {
                totalPrice += 3100;
            }
            else
                totalPrice -= 3100;
        }

        private void ckbZCol_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbZCol.Checked)
            {
                totalPrice += 3100;
            }
            else
                totalPrice -= 3100;
        }

        private void ckbSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSprite.Checked)
            {
                totalPrice += 3100;
            }
            else
                totalPrice -= 3100;
        }

        private void ckbZSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbZSprite.Checked)
            {
                totalPrice += 3100;
            }
            else
                totalPrice -= 3100;
        }
    }
}