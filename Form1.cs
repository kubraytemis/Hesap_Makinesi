using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sayi1, sayi2, sonuc;
        string islem;

        void sonucyaz()
        {
            lblislem.Text = sayi1 + islem + sayi2 + "=" + sonuc.ToString();
            txtEkran.Text = sonuc.ToString();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "0";
            }
            else
            {
                txtEkran.Text += "0";
            }
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "1";
            }
            else
            {
                txtEkran.Text += "1";   // yerine    txtEkran.Text = txtEkran.Text + "1";  yazilabilir.

            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text=="0")
            {
                txtEkran.Text = "2";
            }
            else
            {
                txtEkran.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "3";
            }
            else
            {
                txtEkran.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text=="0")
            {
                txtEkran.Text = "4";
            }
            else
            {
                txtEkran.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text=="0")
            {
                txtEkran.Text = "5";
            }
            else
            {
                txtEkran.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text=="0")
            {
                txtEkran.Text = "6";
            }
            else
            {
                txtEkran.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "7";
            }
            else
            {
                txtEkran.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text=="0")
            {
                txtEkran.Text = "8";
            }
            else
            {
                txtEkran.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text=="0")
            {
                txtEkran.Text = "9";
            }
            else
            {
                txtEkran.Text += "9";
            }
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text!=" ")
            {
                txtEkran.Text += ",";
                btnVirgul.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen sayı giriniz...");
            }
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            btnVirgul.Enabled = true;
            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "+";
            txtEkran.Text = " ";
            lblislem.Text = sayi1 + islem;

            btnToplama.Enabled = false;
            btnCıkarma.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
        }

        private void btnCıkarma_Click(object sender, EventArgs e)
        {
            btnVirgul.Enabled = true;
            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "-";
            txtEkran.Text = " ";
            lblislem.Text = sayi1 + islem;


            btnToplama.Enabled = false;
            btnCıkarma.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            btnVirgul.Enabled = true;
            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "x";
            txtEkran.Text = " ";
            lblislem.Text = sayi1 + islem;

            btnToplama.Enabled = false;
            btnCıkarma.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            btnVirgul.Enabled = true;
            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "/";
            txtEkran.Text = " ";
            lblislem.Text = sayi1 + islem;


            btnToplama.Enabled = false;
            btnCıkarma.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text!=" ")
            {
                sayi2 = Convert.ToDouble(txtEkran.Text);
                switch(islem)
                {
                    case "+":sonuc = sayi1 + sayi2;
                        sonucyaz();
                        break;
                    case "-":sonuc = sayi1 - sayi2;
                        sonucyaz();
                        break;
                    case "x":sonuc = sayi1 * sayi2;
                        sonucyaz();
                        break;
                    case "/":sonuc = sayi1 / sayi2;
                        sonucyaz();
                        break;
                       
                }

                btnToplama.Enabled = true;
                btnCıkarma.Enabled = true;
                btnCarpma.Enabled = true;
                btnBolme.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Sayı Giriniz...");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
            lblislem.Text = " ";
            sonuc = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text==sonuc.ToString())
            {
                lblislem.Text = " ";
                txtEkran.Text = "0";
            }
            else
            {
                lblislem.Text = sayi1 + islem;
                txtEkran.Text = "0";
            }
        }

       
        
    }
}
