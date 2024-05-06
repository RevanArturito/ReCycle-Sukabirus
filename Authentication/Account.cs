using Microsoft.AspNetCore.Authentication.OAuth;

namespace Authentication
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string role { get; set; } 

        public Account(string username, string password, string email, string phone)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.phone = phone;
            this.role = "user";
        } 

        
    }
}
