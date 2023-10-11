using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodXYZ.Models
{
    class keranjang
    {
        public string id_transaksi { get; set; }
        public string kode_barang { get; set; }
        public string nama_barang { get; set; }
        public string harga_satuan { get; set; }
        public string kuantitas { get; set; }
        public string subtotal { get; set; }
    }
}
