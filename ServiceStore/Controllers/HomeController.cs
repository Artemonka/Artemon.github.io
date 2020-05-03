using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult StoreHomePage()  //Домашняя страница
        {
            
            return View();
        }

    }
}
