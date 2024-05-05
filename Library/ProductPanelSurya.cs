using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ProductPanelSurya
    {
        public string namaproduk { get; set; }
        public string jenis { get; set; }
        public string idProduk { get; set; }
        public string hargaProduk { get; set; }
        public string panjangProduk { get; set; }
        public string lebarProduk { get; set; }
        public int stokProduk { get; set; }
        public string deskripsiProduk { get; set; }

        public ProductPanelSurya(string id, string nama, string jenis, string harga, string panjang, string lebar, int stok, string deskripsi)
        {
            this.namaproduk = nama;
            this.jenis = jenis;
            this.idProduk = id;
            this.hargaProduk = harga;
            this.panjangProduk = panjang;
            this.lebarProduk = lebar;
            this.stokProduk = stok;
            this.deskripsiProduk = deskripsi;
        }
    }
}
