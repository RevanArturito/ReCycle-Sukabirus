using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UserOps
{
    public class Profile
    {
        public void ProfileView(string username, string email, string phone)
        {
            UIapp ui = new UIapp();
            ui.ProfileView1();
            Console.WriteLine("");
            Console.WriteLine($"Halo, {username}");
            Console.WriteLine($"{email}");
            Console.WriteLine($"+62 {phone}");
            ui.ProfileView2();
        }
    }
}
