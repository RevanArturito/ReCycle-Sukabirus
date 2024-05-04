using System;
using System.Collections.Generic;
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
            string inputID, inputNama, inputJenis, inputHarga, inputPanjang, inputLebar, inputDeskripsi;

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

            // Adding a new product to the list
            Console.WriteLine();

            string json = File.ReadAllText(filePath);
            List<ProductPanelSurya> productsFromFile = JsonConvert.DeserializeObject<List<ProductPanelSurya>>(json);
            products = productsFromFile.ToList();
            products.Add(new ProductPanelSurya(inputID, inputNama, inputJenis, inputHarga, inputPanjang, inputLebar, inputDeskripsi));
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