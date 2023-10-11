using FoodXYZ.Controllers;
using FoodXYZ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Views
{
    public partial class FormKasir : Form
    {
        FoodxyzDbContext context = new FoodxyzDbContext();

        AuthController authController = new AuthController();
        
        List<keranjang> keranjang;

        public FormKasir()
        {
            InitializeComponent();
        }

        private void queryKeranjang()
        {
            dgvKeranjang.DataSource = keranjang;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            authController.logout();
            this.Hide();
            (new FormLogin()).Show();
        }

        private void FormKasir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodxyzDataSet.tbl_transaksi' table. You can move, or remove it, as needed.
            this.tbl_transaksiTableAdapter.Fill(this.foodxyzDataSet.tbl_transaksi);

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }
    }
}
