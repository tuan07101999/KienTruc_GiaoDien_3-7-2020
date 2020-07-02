using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Phim
    {
        public int PhimId { get; set; }

        public string TenPhim { get; set; }
        public string LuaTuoi { get; set; }
        public DateTime NgayCongChieu { get; set; }
        public string TheLoai { get; set; }
        public int ThoiLuong { get; set; }
        public string NuocSanXuat { get; set; }
        public string DaoDien { get; set; }
        public string NoiDung { get; set; }

        public int SuatChieuId { get; set; }
        public virtual SuatChieu SuatChieu { get; set; }

        public virtual List<SuatChieu> suatChieus { get; set; }
    }
}
