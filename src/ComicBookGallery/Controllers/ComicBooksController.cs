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
            ViewBag.SeriesTitle = "The Amazing spider man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue ! Witness the final hours of doctor Octopus'life and his great act of revenge! Even if Spider-Man survies... WILL PETER PARKER?</p>";
            ViewBag.Artists = new string[]
        {
            "Script: Dan Slott",
            "Pencils: Humberto Ramos",
            "Inks: victor Olazaba",
            "Colors: Edgar Delgado",
            "letters: Chris Eliopoulos"
        };



            return View();
          

        }

    }
}