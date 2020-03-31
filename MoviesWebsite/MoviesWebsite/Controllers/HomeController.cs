using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MoviesWebsite.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //At the end all three might prevent caching your data but still have different meanings.
        //[OutputCache(Duration = 0, Location = OutputCacheLocation.Client, VaryByParam = "*")]
        //[OutputCache(NoStore = true, Duration = 0, Location = "None", VaryByParam = "*")]
        //[OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]

        [OutputCache(Duration =0,Location =OutputCacheLocation.Server ,VaryByParam ="*",NoStore =true)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}