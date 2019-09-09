using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookmarkImportClient.Web.Models;

namespace BookmarkImportClient.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /*
        /// <remarks>Should likely delegate to other action method, and should call data API (BookmarkImportApi),  
        /// once input has been validated/normalized.</remarks>
        /// <returns>Home page for web UI as MVC View object.</returns>
        /// <param name="formFiles">Bookmark import/export files as model objects - likely only one (1) incoming.</param>
        [HttpPost]
        public IActionResult Index(List<Microsoft.AspNetCore.Http.IFormFile> formFiles)
        {
            //TODO: Process Mozilla-style bookmark export/import files.

            //For debugging:
            if (formFiles.Any()) {
                ViewData["Message"] = "First bookmark file name: " + formFiles.First().FileName;
            }

            return View();
        }
        */

        //TODO: Rename view and correlated action method to match display data.
        public IActionResult About()
        {
            ViewData["Message"] = "Bookmarks import files were processed without error.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
