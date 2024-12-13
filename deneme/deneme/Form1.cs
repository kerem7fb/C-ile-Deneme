using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;
        int dakika = 0;
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string k_adi, sifre;
            k_adi = textBox1.Text;
            sifre = textBox2.Text;
            if (k_adi == "kerem" && sifre == "fb")
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else 
            {
                MessageBox.Show("Giriş Başarısız");
                sayac = sayac + 1;
            }
            if (sayac == 3)
            {
                timer1.Start();
                button1.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                saniye++;
                label4.Text = saniye.ToString();
                if (saniye == 60) 
                {
                    dakika++;
                    saniye = 0;
                    label3.Text = dakika.ToString();
                    if (dakika == 3) 
                    {
                        label4.Text = "00";
                        label3.Text = "3";
                        saniye = 0;
                        dakika = 0;
                        timer1.Enabled = false;
                        button1.Enabled = true;
                    }
                }

            }
        }
    }

