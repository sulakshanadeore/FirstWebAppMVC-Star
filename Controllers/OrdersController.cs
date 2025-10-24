using FirstWebAppMVC_Star.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppMVC_Star.Controllers
{
    public class OrdersController : Controller
    {
        static List<OrdersModel> orders = null;
         public OrdersController()
        {
             orders = new List<OrdersModel>() {
            new OrdersModel
            {
                OrderID=1,
                OrderDate=new DateTime(2024,10,11),
                CustomerID=101,
                EmpID=1001
            },
            new OrdersModel{  OrderID=2,
                OrderDate=new DateTime(2024,01,12),
                CustomerID=102,
                EmpID=1001},
             new OrdersModel{  OrderID=3,
                OrderDate=new DateTime(2024,02,10),
                CustomerID=103,
                EmpID=1002},

            };
        }
        
        public IActionResult ListOrders()
        {
            ViewBag.OrdersInHand = orders;
            ViewBag.orderCount=orders.Count;
            return View();
        }

        public ActionResult ShowAllOrders()
        {

            ViewData["ordersData"] = orders;
            return View();
        }


        public ActionResult EditOrder()
        {

            return View();
        }

        public ActionResult DeleteOrder()
        {

            return View();
        }
    }
}
