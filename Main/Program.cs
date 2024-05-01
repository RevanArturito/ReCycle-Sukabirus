// See https://aka.ms/new-console-template for more information
using Authentication;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AuthConsole
{ 
    internal class Program
    {
        public static List<Account> accounts = new List<Account>();

        public static  bool LoginCheck(string username, string password)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].username ==  username && accounts[i].password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool AdminCheck(string username, string password)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].username == username && accounts[i].password == password)
                {
                    if (accounts[i].role == "admin")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void Main(string[] args)
        {
            //FirestoreHelper.SetEnvironmentVariable();
            UI ui = new UI();
            ui.ApplicationStartUI();
            int nomor1 = Convert.ToInt32(Console.ReadLine());

            const string FilePath = @"./Account.json";
            using (StreamReader Read = new StreamReader(FilePath))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(Read.ReadToEnd());
            }
            switch (nomor1)
            {
                case 1:
                    Console.WriteLine("Login");
                    Console.Write("Username : ");
                    string usernameLogin = Console.ReadLine();
                    Console.Write("Password : ");
                    string passwordLogin = Console.ReadLine();

                    if (LoginCheck(usernameLogin, passwordLogin))
                    {
                        if (AdminCheck(usernameLogin, passwordLogin))
                        {
                            ui.AdminOption();
                            int nomor2 = Convert.ToInt32(Console.ReadLine());
                            switch (nomor2)
                            {
                                case 1:
                                    Console.WriteLine("tes1");
                                    break;
                                case 2:
                                    Console.WriteLine("tes2");
                                    break;
                                case 0:
                                    break;
                            }
                        }
                    } else {
                        Console.WriteLine("gagal");
                    }
                    break;
                case 2:
                    
                    for (int i = 0;i < accounts.Count;i++)
                    {
                        Console.WriteLine(accounts[i].username);
                        Console.WriteLine(accounts[i].password);
                        Console.WriteLine(accounts[i].email);
                        Console.WriteLine(accounts[i].phone);
                        Console.WriteLine(accounts[i].role);
                    }
                    
                    /*  Console.WriteLine("###   Masukkan Data   ###");
                      Console.Write("Username : ");
                      string username = Console.ReadLine();
                      Console.Write("Password : ");
                      string password = Console.ReadLine();
                      Console.Write("Email    : ");
                      string email = Console.ReadLine();
                      Console.Write("Phone    : ");
                      string phone = Console.ReadLine();

                      UserData GetWriteData()
                      {
                          return new UserData()
                          {
                              UserName = username,
                              Password = password,
                              Email = email,
                              PhoneNumber = phone,
                          };
                      }

                      var dbr = FirestoreHelper.Database;
                      var data = GetWriteData();
                      *//*DocumentReference docRefR = dbr.Collection("UserData").Document();
                      docRefR.SetAsync(data);*//*

                      var collectionRef = dbr.Collection("UserData");
                      var docRefR = collectionRef.Document();
                      docRefR.SetAsync(data);*/

                    break;
                case 0:
                    Console.WriteLine();
                    Console.WriteLine("Terima Kasih");
                    break;
            }

        }
    }

}


