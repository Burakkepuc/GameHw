using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace GameHW
{
    //Microservice
    class GamerManager : IGamerService
    {
         IUserValidationService _userValidationService;

         public GamerManager(IUserValidationService userValidationService)
         {
             _userValidationService = userValidationService;
         }

         public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
            Console.WriteLine("Kayıt oldu");

            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Güncellendi");

            }
            else
            {
                Console.WriteLine("Kayıt Güncellenmedi");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Silindi");

            }
            else
            {
                Console.WriteLine("Kayıt Silinemedi");
            }
        }
    }
}
