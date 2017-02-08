using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ThanhVienModel
    {
        public int MaThanhVien { get; set; }
        public string TenTruyCap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public string Email { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string QuyenHan { get; set; }

        public virtual ICollection<LichSuDownload> LichSuDownloads { get; set; }

        public virtual ICollection<DanhSachTaiLieuYeuTichModel> DanhSachTaiLieuYeuThichs { get; set; }

        public virtual ICollection<BinhLuanModel> BinhLuans { get; set; }
    }
}