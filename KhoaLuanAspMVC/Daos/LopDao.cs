using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoaLuanAspMVC.Daos
{
    public class LopDao
    {
        MyDB myDb = new MyDB();
        public List<LOP> getAll()
        {
            return myDb.LOPs.ToList();
        }
    }
}