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

namespace QuizMahasiswa
{
    public partial class MasterBarang008 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-54HD65JO\ELORA;Initial Catalog=QuizMahasiswa;Integrated Security=True;Pooling=False");
        public MasterBarang008()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        void LoadData()
        {
            var st = from tb in db.tbl_barangs select tb;
            dataGridView1.DataSource = st;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_barang = txtbarang.Text;
            int harga = int.Parse(txtHarga.Text);
            int stok = int.Parse(txtStock.Text);
            string nama_supplier = txtSupplier.Text;

            var data = new tbl_barang
            {
                nama_barang = nama_barang,
                harga = harga,
                stok = stok,
                nama_supplier = nama_supplier
            };
            db.tbl_barangs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Successfully");
            txtbarang.Text = "";
            txtHarga.Text = "";
            txtStock.Text = "";
            txtSupplier.Text = "";
            LoadData();
        }

        private void MasterBarang008_Load(object sender, EventArgs e)
        {

        }
    }
}
