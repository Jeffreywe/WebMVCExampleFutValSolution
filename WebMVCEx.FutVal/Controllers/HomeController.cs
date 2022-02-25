using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVCExFutVal.Models;

namespace WebMVCExFutVal.Controllers {
    public class HomeController : Controller {

        public IActionResult Index() {
            ViewBag.Name = "Mary"; // view bag is a built in dictionary
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model) {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }
    }
}
