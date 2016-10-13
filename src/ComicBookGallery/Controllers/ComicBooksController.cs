using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing spider man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final Issue! ma niiiiiiga</p>",
                Artists = new Artist[]
                {
                    new Artist() {Name="Dan Slott",Role="Script" },
                    new Artist() {Name="Ramos",Role="Penicls" },
                    new Artist() {Name="Victor",Role="Inks" },
                    new Artist() {Name="Edgar",Role="Colors" },
                    new Artist() {Name="Chris",Role="Letters" },
                }


            };


            return View(comicBook);
        }
    }
}