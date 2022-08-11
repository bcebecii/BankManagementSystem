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
    public partial class MusteriDurum_T : Form
    {
        public MusteriDurum_T()
        {
            InitializeComponent();
        }

        private void MusteriDurum_T_Load(object sender, EventArgs e)
        {
            label4.Text = Formİşlemleri.temsilciForm.temsilciTC.Text;
            Musteri();

            

        }

        float toplamBak = 0; 
        public void toplamBakiye()
        {
            SqlOperations.baglanti.Open();
            string kontrolSorgu = " Select sum(hesapbakiye/kur) as toplam from musteriler inner join hesaplar on musteriler.musteriid = hesaplar.musteriid inner join birim on hesaplar.birimid = birim.birimid where hesaplar.musteriid ="+ seciliMusteriID +"";
            SqlCommand cmdKontrol = new SqlCommand(kontrolSorgu, SqlOperations.baglanti);
            SqlDataReader oku = cmdKontrol.ExecuteReader();

            while (oku.Read())
            {
                toplamBak = Convert.ToSingle(oku["toplam"]);

            }
            label7.Text = toplamBak.ToString();
            cmdKontrol.Dispose();
            oku.Close();

            SqlOperations.baglanti.Close();


        }

        float toplamGel = 0;
        public void toplamGelir ()
        {
            SqlOperations.baglanti.Open();
            string kontrolSorgu = " Select sum(aylikGelir/kur) as toplam from musteriler inner join hesaplar on musteriler.musteriid = hesaplar.musteriid inner join birim on hesaplar.birimid = birim.birimid where hesaplar.musteriid =" + seciliMusteriID + "";
            SqlCommand cmdKontrol = new SqlCommand(kontrolSorgu, SqlOperations.baglanti);
            SqlDataReader oku = cmdKontrol.ExecuteReader();
            while (oku.Read())
            {
                toplamGel = Convert.ToSingle(oku["toplam"]);

            }
            label12.Text = toplamGel.ToString();
            cmdKontrol.Dispose();
            oku.Close();
            SqlOperations.baglanti.Close();


        }

        float toplamGid = 0;
        public void toplamGider()
        {


        }
       
        
        public void Musteri()
        {
            string sorgu = "SELECT musteriler.musteriid ,musteriler.adSoyad , temsilci.tc FROM musteriler RIGHT JOIN hesaplar on hesaplar.musteriid = musteriler.musteriid INNER JOIN temsilci on temsilci.temsilciid = musteriler.temsilciid WHERE temsilci.tc ="+ label4.Text +"  group by musteriler.musteriid, temsilci.tc, musteriler.adSoyad" ;
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView2.DataSource = tablo3;

        }
        public void musteriHesaplari()
        {
            string sorgu = "Select hesaplar.hesapid,hesaplar.hesapbakiye,birim.birimAd ,birim.kur,hesaplar.aylikGelir,hesaplar.aylıkGider from musteriler inner join hesaplar on musteriler.musteriid = hesaplar.musteriid inner join birim on hesaplar.birimid = birim.birimid where hesaplar.hesapDurum = 1 and hesaplar.musteriid ="+ seciliMusteriID +"";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView3.DataSource = tablo3;

        }

   


        int seciliMusteriID = 0;
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

            //this.dataGridView1.Columns["birimid"].Visible = false;
               seciliMusteriID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["musteriid"].Value);
               label3.Text = seciliMusteriID.ToString();


            musteriHesaplari();
            toplamBakiye();
            toplamGelir();
        }


        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
