using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMahasiswa
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterBarang008 MB = new MasterBarang008();
            MB.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportBarang011 RP = new ReportBarang011();
            RP.Show();
        }
    }
}
