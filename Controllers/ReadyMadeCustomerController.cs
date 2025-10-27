using FirstWebAppMVC_Star.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppMVC_Star.Controllers
{
    public class ReadyMadeCustomerController : Controller
    {
        static List<CustomerModel> customers = new List<CustomerModel>() {
        new CustomerModel{Custid=1,Name="Gauri",City="Pune",Rating=5 },
        new CustomerModel{Custid=2,Name="Simran",City="Mumbai",Rating=5 },
        new CustomerModel{Custid=3,Name="Dinesh",City="Pune",Rating=4 },
        new CustomerModel{Custid=5,Name="Suresh",City="Pune",Rating=5 }


        };
        // GET: ReadyMadeCustomerController
        public IActionResult Index()
        {
            return View(customers);
        }
  
       
        // GET: ReadyMadeCustomerController/Details/5
        public ActionResult Details(int id)
        {
            var findCust=(from c in customers
                         where c.Custid == id   
                         select c).FirstOrDefault();
            if (findCust == null)
            { 
            return RedirectToAction(nameof(Index));
            }
            return View(findCust);
        }

        // GET: ReadyMadeCustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReadyMadeCustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                CustomerModel cust = new CustomerModel();
                cust.Custid = Convert.ToInt32(collection["Custid"]);
                cust.Name = collection["Name"].ToString();
                cust.City = collection["City"].ToString();
                cust.Rating = Convert.ToInt32(collection["Rating"]);
                customers.Add(cust);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReadyMadeCustomerController/Edit/5
        public ActionResult Edit(int id)
        {

            var findCust = (from c in customers
                           where c.Custid == id
                           select c).FirstOrDefault();
            // return RedirectToAction("Edit", new { id = id, model = findCust });
            return View(findCust);
        }

        // POST: ReadyMadeCustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerModel model)
        {
            try
            {
                CustomerModel findCust = (from c in customers
                               where c.Custid == id
                               select c).FirstOrDefault();
                findCust.Custid=model.Custid;
                findCust.Name=model.Name;
                findCust.City=model.City;   
                findCust.Rating=model.Rating;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReadyMadeCustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            
            var foundCust=customers.Find(c=>c.Custid==id);
           
            return View(foundCust);
        }

        // POST: ReadyMadeCustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CustomerModel collection)
        {
            try
            {
                var foundCust = customers.Find(c => c.Custid == id);
                customers.Remove(foundCust);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
