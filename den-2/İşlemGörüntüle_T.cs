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
    public partial class İşlemGörüntüle_T : Form
    {
        public İşlemGörüntüle_T()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            string b = Formİşlemleri.müsteriForm.lblTC.Text;
            string sorgu = "Select islemler.islemid,temsilci.temsilciid, musteriler.musteriid,islemler.kaynakHesapid, islemler.hedef,kodlar.islemAd ,islemler.kaynakBakiye,islemler.hedefBakiye,islemler.miktar,islemler.tarih From musteriler INNER JOIN temsilci ON musteriler.temsilciid=temsilci.temsilciid INNER JOIN islemler ON musteriler.tc = islemler.tcno INNER JOIN kodlar on kodlar.kodid = islemler.işlemkodu where temsilci.tc ='" + label1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);         
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
        }

        private void İşlemGörüntüle_T_Load(object sender, EventArgs e)
        {
            label1.Text = Formİşlemleri.temsilciForm.temsilciTC.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
