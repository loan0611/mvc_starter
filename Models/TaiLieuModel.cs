using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class TaiLieuModel
    {
        public int MaTaiLieu { get; set; }
        public int MaChuyenDe { get; set; }
        public int MaTuKhoa { get; set; }
        public int MaNgonNgu { get; set; }
        public int MaThanhVienUpload { get; set; }
        public int MaThanhVienDuyet { get; set; }
        public int MaRating { get; set; }
        public string NhanDe { get; set; }
        public int SoTrang { get; set; }
        public DateTime NgayUpload { get; set; }
        public int KichThuoc { get; set; }
        public int LuotXem { get; set; }
        public string LinkFile { get; set; }
        public int SoLanDownload { get; set; }
        public string GhiChu { get; set; }
        public decimal Phi { get; set; }
        public string TinhTrang { get; set; }

        public virtual ChuyenDeModel ChuyenDe { get; set; }
        public virtual NgonNguModel NgonNgu { get; set; }
        public virtual TacGiaModel TacGia { get; set; }
        public virtual RatingModel Rating { get; set; }


        public virtual ICollection<LichSuDownload> LichSuDownloads { get; set; }

        public virtual ICollection<DanhSachTaiLieuYeuTichModel> DanhSachTaiLieuYeuThichs { get; set; }

        public virtual ICollection<BinhLuanModel> BinhLuans { get; set; }

    }
}