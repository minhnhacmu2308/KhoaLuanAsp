using KhoaLuanAspMVC.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhoaLuanAspMVC.Controllers
{
    public class DiemController : Controller
    {
        DiemDao diemDao = new DiemDao();
        // GET: Diem
        public ActionResult Index()
        {
            ViewBag.List = diemDao.getAll();
            return View();
        }
        public ActionResult DiemSV(string id)
        {
            ViewBag.List = diemDao.checkDelete(id);
            ViewBag.SoTC = diemDao.sumTC(id);
            ViewBag.DiemTB = diemDao.diemTB(id);
            return View();
        }
    }
}