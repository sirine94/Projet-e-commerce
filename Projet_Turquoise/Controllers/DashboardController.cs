using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projet_Turquoise.Models;
using System.IO;

namespace Projet_Turquoise.Controllers
{
    [Authorize(Users = "Administrator@gmail.com")]
    public class DashboardController : Controller
    {
        // GET: Dashboard
       public ActionResult Index()
        {  
            return View();
        }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/Content/Photos"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "File Uploaded Successfully!!";
                return View();
            } 
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
        }
    }
}
