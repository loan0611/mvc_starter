using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class NgonNguModel
    {
        public int MaNgonNgu { get; set; }
        public string NgonNgu { get; set; }

        public virtual ICollection<TaiLieuModel> TaiLieus { get; set; }

    }
}