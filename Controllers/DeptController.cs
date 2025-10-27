using FirstWebAppMVC_Star.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FirstWebAppMVC_Star.Controllers
{
    public class DeptController : Controller
    {



 static List<DeptModel> depts = new List<DeptModel>() {
        new DeptModel{Deptno=10,Dname="Sales",Loc="Mumbai" },
        new DeptModel{Deptno=20,Dname="Dev",Loc="Pune" }

        };

        

        
        public IActionResult ShowEmpByDeptno()
        {
            if (TempData["empDept"] != null)
            {
           var data = TempData["empDept"].ToString();

    List<EmployeeModel> showdata = JsonSerializer.Deserialize<List<EmployeeModel>>(data);
                TempData["finalshow"] = showdata;
            }
            return View();
        }
    }
}
