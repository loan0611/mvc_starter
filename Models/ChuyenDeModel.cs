using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ChuyenDeModel
    {
        public int MaChuyenDe { get; set; }
        public string ChuyenDe { get; set; }

        public virtual ICollection<TaiLieuModel> TaiLieus { get; set; }
    }
}