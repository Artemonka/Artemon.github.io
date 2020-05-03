using ServiceStore.Data.Interfaces;
using ServiceStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Data.Repository
{
    public class PersonalRepository : IAllPersonals
    {
        private readonly AppDBContent appDBContent;

        public PersonalRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public void CreatePersonal(Personal personal)
        {
           this.appDBContent.Personal.Add(new Personal
            {
                Name = personal.Name,
                LastName = personal.LastName,
                Login = personal.Login,
                Passwrord = personal.Passwrord,
                Phone = personal.Phone,
                SurName = personal.SurName,
                Email = personal.Email,
                Admin = false,
                Buy = false
            });
            appDBContent.SaveChanges();
            
        }



    }
}
