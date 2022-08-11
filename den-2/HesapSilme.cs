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
    public partial class HesapSilme : Form
    {
        public HesapSilme()
        {
            InitializeComponent();
        }

        public void hesapidBul()
        {
            SqlOperations.baglanti.Open();
            string a = Formİşlemleri.müsteriForm.lblTC.Text;
            string sorgu = "Select musteriler.musteriid,hesaplar.hesapid,hesaplar.hesapbakiye,hesaplar.hesapDurum,hesaplar.birimid from musteriler inner join hesaplar on musteriler.musteriid = hesaplar.musteriid  where musteriler.tc ='" + a + "'AND hesapDurum='" + 1 + "'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;

            SqlOperations.baglanti.Close();
        }

        private void HesapSilme_Load(object sender, EventArgs e)
        {
            lblTC.Text = Formİşlemleri.müsteriForm.lblTC.Text;
            hesapidBul();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formİşlemleri.hSilmeForm.Hide();
        }

        int hesapid;
        int sayi;
        double bakiye;
        private void button1_Click(object sender, EventArgs e)
        {
            bakiye = Convert.ToDouble(textBox3.Text);
            if (bakiye > 0)
            {
                MessageBox.Show("Bakiyesi 0 olmayan hesap silinemez");
            }
            if (bakiye == 0)
            {
                textBox3.Text = "0";
                sayi = Convert.ToInt16(textBox3.Text);
                hesapid = Convert.ToInt16(textBox2.Text);
                SqlOperations.baglanti.Open();
                string sorgu2 = " Update hesaplar set hesaplar.hesapDurum='" + sayi + "',hesaplar.musteriid='" + textBox1.Text + "',hesaplar.birimid='" + textBox4.Text + "'where hesaplar.hesapid='" + hesapid + "'";
                SqlCommand cmd = new SqlCommand(sorgu2, SqlOperations.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(sorgu2, SqlOperations.baglanti);
                DataTable tablo2 = new DataTable();
                da.Fill(tablo2);
                SqlOperations.baglanti.Close();
                MessageBox.Show("Hesap silme talebiniz alındı");
                hesapidBul();
            }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}