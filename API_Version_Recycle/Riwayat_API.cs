using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API_Version_Recycle
{
    public class Riwayat_API
    {
        //atribut untuk deserialisasi
        public string namaPanel { get; set; }
        public string harga { get; set; }
        public int jumlahBeli { get; set; }

        //constructor kosong untuk deserialisasi
        public Riwayat_API() { }

        public Riwayat_API(string nama_Panel, string Harga, int jumlah_beli)
        {
            this.namaPanel = nama_Panel;
            this.harga = Harga;
            this.jumlahBeli = jumlah_beli;
        }
    }

}