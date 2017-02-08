using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<TaiLieuModel> TaiLieus { get; set; }
        public DbSet<ChuyenDeModel> ChuyenDes { get; set; }
        public DbSet<BinhLuanModel> BinhLuans { get; set; }
        public DbSet<NgonNguModel> NgonNgus { get; set; }
        public DbSet<TacGiaModel> TacGias { get; set; }
        public DbSet<TuKhoaModel> TuKhoas { get; set; }
        public DbSet<ThanhVienModel> ThanhViens { get; set; }
        public DbSet<ReplyModel> Replys { get; set; }
        public DbSet<RatingModel> Ratings { get; set; }
        public DbSet<DanhSachTaiLieuYeuTichModel> DSTLYTs { get; set; }
        public DbSet<LichSuDownload> LichSuDownloads { get; set; }
        public DbSet<TuKhoaTaiLieuModel> TuKhoaTaiLieus { get; set; }
        public DbSet<DiemTichLuyModel> DiemTichLuys { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}