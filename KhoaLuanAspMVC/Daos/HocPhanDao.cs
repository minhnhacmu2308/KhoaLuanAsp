﻿using KhoaLuanAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoaLuanAspMVC.Daos
{
    public class HocPhanDao
    {
        MyDB myDb = new MyDB();
        public List<HOCPHAN> getAll()

        {
            return myDb.HOCPHANs.ToList();
        }
    }
}