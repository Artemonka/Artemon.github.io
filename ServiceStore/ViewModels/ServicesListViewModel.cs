using ServiceStore.Data.Models;
using System.Collections.Generic;


namespace ServiceStore.ViewModels
{
    public class ServicesListViewModel
    {
        public IEnumerable<Service> AllService { set; get; }
    }
}
