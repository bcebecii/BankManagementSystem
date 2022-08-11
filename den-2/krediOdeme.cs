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
using System.Runtime.InteropServices;
namespace den_2
{
    public partial class krediOdeme : Form
    {
        public krediOdeme()
        {
            InitializeComponent();
        }
        String tc;

        public void kredilerim()
        {
            tc = Formİşlemleri.müsteriForm.lblTC.Text;
            SqlOperations.baglanti.Open();
            string sorgu = "Select kredi.tc,kredi.krediid,kredi.hesapid,kredi.krediMiktar,kredi.onayTarih,kredi.vade From kredi inner join hesaplar on kredi.hesapid=hesaplar.hesapid inner join musteriler on musteriler.tc=kredi.tc where musteriler.tc =" + tc + " AND krediDurum='" + 1 + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo4 = new DataTable();
            da.Fill(tablo4);
            dataGridView1.DataSource = tablo4;

            SqlOperations.baglanti.Close();
        }
        double faizOran;
        double gFaizOran;
        public void faizler()
        {
            SqlOperations.baglanti.Open();
            string query = "Select faizOrani From faizler";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(query, SqlOperations.baglanti);
            DataTable tablo4 = new DataTable();
            da.Fill(tablo4);
            dataGridView2.DataSource = tablo4;
            faiz.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
            gfaiz.Text = dataGridView2.Rows[1].Cells[0].Value.ToString();
            faizOran = Convert.ToDouble(faiz.Text);
            gFaizOran = Convert.ToDouble(gfaiz.Text);
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
        }
        int id;
        public void idBul()
        {
            SqlOperations.baglanti.Open();
            tc = Formİşlemleri.müsteriForm.lblTC.Text;
            string sorgu = "Select musteriid,tc From musteriler Where tc= '" + tc + "'";
            SqlCommand cmd = new SqlCommand(sorgu, SqlOperations.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo4 = new DataTable();
            da.Fill(tablo4);
            dataGridView3.DataSource = tablo4;
            textBox10.Text = tablo4.Rows[0]["musteriid"].ToString();
            id = Convert.ToInt32(textBox10.Text);


            SqlOperations.baglanti.Close();
        }
        double borc;
        double borcFaiz;
        double vade;
        double aylık;

        public void borcum()
        {
            borc = Convert.ToDouble(textBox3.Text);
            borcFaiz = borc * (faizOran / 100);
            vade = Convert.ToDouble(textBox8.Text);
            textBox9.Text = borcFaiz.ToString();
            borc = (borc + borcFaiz);
            textBox7.Text = borc.ToString();
            aylık = borc / vade;
            textBox6.Text = aylık.ToString();


        }
        public void tabloyaEkleme()
        {

            string guncelle = "update kredi set faiz= '" + borcFaiz + "',krediBorcu='" + textBox3.Text + "' where tc = '" + tc + "'AND krediid='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(guncelle, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();


        }

        float hesappBakiye = 0;

        public void hesapbakiy()
        {
            SqlOperations.baglanti.Open();
            string kontrolSorgu = "SELECT hesapBakiye FROM hesaplar WHERE hesapid= " + Convert.ToInt32(textBox2.Text) + "";
            SqlCommand cmdKontrol = new SqlCommand(kontrolSorgu, SqlOperations.baglanti);
            SqlDataReader oku = cmdKontrol.ExecuteReader();

            while (oku.Read())
            {
                hesappBakiye = Convert.ToSingle(oku["hesapBakiye"]);

            }
            cmdKontrol.Dispose();
            oku.Close();
            SqlOperations.baglanti.Close();
        }


        public void hesabaYansitma()
        {

            SqlOperations.baglanti.Open();
            SqlCommand commandUpdate = new SqlCommand("UPDATE hesaplar SET hesapBakiye =@pbakiye WHERE hesapid =@phesapid", SqlOperations.baglanti);

            commandUpdate.Parameters.AddWithValue("@pbakiye", hesappBakiye - Convert.ToSingle(textBox5.Text));
            commandUpdate.Parameters.AddWithValue("@phesapid", Convert.ToInt32(textBox2.Text));
            commandUpdate.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
        }



        public void krediOdeme_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            gfaiz.Visible = false;
            faiz.Visible = false;

            dateTimePicker1.MinDate = DateTime.Now;
            idBul();
            faizler();
            kredilerim();
            bGelir();
            borcum();
            tabloyaEkleme();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        double odemee = 0;
        double gelir;
        double gBakiye;

        public void bGelir()
        {
            SqlOperations.baglanti.Open();
            string sorgu = "Select gelir from banka where bankaid ='" + 1 + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo5 = new DataTable();
            da.Fill(tablo5);
            dataGridView5.DataSource = tablo5;
            textBox12.Text = tablo5.Rows[0]["gelir"].ToString();
            gelir = Convert.ToDouble(textBox12.Text);
            SqlOperations.baglanti.Close();


        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapbakiy();


            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Lütfen Ödenecek Kredi Miktarı Giriniz");
            }

            else if (Convert.ToSingle(textBox5.Text) > hesappBakiye)
            {

                MessageBox.Show("Hesapta yeterli bakiye yoktur");
            }
            else
            {
                hesabaYansitma();

                SqlOperations.baglanti.Open();
                string b = Formİşlemleri.müsteriForm.lblTC.Text;
                string sorgu = "Select hesaplar.hesapbakiye,hesapid from hesaplar  where hesapid ='" + textBox2.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
                DataTable tablo5 = new DataTable();
                da.Fill(tablo5);
                dataGridView4.DataSource = tablo5;
                textBox11.Text = tablo5.Rows[0]["hesapbakiye"].ToString();
                // hesappBakiye = Convert.ToSingle(textBox11.Text);
                odemee = Convert.ToDouble(textBox5.Text);
                gBakiye = hesappBakiye - odemee;
                SqlOperations.baglanti.Close();

            }


            SqlOperations.baglanti.Open();
            string query = "Insert into islemler (tcno,kaynakHesapid,hedef,işlemkodu,kaynakBakiye,miktar,tarih,islemDurum) values (@ptcno,@pkaynakHesapid,@phedef,@pislemKodu,@pkaynakBakiye,@pmiktar,@ptarih,@pislemDurum)";
            SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
            cmd.Parameters.AddWithValue("@ptcno", tc);
            cmd.Parameters.AddWithValue("@pkaynakHesapid", Convert.ToInt32(textBox2.Text));
            //hedef kredı ıd
            cmd.Parameters.AddWithValue("@phedef", 4);
            cmd.Parameters.AddWithValue("@pislemKodu", 4);
            cmd.Parameters.AddWithValue("@pkaynakBakiye", textBox11.Text);
            cmd.Parameters.AddWithValue("@pmiktar", textBox5.Text);
            cmd.Parameters.AddWithValue("@ptarih", labelTarih.Text);
            cmd.Parameters.AddWithValue("@pislemDurum", 2);
            cmd.ExecuteNonQuery();
            textBox14.Text = gBakiye.ToString();


            SqlOperations.baglanti.Close();


        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}