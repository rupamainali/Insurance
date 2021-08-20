using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayRuRemit.Controllers
{
    public class PayRuController : Controller
    {
        // GET: PayRu
        public ActionResult Create()
        {
            return View();
        }
    }
}