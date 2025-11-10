using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectAkhir_Gading
{
    public partial class Form1 : Form
    {
        int jumlahpesanan = 0;
        // Membuat Array untuk nama pesanan,jumlah menu,harga menu
        string[] namapesanan = new string[6];
        int[] jumlahmenu = new int[6];
        int[] hargamenu = new int[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblnama_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Memberikan inisialisasi tampilan awal
            lblnamapesanan1.Text = "";
            lblnamapesanan2.Text = "";
            lblnamapesanan3.Text = "";
            lblnamapesanan4.Text = "";
            lblnamapesanan5.Text = "";
            lblnamapesanan6.Text = "";

            lbljumlahbeli1.Text = "";
            lbljumlahbeli2.Text = "";
            lbljumlahbeli3.Text = "";
            lbljumlahbeli4.Text = "";
            lbljumlahbeli5.Text = "";
            lbljumlahbeli6.Text = "";

            lblhasil1.Text = "";
            lblhasil2.Text = "";
            lblhasil3.Text = "";
            lblhasil4.Text = "";
            lblhasil5.Text = "";
            lblhasil6.Text = "";

            btntambah1.Text = "";
            btntambah2.Text = "";
            btntambah3.Text = "";
            btntambah4.Text = "";
            btntambah5.Text = "";
            btntambah6.Text = "";

            btnkurang1.Text = "";
            btnkurang2.Text = "";
            btnkurang3.Text = "";
            btnkurang4.Text = "";
            btnkurang5.Text = "";
            btnkurang6.Text = "";

            // Kosongkan label hasil total
            lblhasiltotal.Text = "";

            // Kosongkan label hasil kembalian
            lblhkembalian.Text = "";

            // Membuat tampilan awal button (+) dan (-) tidak kelihatan garis - garis kotak
            btntambah1.FlatStyle = FlatStyle.Flat;
            btntambah1.FlatAppearance.BorderSize = 0;
            btntambah2.FlatStyle = FlatStyle.Flat;
            btntambah2.FlatAppearance.BorderSize = 0;
            btntambah3.FlatStyle = FlatStyle.Flat;
            btntambah3.FlatAppearance.BorderSize = 0;
            btntambah4.FlatStyle = FlatStyle.Flat;
            btntambah4.FlatAppearance.BorderSize = 0;
            btntambah5.FlatStyle = FlatStyle.Flat;
            btntambah5.FlatAppearance.BorderSize = 0;
            btntambah6.FlatStyle = FlatStyle.Flat;
            btntambah6.FlatAppearance.BorderSize = 0;

            btnkurang1.FlatStyle = FlatStyle.Flat;
            btnkurang1.FlatAppearance.BorderSize = 0;
            btnkurang2.FlatStyle = FlatStyle.Flat;
            btnkurang2.FlatAppearance.BorderSize = 0;
            btnkurang3.FlatStyle = FlatStyle.Flat;
            btnkurang3.FlatAppearance.BorderSize = 0;
            btnkurang4.FlatStyle = FlatStyle.Flat;
            btnkurang4.FlatAppearance.BorderSize = 0;
            btnkurang5.FlatStyle = FlatStyle.Flat;
            btnkurang5.FlatAppearance.BorderSize = 0;
            btnkurang6.FlatStyle = FlatStyle.Flat;
            btnkurang6.FlatAppearance.BorderSize = 0;

            // Mengatur tampilan awal agar tombol (+) dan (-) tidak bisa digunakan / dijalankan
            btntambah1.Enabled = false;
            btntambah2.Enabled = false;
            btntambah3.Enabled = false;
            btntambah4.Enabled = false;
            btntambah5.Enabled = false;
            btntambah6.Enabled = false;
            btnkurang1.Enabled = false;
            btnkurang2.Enabled = false;
            btnkurang3.Enabled = false;
            btnkurang4.Enabled = false;
            btnkurang5.Enabled = false;
            btnkurang6.Enabled = false;

            // Membuat kolom data grid view
            dgvpenjualan.Columns.Clear();

            dgvpenjualan.Columns.Add("colnama", "Nama Pembeli");
            dgvpenjualan.Columns.Add("coltotal", "Total Harga");


        }
        // Membuat fungsi untuk menambah pesanan di daerah keranjang
        void tambahpesanan(string nama, int harga)  
        {
            // Akan memeriksa apakah menu yang dipilih sudah ada di keranjang atau belum
            for (int i = 0; i < jumlahpesanan; i++) // Melakukan loop selama i = 0 sampai kurang dari jumlah pesanan yang sudah tersimpan
            {
                if (namapesanan[i] == nama) // Jika nama pesanan yang ada di array sama dengan nama pesanan yang dipilih kasih peringatan
                {
                    MessageBox.Show("Menu sudah ada di keranjang!", "PERINGATAN",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Menghentikan fungsi tambahpesanan jika menu sudah ada di keranjang
                }
            }
            if (jumlahpesanan < 6) // Maksimal 6 pesanan
            {
                jumlahpesanan++; // Menggunakan Increment untuk menambah jumlah pesanan sebelumnya 0 menjadi 1 setelah dijalankan
                int index = jumlahpesanan - 1; // Digunakan untuk pada index jika jumalh pesanan = 1 maka index = 0

                // index yang akan menentukan data di array
                namapesanan[index] = nama;
                jumlahmenu[index] = 1;
                hargamenu[index] = harga;

                if (index == 0) // Pesanan 1
                {
                    lblnamapesanan1.Text = namapesanan[index];
                    lbljumlahbeli1.Text = jumlahmenu[index].ToString();
                    lblhasil1.Text = "Rp. " + hargamenu[index].ToString("N0");
                    btntambah1.Text = "+";
                    btnkurang1.Text = "-";
                    btntambah1.FlatStyle = FlatStyle.Standard;
                    btntambah1.FlatAppearance.BorderSize = 1;
                    btnkurang1.FlatStyle = FlatStyle.Standard;
                    btnkurang1.FlatAppearance.BorderSize = 1;
                    btntambah1.Enabled = true;
                    btnkurang1.Enabled = true;
                    totalharga(); // Memanggil fungsi total harga agar ketika menu diklik langsung muncul total harga

                }
                else if (index == 1) // Pesanan 2
                {
                    lblnamapesanan2.Text = namapesanan[index];
                    lbljumlahbeli2.Text = jumlahmenu[index].ToString();
                    lblhasil2.Text = "Rp. " + hargamenu[index].ToString("N0");
                    btntambah2.Text = "+";
                    btnkurang2.Text = "-";
                    btntambah2.FlatStyle = FlatStyle.Standard;
                    btntambah2.FlatAppearance.BorderSize = 1;
                    btnkurang2.FlatStyle = FlatStyle.Standard;
                    btnkurang2.FlatAppearance.BorderSize = 1;
                    btntambah2.Enabled = true;
                    btnkurang2.Enabled = true;
                    totalharga(); // Memanggil fungsi total harga agar ketika menu diklik langsung muncul total harga   
                }
                else if (index == 2) // Pesanan 3
                {
                    lblnamapesanan3.Text = namapesanan[index];
                    lbljumlahbeli3.Text = jumlahmenu[index].ToString();
                    lblhasil3.Text = "Rp. " + hargamenu[index].ToString("N0");
                    btntambah3.Text = "+";
                    btnkurang3.Text = "-";
                    btntambah3.FlatStyle = FlatStyle.Standard;
                    btntambah3.FlatAppearance.BorderSize = 1;
                    btnkurang3.FlatStyle = FlatStyle.Standard;
                    btnkurang3.FlatAppearance.BorderSize = 1;
                    btntambah3.Enabled = true;
                    btnkurang3.Enabled = true;
                    totalharga(); // Memanggil fungsi total harga agar ketika menu diklik langsung muncul total harga         
                }
                else if (index == 3) // Pesanan 4
                {
                    lblnamapesanan4.Text = namapesanan[index];
                    lbljumlahbeli4.Text = jumlahmenu[index].ToString();
                    lblhasil4.Text = "Rp. " + hargamenu[index].ToString("N0");
                    btntambah4.Text = "+";
                    btnkurang4.Text = "-";
                    btntambah4.FlatStyle = FlatStyle.Standard;
                    btntambah4.FlatAppearance.BorderSize = 1;
                    btnkurang4.FlatStyle = FlatStyle.Standard;
                    btnkurang4.FlatAppearance.BorderSize = 1;
                    btntambah4.Enabled = true;
                    btnkurang4.Enabled = true;
                    totalharga(); // Memanggil fungsi total harga agar ketika menu diklik langsung muncul total harga     
                }
                else if (index == 4) // Pesanan 5
                {
                    lblnamapesanan5.Text = namapesanan[index];
                    lbljumlahbeli5.Text = jumlahmenu[index].ToString();
                    lblhasil5.Text = "Rp. " + hargamenu[index].ToString("N0");
                    btntambah5.Text = "+";
                    btnkurang5.Text = "-";
                    btntambah5.FlatStyle = FlatStyle.Standard;
                    btntambah5.FlatAppearance.BorderSize = 1;
                    btnkurang5.FlatStyle = FlatStyle.Standard;
                    btnkurang5.FlatAppearance.BorderSize = 1;
                    btntambah5.Enabled = true;
                    btnkurang5.Enabled = true;
                    totalharga(); // Memanggil fungsi total harga agar ketika menu diklik langsung muncul total harga
                }
                else if (index == 5) // Pesanan 6
                {
                    lblnamapesanan6.Text = namapesanan[index];
                    lbljumlahbeli6.Text = jumlahmenu[index].ToString();
                    lblhasil6.Text = "Rp. " + hargamenu[index].ToString("N0");
                    btntambah6.Text = "+";
                    btnkurang6.Text = "-";
                    btntambah6.FlatStyle = FlatStyle.Standard;
                    btntambah6.FlatAppearance.BorderSize = 1;
                    btnkurang6.FlatStyle = FlatStyle.Standard;
                    btnkurang6.FlatAppearance.BorderSize = 1;
                    btntambah6.Enabled = true;
                    btnkurang6.Enabled = true;
                    totalharga(); // Memanggil fungsi total harga agar ketika menu diklik langsung muncul total harga
                }
            }
        }
        // Membuat Fungsi untuk mengoperasikan perhitungan jumlah menu yang dibeli dikali harga menu
        double totalharga()
        {
            double total = 0;
            for (int i = 0; i < jumlahpesanan; i++) // Melakukan loop selama i = 0 sampai kurang dari jumlah pesanan
            {
                // Membuat operasi perhitungan total harga per menu 
                total += hargamenu[i] * jumlahmenu[i];
            }
            // Hasil semua total harga pemesanan
            lblhasiltotal.Text = "Rp. " + total.ToString("N0");
            return total; // Berfungsi untuk mengirim hasil total ke bagian lainnya
        }

        private void pnlmenuutama_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scroolbalmenu_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            // Menampilkan semua item food dan drink
            gbayamgoreng.Visible = true;
            gbayambakar.Visible = true;
            gblele.Visible = true;
            gbbebekgoreng.Visible = true;
            gbesteh.Visible = true;
            gbtehhangat.Visible = true;

            // Agar sehabis pindah menu dari drink ke home posisi item drink kembali kebawah
            gbesteh.Location = new Point(40, 998);
            gbtehhangat.Location = new Point(510, 998);
        }

        private void btnfood_Click(object sender, EventArgs e)
        {
            // Menampilkan item food/menampilkan group box makanan
            gbayamgoreng.Visible = true;
            gbayambakar.Visible = true;
            gblele.Visible = true;
            gbbebekgoreng.Visible = true;

            // Menyembunyikan item drink/menyembunyikan group box minuman
            gbesteh.Visible = false;
            gbtehhangat.Visible = false;


        }

        private void btndrink_Click(object sender, EventArgs e)
        {
            // Menampilkan item drink/menampilkan group box minuman
            gbesteh.Visible = true;
            gbtehhangat.Visible = true;

            // Menyembunyikan item food/menyembunyikan group box makanan
            gbayamgoreng.Visible = false;
            gbayambakar.Visible = false;
            gblele.Visible = false;
            gbbebekgoreng.Visible = false;

            // Mengatur posisi agar item drink naik keatas
            gbesteh.Location = new Point(40, 23);
            gbtehhangat.Location = new Point(510, 23);
        }

        private void btnayamg_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi dari main (string nama, int harga)
            tambahpesanan("Ayam Goreng + Nasi", 10000); //Pemanggilan fungsi untuk menu Ayam goreng + Nasi
        }

        private void gbpembelian_Enter(object sender, EventArgs e)
        {

        }

        private void btntambah1_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 1 pada tanda ( + ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[0] < 100)
            {
                jumlahmenu[0]++;
                lbljumlahbeli1.Text = jumlahmenu[0].ToString();
                lblhasil1.Text = "Rp. " + (jumlahmenu[0] * hargamenu[0]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }



        }

        private void btnkurang1_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 1 pada tanda ( - ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[0] > 1)
            {
                jumlahmenu[0]--;
                lbljumlahbeli1.Text = jumlahmenu[0].ToString();
                lblhasil1.Text = "Rp. " + (jumlahmenu[0] * hargamenu[0]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }
        }

        private void btnayamb_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi dari main (string nama, int harga)
            tambahpesanan("Ayam Bakar + Nasi", 13000); //Pemanggilan fungsi untuk menu Ayam Bakar + Nasi
        }

        private void btnbebekg_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi dari main (string nama, int harga)
            tambahpesanan("Bebek Goreng + Nasi", 15000); //Pemanggilan fungsi untuk menu Bebek Goreng + Nasi
        }

        private void btnlele_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi dari main (string nama, int harga)
            tambahpesanan("Lele + Nasi", 8000); //Pemanggilan fungsi untuk menu Lele + Nasi
        }

        private void btnesteh_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi dari main (string nama, int harga)
            tambahpesanan("Es Teh", 3000); //Pemanggilan fungsi untuk menu Es teh
        }

        private void btntehhangat_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi dari main (string nama, int harga)
            tambahpesanan("Teh Hangat", 3000); //Pemanggilan fungsi untuk menu Teh Hangat
        }

        private void btntambah2_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 2 pada tanda ( + ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[1] < 100)
            {
                jumlahmenu[1]++;
                lbljumlahbeli2.Text = jumlahmenu[1].ToString();
                lblhasil2.Text = "Rp. " + (jumlahmenu[1] * hargamenu[1]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }

        }

        private void btnkurang2_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 2 pada tanda ( - ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[1] > 1)
            {
                jumlahmenu[1]--;
                lbljumlahbeli2.Text = jumlahmenu[1].ToString();
                lblhasil2.Text = "Rp. " + (jumlahmenu[1] * hargamenu[1]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }


        }

        private void btntambah3_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 3 pada tanda ( + ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[2] < 100)
            {
                jumlahmenu[2]++;
                lbljumlahbeli3.Text = jumlahmenu[2].ToString();
                lblhasil3.Text = "Rp. " + (jumlahmenu[2] * hargamenu[2]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }

        }

        private void btnkurang3_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 3 pada tanda ( - ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[2] > 1)
            {
                jumlahmenu[2]--;
                lbljumlahbeli3.Text = jumlahmenu[2].ToString();
                lblhasil3.Text = "Rp. " + (jumlahmenu[2] * hargamenu[2]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }

        }

        private void btntambah4_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 4 pada tanda ( + ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[3] < 100)
            {
                jumlahmenu[3]++;
                lbljumlahbeli4.Text = jumlahmenu[3].ToString();
                lblhasil4.Text = "Rp. " + (jumlahmenu[3] * hargamenu[3]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }

        }

        private void btnkurang4_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 4 pada tanda ( - ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[3] > 1)
            {
                jumlahmenu[3]--;
                lbljumlahbeli4.Text = jumlahmenu[3].ToString();
                lblhasil4.Text = "Rp. " + (jumlahmenu[3] * hargamenu[3]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }

        }

        private void btntambah5_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 5 pada tanda ( + ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[4] < 100)
            {
                jumlahmenu[4]++;
                lbljumlahbeli5.Text = jumlahmenu[4].ToString();
                lblhasil5.Text = "Rp. " + (jumlahmenu[4] * hargamenu[4]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }

        }

        private void btnkurang5_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 5 pada tanda ( - ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[4] > 1)
            {
                jumlahmenu[4]--;
                lbljumlahbeli5.Text = jumlahmenu[4].ToString();
                lblhasil5.Text = "Rp. " + (jumlahmenu[4] * hargamenu[4]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }

        }

        private void btntambah6_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 6 pada tanda ( + ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[5] < 100)
            {
                jumlahmenu[5]++;
                lbljumlahbeli6.Text = jumlahmenu[5].ToString();
                lblhasil6.Text = "Rp. " + (jumlahmenu[5] * hargamenu[5]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }

        }

        private void btnkurang6_Click(object sender, EventArgs e)
        {
            // Mengoperasikan button pesanan 6 pada tanda ( - ) agar ketika diklik dapat berfungsi
            if (jumlahmenu[5] > 1)
            {
                jumlahmenu[5]--;
                lbljumlahbeli6.Text = jumlahmenu[5].ToString();
                lblhasil6.Text = "Rp. " + (jumlahmenu[5] * hargamenu[5]).ToString("N0");
                //  Memanggil fungsi dari main ()
                totalharga(); // Pemanggilan fungsi total harga
            }

        }

        private void btnselesai_Click(object sender, EventArgs e)
        {
            double total = totalharga(); // Memanggil fungsi total harga
            double bayar = 0;
            double kembalian = 0;

        while (!double.TryParse(tbxbayar.Text,out bayar) && string.IsNullOrWhiteSpace(tbxnama.Text))
            {
                MessageBox.Show("Masukkan nama dan uang bayar!", "EROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Ambil nilai dari textbox bayar
            while (!double.TryParse(tbxbayar.Text, out bayar))
            {
                MessageBox.Show("Masukkan angka yang benar untuk uang bayar!", "EROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;            
            }
            while (string.IsNullOrWhiteSpace(tbxnama.Text))
            {
                MessageBox.Show("Masukkan nama pembeli!", "EROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Hitung uang kembalian
            kembalian = bayar - totalharga();
            
            // Tampilkan hasil ke label
            if (kembalian < 0)
            {
                // jika uang kurang
                lblhkembalian.Text = "Uang kurang Rp. " + Math.Abs(kembalian)
                    .ToString("N0"); lblhkembalian.ForeColor = Color.Red;
                MessageBox.Show("Maaf uang kurang!", "EROR",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // jika uang cukup/lebih + dapat kembalian
                lblhkembalian.Text = "Rp. " + kembalian.ToString("N0");lblhkembalian.ForeColor = Color.Green;
                MessageBox.Show("Terimakasih uang kembalian Rp. " + kembalian.ToString("N0"), "INFORMATION",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ambil data dari form
                string nama = tbxnama.Text;
                double uangbayar = double.Parse(tbxbayar.Text);


                // Bersihkan struk
                rtbstruk.Clear();

                // Membuat struk pembayaran
                rtbstruk.AppendText("===== RUMAH MAKAN GADING =====\n");
                rtbstruk.AppendText("               STRUK PEMBAYARAN\n");
                rtbstruk.AppendText("------------------------------\n");
                rtbstruk.AppendText($"Atas Nama : {nama}\n");
                rtbstruk.AppendText("------------------------------\n");

                // Membuat perulangan for untuk menampilkan semua pesanan    
                for (int i = 0; i < jumlahpesanan; i++)
                {
                    // Menampilkan nama pesanan, jumlah menu, dan harga per menu
                    rtbstruk.AppendText($"{namapesanan[i]} {jumlahmenu[i]} = " +
                        $"Rp. {(hargamenu[i] * jumlahmenu[i]).ToString("N0")}\n");
                }
                // Menampilkan total harga, uang bayar, dan kembalian
                rtbstruk.AppendText("------------------------------\n");
                rtbstruk.AppendText($"Total Harga : Rp. {total.ToString("N0")}\n");
                rtbstruk.AppendText($"Uang Bayar  : Rp. {uangbayar.ToString("N0")}\n");
                rtbstruk.AppendText($"Kembalian   : Rp. {kembalian.ToString("N0")}\n");

                rtbstruk.AppendText("------------------------------\n");
                rtbstruk.AppendText("===== TERIMA KASIH SUDAH MEMESAN =====\n");
                return;
            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {

        }
        // Fungsi untuk mengupdate tampilan jumlah beli dan total harga setiap menu
        void updatetampilanmenu()
        {
            // Fungsi ini khusus untuk btnreset

            // kosongkan label nama pesanan
            lblnamapesanan1.Text = "";
            lblnamapesanan2.Text = "";
            lblnamapesanan3.Text = "";
            lblnamapesanan4.Text = "";
            lblnamapesanan5.Text = "";
            lblnamapesanan6.Text = "";

            // Mengubah jumlah menu menjadi seperti jumlah menu awal  
            lbljumlahbeli1.Text = "";
            lbljumlahbeli2.Text = "";
            lbljumlahbeli3.Text = "";
            lbljumlahbeli4.Text = "";
            lbljumlahbeli5.Text = "";
            lbljumlahbeli6.Text = "";

            // Mengubah lblhasil (harga tiap menu) menjadi seperti menu awal
            lblhasil1.Text = "";
            lblhasil2.Text = "";
            lblhasil3.Text = "";
            lblhasil4.Text = "";
            lblhasil5.Text = "";
            lblhasil6.Text = "";

            // Membuat tampilan (+) dan (-) menjadi hilang
            btntambah1.Text = "";
            btntambah2.Text = "";
            btntambah3.Text = "";
            btntambah4.Text = "";
            btntambah5.Text = "";
            btntambah6.Text = "";

            btnkurang1.Text = "";
            btnkurang2.Text = "";
            btnkurang3.Text = "";
            btnkurang4.Text = "";
            btnkurang5.Text = "";
            btnkurang6.Text = "";

            // Kosongkan label hasil total
            lblhasiltotal.Text = "";


            // Membuat tampilan button (+) dan (-) tidak kelihatan garis-garis kotak dan kembali seperti menu awal
            btntambah1.FlatStyle = FlatStyle.Flat;
            btntambah1.FlatAppearance.BorderSize = 0;
            btntambah2.FlatStyle = FlatStyle.Flat;
            btntambah2.FlatAppearance.BorderSize = 0;
            btntambah3.FlatStyle = FlatStyle.Flat;
            btntambah3.FlatAppearance.BorderSize = 0;
            btntambah4.FlatStyle = FlatStyle.Flat;
            btntambah4.FlatAppearance.BorderSize = 0;
            btntambah5.FlatStyle = FlatStyle.Flat;
            btntambah5.FlatAppearance.BorderSize = 0;
            btntambah6.FlatStyle = FlatStyle.Flat;
            btntambah6.FlatAppearance.BorderSize = 0;

            btnkurang1.FlatStyle = FlatStyle.Flat;
            btnkurang1.FlatAppearance.BorderSize = 0;
            btnkurang2.FlatStyle = FlatStyle.Flat;
            btnkurang2.FlatAppearance.BorderSize = 0;
            btnkurang3.FlatStyle = FlatStyle.Flat;
            btnkurang3.FlatAppearance.BorderSize = 0;
            btnkurang4.FlatStyle = FlatStyle.Flat;
            btnkurang4.FlatAppearance.BorderSize = 0;
            btnkurang5.FlatStyle = FlatStyle.Flat;
            btnkurang5.FlatAppearance.BorderSize = 0;
            btnkurang6.FlatStyle = FlatStyle.Flat;
            btnkurang6.FlatAppearance.BorderSize = 0;

            // Mereset tombol (+) dan (-) agar tidak bisa digunakan / dijalankan seperti tampilan awal
            btntambah1.Enabled = false;
            btntambah2.Enabled = false;
            btntambah3.Enabled = false;
            btntambah4.Enabled = false;
            btntambah5.Enabled = false;
            btntambah6.Enabled = false;
            btnkurang1.Enabled = false;
            btnkurang2.Enabled = false;
            btnkurang3.Enabled = false;
            btnkurang4.Enabled = false;
            btnkurang5.Enabled = false;
            btnkurang6.Enabled = false;
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            // Kosongkan semua textbox
            tbxnama.Text = "";
            tbxbayar.Text = "";

            // Kosongkan label hasil total dan kembalian
            lblhasiltotal.Text = "";
            lblhkembalian.Text = "";


            // Kosongkan jumlah pesanan
            for (int i = 0; i < jumlahpesanan; i++)
            {
                jumlahmenu[i] = 0; // Reset jumlah pesanan di array
            }

            // Panggil fungsi update tampilan 
            updatetampilanmenu();

            // panggil jumlahpesanan agar pesanan bisa direset dan pesanan dapat dimulai dari pesanan 1
            jumlahpesanan = 0;


            rtbstruk.Clear(); // Mengosongkan struk juga

            // Pesan Konfirmasi
            MessageBox.Show("Form berhasil direset!", "INFORMASI",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvpenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvpenjualan.Columns.Add("colnama", "Nama Pembeli"); // nama colom di code, // teks yang ditampilkan
            dgvpenjualan.Columns.Add("coltotal", "Total Harga");

        }

        private void btntambahdata_Click(object sender, EventArgs e)
        {
            string nama = tbxnama.Text;
            double total = totalharga(); // Memanggil fungsi total harga
            int pilihan = 1; // variabel pilihan di set ke 1 (tindakan yang akan dilakukan di switch)

            // Membuat informasi untuk tombol tambah data agar tidak dapat diklik sebelum mengisi nama dan total harga
            if (nama == "" || total == 0)
            {
                MessageBox.Show("Nama dan total harga harus diisi!", "PERINGATAN",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return;
            }

            do
            {
                switch (pilihan) // switch hanya akan masuk ke case 1
                {
                    case 1: // Tambahkan baris ke Data Grid View
                        dgvpenjualan.Rows.Add(nama, total.ToString("N0"));

                        pilihan = 0 // loop berhenti setelah 1 kali
                                ; break;
                    default: // Nilai tidak dikenal berhenti juga
                        pilihan = 0;
                        break;
                }
            } while (pilihan != 0); // Jalankan perintah didalam do-while minimal sekali,
                                    // lalu ulang lagi selama pilihan tidak sama dengan 0

        }

        private void btnresetdata_Click(object sender, EventArgs e)
        {
            // Reset semua data di Data Grid View atau menghapus semua baris
            dgvpenjualan.Rows.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ketika mengklik btnlogin akan pindah ke menu login
            FormLogin formlogin = new FormLogin();
            formlogin.Show(); // Menampilkan form login
            this.Hide(); // Menyembunyikan form utama
        }

        private void dgvpenjualan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            // Membuat fitur untuk keluar dari aplikasi
            // Konfirmasi sebelum keluar dari aplikasi
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?",
                "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) // Jika user memilih Yes
            {
                Application.Exit(); // Keluar dari aplikasi
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Jika ingin menghapus salah satu baris atau data pada data grid view
            if (dgvpenjualan.CurrentRow != null) // Memeriksa apakah ada baris yang dipilih
            {
                dgvpenjualan.Rows.RemoveAt(dgvpenjualan.CurrentRow.Index); // Menghapus baris yang dipilih
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus! ", "INFORMASI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); // Memberikan informasi jika tidak ada baris yang dipilih
            }
        }

        private void btncetakstruk_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (rtbstruk.Text == "")
            {
                MessageBox.Show("Struk kosong, tidak dapat mencetak!", "PERINGATAN",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Membuat fitur print struk pembayaran
            printPreviewDialogjualan.Document = printDocumentjualan;
            printPreviewDialogjualan.ShowDialog();
        }

        private void printDocumentjualan_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Mengatur font untuk isi struk
            Font isi = new Font("Arial", 12, FontStyle.Regular);

            // Mengatur posisi awal untuk mencetak teks
            int y = 20;
            
            // Cetak isi dari rtbstruk
            string[] lines = rtbstruk.Text.Split('\n');
            foreach (string line in lines)
            {
                e.Graphics.DrawString(line, isi, Brushes.Black, 10, y); 
                y += 20; // Jarak antar baris
            }           
        }
    }
}
