using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODRadmin.Models;

namespace ODRadmin.Controllers
{
    [Authorize(Users = "avelitch@sow.by,labkovich.mihail@gmail.com,ksiegowosc@taxcare.pl")]
    public class TaxCareController : Controller
    {
        // GET: TaxCare
        public ActionResult Files()
        {
            return View();
        }

        public ActionResult FileManagerPartial()
        {
            return PartialView();
        }

        public FileStreamResult FileManagerDownload()
        {
            return FileManagerExtension.DownloadFiles(FileManagerHelper.GetSettings(), Server.MapPath("~/content/taxcare/"));
        }
    }
  

}