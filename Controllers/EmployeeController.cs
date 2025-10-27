using FirstWebAppMVC_Star.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FirstWebAppMVC_Star.Controllers
{
    public class EmployeeController : Controller
    {
       public static List<EmployeeModel> emplist = new List<EmployeeModel>() {
    new EmployeeModel{Empid=1,EmployeeName="Suresh",Deptno=10 },
    new EmployeeModel{ Empid=2,EmployeeName="Ramesh",Deptno=20 },
    new EmployeeModel{ Empid=3,EmployeeName="Jayesh",Deptno=10 }
    };
        public IActionResult Index()
        {
            TempData["empdata"] = emplist;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

            [HttpPost]
        public IActionResult Details(int id) {
            var empdata = (from edata in emplist
                          where edata.Deptno == id
                          select edata).ToList();
            //TempData["empDept"]=Newtonsoft.Json.JsonConvert.SerializeObject(empdata);

            TempData["empDept"]=JsonSerializer.Serialize(empdata);


            return RedirectToAction("ShowEmpByDeptno","Dept");
        
        }
    }
}
