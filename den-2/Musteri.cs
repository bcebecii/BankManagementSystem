using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace den_2
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Formİşlemleri.müsteriForm.Hide();
        }

        private void Müsteri_Load(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formİşlemleri.mGuncelle.label3.Text = lblTarih.Text; 
            //this.Hide();
            Formİşlemleri.mGuncelle.ShowDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formİşlemleri.hSilmeForm.label3.Text = lblTarih.Text;
            //   this.Hide();
            Formİşlemleri.hSilmeForm.ShowDialog();
            
        }

        private void lblTC_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formİşlemleri.paraCekForm.label7.Text = lblTarih.Text;
            Formİşlemleri.paraCekForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formİşlemleri.paraYatirForm.label7.Text = lblTarih.Text;
            Formİşlemleri.paraYatirForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Formİşlemleri.hesapAcma.label6.Text = lblTarih.Text;
            Formİşlemleri.hesapAcma.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formİşlemleri.transferForm.label12.Text = lblTarih.Text;
            Formİşlemleri.transferForm.ShowDialog();    
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formİşlemleri.krediTalep.label6.Text = lblTarih.Text;   
            Formİşlemleri.krediTalep.ShowDialog();
        }

        private void lblTarih_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AylıkÖzet_M ozet = new AylıkÖzet_M();
            ozet.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formİşlemleri.krediOdeme.labelTarih.Text = lblTarih.Text;
            Formİşlemleri.krediOdeme.ShowDialog();

        }
    }
}