using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODRadmin.Models;

namespace ODRadmin.Controllers
{
    public class FirmController : Controller
    {
        // GET: Firm
     

        [HttpGet]
        public ActionResult Index()
        {
           
            var x = new client();
            x.CompanyName = "Организация";
            return View(new client());
        }

        [HttpPost]
        public ActionResult Index(client item)
        {
            if (ModelState.IsValid)
            {
                return View("OKview");
            }
            else return View("Index", item);

        
            }
        }
    }