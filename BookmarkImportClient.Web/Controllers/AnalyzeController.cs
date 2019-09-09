using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadSample.Controllers
{
    public class AnalyzeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Do the analysis of loaded bookmark data here.");
        }
    }
}