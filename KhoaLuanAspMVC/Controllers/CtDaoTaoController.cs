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
        // GET: CtDaoTao
        public ActionResult Index()
        {
            ViewBag.List = ctDaoTaoDao.getAll();
            return View();
        }
    }
}