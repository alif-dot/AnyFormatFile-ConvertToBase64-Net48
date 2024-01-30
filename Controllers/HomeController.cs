using PdfDocxFileConvertToBase64.Models;
using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PdfDocxFileConvertToBase64.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(FileUploadModel model)
        {
            if (model.File != null && model.File.ContentLength > 0)
            {
                byte[] fileBytes;

                using (MemoryStream ms = new MemoryStream())
                {
                    model.File.InputStream.CopyTo(ms);
                    fileBytes = ms.ToArray();
                }

                string base64String = Convert.ToBase64String(fileBytes);

                try
                {
                    using (MyAppContext db = new MyAppContext())
                    {
                        db.Database.CommandTimeout = 3600;
                        db.DocumentTable.Add(new Document
                        {
                            FileName = Path.GetFileName(model.File.FileName),
                            FileType = Path.GetExtension(model.File.FileName),
                            Base64Content = base64String,
                            UploadedDateTime = DateTime.Now
                        });

                        db.SaveChanges();
                        ViewBag.Success = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                ViewBag.Base64String = base64String;
            }

            return RedirectToAction("Index");
        }
    }
}