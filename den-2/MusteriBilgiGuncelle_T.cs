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
    public partial class MusteriBilgiGuncelle_T : Form
    {
        public MusteriBilgiGuncelle_T()
        {
            InitializeComponent();
        }
        public void liste()
        {
            SqlOperations.baglanti.Open();
            string b = Formİşlemleri.temsilciForm.temsilciTC.Text;
            string sorgu = "Select musteriler.musteriid,musteriler.adSoyad,musteriler.telefon,musteriler.tc, musteriler.adres,musteriler.ePosta from musteriler inner join temsilci on musteriler.temsilciid = temsilci.temsilciid  where temsilci.tc ='" + b + "'";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
            SqlOperations.baglanti.Close();
        }
        private void MusteriBilgiGuncelle_T_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formİşlemleri.MBGuncelleForm.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string guncelle = " update musteriler set telefon='" + textBox1.Text + " ',adres='" + textBox2.Text + " ',ePosta='" + textBox3.Text + " 'where musteriid = '" + textBox4.Text + "'";
            SqlCommand cmd = new SqlCommand(guncelle, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
            liste();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string guncelle = "Delete From musteriler Where musteriid = '" + textBox4.Text + "'";
            SqlCommand cmd = new SqlCommand(guncelle, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
            liste();
        }
    }
}
