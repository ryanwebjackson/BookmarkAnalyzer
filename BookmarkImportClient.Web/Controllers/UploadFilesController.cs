using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadSample.Controllers
{
    public class UploadFilesController : Controller
    {
        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.
            //https://github.com/aspnet/AspNetCore.Docs/blob/master/aspnetcore/mvc/models/file-uploads/sample/FileUploadSample/Controllers/UploadFilesController.cs
            var loadedRecords = BookmarkDataProcessor.Main.LoadNetscapeStyleBookmarkFile(filePath);

            return Ok(new { uploadFileSize = size, recordsLoaded = loadedRecords });
        }
    }
}