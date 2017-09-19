using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MVClab.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFile"));
            ViewBag.fileArray = files;
            return View();
        }

        public ActionResult Content(string id)
        {
            var newPath = Server.MapPath($"~/TextFile/{id}.txt");
            ViewBag.content = System.IO.File.ReadAllText(newPath);

            return View();
        }
    }
}