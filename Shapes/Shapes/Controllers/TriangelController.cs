using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shapes.Models;

namespace Shapes.Controllers
{
    public class TriangelController : Controller
    {
        // GET: Triangel
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Triangle t)
        {
            bool isTriangle = t.LaTamGiac();
            if(isTriangle == true)
            {
                ViewBag.ThongBao = "Dien Tich = " + t.Acreage() + " - Chu Vi = " + t.Perimeter();
                ViewBag.Class = "alert-success";
            }
            else
            {
                ViewBag.Class = "alert-warning";
                ViewBag.ThongBao = "Không phải là tam giác, vui lòng nhập lại";
            }

            return View(t);
        }

        
    }
}