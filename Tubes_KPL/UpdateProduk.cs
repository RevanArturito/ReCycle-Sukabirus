using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    internal class UpdateProduk
    {
        public void update(List<Produk> list, int index)
        {
            string nama, jenis, harga, panjang, lebar, deskripsi;
            Console.WriteLine("Masukkan Data Baru:");
            Console.Write("Nama: ");
            nama = Console.ReadLine();
            list[index].namaproduk = nama;
            Console.Write("Jenis: ");
            jenis = Console.ReadLine();
            list[index].jenis = jenis;
            Console.Write("Harga: ");
            harga = Console.ReadLine();
            list[index].hargaProduk = harga;
            Console.Write("Panjang: ");
            panjang = Console.ReadLine();
            list[index].panjangProduk = panjang;
            Console.Write("Lebar: ");
            lebar = Console.ReadLine();
            list[index].lebarProduk = lebar;
            Console.Write("Deskripsi: ");
            deskripsi = Console.ReadLine();
            list[index].deskripsiProduk = deskripsi;

            //string inputNama = Console.ReadLine();
            //string inputHarga = Console.ReadLine();
            const string FilePath = @"./ProductsSolarPanel.json";
            //List<Produk> acc = new List<Product>();
            //acc.Add(new Product(inputNama, inputHarga));
            //acc.Add(new Product("nama3", "nama3"));
            // acc.Add(new Product("nama5", "nama5"));

            var HasilKonversi = JsonConvert.SerializeObject(list);

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

        public int findProduk(List<Produk> list, string ID_Produk)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].idProduk.Equals(ID_Produk))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
