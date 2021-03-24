using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shapes.Models;

namespace Shapes.Controllers
{
    public class RectangleController : Controller
    {
        // GET: Rectangle
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Rectangle t)
        {
           
            ViewBag.ThongBao = "Dien Tich = " + t.Acreage() + " - Chu Vi = " + t.Perimeter();

            return View(t);
        }
    }
}