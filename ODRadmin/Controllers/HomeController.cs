using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODRadmin.Models;
using DevExpress.Web.Mvc;

namespace ODRadmin.Controllers
{
    [Authorize(Users = "avelitch@sow.by,labkovich.mihail@gmail.com")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }
        public ActionResult Docs()
        {


            return View();
        }
        public ActionResult Reports()
        {


            return View();
        }
        public ActionResult Files()
        {


            return View();
        }
        public ActionResult Contact()
        {


            return View();
        }
        public ActionResult FilesContractors()
        {


            return View();
        }
        public ActionResult FilesAdmins()
        {


            return View();
        }
        public ActionResult FileManagerPartial()
        {
            return PartialView();
        }

        public FileStreamResult FileManagerDownload()
        {
            return FileManagerExtension.DownloadFiles(FileManager3Helper.GetSettings(), Server.MapPath("~/content/"));
        }
    }
}