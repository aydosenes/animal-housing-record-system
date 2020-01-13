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
    public partial class Form5 : Form
    {
        string sifree;
        public Form1 frm1;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifree = textBox1.Text;
            if (sifree == "1234")
            {


                frm1.frm3.Show();
                this.Hide();
                frm1.frm5.textBox1.Text = "";

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
