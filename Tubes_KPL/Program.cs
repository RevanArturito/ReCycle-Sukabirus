using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Serialization;
using Tubes_KPL;

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating a list to store product
        List<Produk> products = new List<Produk>();
        string filePath = @"./ProductsSolarPanels.json";
        
        // Convert json ke list
        string json = File.ReadAllText(filePath);
        List<Produk> productsFromFile = JsonConvert.DeserializeObject<List<Produk>>(json);
        products = productsFromFile.ToList();

        // Update atau edit produk
        UpdateProduk updater = new UpdateProduk();
        int indexProduk;
        do
        {
            Console.Write("Masukkan nama produk dari produk yang ingin diubah: ");
            string nama = Console.ReadLine();
            indexProduk = updater.findProduk(products, nama);
            if (indexProduk == -1)
            {
                Console.WriteLine("Produk Tidak Ditemukan!");
            }
        } while (indexProduk == -1);
        updater.update(products, indexProduk);
    }
}
