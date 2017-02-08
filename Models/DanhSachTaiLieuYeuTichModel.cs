using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class DanhSachTaiLieuYeuTichModel
    {
        public int MaThanhVien { get; set; }
        public int MaTaiLieu { get; set; }

        public virtual ThanhVienModel ThanhVien { get; set; }
        public virtual TaiLieuModel TaiLieu { get; set; }
    }
}