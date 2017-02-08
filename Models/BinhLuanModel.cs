using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class BinhLuanModel
    {
        public int MaBinhLuan { get; set; }
        public int MaThanhVien { get; set; }
        public int MaTaiLieu { get; set; }
        public string NDBinhLuan { get; set; }
        public DateTime NgayBL { get; set; }

        public virtual ThanhVienModel ThanhVien { get; set; }
        public virtual TaiLieuModel TaiLieus { get; set; }

        public virtual ICollection<ReplyModel> Replys { get; set; }

    }
}