// See https://aka.ms/new-console-template for more information
using System;
using static KPL_Recycle.Profile;
using static KPL_Recycle.Riwayat;
using static KPL_Recycle.Riwayat.History;

namespace KPL_Recycle
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Membuat instance ProfileConfig
            ProfileConfig profileConfig = new ProfileConfig();

            // Menampilkan profil sebelum diperbarui
            Console.WriteLine("Profil Sebelum Diperbarui:");
            profileConfig.ReadJSON();

            // Meminta pengguna untuk memasukkan data baru
            Console.WriteLine("\nMasukkan data baru:");

            Console.Write("Username baru: ");
            string newUsername = Console.ReadLine();

            Console.Write("Email baru: ");
            string newEmail = Console.ReadLine();

            Console.Write("Nomor Telepon baru: ");
            long newPhoneNumber = long.Parse(Console.ReadLine());

            // Memanggil method UpdateProfile untuk memperbarui profil
            profileConfig.UpdateProfile(newUsername, newEmail, newPhoneNumber);

            // Menampilkan profil setelah diperbarui
            Console.WriteLine("\nProfil Setelah Diperbarui:");
            profileConfig.ReadJSON();

            Console.WriteLine("");

            // Membuat instance RiwayatConfig
            RiwayatConfig riwayat = new RiwayatConfig();
            riwayat.ReadJSON();
        }
    }
}