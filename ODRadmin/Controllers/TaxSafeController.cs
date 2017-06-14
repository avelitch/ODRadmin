using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODRadmin.Models;

namespace ODRadmin.Controllers
{
    [Authorize(Users = "avelitch@sow.by,labkovich.mihail@gmail.com,gdansk@taxsafe.pl")]
    public class TaxSafeController : Controller
    {
        // GET: TaxSafe
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
            return FileManagerExtension.DownloadFiles(FileManager2Helper.GetSettings(), Server.MapPath("~/content/taxsafe/"));
        }
    }
  

}
