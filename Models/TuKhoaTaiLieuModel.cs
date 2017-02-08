﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class TuKhoaTaiLieuModel
    {
        public int MaTuKhoa { get; set; }
        public int MaTaiLieu { get; set; }

        public virtual TuKhoaModel TuKhoa { get; set; }
        public virtual TaiLieuModel TaiLieu { get; set; }
    }
}