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
    public partial class Temsilci : Form
    {
        public Temsilci()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Formİşlemleri.temsilciForm.Hide();
            Formİşlemleri.girisForm.Show();
        }
      
        int musteriSayisi = 0;
       
        private void Temsilci_Load(object sender, EventArgs e)
        {
          //Temsilci formu yüklendiginde giriş yapan temsilciye ait müşterilerin sayısı muterisayisi degiskeninde tutulur.
            SqlOperations.baglanti.Open();
            string sorgu = "Select ISNULL(Count(musteriler.temsilciid),0) as sayi From musteriler INNER JOIN temsilci ON musteriler.temsilciid=temsilci.temsilciid where temsilci.tc=@tc"; 
            SqlCommand cmd = new SqlCommand(sorgu,SqlOperations.baglanti);
            cmd.Parameters.AddWithValue("@tc",Formİşlemleri.temsilciForm.temsilciTC.Text);   
            SqlDataReader veriOku = cmd.ExecuteReader();
            while (veriOku.Read())
            {
                musteriSayisi = Convert.ToInt16(veriOku["sayi"]);
            }
            lblMusteriSayisi.Text = musteriSayisi.ToString();
            cmd.Dispose();
            veriOku.Close();
            SqlOperations.baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formİşlemleri.mustEkleTems.lblTarih.Text = lblTarih.Text;
            Formİşlemleri.mustEkleTems.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Formİşlemleri.MBGuncelleForm.lblTarih.Text =lblTarih.Text;
            Formİşlemleri.MBGuncelleForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriDurum_T musteriDurum = new MusteriDurum_T();
            musteriDurum.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formİşlemleri.musteriTalep.label2.Text= lblTarih.Text;
            Formİşlemleri.musteriTalep.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            İşlemGörüntüle_T islem = new İşlemGörüntüle_T();
            islem.Show();

        
        }
    }
}
