using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class LichSuDownload
    {
        public int MaThanhVien { get; set; }
        public int MaTaiLieu { get; set; }

        public virtual ThanhVienModel ThanhVien { get; set; }
        public virtual TaiLieuModel TaiLieu { get; set; }
    }
}