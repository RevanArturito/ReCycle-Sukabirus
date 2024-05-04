using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UIapp
    {
        public void ApplicationStartUI()
        {
            Console.WriteLine("#############################################");
            Console.WriteLine("###           ReCycle Sukabirus           ###");
            Console.WriteLine("#            Faisal, Rifqi, Revan           #");
            Console.WriteLine("#           Farrel, Faishal, Riva           #");
            Console.WriteLine("#############################################");
            Console.WriteLine("#                                           #");
            Console.WriteLine("#               1. Lohjin Rek               #");
            Console.WriteLine("#               2. Rehjister Rek            #");
            Console.WriteLine("#               0. Exit                     #");
            Console.WriteLine("#############################################");
            Console.WriteLine();
            Console.Write("Pilihan : ");
        }

        public void AdminOption()
        {
            Console.WriteLine();
            Console.WriteLine("#############################################");
            Console.WriteLine("###           ReCycle Sukabirus           ###");
            Console.WriteLine("###                 Admin                 ###");
            Console.WriteLine("#############################################");
            Console.WriteLine("#                                           #");
            Console.WriteLine("#                  1.Edit                   #");
            Console.WriteLine("#                  2.Tambah                 #");
            Console.WriteLine("#                  3.Hapus                  #");
            Console.WriteLine("#                  4.Daftar Produk          #");
            Console.WriteLine("#                  0.Exit                   #");
            Console.WriteLine("#############################################");
            Console.WriteLine();
            Console.Write("Pilihan : ");
        }
        public void UserOption()
        {
            Console.WriteLine();
            Console.WriteLine("#############################################");
            Console.WriteLine("###           ReCycle Sukabirus           ###");
            Console.WriteLine("###                 User                  ###");
            Console.WriteLine("#############################################");
            Console.WriteLine("#                                           #");
            Console.WriteLine("#                  1.Beli Produk            #");
            Console.WriteLine("#                  2.Profil                 #");
            Console.WriteLine("#                  0.Exit                   #");
            Console.WriteLine("#############################################");
            Console.WriteLine();
            Console.Write("Pilihan : ");
        }
        public void UserProfile()
        {
            Console.WriteLine();
            Console.WriteLine("#############################################");
            Console.WriteLine("###           ReCycle Sukabirus           ###");
            Console.WriteLine("###              User Profil              ###");
            Console.WriteLine("#############################################");
            Console.WriteLine("#                                           #");
            Console.WriteLine("#                1.Riwayat Transaksi        #");
            Console.WriteLine("#                2.Logout                   #");
            Console.WriteLine("#                0.Back                     #");
            Console.WriteLine("#############################################");
            Console.WriteLine();
            Console.Write("Pilihan : ");
        }
        public void RegisterBerhasil()
        {
            Console.WriteLine("");
            Console.WriteLine("#############################################");
            Console.WriteLine("###           Register Berhasil           ###");
            Console.WriteLine("#############################################");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
