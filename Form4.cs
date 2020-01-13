using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form1 frm1;
        string sifre;
        public Form4()
        {
            InitializeComponent();
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifre = textBox1.Text;
            if (sifre == "1234")
            {


                frm1.frm2.Show();
                this.Hide();
                frm1.frm4.textBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Bu Programı Yetkisiz Kişiler Kullanamz..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }
    }
}
