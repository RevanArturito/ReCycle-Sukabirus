using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KPL_Recycle
{
    public class Profile
    {
        public class Profiles
        {
            //atribut untuk deserialisasi
            public string username { get; set; }
            public string email { get; set; }
            public long phoneNumber { get; set; }

            //constructor kosong untuk deserialisasi
            public Profiles() { }

            public Profiles(string username, string email, long phoneNumber)
            {
                this.username = username;
                this.email = email;
                this.phoneNumber = phoneNumber;
            }
        }

        public class ProfileConfig
        {
            public Profiles configuration;

            public const string filePath = "D:\\VS\\KPL_Recycle\\KPL_Recycle\\profile.json";

            public ProfileConfig()
            {
                ReadConfigFile();
            }

            private void ReadConfigFile()
            {
                string configJsonData = File.ReadAllText(filePath);
                configuration = JsonSerializer.Deserialize<Profiles>(configJsonData);
            }

            public void ReadJSON()
            {
                Console.WriteLine("========== Profile ==========");
                Console.WriteLine($"Nama          : {configuration.username}");
                Console.WriteLine($"Email         : {configuration.email}");
                Console.WriteLine($"Nomor Telepon : +{configuration.phoneNumber}");
            }
        }
    }
}