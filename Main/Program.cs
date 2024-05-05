// See https://aka.ms/new-console-template for more information
using Authentication;
using Authentication.Controllers;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Library;
using Library.AdminOps;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace AuthConsole
{ 
    internal class Program
    {
        
        public static List<Account> accounts = new List<Account>();
        
        public static void Main(string[] args)
        {
        
            UIapp ui = new UIapp(); // panggil class ui
            CheckingFunc checkingFunc = new CheckingFunc(); // panggil class CheckingFunc
            ViewAsAdmin adminView = new ViewAsAdmin();
            CreateAsAdmin adminCreate = new CreateAsAdmin();
            DeleteAsAdmin adminDelete = new DeleteAsAdmin();

            // Read data akun json file
            const string FilePath = @"./Account.json";
            const string ProductFilePath = @"./ProductsSolarPanels.json";
            using (StreamReader Read = new StreamReader(FilePath))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(Read.ReadToEnd());
            }
            string json = File.ReadAllText(ProductFilePath);

            // Deserialisasi JSON menjadi array objek
            List<ProductPanelSurya> productsFromFile = JsonConvert.DeserializeObject<List<ProductPanelSurya>>(json);



            ui.ApplicationStartUI();
            int nomor1 = Convert.ToInt32(Console.ReadLine());
            while (nomor1 != 0)
            {
                switch (nomor1)
                {
                    case 1: // login

                        // input data
                        Console.WriteLine("Login");
                        Console.Write("Username : ");
                        string usernameLogin = Console.ReadLine();
                        Console.Write("Password : ");
                        string passwordLogin = Console.ReadLine();

                        if (checkingFunc.LoginCheck(usernameLogin,passwordLogin))
                        {
                            if (checkingFunc.AdminCheck(usernameLogin, passwordLogin))
                            {
                                ui.AdminOption();
                                int nomor2 = Convert.ToInt32(Console.ReadLine());
                                while(nomor2 != 0)
                                {
                                    switch (nomor2)
                                    {
                                        case 1:

                                            Console.WriteLine("tes1");
                                            break;
                                        case 2:
                                            adminCreate.CreateProduct();
                                            break;
                                        case 3:
                                            adminView.viewProduct();
                                            adminDelete.Delete();
                                            break;
                                        case 4:
                                            adminView.viewProduct();
                                            break;
                                        case 0:
                                            break;
                                        default:
                                            Console.WriteLine("Pilihan Tidak Sesuai");
                                            break;
                                    }
                                    ui.AdminOption();
                                    nomor2 = Convert.ToInt32(Console.ReadLine());
                                }  
                            }
                            else
                            {
                                ui.UserOption();
                                int nomor3 = Convert.ToInt32(Console.ReadLine());
                                while(nomor3 != 0)
                                {

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("gagal");
                        }
                        break;
                    
                    case 2: // Register

                        //Input data
                        Console.WriteLine("###   Masukkan Data   ###");
                        Console.Write("Username : ");
                        string username = Console.ReadLine();
                        Console.Write("Password : ");
                        string password = Console.ReadLine();
                        Console.Write("Email    : ");
                        string email = Console.ReadLine();
                        Console.Write("Phone    : ");
                        string phone = Console.ReadLine();
                        Console.WriteLine();

                        AuthController authController = new AuthController();
                        authController.Post(new Account(username, password, email, phone));
                        for (int i = 0; i < accounts.Count; i++)
                        {


                            Console.WriteLine(accounts[i].username);
                            Console.WriteLine(accounts[i].password);
                            Console.WriteLine(accounts[i].email);
                            Console.WriteLine(accounts[i].phone);
                            Console.WriteLine(accounts[i].role);

                        }
                        ui.RegisterBerhasil();
                        break;
                    default:
                        Console.WriteLine("Pilihan Tidak Sesuai");
                        break;
                }
                ui.ApplicationStartUI();
                nomor1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("End Program");
        }
    }

}


