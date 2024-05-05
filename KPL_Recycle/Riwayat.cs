using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace KPL_Recycle
{
    public class Riwayat
    {
        public class History
        {
            //atribut untuk deserialisasi
            public string namaPanel { get; set; }
            public string harga { get; set; }
            public int jumlahBeli { get; set; }

            //constructor kosong untuk deserialisasi
            public History() { }

            public History(string nama_Panel, string Harga, int jumlah_beli)
            {
                this.namaPanel = nama_Panel;
                this.harga = Harga;
                this.jumlahBeli = jumlah_beli;
            }
            public class RiwayatConfig
            {
                public History[] configurations;

                public const string filePath = "D:\\VS\\KPL_Recycle\\KPL_Recycle\\riwayat.json";

                public RiwayatConfig()
                {
                    ReadConfigFile();
                }

                private void ReadConfigFile()
                {
                    string configJsonData = File.ReadAllText(filePath);
                    configurations = JsonSerializer.Deserialize<History[]>(configJsonData);
                }

                public void ReadJSON()
                {
                    Console.WriteLine("========== Riwayat Transaksi ==========");
                    Console.WriteLine(" | Nama Panel |" + " | Harga | " + " | Jumlah Dibeli | ");
                    Console.WriteLine("--------------------------------------------");

                    foreach (var config in configurations)
                    {
                        Console.WriteLine($"  {config.namaPanel}   {config.harga}          {config.jumlahBeli}");
                    }

                    Console.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}