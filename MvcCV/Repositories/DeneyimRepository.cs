﻿using MvcCV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCV.Repositories
{
    public class DeneyimRepository : GenericRepository<Tbl_Deneyimlerim>
    {
        DbCVEntities db = new DbCVEntities();
    }
}