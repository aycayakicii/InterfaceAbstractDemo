using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {

        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1997&&
                gamer.FirstName=="Ayca"&&
                gamer.LastName=="YAKICI"&&
                gamer.IdentitiyNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
