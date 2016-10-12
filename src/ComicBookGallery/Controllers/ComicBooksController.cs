using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The amazing Spider-man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final Issue! ma niiiiiiga</p>";
            ViewBag.Artists = new string[]
            {
                "Test","Drago","magio"
            };

            return View();
        }
    }
}