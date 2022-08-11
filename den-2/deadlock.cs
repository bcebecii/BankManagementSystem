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
    public partial class deadlock : Form
    {
        public deadlock()
        {
            InitializeComponent();
        }
        
        private void deadlock_Load(object sender, EventArgs e)
        {   dataGridView2.Visible = false;
           
            SqlOperations.baglanti.Open();
            string b = Formİşlemleri.müsteriForm.lblTC.Text;
            string sorgu = "Select islemid,kaynakHesapid, hedef,kodlar.islemAd,tarih from islemler inner join kodlar on islemler.işlemKodu=kodlar.kodid where işlemKodu="+4+" OR işlemKodu="+3+" ";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
            string sorgu2 = "Select count(islemid) as sayi from islemler  where  işlemKodu=" + 4 + " OR işlemKodu=" + 3 + " ";
            SqlDataAdapter da2 = new SqlDataAdapter(sorgu2, SqlOperations.baglanti);
            DataTable tablo4 = new DataTable();
            da.Fill(tablo4);
            SqlCommand cmd = new SqlCommand(sorgu2, SqlOperations.baglanti);
            dataGridView2.DataSource = tablo4;
            cmd.Parameters.AddWithValue("sayi",textBox1.Text);
            object sonuc = cmd.ExecuteScalar();
            textBox1.Text = sonuc != null ? sonuc.ToString() : "0";
            SqlOperations.baglanti.Close();


        }
    }
}
