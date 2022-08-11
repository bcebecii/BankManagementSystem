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
    public partial class mguncelle : Form
    {
        public mguncelle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string guncelle = " update musteriler set adSoyad = '" + gAD.Text + "',telefon='" + gTelefon.Text +"',adres='" + gAdres.Text + "',ePosta='" + gEposta.Text + "' where tc = '" + label8.Text + "'";
            SqlCommand cmd = new SqlCommand(guncelle, SqlOperations.baglanti);
            SqlOperations.baglanti.Open();
            cmd.ExecuteNonQuery();
            SqlOperations.baglanti.Close();
            refreshDataGrid();

        }

      
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            gAD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            gTelefon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            gAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            gEposta.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

       
        public void refreshDataGrid()
        {
            label8.Text = Formİşlemleri.müsteriForm.lblTC.Text;
            SqlOperations.baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select adSoyad as [Ad Soyad],telefon as Telefon,tc as TC,adres as Adres,ePosta as [E-Posta] from musteriler where tc = '" + label8.Text + "'", SqlOperations.baglanti);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            SqlOperations.baglanti.Close();

        }
        
        
        
        private void mguncelle_Load(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formİşlemleri.mGuncelle.Hide();
        }

        private void gAdres_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    }
    

