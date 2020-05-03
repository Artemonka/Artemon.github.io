using Microsoft.EntityFrameworkCore;
using ServiceStore.Data.Interfaces;
using ServiceStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Data.Repository
{
    public class ServiceRepository: IAllServices
    {
        private readonly AppDBContent appDBContent;

        public ServiceRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Service> Services => appDBContent.Service;

        //public Service getObjectService(int ServiceId) => appDBContent.Service.FirstOrDefault(p => p.Id == ServiceId);
    }
}
