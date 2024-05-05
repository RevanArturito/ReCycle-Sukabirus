using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library.AdminOps
{
    public class DeleteAsAdmin
    {
        public void Delete()
        {
            List<ProductPanelSurya> products = new List<ProductPanelSurya>();
            string filePath = @"./ProductsSolarPanels.json";
            string json = File.ReadAllText(filePath);
            List<ProductPanelSurya> productsFromFile = JsonConvert.DeserializeObject<List<ProductPanelSurya>>(json);
            ViewAsAdmin view = new ViewAsAdmin();

            // Deserialisasi JSON menjadi array objek


            Console.WriteLine("Masukkan data yang ingin dihapus (nomor)");
            int index;
            string input = Console.ReadLine();

            if (int.TryParse(input, out index))
            {
                //index = index - 1;

                // Memanggil metode DeleteByIndex untuk menghapus item dari list berdasarkan indeks yang dimasukkan oleh pengguna
                DeleteAdmin<ProductPanelSurya> delet = new DeleteAdmin<ProductPanelSurya>(productsFromFile);
                delet.DeleteByIndex(Convert.ToInt32(input)-1);

                // Tampilkan isi list setelah penghapusan
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
                Console.WriteLine("Setelah dihapus:");
                Console.WriteLine(" ");
                Console.WriteLine("Daftar item:");
                view.viewProduct();
            }
            else
            {
                Console.WriteLine("Input tidak valid. Harap masukkan bilangan bulat.");
            }
        }
        public class DeleteAdmin<T>
        {


            private List<T> items;

            public DeleteAdmin(List<T> items)
            {
                this.items = items;
            }

            public void DeleteByIndex(int index)
            {
                Debug.Assert(index <= items.Count, "Pilihan tidak sesuai");

                if (index >= 0 && index < items.Count)
                {

                    T deletedItem = items[index];
                    items.RemoveAt(index);
                    Console.WriteLine(" ");
                    Console.WriteLine($"({deletedItem}) telah dihapus.");
                    Console.WriteLine(" ");

                }
                else
                {
                    Console.WriteLine("Indeks tidak valid.");
                }
            }
        }

    }
}

