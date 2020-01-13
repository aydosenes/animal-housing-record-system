using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form2 frm2; //Form2 yi diğer formların göreceği şekilde tanıttık frm2 değişkenimiz
        public Form3 frm3; //Form3 yi diğer formların göreceği şekilde tanıttık frm3 değişkenimiz
        public Form4 frm4;
        public Form5 frm5;

        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source= vt1.mdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();

        public void listele()
        {
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select* from hayvan_bil", bag);
            adtr.Fill(dtst, " hayvan_bil");
            dataView1.Table = dtst.Tables[0];
            dataGrid1.DataSource = dataView1;
            adtr.Dispose();
            bag.Close();
        }

        public void listele2()
        {
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select* from hayvansever_bil", bag);
            adtr.Fill(dtst, " hayvansever_bil");
            dataView2.Table = dtst.Tables[1];
            dataGrid2.DataSource = dataView2;
            adtr.Dispose();
            bag.Close();

        }

        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2(); 
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;
            frm5.frm1 = this;
        }


        public void ara()
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From hayvan_bil", bag);
            if (frm2.textBox7.Text == "")
            {
                kmt.Connection = bag;
                kmt.CommandText = "Select * from hayvan_bil";
                adtr.SelectCommand = kmt;
                adtr.Fill(dtst, "hayvan_bil");
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            adtr.SelectCommand.CommandText = " Select * From hayvan_bil" +
                 " where(hayvan_no like '%" + frm2.textBox7.Text + "%' )";
            dtst.Clear();
            adtr.Fill(dtst, "hayvan_bil");
            bag.Close();
        }       

        public void aralistele()
        {
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From hayvan_bil", bag);
            adtr.Fill(dtst, "hayvan_bil");
           frm2.dataGridView1.DataMember = "hayvan_bil";
          frm2.dataGridView1.DataSource = dtst;
            adtr.Dispose();
            bag.Close();
        }

        public void aralistele2()
        {
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From hayvansever_bil", bag);
            adtr.Fill(dtst, "hayvansever_bil");
            frm3.dataGridView1.DataMember = "hayvansever_bil";
            frm3.dataGridView1.DataSource = dtst;
            adtr.Dispose();
            bag.Close();
        }

        public void ara2()
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From hayvansever_bil", bag);
            if (frm3.textBox10.Text == "")
            {
                kmt.Connection = bag;
                kmt.CommandText = "Select * from hayvansever_bil";
                adtr.SelectCommand = kmt;
                adtr.Fill(dtst, "hayvansever_bil");
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            adtr.SelectCommand.CommandText = " Select * From hayvansever_bil" +
                 " where(okul_no like '%" + frm3.textBox10.Text + "%' )";
            dtst.Clear();
            adtr.Fill(dtst, "hayvansever_bil");
            bag.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            listele2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm4.Show();            
            this.Hide();
            //form4 yi açıyoruz
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm5.Show();
            this.Hide();
            //form3 yi açıyoruz
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
