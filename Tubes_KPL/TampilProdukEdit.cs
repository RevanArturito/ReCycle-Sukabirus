using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    public class TampilProdukEdit<T>
    {
        private List<T> _listProduk;

        public TampilProdukEdit(List<T> listProduk)
        {
            _listProduk = listProduk;
        }

        public void TampilkanProduk(int indexProduk)
        {
            if (indexProduk >= 0 && indexProduk < _listProduk.Count)
            {
                T produk = _listProduk[indexProduk];
                Type t = typeof(T);

                Console.WriteLine("Produk yang akan diubah:");
                Console.WriteLine("-------------------------------------------");

                foreach (var prop in t.GetProperties())
                {
                    Console.WriteLine($"{prop.Name}: {prop.GetValue(produk)}");
                }

                Console.WriteLine("-------------------------------------------");
            }
            else
            {
                Console.WriteLine("Indeks produk tidak valid.");
            }
        }
    }
}
