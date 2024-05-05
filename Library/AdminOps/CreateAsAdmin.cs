using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Library.AdminOps
{
    public class CreateAsAdmin
    {
        // Creating a list to store product
        List<ProductPanelSurya> products = new List<ProductPanelSurya>();
        string filePath = @"./ProductsSolarPanels.json";

        public void CreateProduct()
        {
            string inputNama, inputJenis, inputHarga, inputPanjang, inputLebar, inputDeskripsi;
            int inputStok;

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

            Console.WriteLine("Enter Product Name:");
            inputNama = Console.ReadLine();
            Debug.Assert(inputNama != "", "Nama Produk Jangan Kosong"); // Defensive Programing

            Console.WriteLine("Enter Product Type:");
            inputJenis = Console.ReadLine();

            Console.WriteLine("Enter Product Price:");
            inputHarga = Console.ReadLine();

            Console.WriteLine("Enter Product Length:");
            inputPanjang = Console.ReadLine();

            Console.WriteLine("Enter Product Width:");
            inputLebar = Console.ReadLine();

            Console.WriteLine("Enter Product Stock:");
            inputStok = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Description:");
            inputDeskripsi = Console.ReadLine();

            // Adding a new product to the list
            Console.WriteLine();

            string json = File.ReadAllText(filePath);
            List<ProductPanelSurya> productsFromFile = JsonConvert.DeserializeObject<List<ProductPanelSurya>>(json);
            products = productsFromFile.ToList();
            products.Add(new ProductPanelSurya(randomText, inputNama, inputJenis, inputHarga, inputPanjang, inputLebar, inputStok, inputDeskripsi));
            ReadData(products);

        }

        public void ReadData(List<ProductPanelSurya> produk)
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
        // End Bagian
    }
}