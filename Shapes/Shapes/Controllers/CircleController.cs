using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shapes.Models;

namespace Shapes.Controllers
{
    public class CircleController : Controller
    {
        // GET: Circle
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Circle c)
        {
            ViewBag.ThongBao = "Dien Tich = " + c.Acreage() + " - Chu Vi = " + c.Perimeter();
            return View(c);
        }
    }
}