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
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }


    
        private void Form2_Load(object sender, EventArgs e)
        {
            frm1.dtst.Clear();
            
            frm1.aralistele(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
            frm1.listele();
            frm1.listele2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm1.frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText ="INSERT INTO hayvan_bil(kimlik_no , hayvan_adi , hayvan_turu , hayvan_cinsi , dogum_tarihi) VALUES ('" + textBox1.Text + "' , '" + textBox2.Text + "' ,'" + textBox3.Text + "' ,'" + textBox4.Text + "' ,'" + textBox5.Text + "')";//sgl kodalrıyla ekleme yapıyoruz.
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
            frm1.listele();
            frm1.listele2();
            MessageBox.Show("Kaydedildi");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            //textBox6.Text = "";
            //textBox7.Text = "";
            //textBox8.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "DELETE FROM hayvan_bil WHERE kimlik_no='"+textBox6.Text+"'";
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
            frm1.listele();
            frm1.listele2();
            MessageBox.Show("Silindi");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "Update hayvan_bil set kimlik_no='" + textBox1.Text + "',hayvan_adi='" + textBox2.Text + "',dogum_tarihi='" + textBox3.Text + "',hayvan_cinsi='" + textBox4.Text + "' where kimlik_no='" + textBox1.Text + "'";
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
            frm1.listele2();
            frm1.listele();
            MessageBox.Show("Değiştirildi");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm1.ara();
            dataGridView1.Visible = true;
            
            
        }
    }
}
