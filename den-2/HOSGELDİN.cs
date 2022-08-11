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
    public partial class HOSGELDİN : Form
    {
        public HOSGELDİN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             this.Hide();
            Formİşlemleri.girisForm.Show();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
           
           
        }

        private void HOSGELDİN_Load(object sender, EventArgs e)
        {

        }
    }
}
