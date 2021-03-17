using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace theFirstApp.Controllers
{
    public class PortflioController : Controller
    {
        // GET: Portflio
        public ActionResult Index()
        {
            return View();
        }
    }
}