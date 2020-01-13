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
    public partial class Form3 : Form
    {
        public Form1 frm1;


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            frm1.dtst.Clear();

            frm1.aralistele2(); 
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
            frm1.frm4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            Application.Exit();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "INSERT INTO hayvansever_bil(tc , ad , soyad , adres , e_posta , cep_tel ) VALUES ('" + textBox1.Text + "' , '" + textBox2.Text + "' ,'" + textBox3.Text + "' ,'" +  "' ,'" + "','" + textBox6.Text + "' ,'" + textBox7.Text + "' ,'" + textBox8.Text + "')";
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
            frm1.listele2();
            frm1.listele();
            MessageBox.Show("Kaydelidi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "DELETE FROM hayvansever_bil WHERE tc='" + textBox9.Text + "'";
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
            frm1.listele2();
            frm1.listele();
            MessageBox.Show("Silindi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "Update hayvansever_bil set tc='" + textBox1.Text + "',ad='" + textBox2.Text + "',soyad='" + textBox3.Text + "', adres='" + textBox8.Text + "'  , e_posta='" + textBox7.Text + "'   , cep_tel='" + textBox6.Text + "'     where tc='" + textBox1.Text + "'";
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
            frm1.ara2();
            dataGridView1.Visible = true;
            
        }
    }
}
