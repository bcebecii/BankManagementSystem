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
    public partial class MusteriListele_BM : Form
    {
      
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-KQ2VGPK;Initial Catalog=den2;Integrated Security=True");
        public MusteriListele_BM()
        {
            InitializeComponent();
        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlOperations.baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from musteriler", SqlOperations.baglanti);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            SqlOperations.baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Formİşlemleri.mustListFormMudur.Hide();
        }
    }
}
