using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Text.Json;

namespace Authentication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController
    {
        public static List<Account> accounts = new List<Account>();

        public const String filePath = @"./Account.json";

       

        public static void ListCheck(List<Account> acc)
        {
            var HasilKonversi = JsonConvert.SerializeObject(acc);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };


            FileStream fileStream = new FileStream(@"./Account.json", FileMode.Create);
            using (StreamWriter write = new StreamWriter(fileStream))
            {
                write.Write(HasilKonversi);
            }
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            using (StreamReader Read = new StreamReader(filePath))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(Read.ReadToEnd());
            }
            return accounts;
        }

        [HttpPost]
        public void Post([FromBody] Account ListAccount)
        {
            accounts.Add(ListAccount);
            ListCheck(accounts);

        }

        [HttpGet("{id}")]
        public Account Get(int id)
        {
            return accounts[id];
        }

    }
}
