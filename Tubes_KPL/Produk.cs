using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Reflection;

namespace Tubes_KPL
{
    public class Produk
    {
        public string namaproduk { get; set; }
        public string jenis { get; set; }
        public string idProduk { get; set; }
        public string hargaProduk { get; set; }
        public string panjangProduk { get; set; }
        public string lebarProduk { get; set; }
        public string stokProduk { get; set; }
        public string deskripsiProduk { get; set; }

        public Produk(string nama, string jenis, string id, string harga, string panjang, string lebar, string stokProduk, string deskripsi)
        {
            this.namaproduk = nama;
            this.jenis = jenis;
            this.idProduk = id;
            this.hargaProduk = harga;
            this.panjangProduk = panjang;
            this.lebarProduk = lebar;
            this.stokProduk = stokProduk;
            this.deskripsiProduk = deskripsi;
        }

    }
    
}
