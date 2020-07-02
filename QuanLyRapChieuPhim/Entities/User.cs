using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string HoTen { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public int GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int ChucVu { get; set; }

        public int RapPhimId { get; set; }

        public virtual RapPhim RapPhim { get; set; }

        public virtual List<Ve> Ves { get; set; }
    }
}
