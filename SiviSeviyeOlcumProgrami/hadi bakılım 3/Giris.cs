using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hadi_bakılım_3
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = "CihatSÖZEN";
            string parola = "12345";
            if(txtad.Text==kullaniciadi && txtparola.Text == parola)
            {
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("***Kullanıcı Adı veya Parola Hatalı...!","Hatalı...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
            //Form1 frm1 = new Form1(); olmadııııı
            //frm1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            txtparola.UseSystemPasswordChar = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                txtparola.UseSystemPasswordChar = false;

            }
            else
            {
                txtparola.UseSystemPasswordChar = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz...?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tus == DialogResult.Yes)
            {
                Application.Exit();

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Phakkinda frmphakkinda = new Phakkinda();
            frmphakkinda.ShowDialog();
        }
    }
}
