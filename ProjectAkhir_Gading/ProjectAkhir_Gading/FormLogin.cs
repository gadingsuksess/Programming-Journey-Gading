using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir_Gading
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Membuat Username dan Password untuk kasir cerdas ini
            string namebenar = "bosgading";
            string passwordbenar = "buka";

            // Mengambil input dari user 
            string nameinput = txtnama.Text;
            string passwordinput = txtpassword.Text;

            // Validasi login
            if (namebenar == nameinput && passwordbenar == passwordinput) 
            {
               MessageBox.Show("Login berhasil!", "Information",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membuka form1 / form menu utama
                Form1 formmenu = new Form1();
                formmenu.Show();
                this.Hide();
            }
            else
            {
                // Jika login gagal
                MessageBox.Show("Username atau sandi salah coba ulangi lagi", "Eror",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Membersihkan file password
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }
    }
}
