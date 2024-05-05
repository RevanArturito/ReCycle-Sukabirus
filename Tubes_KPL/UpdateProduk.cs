﻿using Newtonsoft.Json;
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

            //input nama produk
            Console.WriteLine("Masukkan Data Baru:");
            Console.Write("Nama: ");
            nama = Console.ReadLine();
            list[index].namaproduk = nama;

            //input jenis
            Console.Write("Jenis: ");
            jenis = Console.ReadLine();
            list[index].jenis = jenis;
            
            int cekHarga;
            // Meminta input harga yang sesuai dengan format yang diinginkan
            do
            {
                Console.Write("Harga: ");
                harga = Console.ReadLine();
                if (!int.TryParse(harga, out cekHarga))
                {
                    Console.WriteLine("Harga harus berupa angka.");
                }
            } while (!int.TryParse(harga, out cekHarga));

            list[index].hargaProduk = cekHarga.ToString();

            // Meminta input panjang yang sesuai dengan format yang diinginkan
            int cekPanjang;
            
            do
            {
                Console.Write("Panjang: ");
                panjang = Console.ReadLine();
                if (!int.TryParse(panjang, out cekPanjang))
                {
                    Console.WriteLine("Panjang harus berupa angka.");
                }
            } while (!int.TryParse(panjang, out cekPanjang));

            list[index].panjangProduk = cekPanjang.ToString();

            // Meminta input lebar yang sesuai dengan format yang diinginkan
            int cekLebar;
            do
            {
                Console.Write("Lebar: ");
                lebar = Console.ReadLine();
                if (!int.TryParse(lebar, out cekLebar))
                {
                    Console.WriteLine("Lebar harus berupa angka.");
                }
            } while (!int.TryParse(lebar, out cekLebar));

            //input deskripsi
            list[index].lebarProduk = cekLebar.ToString();
            Console.Write("Deskripsi: ");
            deskripsi = Console.ReadLine();
            list[index].deskripsiProduk = deskripsi;

            // Masukkan ke file json
            const string FilePath = @"./ProductsSolarPanel.json";

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

        public int findProduk(List<Produk> list, string nama_Produk)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].namaproduk.Equals(nama_Produk))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
