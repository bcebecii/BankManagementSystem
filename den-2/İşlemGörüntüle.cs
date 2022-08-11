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
    public partial class İşlemGörüntüle : Form
    {
        public İşlemGörüntüle()
        {
            InitializeComponent();
        }

            

        private void button1_Click(object sender, EventArgs e)
        {
            string b = Formİşlemleri.müsteriForm.lblTC.Text;
            string sorgu = "Select islemid, tcno,kaynakHesapid, hedef, işlemkodu,kaynakBakiye,hedefBakiye,miktar,tarih from islemler ";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox1.Text);
                
            string b = Formİşlemleri.müsteriForm.lblTC.Text;
            string sorgu = " select TOP " + k+ "islemid, tcno,kaynakHesapid, hedef, işlemkodu,kaynakBakiye,hedefBakiye,miktar,tarih from islemler order by islemid DESC ";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
             

        }

        private void İşlemGörüntüle_Load(object sender, EventArgs e)
        {
                
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
