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
    public partial class BankaMuduru : Form
    {
        public BankaMuduru()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formİşlemleri.mustListFormMudur.label2.Text = lblTarih.Text;
            Formİşlemleri.mustListFormMudur.Show();

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            //Formİşlemleri.girisForm.label4.Text = Formİşlemleri.bankaMuduruForm.label3.Text;
     
            Formİşlemleri.girisForm.Visible = true;
            Formİşlemleri.bankaMuduruForm.Visible = false;
        

        }
       
        private void BankaMuduru_Load(object sender, EventArgs e)
        {     
            label4.Visible = false;
      
        }

       

        public void mustGelirgiderSifirla() {

            SqlOperations.baglanti.Open();
            string query = "UPDATE hesaplar SET aylikGelir= 0,aylıkGider = 0 where hesapDurum = 1";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);  
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();

        }
        
        
        float temsilciSayisi = 0;
        float temMaas = 0;
       
    
        public void temsilciSay()
        {
            SqlOperations.baglanti.Open();
            string kontrolSorgu = "SELECT count(temsilciid) as toplamTemsilci FROM temsilci  where temsilciid <> 2"; 
            SqlCommand cmdKontrol = new SqlCommand(kontrolSorgu, SqlOperations.baglanti);
            
            SqlDataReader oku = cmdKontrol.ExecuteReader();
            
            while (oku.Read())
            {
                temsilciSayisi = Convert.ToInt32(oku["toplamTemsilci"]);
           
            }  
            cmdKontrol.Dispose();
 
            oku.Close();
           
            SqlOperations.baglanti.Close(); 
        }
       
      
        public void temsilciMaas()
        {
            SqlOperations.baglanti.Open();
            string kontrolSorgu = "SELECT miktar FROM maas where maasKodu =1";
            SqlCommand cmdKontrol = new SqlCommand(kontrolSorgu, SqlOperations.baglanti);
            SqlDataReader oku = cmdKontrol.ExecuteReader();
            while (oku.Read())
            {
                temMaas = Convert.ToSingle(oku["miktar"]);

            }
            cmdKontrol.Dispose();
            oku.Close();
            SqlOperations.baglanti.Close();

        }

        float bankGider = 0;
        float bankToplamBakiye;
      
        public void banka()
        {
            SqlOperations.baglanti.Open();
            SqlCommand cmdKontrol2 = new SqlCommand("select toplamBakiye from banka ", SqlOperations.baglanti);
            SqlDataReader oku2 = cmdKontrol2.ExecuteReader();

            while (oku2.Read())
            {
             
                bankToplamBakiye = Convert.ToSingle(oku2["toplamBakiye"]);
            }     
            label4.Text = bankToplamBakiye.ToString();
            cmdKontrol2.Dispose();
            oku2.Close();
            SqlOperations.baglanti.Close();
            //---------------------------------------------------------------
            SqlOperations.baglanti.Open();
            SqlCommand cmdKontrol3 = new SqlCommand("select gider from banka where bankaid = 1",SqlOperations.baglanti);

            SqlDataReader oku3 = cmdKontrol3.ExecuteReader();
            while (oku3.Read())
            {
                bankGider = Convert.ToSingle(oku3["gider"]);
            }    
            cmdKontrol3.Dispose();
            oku3.Close();
            SqlOperations.baglanti.Close();
           
            //---------------------------------------------------------------
            SqlOperations.baglanti.Open();
            string query = "UPDATE banka SET gider = @pgider,toplamBakiye = @pToplamBakiye where bankaid = 1";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            cmd.Parameters.AddWithValue("@pgider", bankGider + (temsilciSayisi*temMaas));
            cmd.Parameters.AddWithValue("@pToplamBakiye",bankToplamBakiye- (temsilciSayisi * temMaas));
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();



        }

        public static int a =0;
        private void button5_Click(object sender, EventArgs e)
            {
            temsilciSay();
            temsilciMaas();
            mustGelirgiderSifirla();
            banka();


                a++;
                DateTime tarih = DateTime.Now.AddMonths(a);
                label3.Text = tarih.ToShortDateString().ToString();
                Formİşlemleri.girisForm.lbltarih.Text = tarih.ToShortDateString();
   
                MessageBox.Show("Sistem 1 ay ileri alındı.\nTemsilci maaşları yattı.\nMüşteri gelir ve giderleri sıfırlandı");
  
        }
        private void button7_Click(object sender, EventArgs e)
        {
            temsilciSay();
            temsilciMaas();
            SqlOperations.baglanti.Open();
            SqlCommand cmdKontrol2 = new SqlCommand("select toplamBakiye from banka where bankaid = 1", SqlOperations.baglanti);
            SqlDataReader oku2 = cmdKontrol2.ExecuteReader();

            while (oku2.Read())
            {

                bankToplamBakiye = Convert.ToSingle(oku2["toplamBakiye"]);
            }
            cmdKontrol2.Dispose();
            oku2.Close();
            SqlOperations.baglanti.Close();
            //---------------------------------------------------------------
            SqlOperations.baglanti.Open();
            SqlCommand cmdKontrol3 = new SqlCommand("select gider from banka where bankaid = 1", SqlOperations.baglanti);

            SqlDataReader oku3 = cmdKontrol3.ExecuteReader();
            while (oku3.Read())
            {
                bankGider = Convert.ToSingle(oku3["gider"]);
            }
            cmdKontrol3.Dispose();
            oku3.Close();
            SqlOperations.baglanti.Close();

            //---------------------------------------------------------------
            SqlOperations.baglanti.Open();
            string query = "UPDATE banka SET gider = @pgider,toplamBakiye = @pToplamBakiye where bankaid = 1";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            cmd.Parameters.AddWithValue("@pgider", bankGider - (temsilciSayisi * temMaas));
            cmd.Parameters.AddWithValue("@pToplamBakiye", bankToplamBakiye + (temsilciSayisi * temMaas));
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();

            a--;
            DateTime tarih = DateTime.Now.AddMonths(a);
            label3.Text = tarih.ToShortDateString().ToString();
            Formİşlemleri.girisForm.lbltarih.Text = tarih.ToShortDateString();   
            MessageBox.Show("Sistem 1 ay geri alındı.");

        }


        private void button2_Click(object sender, EventArgs e)
        {

            Formİşlemleri.kur.label9.Text = lblTarih.Text;
            Formİşlemleri.kur.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formİşlemleri.personelislemForm.label11.Text = lblTarih.Text;
            Formİşlemleri.personelislemForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formİşlemleri.mustEkleMudur.label7.Text = lblTarih.Text;
            Formİşlemleri.mustEkleMudur.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {
          Formİşlemleri.islemGoruntule.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BankaGenelDurum bankDurum = new BankaGenelDurum();
            bankDurum.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formİşlemleri.deadlock.label1.Text = lblTarih.Text;
            Formİşlemleri.deadlock.Show();
        }
    }
}
