using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace web2.Controllers
{
    public class VietNamController : Controller
    {
        public IActionResult Index()
        {
            string country = "Vietnam";
            int population = 100;
            List<string> cities = new List<string>()
            {
                "Hanoi", "HCM City", "Da Nang"
            };
            //Pass dữ liệu từ controller (back-end) sang view (front-end)
            //Cách 1: sử dụng ViewData
            ViewData["TenNuoc"] = country;
            ViewData["DanSo"] = population;
            //Cách 2: sử dụng ViewBag
            ViewBag.ThanhPho = cities;

            return View();
        }
    }
}
