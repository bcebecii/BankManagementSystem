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
    public partial class Kur_BM : Form
    {
        public Kur_BM()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KQ2VGPK;Initial Catalog=den2;Integrated Security=True");
        private void listele()
        {
            SqlOperations.baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select birimid,birimAd,kur from birim", SqlOperations.baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            SqlOperations.baglanti.Close();

        }


        private void kur_Load(object sender, EventArgs e)
        {
            listele();
            faizGor();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Insert into birim (birimAd,kur) values (@pbirimAd,@pkur)";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();
            cmd.Parameters.AddWithValue("@pbirimAd", textKurAd.Text);
            cmd.Parameters.AddWithValue("@pkur", textKur.Text);
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string guncelle = " update birim set kur = '" + textKur.Text + "',birimAd='" + textKurAd.Text + " ' where birimid = '" + birimid.Text + "'";
            SqlCommand cmd = new SqlCommand(guncelle, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();

            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
            listele();
        }
        public void faizGor()
        {
            SqlOperations.baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from faizler", SqlOperations.baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            SqlOperations.baglanti.Close();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            string guncelle = " update faizler set faizOrani = '" + textFaizOranı.Text + "',faizAd='" + textfaizAdı.Text + " ' where faizid = '" + textFaizid.Text + "'";
            SqlCommand cmd = new SqlCommand(guncelle, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();

            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
            faizGor();
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            birimid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textKurAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textKur.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }


        private void Geri_Click(object sender, EventArgs e)
        {
            Formİşlemleri.kur.Hide();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textFaizid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textfaizAdı.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textFaizOranı.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

        }

    }
}