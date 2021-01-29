using System;
using System.Collections.Generic;
using System.Text;

namespace GameHW
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirtYear == 1996 && gamer.FirstName == "Burak" && gamer.Lastname == "Kepüç" &&
                gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
                return false;
        }
    }
}
