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
    public partial class Personelİşlemleri_BM : Form
    {
        public Personelİşlemleri_BM()
        {
            InitializeComponent();
        }

        public void maasList()
        {
            SqlOperations.baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from maas", SqlOperations.baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            SqlOperations.baglanti.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            maasList();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            maas1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            maas2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            maas3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string guncelle = " update maas set miktar = '" + maas3.Text + "' where maasKodu = '" + maas1.Text + "'";
            SqlCommand cmd = new SqlCommand(guncelle, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
            maasList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "Select * From temsilci Where calisanKodu='1'";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter(query, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();

        }
        private void geriBTN_Click(object sender, EventArgs e)
        {
            Formİşlemleri.personelislemForm.Hide();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void maas3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}