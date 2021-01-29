using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GameHW
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer{
                BirtYear = 1996,
                FirstName = "Burak",
                Lastname = "Kepüç",
                IdentityNumber = 12345
            });
        }
    }
}
