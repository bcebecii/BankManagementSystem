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
    public partial class MTalepListele_T : Form
    {
        public MTalepListele_T()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        String c;
        String id;

        private void musteriTalep_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox6.Visible = false;
            SqlOperations.baglanti.Open();
            c = Formİşlemleri.temsilciForm.temsilciTC.Text;

            string sorgu = "Select temsilciid from temsilci where temsilci.tc='" + c + "'";
            SqlCommand cmd = new SqlCommand(sorgu, SqlOperations.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;

            id = tablo3.Rows[0]["temsilciid"].ToString();

            SqlOperations.baglanti.Close();



        }
        // hesap acma talep
        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = "Hesap açma talep";
            textBox6.Text = "E";
            SqlOperations.baglanti.Open();
            string sorgu = "Select hesaplar.hesapid,hesaplar.musteriid,hesaplar.birimid,hesaplar.hesapDurum from temsilci inner join musteriler on temsilci.temsilciid = musteriler.temsilciid INNER JOIN hesaplar on musteriler.musteriid = hesaplar.musteriid where temsilci.temsilciid ='" + id + "'AND hesaplar.hesapDurum = '" + 2 + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo5 = new DataTable();
            da.Fill(tablo5);
            dataGridView2.DataSource = tablo5;
            SqlOperations.baglanti.Close();

        }
        //hesap silme talep
        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "Hesap Silme Talepleri";
            textBox6.Text = "S";
            SqlOperations.baglanti.Open();
            string sorgu = "Select hesaplar.hesapid,musteriler.musteriid,hesaplar.birimid,hesaplar.hesapDurum from musteriler inner join hesaplar on musteriler.musteriid = hesaplar.musteriid  where musteriler.temsilciid='" + id + "'AND hesapDurum='" + 0 + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView2.DataSource = tablo3;
            SqlOperations.baglanti.Close();
        }
        //kredi talep

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "Kredi Talep";
            textBox6.Text = "K";

            SqlOperations.baglanti.Open();
            string sorgu = "Select musteriler.musteriid,kredi.krediid,hesaplar.hesapid,kredi.vade From hesaplar inner join musteriler on musteriler.musteriid=hesaplar.musteriid inner join kredi on hesaplar.hesapid=kredi.hesapid where musteriler.temsilciid =" + id + "AND kredi.krediDurum=" + 2 + "";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo4 = new DataTable();
            da.Fill(tablo4);
            dataGridView2.DataSource = tablo4;
            SqlOperations.baglanti.Close();

        }
        //onay
        int sayi1;
        int sayi;
        int hesapid;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "E")
            {
                textBox4.Text = "1";
                sayi1 = Convert.ToInt16(textBox4.Text);
                SqlOperations.baglanti.Open();

                string sorgu = "Update hesaplar set hesapDurum='" + sayi1 + "' where hesaplar.hesapid='" + textBox1.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
                DataTable tablo2 = new DataTable();
                da.Fill(tablo2);

                SqlOperations.baglanti.Close();
                MessageBox.Show("Hesap Açma Talebi Onaylandı...");

            }
            if (textBox6.Text == "S")

            {
                hesapid = Convert.ToInt16(textBox2.Text);
                SqlOperations.baglanti.Open();
                string sorgu2 = "Delete from hesaplar where hesaplar.hesapid='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sorgu2, SqlOperations.baglanti);

                DataTable tablo3 = new DataTable();
                cmd.ExecuteNonQuery();
                SqlOperations.baglanti.Close();
                MessageBox.Show("Hesap Silme Talebi Onaylandı Silme İşlemi Yapılıyor...");

            }
            if (textBox6.Text == "K")
            {
                SqlOperations.baglanti.Open();

                string sorgu = "Update kredi set krediDurum='" +1+ "' where kredi.krediid='" + textBox2.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
                DataTable tablo2 = new DataTable();
                da.Fill(tablo2);

                SqlOperations.baglanti.Close();
                MessageBox.Show("Kredi Talebi Onaylandı");

            }

        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();


        }
        //red
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "E")
            {

                SqlOperations.baglanti.Open();
                string sorgu = "Delete From hesaplar where hesapid='" + textBox1.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
                DataTable tablo5 = new DataTable();
                da.Fill(tablo5);
                dataGridView2.DataSource = tablo5;
                SqlOperations.baglanti.Close();
                MessageBox.Show("Hesap açma talebi reddedildi");

            }
            if (textBox6.Text == "S")
            {
                textBox4.Text = "1";
                sayi1 = Convert.ToInt16(textBox4.Text);
                SqlOperations.baglanti.Open();
                string sorgu = "Update hesaplar set hesapDurum='" + sayi1 + "' where hesaplar.hesapid='" + textBox1.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
                DataTable tablo2 = new DataTable();
                da.Fill(tablo2);

                SqlOperations.baglanti.Close();
                MessageBox.Show("Hesap silme talebi reddedildi");

            }
            if (textBox6.Text == "K")
            {
                SqlOperations.baglanti.Open();
                string sorgu = "Delete From kredi where krediid='" + textBox2.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
                DataTable tablo5 = new DataTable();
                da.Fill(tablo5);
                dataGridView2.DataSource = tablo5;
                SqlOperations.baglanti.Close();
                MessageBox.Show("Kredi Talebi Reddedildi");

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formİşlemleri.musteriTalep.Hide();
        }


    }
}