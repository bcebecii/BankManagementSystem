using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace den_2
{
    public partial class hesapAcma : Form
    {
        string b;
        string id;
        int durum;
      
        public hesapAcma()
        {
            InitializeComponent();
        }
        public void hesapp()
        {
            SqlOperations.baglanti.Open();
            b = Formİşlemleri.müsteriForm.lblTC.Text.ToString();
            string sorgu = "Select musteriid,tc From musteriler Where musteriler.tc= '" + b + "'";
            SqlCommand cmd = new SqlCommand(sorgu, SqlOperations.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo4 = new DataTable();
            da.Fill(tablo4);
            dataGridView2.DataSource = tablo4;
            id = tablo4.Rows[0]["musteriid"].ToString();

            textBox3.Text = id;

            SqlOperations.baglanti.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }
        public int i;
        

        private void hesapAcma_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            label5.Text = Formİşlemleri.müsteriForm.lblTC.Text;
            hesapp();
            SqlOperations.baglanti.Open();
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select birimid,birimAd as [Para Birimi] from birim", SqlOperations.baglanti);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            SqlOperations.baglanti.Close();


        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlOperations.baglanti.Open();

            textBox4.Text = "2";
            durum = Convert.ToInt16(textBox4.Text);


            DataTable tablo = new DataTable();


            string hesap = " Insert into hesaplar (birimid,musteriid,hesapdurum) values (@pbirimid,'" + id + "','" + durum + "')";
            SqlCommand cmd = new SqlCommand(hesap, SqlOperations.baglanti);

            cmd.Parameters.AddWithValue("@pbirimid", textBox1.Text);

            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
            MessageBox.Show("Hesap Açma Talebiniz Alındı");
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}