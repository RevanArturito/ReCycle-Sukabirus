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
            // Assuming ReadJSON is an instance method
            ProfileConfig profile = new ProfileConfig();
            profile.ReadJSON();

            Console.WriteLine("");

            RiwayatConfig riwayat = new RiwayatConfig();
            riwayat.ReadJSON();
        }
    }
}