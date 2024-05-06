using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

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
            // Atribut untuk menyimpan konfigurasi profil
            public Profiles configuration;
            // Lokasi file JSON untuk konfigurasi profil
            public const string filePath = "D:\\VS\\KPL_Recycle\\KPL_Recycle\\profile.json";

            //constructor membaca config dari file json
            public ProfileConfig()
            {
                ReadConfigFile();
            }
            // Method membaca isi file json
            private void ReadConfigFile()
            {
                string configJsonData = File.ReadAllText(filePath);
                configuration = JsonSerializer.Deserialize<Profiles>(configJsonData);
            }

            // Method update profile
            public void UpdateProfile(string newUsername, string newEmail, long newPhoneNumber)
            {
                // Precondition
                Debug.Assert(!string.IsNullOrEmpty(newUsername), "Username yang baru tidak boleh kosong.");
                Debug.Assert(!string.IsNullOrEmpty(newEmail), "Email yang baru tidak boleh kosong.");
                Debug.Assert(newPhoneNumber > 13 , "Nomor HP yang baru tidak boleh lebih dari 13 angka.");

                // Update informasi profile dengan nilai yang baru
                configuration.username = newUsername;
                configuration.email = newEmail;
                configuration.phoneNumber = newPhoneNumber;

                // Postcondition
                Debug.Assert(configuration.username == newUsername, "Profile username is not updated.");
                Debug.Assert(configuration.email == newEmail, "Profile email is not updated.");
                Debug.Assert(configuration.phoneNumber == newPhoneNumber, "Profile phone number is not updated.");

                // Save updated profile ke JSON file
                SaveConfigToFile();
            }

            // Save new profile ke json
            private void SaveConfigToFile()
            {
                string json = JsonSerializer.Serialize(configuration);
                File.WriteAllText(filePath, json);
            }

            //Menampilkan profile
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
