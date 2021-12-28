using KhoaLuanAspMVC.Daos;
using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhoaLuanAspMVC.Controllers
{
    public class HomeController : Controller
    {
        SinhVienDao sinhVienDao = new SinhVienDao();
        public ActionResult Index()
        {
            var result = (SINHVIEN)Session["USER"];
            if (result == null)
            {
                return RedirectToAction("Login", "Authentication");
            }
            else
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}