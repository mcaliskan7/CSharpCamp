using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Registration Successful");
            }
            else
            {
                Console.WriteLine("Registration Failed");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registration Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Registration Updated");
        }
    }
}