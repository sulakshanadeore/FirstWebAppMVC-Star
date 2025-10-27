using FirstWebAppMVC_Star.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace FirstWebAppMVC_Star.Controllers
{
    public class CustomerController : Controller
    {
        static List<CustomerModel> customers = new List<CustomerModel>() { 
        new CustomerModel{Custid=1,Name="Gauri",City="Pune",Rating=5 },
        new CustomerModel{Custid=2,Name="Simran",City="Mumbai",Rating=5 },
        new CustomerModel{Custid=3,Name="Dinesh",City="Pune",Rating=4 },
        new CustomerModel{Custid=5,Name="Suresh",City="Pune",Rating=5 }


        };

        public IActionResult Index()
        {
            return View(customers);
        }


    }
}
