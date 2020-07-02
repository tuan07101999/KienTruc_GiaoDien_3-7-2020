using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ve
    {
        public int VeId { get; set; }
        public DateTime ThoiGianMuaVe { get; set; }
        public Double GiaVe { get; set; }

        public int GheId { get; set; }
        public int SuatChieuId { get; set; }
        public int UserId { get; set; }

        public virtual SuatChieu SuatChieu { get; set; }
        public virtual User User { get; set; }
        public virtual Ghe Ghe { get; set; }
    }
}
