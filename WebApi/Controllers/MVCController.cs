using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class MVCController : Controller
    {
        // GET: MVC
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetImage(int id = 1)
        {
            Categories Categories = db.Categories.Find(id);
            byte[] img = Categories.Picture;
            if (img == null)
            {
                return File("~/images/NO.jpg", "image/png");
            }
            else
                return File(img, "image/jpeg");
        }


        public ActionResult Index2()
        {
            return View();
        }
    }
}