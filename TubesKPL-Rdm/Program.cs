using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

class Program
{

    public static void Main(string[] args)
    {
        string inputNama, inputJenis, inputHarga, inputPanjang, inputLebar, inputDeskripsi;

        // Inisialisasi objek dari kelas Random
        Random inputID = new Random();

        // Membuat 4 teks angka acak
        string randomText = "";
        for (int i = 0; i < 4; i++)
        {
            // Menghasilkan angka acak antara 0 dan 9
            int randomNumber = inputID.Next(10);

            // Menambahkan angka acak ke teks
            randomText += randomNumber.ToString();
        }

        /*Console.WriteLine("Enter Product ID:");
        inputID = Console.ReadLine();*/

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
        List<ProductPanelSurya> products = new List<ProductPanelSurya>();

        // Adding a new product to the list
        products.Add(new ProductPanelSurya(randomText, inputNama, inputJenis, inputHarga, inputPanjang, inputLebar, inputDeskripsi));

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


// -- GA KEPAKAI --
// JenisKelamin jk = JenisKelamin.WANITA;

/*
public class GenericClass<T>
{
    private T genericField;

    public GenericClass(T value)
    {
        genericField = value;
    }

    public void Display()
    {
        Console.WriteLine("Nilai dari genericField: " + genericField);
    }
}

// class Program
{
    static void Main(string[] args)
    {
        JenisKelamin jk = JenisKelamin.PRIA;
        Console.WriteLine("Jenis Kelamin : " + jk);
    }
}

public class GenericClass<T>
{
    private T genericField;

    public GenericClass(T value)
    {
        genericField = value;
    }
}
*/

// List<ProductPanelSurya> isi = new List<ProductPanelSurya>();

// Adding elements to the list
// isi.Add(new ProductPanelSurya("A", "A", "A", "A", "A", "A", "A"));

/* ;
 isi.Add("3");
 isi.Add("4");
 isi.Add("5");
*/
//GenericClass<Prod> stringObj = new GenericClass<string>("Hello, Generics!");

//Console.WriteLine("Element at index 0: " + isi[4]);
/*for (int i =0;i<isi.Count;i++)
{
    Console.WriteLine(isi[i].namaproduk);
    Console.WriteLine(isi[i].jenis);
    Console.WriteLine(isi[i].hargaProduk);
    Console.WriteLine(isi[i].panjangProduk);
    Console.WriteLine(isi[i].lebarProduk);
    Console.WriteLine(isi[i].deskripsiProduk);
}*/

// AtributPanelSurya panelSurya = new AtributPanelSurya();

// Memanggil metode ConstPanelSurya untuk menampilkan informasi panel surya
// panelSurya.printPanjang();

// Menunggu input sebelum menutup aplikasi

/* AtributPanelSurya atributPanelSurya = new AtributPanelSurya();
 atributPanelSurya.PrintPanjang();*/

/*foreach (string tes in isi)
    {
        Console.WriteLine(tes);
    }*/

/* AtributPanelSurya atributPanelSurya = new AtributPanelSurya();

    // Menggunakan reflection untuk mendapatkan semua method dalam class AtributPanelSurya
    var methods = typeof(AtributPanelSurya).GetMethods(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

    foreach (var method in methods)
    {
        // Memastikan method yang dipanggil adalah method yang telah didefinisikan dalam class (bukan method bawaan dari .NET)
        if (method.DeclaringType == typeof(AtributPanelSurya))
        {
            // Memanggil method jika bukan constructor
            if (!method.IsConstructor)
            {
                // Console.WriteLine($"Calling method: {method.Name}");
                // Console.WriteLine(typeof(AtributPanelSurya));
                 method.Invoke(atributPanelSurya, null);
                Console.WriteLine();
            }
        }
    }*/