namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QLRapPhim : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ghes",
                c => new
                    {
                        GheId = c.Int(nullable: false, identity: true),
                        TenGhe = c.String(),
                        Gia = c.Double(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GheId);
            
            CreateTable(
                "dbo.Ves",
                c => new
                    {
                        VeId = c.Int(nullable: false, identity: true),
                        ThoiGianMuaVe = c.DateTime(nullable: false),
                        GiaVe = c.Double(nullable: false),
                        GheId = c.Int(nullable: false),
                        SuatChieuId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VeId)
                .ForeignKey("dbo.Ghes", t => t.GheId, cascadeDelete: true)
                .ForeignKey("dbo.SuatChieux", t => t.SuatChieuId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.GheId)
                .Index(t => t.SuatChieuId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.SuatChieux",
                c => new
                    {
                        SuatChieuId = c.Int(nullable: false, identity: true),
                        KhungGioId = c.Int(nullable: false),
                        PhimId = c.Int(nullable: false),
                        Phim_PhimId = c.Int(),
                        Phim_PhimId1 = c.Int(),
                    })
                .PrimaryKey(t => t.SuatChieuId)
                .ForeignKey("dbo.KhungGios", t => t.KhungGioId, cascadeDelete: true)
                .ForeignKey("dbo.Phims", t => t.Phim_PhimId)
                .ForeignKey("dbo.Phims", t => t.Phim_PhimId1)
                .Index(t => t.KhungGioId)
                .Index(t => t.Phim_PhimId)
                .Index(t => t.Phim_PhimId1);
            
            CreateTable(
                "dbo.KhungGios",
                c => new
                    {
                        KhungGioId = c.Int(nullable: false, identity: true),
                        TenKhungGio = c.String(),
                    })
                .PrimaryKey(t => t.KhungGioId);
            
            CreateTable(
                "dbo.Phims",
                c => new
                    {
                        PhimId = c.Int(nullable: false, identity: true),
                        TenPhim = c.String(),
                        LuaTuoi = c.String(),
                        NgayCongChieu = c.DateTime(nullable: false),
                        TheLoai = c.String(),
                        ThoiLuong = c.Int(nullable: false),
                        NuocSanXuat = c.String(),
                        DaoDien = c.String(),
                        NoiDung = c.String(),
                        SuatChieuId = c.Int(nullable: false),
                        SuatChieu_SuatChieuId = c.Int(),
                        RapPhim_RapPhimId = c.Int(),
                    })
                .PrimaryKey(t => t.PhimId)
                .ForeignKey("dbo.SuatChieux", t => t.SuatChieu_SuatChieuId)
                .ForeignKey("dbo.RapPhims", t => t.RapPhim_RapPhimId)
                .Index(t => t.SuatChieu_SuatChieuId)
                .Index(t => t.RapPhim_RapPhimId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        HoTen = c.String(),
                        Email = c.String(),
                        DiaChi = c.String(),
                        GioiTinh = c.Int(nullable: false),
                        SoDienThoai = c.String(),
                        TenDangNhap = c.String(),
                        MatKhau = c.String(),
                        ChucVu = c.Int(nullable: false),
                        RapPhimId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.RapPhims", t => t.RapPhimId, cascadeDelete: true)
                .Index(t => t.RapPhimId);
            
            CreateTable(
                "dbo.RapPhims",
                c => new
                    {
                        RapPhimId = c.Int(nullable: false, identity: true),
                        TenRap = c.String(),
                        SoluongGhe = c.Int(nullable: false),
                        DiaChi = c.String(),
                        SoDienThoaiLienHe = c.String(),
                    })
                .PrimaryKey(t => t.RapPhimId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ves", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "RapPhimId", "dbo.RapPhims");
            DropForeignKey("dbo.Phims", "RapPhim_RapPhimId", "dbo.RapPhims");
            DropForeignKey("dbo.Ves", "SuatChieuId", "dbo.SuatChieux");
            DropForeignKey("dbo.SuatChieux", "Phim_PhimId1", "dbo.Phims");
            DropForeignKey("dbo.SuatChieux", "Phim_PhimId", "dbo.Phims");
            DropForeignKey("dbo.Phims", "SuatChieu_SuatChieuId", "dbo.SuatChieux");
            DropForeignKey("dbo.SuatChieux", "KhungGioId", "dbo.KhungGios");
            DropForeignKey("dbo.Ves", "GheId", "dbo.Ghes");
            DropIndex("dbo.Users", new[] { "RapPhimId" });
            DropIndex("dbo.Phims", new[] { "RapPhim_RapPhimId" });
            DropIndex("dbo.Phims", new[] { "SuatChieu_SuatChieuId" });
            DropIndex("dbo.SuatChieux", new[] { "Phim_PhimId1" });
            DropIndex("dbo.SuatChieux", new[] { "Phim_PhimId" });
            DropIndex("dbo.SuatChieux", new[] { "KhungGioId" });
            DropIndex("dbo.Ves", new[] { "UserId" });
            DropIndex("dbo.Ves", new[] { "SuatChieuId" });
            DropIndex("dbo.Ves", new[] { "GheId" });
            DropTable("dbo.RapPhims");
            DropTable("dbo.Users");
            DropTable("dbo.Phims");
            DropTable("dbo.KhungGios");
            DropTable("dbo.SuatChieux");
            DropTable("dbo.Ves");
            DropTable("dbo.Ghes");
        }
    }
}
