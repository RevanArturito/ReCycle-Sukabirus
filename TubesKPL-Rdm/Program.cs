// See https://aka.ms/new-console-template for more information
// Console.WriteLine("==============================");
//Console.WriteLine("| TUGAS BESAR KELOMPOK 4 KPL |");
// Console.WriteLine("==============================");
// Console.WriteLine("1. List Produk Panel Surya");
// 
// Console.WriteLine("2. Profil"); // Log Out masuknya di profil, dan riwayat pembelian / report juga
// 
// mendeklarasikan enumerasi jeniskelamin bernilai 2 value, yakni pria dan wanita
enum JenisKelamin { PRIA, WANITA}

// 
class Program
{
    static void Main(string[] args)
    {
        JenisKelamin jk = JenisKelamin.PRIA;
        Console.WriteLine("Jenis Kelamin : " + jk);
    }
}

// -- GA KEPAKAI --
// JenisKelamin jk = JenisKelamin.WANITA;
