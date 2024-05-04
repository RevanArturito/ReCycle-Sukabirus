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
        public string deskripsiProduk { get; set; }

        public Produk(string nama, string jenis, string id, string harga, string panjang, string lebar, string deskripsi)
        {
            this.namaproduk = nama;
            this.jenis = jenis;
            this.idProduk = id;
            this.hargaProduk = harga;
            this.panjangProduk = panjang;
            this.lebarProduk = lebar;
            this.deskripsiProduk = deskripsi;
        }
/*      public void TambahProduk()
        {
            //*string filePath = "D:\\codingan\\Tubes_KPL\\Tubes_KPL\\Produk.json";
            //string jsonString = File.ReadAllText(filePath);
            // Serialisasi list produk ke dalam JSON
            //jsonString = JsonConvert.SerializeObject(daftarProduk, Formatting.Indented);

            // Tulis JSON ke dalam file
            //File.WriteAllText(namaFile, jsonString);
            //const string FilePath = @"./Testing.json";
            const string FilePath = @"./Produk.json";
            //List<Produk> acc = new List<Product>();
            //acc.Add(new Product(inputNama, inputHarga));
            //acc.Add(new Product("nama3", "nama3"));
            // acc.Add(new Product("nama5", "nama5"));
            string nama, ID, jenis, harga, panjang, lebar, deskripsi;
            Console.WriteLine("Masukkan Data Baru:");
            Console.Write("Nama: ");
            nama = Console.ReadLine();
            Console.Write("ID: ");
            ID = Console.ReadLine();
            Console.Write("Jenis: ");
            jenis = Console.ReadLine();
            Console.Write("Harga: ");
            harga = Console.ReadLine();
            Console.Write("Panjang: ");
            panjang = Console.ReadLine();
            Console.Write("Lebar: ");
            lebar = Console.ReadLine();
            Console.Write("Deskripsi: ");
            deskripsi = Console.ReadLine();
            List<Produk> acc = new List<Produk>();
            acc.Add(nama, jenis, ID, harga, panjang, lebar, deskripsi);

            var HasilKonversi = JsonConvert.SerializeObject(acc);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };


            FileStream fileStream = new FileStream(@"./Produk.json", FileMode.Create);
            using (StreamWriter write = new StreamWriter(fileStream))
            {
                write.Write(HasilKonversi);
            }
            string filePath = "D:\\codingan\\Tubes_KPL\\Tubes_KPL\\bin\\Debug\\net8.0\\Produk.json";
            try
            {
                // Membaca seluruh teks dari file JSON
                string json = File.ReadAllText(filePath);

                // Deserialisasi JSON menjadi array objek
                var produk = JsonConvert.DeserializeObject<Produk[]>(json);

                // Menampilkan data produk ke konsol
                foreach (var Produk in produk)
                {
                    Console.WriteLine("Nama Produk: " + Produk.namaproduk);
                    Console.WriteLine("Jenis: " + Produk.jenis);
                    Console.WriteLine("ID Produk: " + Produk.idProduk);
                    Console.WriteLine("Harga Produk: " + Produk.hargaProduk);
                    Console.WriteLine("Panjang Produk: " + Produk.panjangProduk);
                    Console.WriteLine("Lebar Produk: " + Produk.lebarProduk);
                    Console.WriteLine("Deskripsi Produk: " + Produk.deskripsiProduk);
                    Console.WriteLine();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File tidak ditemukan.");
            }
            catch (System.Text.Json.JsonException)
            {
                Console.WriteLine("Format JSON tidak valid.");
            }

        }
    */

    }
    
}
