using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Serialization;
using Tubes_KPL;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputID, inputNama, inputJenis, inputHarga, inputPanjang, inputLebar, inputDeskripsi;

        /*Console.Write("Masukkan N Produk Panel Surya:");
        nDataPanel = int.Parse(Console.ReadLine());*/

        Console.WriteLine("Enter Product ID:");
        inputID = Console.ReadLine();

        Console.WriteLine("Enter Product Name:");
        inputNama = Console.ReadLine();

        Console.WriteLine("Enter Product Type:");
        inputJenis = Console.ReadLine();

        Console.WriteLine("Enter Product Price:");
        inputHarga = Console.ReadLine();

        Console.WriteLine("Enter Product Length:");
        inputPanjang = Console.ReadLine();

        Console.WriteLine("Enter Product Width:");
        inputLebar = Console.ReadLine();

        Console.WriteLine("Enter Product Description:");
        inputDeskripsi = Console.ReadLine();

        // Creating a list to store product
        List<Produk> products = new List<Produk>();

        // Adding a new product to the list
        products.Add(new Produk(inputID, inputNama, inputJenis, inputHarga, inputPanjang, inputLebar, inputDeskripsi));

        Console.WriteLine();

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
        // End Bagian

        // Lokasi file JSON
        string filePath = @"./ProductsSolarPanels.json";

        try
        {
            // Membaca seluruh teks dari file JSON
            string json = File.ReadAllText(filePath);

            // Deserialisasi JSON menjadi array objek
            List<Produk> productsFromFile = JsonConvert.DeserializeObject<List<Produk>>(json);

            // Menampilkan data produk ke konsol
            foreach (var product in products)
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

        Console.Write("Masukkan ID produk dari produk yang ingin diubah: ");
        string id = Console.ReadLine();
        UpdateProduk updater = new UpdateProduk(); // Membuat instance dari UpdateProduk
        int indexProduk = updater.findProduk(products, id);
        updater.update(products, indexProduk);
    }
}
