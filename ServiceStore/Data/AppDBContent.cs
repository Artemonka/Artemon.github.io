using Microsoft.EntityFrameworkCore;
using ServiceStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Data
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

        }
        public DbSet<Service> Service { get; set; }  //услуги
        public DbSet<Personal> Personal { get; set; }  //клиенты
    }
}
