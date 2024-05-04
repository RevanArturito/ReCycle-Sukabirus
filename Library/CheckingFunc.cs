using Authentication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    public class CheckingFunc
    {
        public static List<Account> accounts = new List<Account>();
        const string FilePath = @"./Account.json";
        public bool LoginCheck(string username, string password)
        {
            
            using (StreamReader Read = new StreamReader(FilePath))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(Read.ReadToEnd());
            }
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].username == username && accounts[i].password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AdminCheck(string username, string password)
        {
            using (StreamReader Read = new StreamReader(FilePath))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(Read.ReadToEnd());
            }
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
    }
}
