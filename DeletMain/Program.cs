using DeletMain;
using Library;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        List<ProductPanelSurya> products = new List<ProductPanelSurya>();
        string filePath = @"./ProductsSolarPanels.json";
        string json = File.ReadAllText(filePath);

        // Deserialisasi JSON menjadi array objek
        List<ProductPanelSurya> productsFromFile = JsonConvert.DeserializeObject<List<ProductPanelSurya>>(json);

        int J = 1;
        Console.WriteLine("Daftar item:");
        Console.WriteLine("");
        foreach (var product in productsFromFile)
        {
            Console.WriteLine($"Produk {J}");
            Console.WriteLine("ID Produk: " + product.idProduk);
            Console.WriteLine("Nama Produk: " + product.namaproduk);
            Console.WriteLine("Jenis: " + product.jenis);
            Console.WriteLine("Harga Produk: " + product.hargaProduk);
            Console.WriteLine("Panjang Produk: " + product.panjangProduk);
            Console.WriteLine("Lebar Produk: " + product.lebarProduk);
            Console.WriteLine("Deskripsi Produk: " + product.deskripsiProduk);
            Console.WriteLine();
            J++;
        }

        Console.WriteLine("Masukkan indeks item yang ingin dihapus:");

        
        // Membaca input dari pengguna
        string input = Console.ReadLine();
        

        // Konversi input menjadi bilangan bulat
        int index;
        if (int.TryParse(input, out index))
        {
            index = index - 1;
            // Membuat instance dari kelas DeletAsAdmin dengan list itemsList
            DeletAsAdmin<ProductPanelSurya> deletableList = new DeletAsAdmin<ProductPanelSurya>(productsFromFile);

            // Memanggil metode DeleteByIndex untuk menghapus item dari list berdasarkan indeks yang dimasukkan oleh pengguna
            deletableList.DeleteByIndex(index);

            // Tampilkan isi list setelah penghapusan
            Console.WriteLine("Setelah dihapus:");
               Console.WriteLine(" ");
            Console.WriteLine("Daftar item:");
            int I = 1;
            foreach (var product in productsFromFile)
            {
                Console.WriteLine($"Produk {I}");
                Console.WriteLine("ID Produk: " + product.idProduk);
                Console.WriteLine("Nama Produk: " + product.namaproduk);
                Console.WriteLine("Jenis: " + product.jenis);
                Console.WriteLine("Harga Produk: " + product.hargaProduk);
                Console.WriteLine("Panjang Produk: " + product.panjangProduk);
                Console.WriteLine("Lebar Produk: " + product.lebarProduk);
                Console.WriteLine("Deskripsi Produk: " + product.deskripsiProduk);
                Console.WriteLine();
                I++;
            }
            products = productsFromFile.ToList();
            ReadData(products);
            //Console.WriteLine(string.Join(", ", ));
            void ReadData(List<ProductPanelSurya> produk)
            {
                // Bagian Buat Create File
                var HasilKonversi = JsonConvert.SerializeObject(products);

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true,
                };

                FileStream fileStream = new FileStream(@"./ProductsSolarPanels.json", FileMode.Create);
                using (StreamWriter write = new StreamWriter(fileStream))
                {
                    write.Write(HasilKonversi);
                }
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid. Harap masukkan bilangan bulat.");
        }
    }
}