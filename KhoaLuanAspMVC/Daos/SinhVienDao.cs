using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoaLuanAspMVC.Daos
{
    public class SinhVienDao
    {
        MyDB myDb = new MyDB();

        public List<SINHVIEN> getAll()
        {
            return myDb.SINHVIENs.ToList();
        }

        public SINHVIEN checkLogin(string username, string password)
        {
            return myDb.SINHVIENs.FirstOrDefault(x => x.TAIKHOAN == username && x.MATKHAU == password);
        }
        public void add(SINHVIEN sINHVIEN)
        {
            myDb.SINHVIENs.Add(sINHVIEN);
            myDb.SaveChanges();
        }

        public void edit(SINHVIEN sINHVIEN)
        {
            var obj = myDb.SINHVIENs.FirstOrDefault(x => x.MASV == sINHVIEN.MASV);
            obj.HOTEN = sINHVIEN.HOTEN;
            obj.MALOP = sINHVIEN.MALOP;
            obj.GIOITINH = sINHVIEN.GIOITINH;
            obj.NGAYSINH = sINHVIEN.NGAYSINH;
            obj.NOISINH = sINHVIEN.NOISINH;
            obj.DIACHI = sINHVIEN.DIACHI;
            obj.TAIKHOAN = sINHVIEN.TAIKHOAN;
            obj.MATKHAU = sINHVIEN.MATKHAU;
            obj.GHICHU = sINHVIEN.GHICHU;
            obj.MACN = sINHVIEN.MACN;
            myDb.SaveChanges();
        }

        public void delete(string masv)
        {
            var obj = myDb.SINHVIENs.FirstOrDefault(x => x.MASV == masv);
            myDb.SINHVIENs.Remove(obj);
            myDb.SaveChanges();
        }

        public SINHVIEN getSV(string masv)
        {
            return myDb.SINHVIENs.FirstOrDefault(p => p.MASV == masv);
        }
    }
}