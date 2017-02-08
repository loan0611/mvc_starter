using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class TuKhoaModel
    {
        public int MaTuKhoa { get; set; }
        public string TuKhoa { get; set; }

        public virtual ICollection<TuKhoaTaiLieuModel> TuKhoaTaiLieus { get; set; }
    }
}