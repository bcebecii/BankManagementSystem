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
    public partial class MusteriEkle_BM : Form
    {
        public MusteriEkle_BM()
        {
            InitializeComponent();
        }
        public void sistemKayit()
        {
            string query = "Insert into musteriler (adSoyad,telefon,tc,adres,ePosta,temsilciid) values (@padSoyad,@ptelefon,@ptc,@padres, @pePosta,@ptemsilciid)";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();
            cmd.Parameters.AddWithValue("@padSoyad", tBoxNameSurname.Text);
            cmd.Parameters.AddWithValue("@ptelefon", tBoxPhone.Text);
            cmd.Parameters.AddWithValue("@ptc", tBoxTC.Text);
            cmd.Parameters.AddWithValue("@padres", tBoxAddress.Text);
            cmd.Parameters.AddWithValue("@pePosta", tBoxEPosta.Text);
            cmd.Parameters.AddWithValue("@ptemsilciid", texttemsilci.Text);

            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
        }

        string tcKontrol = "";
        public void tcVarmiKontrol()
        {

            SqlOperations.baglanti.Open();


            string kontrolSorgu = "SELECT tc FROM musteriler WHERE tc='" + tBoxTC.Text + "'";
            SqlCommand cmdKontrol = new SqlCommand(kontrolSorgu, SqlOperations.baglanti);
            SqlDataReader oku = cmdKontrol.ExecuteReader();

            while (oku.Read())
            {
                tcKontrol = oku["tc"].ToString();

            }
            // label10.Text = hesapKontrol.ToString();
            cmdKontrol.Dispose();
            oku.Close();
            SqlOperations.baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            tcVarmiKontrol();
            if (String.IsNullOrEmpty(tBoxNameSurname.Text) || String.IsNullOrEmpty(tBoxPhone.Text) || String.IsNullOrEmpty(tBoxTC.Text) || String.IsNullOrEmpty(tBoxAddress.Text) || String.IsNullOrEmpty(tBoxEPosta.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                tcKontrol = "";
            }
            else if (tBoxPhone.TextLength != 11)
            {
                MessageBox.Show("Eksik telefon numarası girdiniz");
                tcKontrol = "";
            }
            else if (tBoxTC.TextLength != 11)
            {
                MessageBox.Show("Eksik tc girdiniz");
                tcKontrol = "";
            }
            else if (tcKontrol == "")
            {
                sistemKayit();
                MessageBox.Show("Kayıt Oluşturuldu.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Aynı tc ye ait kayıt zaten mecvut");
                tcKontrol = "";
            }

        }

        string temsilciid;

        public void temsilciyeAtama()
        {
            SqlOperations.baglanti.Open();
            string sorgu = "Select TOP 1 ISNULL(Count(musteriler.temsilciid),0) as sayi,temsilci.temsilciid From musteriler RIGHT JOIN temsilci ON musteriler.temsilciid = temsilci.temsilciid group by musteriler.temsilciid,temsilci.temsilciid ORDER BY sayi asc ";
            SqlCommand cmd = new SqlCommand(sorgu, SqlOperations.baglanti);

            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView2.DataSource = tablo3;

            temsilciid = tablo3.Rows[0]["temsilciid"].ToString();

            texttemsilci.Text = temsilciid;

            SqlOperations.baglanti.Close();
        }

        private void MusteriEkleMudur_Load(object sender, EventArgs e)
        {
            tcKontrol = "";
            tBoxNameSurname.Text = "";
            tBoxPhone.Text = "";
            tBoxTC.Text = "";
            tBoxAddress.Text = "";
            tBoxEPosta.Text = "";
            tBoxPhone.MaxLength = 11;
            tBoxTC.MaxLength = 11;
            dataGridView2.Visible = true;
            texttemsilci.Visible = false;
            temsilciyeAtama();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formİşlemleri.mustEkleMudur.Hide();
        }

        //sadece harf girişi izni
        private void tBoxNameSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        //sadece rakam girişi izni
        private void tBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}