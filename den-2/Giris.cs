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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();


        }
        int l;
        int pass;
        int girilenpas;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(txtBoxTC.Text) || String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Lütfen Bilgileri eksiksiz giriniz");
                }
                else
                {
                    if (comboBox1.Text == "Müşteri")
                    {

                        string a = txtBoxTC.Text;
                        string parola;
                        SqlOperations.baglanti.Open();

                        string sorgu = "Select parola from musteriler where musteriler.tc ='" + a + "'";
                        SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
                        DataTable tablo3 = new DataTable();
                        da.Fill(tablo3);
                        dataGridView1.DataSource = tablo3;
                        parola = tablo3.Rows[0]["parola"].ToString();
                        textBox1.Text = parola;
                        pass = Convert.ToInt32(textBox1.Text);
                        girilenpas = Convert.ToInt32(textBox2.Text);
                        SqlOperations.baglanti.Close();

                        if (pass == girilenpas)
                        {
                            Formİşlemleri.müsteriForm.lblTarih.Text = lbltarih.Text;
                            Formİşlemleri.müsteriForm.lblTC.Text = txtBoxTC.Text;
                            Formİşlemleri.müsteriForm.Show();
                            comboBox1.Text="";
                            textBox2.Text = "";
                            txtBoxTC.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Yanlış Parola veya TC");
                        }

                    }
                    if (comboBox1.Text == "Banka Müdürü")
                    {


                        string a = txtBoxTC.Text;
                        string parola;
                        SqlOperations.baglanti.Open();

                        string sorgu = "Select parola from temsilci where temsilci.tc ='" + a + "'";
                        SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
                        DataTable tablo3 = new DataTable();
                        da.Fill(tablo3);
                        dataGridView1.DataSource = tablo3;
                        parola = tablo3.Rows[0]["parola"].ToString();
                        textBox1.Text = parola;
                        pass = Convert.ToInt32(textBox1.Text);
                        girilenpas = Convert.ToInt32(textBox2.Text);
                        SqlOperations.baglanti.Close();
                        if (pass == girilenpas)
                        {
                            // this.Hide();
                            Formİşlemleri.bankaMuduruForm.lblTarih.Text = lbltarih.Text;
                            Formİşlemleri.bankaMuduruForm.Show();
                            comboBox1.Text = "";
                            textBox2.Text = "";
                            txtBoxTC.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Yanlış parola veya TC../nBilgilerinizi kontrol ediniz...");
                        }


                    }
                    if (comboBox1.Text == "Müşteri Temsilcisi")
                    {
                        string a = txtBoxTC.Text;
                        string parola;
                        SqlOperations.baglanti.Open();

                        string sorgu = "Select parola from temsilci where temsilci.tc ='" + a + "'";
                        SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
                        DataTable tablo3 = new DataTable();
                        da.Fill(tablo3);
                        dataGridView1.DataSource = tablo3;
                        parola = tablo3.Rows[0]["parola"].ToString();
                        textBox1.Text = parola;
                        pass = Convert.ToInt32(textBox1.Text);
                        girilenpas = Convert.ToInt32(textBox2.Text);
                        SqlOperations.baglanti.Close();
                        if (pass == girilenpas)
                        {
                            // this.Hide();
                            Formİşlemleri.temsilciForm.lblTarih.Text = lbltarih.Text;
                            Formİşlemleri.temsilciForm.temsilciTC.Text = txtBoxTC.Text;
                            Formİşlemleri.temsilciForm.Show();
                            comboBox1.Text = "";
                            textBox2.Text = "";
                            txtBoxTC.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Yanlış parola veya TC../nBilgilerinizi kontrol ediniz...");
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlOperations.baglanti.Close();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Formİşlemleri.kayitOlForm.lblTarihKayit.Text = lbltarih.Text;
            Formİşlemleri.kayitOlForm.ShowDialog();

        }


        public void Giris_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible= false;
            textBox1.Visible = false;
            // bugunun tarihini atadik 
            DateTime dt = DateTime.Now;
            lbltarih.Text = dt.ToShortDateString();

            comboBox1.Items.Add("Banka Müdürü");
            comboBox1.Items.Add("Müşteri Temsilcisi");
            comboBox1.Items.Add("Müşteri");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}