using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemizlik;


        public Form1()
        {
            InitializeComponent();
        }
        // ekrandan aldığım sayıları labelda göstermek için kullandığım metod.
        private void EkranYaz(string item)
        {
            if (_ekranTemizlik)
            {
                lblEkran.Text = "";
                _ekranTemizlik = false;
            }

            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += item;

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            EkranYaz(item: "0");
        }
        double ilkSayi;
       
        // aritmetik işlemlerin yapılması için kullanmış olduğum metod.
        private void IslemYap(char item)
        {
            _islem = item;
            _ekranTemizlik = true;
            ilkSayi=Convert.ToDouble(lblEkran.Text);
        
        } 
        private void btnEksi_Click(object sender, EventArgs e)
        {
            IslemYap('-');
        }
        private void btnArti_Click(object sender, EventArgs e)
        {
            IslemYap('+');
        }
        private void btnCarpma_Click(object sender, EventArgs e)
        {
            IslemYap('*');
        }
        private void btnBolu_Click(object sender, EventArgs e)
        {
            IslemYap('/');
        }
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            double ikinciSayi=Convert.ToDouble(lblEkran.Text);
            double sonuc = 0;
            switch (_islem)
            {
                case '+':
                    sonuc = ilkSayi + ikinciSayi;
             break;

                case '-':
                    sonuc= ilkSayi - ikinciSayi;
                    break;
                case '/':
                    sonuc= ilkSayi/ikinciSayi;
                    break;
                case '*':
                    sonuc = ilkSayi * ikinciSayi; 
                    break;
                    
            
            }
            lblEkran.Text=Convert.ToString(sonuc);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "0";
        }
    }
}
