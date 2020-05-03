using Microsoft.AspNetCore.Mvc;
using ServiceStore.Data;
using ServiceStore.Data.Interfaces;
using ServiceStore.Data.Models;
using ServiceStore.Data.Repository;
using ServiceStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Controllers
{
    public class PersonalController:Controller 
    {
        private readonly IAllPersonals _iPersonal;
  
      

        public PersonalController(IAllPersonals Personal)
        {
            _iPersonal = Personal;
            
        }

        public ViewResult Account(Personal Pers) //Вывод окна регистрации
        {

            _iPersonal.CreatePersonal(Pers);
            return View();
        }

           public IActionResult Login()
        {
            Personal pers = new Personal();

            return View(pers);
        }
    }
}
