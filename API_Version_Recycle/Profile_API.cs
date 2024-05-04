using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API_Version_Recycle
{
    public class Profile_API
    {
        //atribut untuk deserialisasi
        public string username { get; set; }
        public string email { get; set; }
        public long phoneNumber { get; set; }

        //constructor kosong untuk deserialisasi
        public Profile_API() { }

        public Profile_API(string username, string email, long phoneNumber)
        {
            this.username = username;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
    }
}