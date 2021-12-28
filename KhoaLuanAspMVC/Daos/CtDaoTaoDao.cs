using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoaLuanAspMVC.Daos
{

    public class CtDaoTaoDao
    {
        MyDB myDb = new MyDB();
        public List<CTDAOTAO> getAll()
        {
            return myDb.CTDAOTAOs.ToList();
        }
    }
}