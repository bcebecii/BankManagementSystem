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
    public partial class ParaTransferi : Form
    {
        public ParaTransferi()
        {
            InitializeComponent();
        }

        private void ParaTransferi_Load(object sender, EventArgs e)
        { 
            lblHesap2Bakiye.Visible = false;
            lblHesap2Kur.Visible = false;
            lblhesap2BakiyeTL.Visible = false;
            lblBakiye.Visible=false;
            lblSeciliBirimKur.Visible = false;
            lblBirimid.Visible = false;
            label10.Visible = false;

            label8.Text = Formİşlemleri.müsteriForm.lblTC.Text;
            SqlOperations.baglanti.Open();
            refreshDataGrid();
            SqlOperations.baglanti.Close();

        }
        public void refreshDataGrid()
        {
            hesapKontrol = 0;
            lblAccID.Text = "";
            string b = Formİşlemleri.müsteriForm.lblTC.Text;
            string sorgu = "Select hesaplar.hesapid,hesaplar.hesapbakiye,birim.birimid, birim.birimAd ,birim.kur,hesaplar.aylikGelir,hesaplar.aylıkGider from musteriler inner join hesaplar on musteriler.musteriid = hesaplar.musteriid inner join birim on hesaplar.birimid = birim.birimid where tc ='" + b + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;


        }

        int seciliHesapID = 0;
        float seciliBakiye = 0;
        int seciliBirimid = 0;
        float seciliBirimKur = 0;
        float seciligider = 0;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
            this.dataGridView1.Columns["birimid"].Visible = false;
            ////
            dataGridView1.ColumnHeadersVisible = false;
            // dgv deki hesapid yi bir labela atadık
            seciliHesapID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["hesapid"].Value);
            lblAccID.Text = seciliHesapID.ToString();
           
            // dgv deki bakiyeyi bir labela atadık.  
            seciliBakiye = Convert.ToSingle(dataGridView1.CurrentRow.Cells["hesapBakiye"].Value);
            lblBakiye.Text = seciliBakiye.ToString();

            // dgv deki birimi bir labela atadık.  
            seciliBirimid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["birimid"].Value);
            lblBirimid.Text = seciliBirimid.ToString();

            // dgv deki kur degerini bir labela atadık.  
            seciliBirimKur = Convert.ToSingle(dataGridView1.CurrentRow.Cells["kur"].Value);
            lblSeciliBirimKur.Text = seciliBirimKur.ToString();

             
            seciligider = Convert.ToInt32(dataGridView1.CurrentRow.Cells["aylıkGider"].Value);
    
        }

   


        int hesapKontrol = 0;

        public void hesapVarmiKontrol()
        {
            SqlOperations.baglanti.Open();


            if (String.IsNullOrEmpty(txtTransferIban.Text))
            {
                MessageBox.Show("Lütfen transfer iban giriniz.");

            }
           
            else
            {
                string kontrolSorgu = "SELECT hesapid FROM hesaplar WHERE hesapid= " + Convert.ToInt32(txtTransferIban.Text) + "";
                SqlCommand cmdKontrol = new SqlCommand(kontrolSorgu, SqlOperations.baglanti);
                SqlDataReader oku = cmdKontrol.ExecuteReader();

                while (oku.Read())
                {
                    hesapKontrol = Convert.ToInt32(oku["hesapid"]);

                }
                label10.Text = hesapKontrol.ToString();
                cmdKontrol.Dispose();
                oku.Close();

            }

            SqlOperations.baglanti.Close();

        }


        float gunBakHesap1;
        float gunBakHesap2;
        float hesapBakiyeHesap2;
        float hesap1BakiyedonusumTL = 0;
        float txtMiktardonusumTL = 0;
        float hesap2BakiyedonusumTL =0;
        float hesap2Kur = 0;
        float hesap2gelir = 0;
        private void button1_Click(object sender, EventArgs e)
        {


            if (seciliHesapID.ToString() != txtTransferIban.Text)
            {

                hesapVarmiKontrol();
                if (String.IsNullOrEmpty(txtMiktar.Text))
                {
                    MessageBox.Show("Lütfen miktar giriniz.");
                }


                else if (hesapKontrol == 0)
                {
                    MessageBox.Show("Girilen iban no sistemde kayıtlı değil");
                }

                else
                {
    
                    if (Convert.ToSingle(txtMiktar.Text) <= Convert.ToSingle(dataGridView1.CurrentRow.Cells["hesapBakiye"].Value))
                    {

                        //burda hesap2nin kur degerini okuyup bir değişkene atamayı deniyosun knk
                        SqlOperations.baglanti.Open();
                        string cmdHesap2Kur = "Select birim.kur from musteriler inner join hesaplar on musteriler.musteriid = hesaplar.musteriid inner join birim on hesaplar.birimid = birim.birimid WHERE hesapid=" + Convert.ToInt32(txtTransferIban.Text) + "";
                        SqlCommand cmd2Hesap2Kur = new SqlCommand(cmdHesap2Kur, SqlOperations.baglanti);
                        SqlDataReader veriOkuu = cmd2Hesap2Kur.ExecuteReader();
                        while (veriOkuu.Read())
                        {
                            hesap2Kur = Convert.ToSingle(veriOkuu["kur"]);
                        }
                  
                        lblHesap2Kur.Text = hesap2Kur.ToString();
                        cmd2Hesap2Kur.Dispose();
                        veriOkuu.Close();
                        SqlOperations.baglanti.Close();

                        //burda hesap2nin bakiye degerini okuyup bir değişkene atamayı deniyosun knk
                        SqlOperations.baglanti.Open();
                        string cmdHesap2Bakiye = "SELECT hesapbakiye FROM hesaplar WHERE hesapid=" + Convert.ToInt32(txtTransferIban.Text) + "";

                        SqlCommand cmd2Hesap2 = new SqlCommand(cmdHesap2Bakiye, SqlOperations.baglanti);

                        SqlDataReader veriOku = cmd2Hesap2.ExecuteReader();
                        while (veriOku.Read())
                        {
                            hesapBakiyeHesap2 = Convert.ToSingle(veriOku["hesapbakiye"]);
                        }

                        lblHesap2Bakiye.Text = hesapBakiyeHesap2.ToString();
                        cmd2Hesap2.Dispose();
                        veriOku.Close();
                        SqlOperations.baglanti.Close();
                        
                        //burada hesap 2 nin gelir degerini okuyup bir degiskene atadik       
                        SqlOperations.baglanti.Open();
                        string cmdHesap2Gelir = "SELECT aylikGelir FROM hesaplar WHERE hesapid=" + Convert.ToInt32(txtTransferIban.Text) + "";
                        SqlCommand cmd2Hesap2g = new SqlCommand(cmdHesap2Gelir, SqlOperations.baglanti);
                        SqlDataReader veriOku2 = cmd2Hesap2g.ExecuteReader();
                        while (veriOku2.Read())
                        {
                            hesap2gelir = Convert.ToSingle(veriOku2["aylikGelir"]);
                        }
                        cmd2Hesap2g.Dispose();
                        veriOku2.Close();
                        SqlOperations.baglanti.Close();                     
                        //----------------------------------


                        //Hesap2 nin para transferi yapılmamış bakiyesinin TL ye donüşümü
                        hesap2BakiyedonusumTL = hesapBakiyeHesap2 /hesap2Kur;
                        lblhesap2BakiyeTL.Text = hesap2BakiyedonusumTL.ToString();           

                        SqlOperations.baglanti.Open();
                        
                        //burda seçili hesap1in bakiyesini ve txtmiktari tl ye donusturup degeri bir degişkende tutuyoruz.
                        hesap1BakiyedonusumTL = (seciliBakiye / seciliBirimKur) - (Convert.ToSingle(txtMiktar.Text) / seciliBirimKur);
                        //lbldonusumtl.Text = hesap1BakiyedonusumTL.ToString();
                        txtMiktardonusumTL = Convert.ToSingle(txtMiktar.Text)/seciliBirimKur;
                        lbldonusumTxtMiktar.Text = txtMiktardonusumTL.ToString();
                        //----------------------------------------------------/
                         
                       
                              

                        SqlCommand commandUpdate = new SqlCommand("UPDATE hesaplar SET hesapbakiye =@pguncelBakiye, aylıkGider=@paylikgider WHERE hesapid =@phesapid", SqlOperations.baglanti);
                   
                        gunBakHesap1 = seciliBakiye - Convert.ToSingle(txtMiktar.Text);
                        commandUpdate.Parameters.AddWithValue("@pguncelBakiye", gunBakHesap1);
                        commandUpdate.Parameters.AddWithValue("@paylikgider", seciligider+Convert.ToSingle(txtMiktar.Text));
                        commandUpdate.Parameters.AddWithValue("@phesapid", seciliHesapID);
                        commandUpdate.ExecuteNonQuery();

                        string cmdHesap2 = "UPDATE hesaplar SET hesapbakiye =@pguncelBakiye, aylikGelir=@pgelirhesap2 WHERE hesapid =@phesapid";
                        SqlCommand cmdUpdateHesap2 = new SqlCommand(cmdHesap2, SqlOperations.baglanti);
                        //secilibakiye ve secilihesapId hesap2 nin bakiyesi olmalı
                        gunBakHesap2 = hesapBakiyeHesap2 + (txtMiktardonusumTL*hesap2Kur);
                        cmdUpdateHesap2.Parameters.AddWithValue("@pguncelBakiye", gunBakHesap2);
                        cmdUpdateHesap2.Parameters.AddWithValue("@pgelirhesap2", hesap2gelir + (txtMiktardonusumTL * hesap2Kur) );
                        cmdUpdateHesap2.Parameters.AddWithValue("@phesapid", Convert.ToInt32(txtTransferIban.Text));
                        cmdUpdateHesap2.ExecuteNonQuery();
                        islemEkle();
                        SqlOperations.baglanti.Close();


                        refreshDataGrid();




                    }
                    else if (Convert.ToSingle(txtMiktar.Text) > Convert.ToSingle(dataGridView1.CurrentRow.Cells["hesapBakiye"].Value))
                    { MessageBox.Show("Yetersiz Bakiye"); }
                    else if (Convert.ToSingle(txtMiktar.Text) <= Convert.ToSingle(dataGridView1.CurrentRow.Cells["hesapBakiye"].Value))
                    { MessageBox.Show("Lütfen geçerli bir tarih giriniz."); }

                }

            }

            else
            {

                MessageBox.Show("Aynı iban no ları arasında transfer işlemi yapılamaz");

            }


        }


        public void islemEkle()
        {
            string query = "Insert into islemler (tcno,kaynakHesapid,hedef,işlemkodu,kaynakBakiye,hedefBakiye,miktar,tarih,islemDurum) values (@ptcno,@pkaynakHesapid,@phedefHesapid,@pislemKodu,@pkaynakBakiye,@phedefBakiye,@pmiktar,@ptarih,@pislemDurum)";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            cmd.Parameters.AddWithValue("@ptcno", label8.Text);
            cmd.Parameters.AddWithValue("@pkaynakHesapid", Convert.ToInt32(lblAccID.Text));
            cmd.Parameters.AddWithValue("@phedefHesapid", Convert.ToInt32(txtTransferIban.Text));
            cmd.Parameters.AddWithValue("@pislemKodu", 3);
            cmd.Parameters.AddWithValue("@pkaynakBakiye", gunBakHesap1);
            cmd.Parameters.AddWithValue("@phedefBakiye", gunBakHesap2);
            cmd.Parameters.AddWithValue("@pmiktar", Convert.ToSingle(txtMiktar.Text));
            cmd.Parameters.AddWithValue("@ptarih", label12.Text);
            cmd.Parameters.AddWithValue("@pislemDurum", 3);
            cmd.ExecuteNonQuery();
            // SqlOperations.baglanti.Close();
        }



        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMiktar.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece rakam giriniz.");
                txtMiktar.Text = txtMiktar.Text.Remove(txtMiktar.Text.Length - 1);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formİşlemleri.transferForm.Hide();
        }

    
    }
}
