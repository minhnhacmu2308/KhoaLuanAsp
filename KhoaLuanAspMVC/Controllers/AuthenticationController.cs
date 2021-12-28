using KhoaLuanAspMVC.Daos;
using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhoaLuanAspMVC.Controllers
{
    public class AuthenticationController : Controller
    {
        SinhVienDao sinhVienDao = new SinhVienDao();
        // GET: Authentication
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(SINHVIEN user)
        {
            if (user.TAIKHOAN == "quanly" && user.MATKHAU == "quanly")
            {
                SINHVIEN sv = new SINHVIEN();
                sv.MASV = "QUANLY";
                sv.MALOP = "QUANLY";
                sv.MACN = "QUANLY";
                sv.HOTEN = "QUẢN TRỊ VIÊN";
                Session.Add("USER", sv);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                SINHVIEN checkLogin = sinhVienDao.checkLogin(user.TAIKHOAN, user.MATKHAU);

                if (checkLogin != null)
                {

                    Session.Add("USER", checkLogin);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.msg = "Tài khoản hoặc mật khẩu bị sai";
                    return View();
                }
            }

        }
        public ActionResult Logout()
        {
            Session.Remove("USER");
            return Redirect("/");
        }
    }
}