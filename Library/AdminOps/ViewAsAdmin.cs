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

                // Menampilkan data produk ke konsol
                foreach (var product in productsFromFile)
                {
                    Console.WriteLine("ID Produk: " + product.idProduk);
                    Console.WriteLine("Nama Produk: " + product.namaproduk);
                    Console.WriteLine("Jenis: " + product.jenis);
                    Console.WriteLine("Harga Produk: " + product.hargaProduk);
                    Console.WriteLine("Panjang Produk: " + product.panjangProduk);
                    Console.WriteLine("Lebar Produk: " + product.lebarProduk);
                    Console.WriteLine("Deskripsi Produk: " + product.deskripsiProduk);
                    Console.WriteLine();
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
   