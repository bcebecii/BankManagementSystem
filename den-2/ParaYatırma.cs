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
    public partial class ParaYatırma : Form
    {
        public ParaYatırma()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ParaYatırma_Load(object sender, EventArgs e)
        {
            lblBakiye.Visible = false;
            SqlOperations.baglanti.Open();
            refreshDataGrid();
            SqlOperations.baglanti.Close();
            label8.Text = Formİşlemleri.müsteriForm.lblTC.Text;
        }


        public void islemEkle()
        {
            string query = "Insert into islemler (tcno,kaynakHesapid,işlemkodu,kaynakBakiye,miktar,tarih,islemDurum) values (@ptcno,@pkaynakHesapid,@pislemKodu,@pkaynakBakiye,@pmiktar,@ptarih,@pislemDurum)";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            cmd.Parameters.AddWithValue("@ptcno", label8.Text);
            cmd.Parameters.AddWithValue("@pkaynakHesapid", Convert.ToInt32(lblSeciliHesapid.Text));
            cmd.Parameters.AddWithValue("@pislemKodu", 2);
            cmd.Parameters.AddWithValue("@pkaynakBakiye", gunBak);
            cmd.Parameters.AddWithValue("@pmiktar", Convert.ToSingle(txtMiktar.Text));
            cmd.Parameters.AddWithValue("@ptarih", label7.Text);
            cmd.Parameters.AddWithValue("@pislemDurum", 3);
            cmd.ExecuteNonQuery();
        }


        public void refreshDataGrid()
        {
            string b = Formİşlemleri.müsteriForm.lblTC.Text;
            string sorgu = "Select hesaplar.hesapid,hesaplar.hesapbakiye,birim.birimid, birim.birimAd ,birim.kur, hesaplar.aylikGelir,hesaplar.aylıkGider from musteriler inner join hesaplar on musteriler.musteriid = hesaplar.musteriid inner join birim on hesaplar.birimid = birim.birimid where tc ='" + b + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;

        }

        int seciliHesapID;
        float seciliBakiye;
        float seciliGelir;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["birimid"].Visible = false;
            dataGridView1.ColumnHeadersVisible = false;
            seciliHesapID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["hesapid"].Value);
            lblSeciliHesapid.Text = seciliHesapID.ToString();
            
           // txtMiktar.Text = dataGridView1.CurrentRow.Cells["hesapbakiye"].Value.ToString();
            seciliBakiye = Convert.ToSingle(dataGridView1.CurrentRow.Cells["hesapBakiye"].Value);
            lblBakiye.Text = seciliBakiye.ToString();

            seciliGelir = Convert.ToSingle(dataGridView1.CurrentRow.Cells["aylikGelir"].Value);


        }



        private void button2_Click(object sender, EventArgs e)
        {
            Formİşlemleri.paraYatirForm.Hide();
        }


        float gunBak;
        private void button1_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtMiktar.Text))
            {
                MessageBox.Show("Lütfen miktar giriniz.");

            }
            else {
              
                    SqlCommand commandUpdate = new SqlCommand("UPDATE hesaplar SET hesapbakiye =@pguncelBakiye, aylikGelir = @pgelir WHERE hesapid =@phesapid", SqlOperations.baglanti);
                    SqlOperations.baglanti.Open();
                    gunBak = seciliBakiye + Convert.ToSingle(txtMiktar.Text);
                    commandUpdate.Parameters.AddWithValue("@pguncelBakiye", gunBak);
                    commandUpdate.Parameters.AddWithValue("@pgelir",seciliGelir+Convert.ToSingle(txtMiktar.Text));
                    commandUpdate.Parameters.AddWithValue("@phesapid", seciliHesapID);

                    commandUpdate.ExecuteNonQuery();
                    islemEkle();
                    refreshDataGrid();
                    SqlOperations.baglanti.Close();
            }
           
      
        }

       private void lblSelect_Click(object sender, EventArgs e)
            {

            }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMiktar.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece rakam giriniz.");
                txtMiktar.Text = txtMiktar.Text.Remove(txtMiktar.Text.Length - 1);

            }
        }
    }
}
