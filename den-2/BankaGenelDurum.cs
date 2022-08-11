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
    public partial class BankaGenelDurum : Form
    {
        public BankaGenelDurum()
        {
            InitializeComponent();
        }

        private void BankaGenelDurum_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        float odemeToplam;
        public void krediOdeme()
        {

            SqlOperations.baglanti.Open();
            SqlCommand cmdKontrol3 = new SqlCommand("select sum(miktar) as toplam from islemler where işlemkodu = 4", SqlOperations.baglanti);

            SqlDataReader oku3 = cmdKontrol3.ExecuteReader();
            while (oku3.Read())
            {
                odemeToplam = Convert.ToSingle(oku3["toplam"]);
            }
            cmdKontrol3.Dispose();
            oku3.Close();
            SqlOperations.baglanti.Close();

        }
        float bankaGelir;
        public void bankGelir ()
        {
            SqlOperations.baglanti.Open();
            SqlCommand cmdKontrol3 = new SqlCommand("select gelir from banka where bankaid = 1", SqlOperations.baglanti);

            SqlDataReader oku3 = cmdKontrol3.ExecuteReader();
            while (oku3.Read())
            {
                bankaGelir = Convert.ToSingle(oku3["gelir"]);
            }
            cmdKontrol3.Dispose();
            oku3.Close();
            SqlOperations.baglanti.Close();



        }

        float bankToplamBakiye;
         public void bankaToplamBakiye()
        {
            SqlOperations.baglanti.Open();
            SqlCommand cmdKontrol2 = new SqlCommand("select toplamBakiye from banka ", SqlOperations.baglanti);
            SqlDataReader oku2 = cmdKontrol2.ExecuteReader();

            while (oku2.Read())
            {

                bankToplamBakiye = Convert.ToSingle(oku2["toplamBakiye"]);
            }
         
            cmdKontrol2.Dispose();
            oku2.Close();
            SqlOperations.baglanti.Close();


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            bankaToplamBakiye();
            bankGelir();
            krediOdeme();
            
            SqlOperations.baglanti.Open();
            string query = "UPDATE banka SET gelir = @pgelir,toplamBakiye = @pToplamBakiye where bankaid = 1";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            cmd.Parameters.AddWithValue("@pgelir", bankaGelir + odemeToplam);
            cmd.Parameters.AddWithValue("@pToplamBakiye", bankToplamBakiye + odemeToplam);
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();

            SqlOperations.baglanti.Open();  
            string sorgu = "Select bankaid ,gelir ,gider, kar, toplamBakiye from banka ";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
            SqlOperations.baglanti.Close();

        }
    }
}
