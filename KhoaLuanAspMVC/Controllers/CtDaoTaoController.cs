using KhoaLuanAspMVC.Daos;
using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhoaLuanAspMVC.Controllers
{
    public class CtDaoTaoController : Controller
    {
        CtDaoTaoDao ctDaoTaoDao = new CtDaoTaoDao();
        HocPhanDao HocPhanDao = new HocPhanDao();
        // GET: CtDaoTao
        public ActionResult Index()
        {
            ViewBag.List = HocPhanDao.getAll();
            return View();
        }
    }
}