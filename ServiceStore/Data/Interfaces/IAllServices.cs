using System.Collections.Generic;
using ServiceStore.Data.Models;

namespace ServiceStore.Data.Interfaces
{
 
        public interface IAllServices
        {
          IEnumerable<Service> Services { get; }
        }
    }

