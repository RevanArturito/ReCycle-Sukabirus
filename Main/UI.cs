using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthConsole
{
    internal class UI
    {
        public void ApplicationStartUI()
        {
            Console.WriteLine("### ReCycle Sukabirus ###");
            Console.WriteLine("1. Lohjin Rek");
            Console.WriteLine("2. Rehjister Rek");
            Console.WriteLine("0. Exit");
            Console.WriteLine("#########################");
            Console.WriteLine();
            Console.Write("Pilihan : ");
        }

        public void AdminOption()
        {
            Console.WriteLine();
            Console.WriteLine("### ReCycle Sukabirus ###");
            Console.WriteLine("###      Admin        ###");
            Console.WriteLine("1.Edit");
            Console.WriteLine("2.Tambah");
            Console.WriteLine("3.Hapus");
            Console.WriteLine("0.Exit");
            Console.WriteLine("#########################");
            Console.WriteLine();
            Console.Write("Pilihan : ");
        }
    }
}
