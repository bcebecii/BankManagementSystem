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
    public partial class MusteriEkle_T : Form
    {
        public MusteriEkle_T()
        {
            InitializeComponent();
        }
        string id;
        string a;
        public void temsid()
        {   SqlOperations.baglanti.Open();
            a=Formİşlemleri.temsilciForm.temsilciTC.Text;
            
            string sorgu = "Select temsilciid from temsilci where temsilci.tc='"+a+"'";
            SqlCommand cmd = new SqlCommand(sorgu, SqlOperations.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView2.DataSource = tablo3;

            id = tablo3.Rows[0]["temsilciid"].ToString();
            temsilciText.Text = id.ToString();
           

            SqlOperations.baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            string query = "Insert into musteriler (adSoyad,telefon,tc,adres,ePosta,temsilciid) values (@padSoyad,@ptelefon,@ptc,@padres, @pePosta,@ptemsilciid)";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();
            cmd.Parameters.AddWithValue("@padSoyad", AdText.Text);
            cmd.Parameters.AddWithValue("@ptelefon", telefonText.Text);
            cmd.Parameters.AddWithValue("@ptc", tcText.Text);
            cmd.Parameters.AddWithValue("@padres", AdresText.Text);
            cmd.Parameters.AddWithValue("@pePosta", postaText.Text);
            cmd.Parameters.AddWithValue("@ptemsilciid", temsilciText.Text);

            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
        }

        private void mustEkleTems_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            temsilciText.Visible= false;
            temsid();
        }

        private void geriBTN_Click(object sender, EventArgs e)
        {

            Formİşlemleri.mustEkleTems.Hide();



        }
    }
}
