using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceStore.Data.Interfaces;
using ServiceStore.Data.Models;
using ServiceStore.Models;
using ServiceStore.ViewModels;

namespace ServiceStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly IAllServices _AllService;

        public StoreController(IAllServices iAllService)
        {
            _AllService = iAllService;
        }

        public ViewResult Services()  //Вывод всех услуг
        {
            ServicesListViewModel obj = new ServicesListViewModel();
            obj.AllService = _AllService.Services;
            return View(obj);
        }

        public ViewResult ServiceAbout()   //Вывод услуги
        {
            ServicesListViewModel obj = new ServicesListViewModel();
            obj.AllService = _AllService.Services;
            int _Id = int.Parse(HttpContext.Request.Query.Keys.Last());//Получение айди услуги
             Service serv = new Service();
            //IEnumerable<Service> Services;
            IEnumerator ie = obj.AllService.GetEnumerator();
            int i =0;
            while ((ie.MoveNext()) & !( i == _Id))
            {
               serv = (Service)ie.Current;
                i++;
            }
            return View(serv);
        }

      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
