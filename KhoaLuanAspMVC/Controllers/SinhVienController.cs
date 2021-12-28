using KhoaLuanAspMVC.Daos;
using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhoaLuanAspMVC.Controllers
{
    public class SinhVienController : Controller
    {
        SinhVienDao sinhVienDao = new SinhVienDao();
        LopDao lopDao = new LopDao();
        ChuyenNganhDao chuyenNganhDao = new ChuyenNganhDao();
        DiemDao diemDao = new DiemDao();
        // GET: SinhVien
        public ActionResult Index(string msg)
        {
            ViewBag.List = sinhVienDao.getAll();
            ViewBag.Lop = lopDao.getAll();
            ViewBag.CN = chuyenNganhDao.getAll();
            ViewBag.Msg = msg;
            return View();
        }
        [HttpPost]
        public ActionResult Delete(FormCollection form)
        {
            var masv = form["masv"];
            List<DIEM> listDiem = diemDao.checkDelete(masv);
            if(listDiem.Count > 0)
            {
                return RedirectToAction("Index", new { msg = "2" });
            }
            else
            {
                sinhVienDao.delete(masv);
                return RedirectToAction("Index", new { msg = "1" });
            }
        }
        [HttpPost]
        public ActionResult Add(SINHVIEN sINHVIEN)
        {
            sinhVienDao.add(sINHVIEN);
            return RedirectToAction("Index", new { msg = "1" });
        }
        [HttpPost]
        public ActionResult Update(SINHVIEN sINHVIEN)
        {
            sinhVienDao.edit(sINHVIEN);
            return RedirectToAction("Index", new { msg = "1" });
        }
        public ActionResult Detail(string id)
        {
            ViewBag.SV = sinhVienDao.getSV(id);
            return View();
        }
        public ActionResult XepLoai()
        {
            ViewBag.List = sinhVienDao.getAll();
            return View();
        }
    }
}