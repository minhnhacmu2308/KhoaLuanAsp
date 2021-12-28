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
    }
}