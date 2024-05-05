using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AdminOps
{
    public class ViewAsAdmin
    {
        UIapp ui = new UIapp();
        public void viewProduct()
        {
            // Lokasi file JSON
            string filePath = @"./ProductsSolarPanels.json";

            try
            {
                // Membaca seluruh teks dari file JSON
                string json = File.ReadAllText(filePath);

                // Deserialisasi JSON menjadi array objek
                List<ProductPanelSurya> productsFromFile = JsonConvert.DeserializeObject<List<ProductPanelSurya>>(json);

                ui.DaftarProduk();
                // Menampilkan data produk ke konsol
                int I = 1;
                foreach (var product in productsFromFile)
                {
                    Console.WriteLine($"Produk {I} : ");
                    Console.WriteLine("ID Produk: " + product.idProduk);
                    Console.WriteLine("Nama Produk: " + product.namaproduk);
                    Console.WriteLine("Jenis: " + product.jenis);
                    Console.WriteLine("Harga Produk: Rp" + product.hargaProduk);
                    Console.WriteLine("Panjang Produk: " + product.panjangProduk + " mm");
                    Console.WriteLine("Lebar Produk: " + product.lebarProduk + " mm");
                    Console.WriteLine("Stok tersedia: " + product.stokProduk + " Unit");
                    Console.WriteLine("Deskripsi Produk: " + product.deskripsiProduk);
                    Console.WriteLine();
                    I++;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File tidak ditemukan.");
            }
            catch (System.Text.Json.JsonException)
            {
                Console.WriteLine("Format JSON tidak valid.");
            }
        }
    }
}
   