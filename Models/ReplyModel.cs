using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ReplyModel
    {
        public int MaReply { get; set; }
        public int MaThanhVien { get; set; }
        public int MaBinhLuan { get; set; }
        public string NDReply { get; set; }
        public DateTime NgayReply { get; set; }

        public virtual BinhLuanModel BinhLuan { get; set; }
        public virtual ThanhVienModel ThanhVien { get; set; }
    }
}