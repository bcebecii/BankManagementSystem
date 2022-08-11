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
    public partial class AylıkÖzet_M : Form
    {
        public AylıkÖzet_M()
        {
            InitializeComponent();
        }

        private void AylıkÖzet_M_Load(object sender, EventArgs e)
        {
            
            
            label3.Text = Formİşlemleri.müsteriForm.lblTC.Text;
            label1.Text = Formİşlemleri.müsteriForm.lblTarih.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int ay = dateTime.Month;
           
            string sorgu = "Select islemler.kaynakHesapid as IBAN, islemler.hedef AS [TRANSFER IBAN], islemler.kaynakBakiye AS Bakiye,kodlar.islemAd as İşlem, islemler.miktar as Tutar, hesaplar.aylikGelir as Gelir,hesaplar.aylıkGider as Gider,kredi.faiz as [Aylık Faiz],kredi.anaPara,islemler.tarih as Tarih from islemler INNER JOIN kodlar on kodlar.kodid = islemler.işlemkodu INNER JOIN hesaplar on hesaplar.hesapid = islemler.kaynakHesapid INNER JOIN kredi on kredi.tc = islemler.tcno where islemler.tarih like '____" + ay+"_____' and islemler.tcno='"+label3.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
