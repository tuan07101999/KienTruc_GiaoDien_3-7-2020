using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class KhungGio
    {
        public int KhungGioId { get; set; }
        public string TenKhungGio { get; set; }

        public virtual List<SuatChieu> SuatChieu { get; set; }
    }
}
