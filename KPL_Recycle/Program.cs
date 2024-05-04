// See https://aka.ms/new-console-template for more information
using System;

namespace KPL_Recycle
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProfileConfig profileConfig = new ProfileConfig();
            profileConfig.ReadJSON();
        }
    }
}