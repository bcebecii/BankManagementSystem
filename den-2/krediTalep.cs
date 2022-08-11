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
    public partial class krediTalep : Form
    {
        public krediTalep()
        {
            InitializeComponent();
        }
        String b;
        public void listeleme()
        {
            b= Formİşlemleri.müsteriForm.lblTC.Text;
            string sorgu = "Select hesapid as IBAN,birimid,hesapbakiye as Bakiye from musteriler inner join hesaplar on musteriler.musteriid = hesaplar.musteriid where tc ='" + b + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
           
            

        }

        private void krediTalep_Load(object sender, EventArgs e)
        {
            label5.Text = Formİşlemleri.müsteriForm.lblTC.Text;
           
            listeleme();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="1")
            {  
                if(String.IsNullOrEmpty(textBox4.Text)||String.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Lütfen Miktar ve Vade Bilgilerini Eksiksiz Doldurunuz");
               
                }
                else
                {
                    SqlOperations.baglanti.Open();
                    string day = Formİşlemleri.krediTalep.label6.Text;
                    string query = "Insert into kredi (tc,hesapid,krediMiktar,onayTarih,krediDurum) values (@ptc,@phesapid,@pkrediMiktar,@ponayTarih,@pkrediDurum)";
                    SqlCommand cmd = new SqlCommand(query, SqlOperations.baglanti);
                    //  SqlOperations.baglanti.Open();
                    cmd.Parameters.AddWithValue("@ptc",b);
                    cmd.Parameters.AddWithValue("@phesapid", Convert.ToInt32(textBox1.Text));
                    cmd.Parameters.AddWithValue("@pkrediMiktar", Convert.ToInt32(textBox4.Text));
                    cmd.Parameters.AddWithValue("@ponayTarih",Convert.ToString(day));
                    cmd.Parameters.AddWithValue("@pkrediDurum",2);
                    cmd.ExecuteNonQuery();
                    SqlOperations.baglanti.Close();
                    MessageBox.Show("Kredi talebiniz alındı");
                }
               
            }
            else
            {
                MessageBox.Show("Kredi Başvurusu sadece TL cinsinden yapılabilir");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
