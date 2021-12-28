using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoaLuanAspMVC.Daos
{
    
    public class ChuyenNganhDao
    {
        MyDB myDb = new MyDB();
        public List<CHUYENNGANH> getAll()
        {
            return myDb.CHUYENNGANHs.ToList();
        }
    }
}