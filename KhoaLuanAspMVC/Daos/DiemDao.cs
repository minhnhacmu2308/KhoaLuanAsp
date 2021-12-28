using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoaLuanAspMVC.Daos
{
    public class DiemDao
    {
        MyDB myDb = new MyDB();
        public List<DIEM> checkDelete(string masv)
        {
            return myDb.DIEMs.Where(p => p.MASV == masv).ToList();
        }
        public List<DIEM> getAll()
        {
            return myDb.DIEMs.ToList();
        }
        public int sumTC(string masv)
        {
            return (int)myDb.DIEMs.Where(p => p.MASV == masv).Sum(c => c.HOCPHAN.SOTC);
        }
        public float diemTB(string masv)
        {
            if(checkDelete(masv).Count > 0)
            {
                return (float)myDb.DIEMs.Where(p => p.MASV == masv).Average(c => c.DIEM1);
            }
            else
            {
                return 0;
            }
            
        }
    }
}