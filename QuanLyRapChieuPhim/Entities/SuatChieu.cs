using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SuatChieu
    {
        public int SuatChieuId { get; set; }

        public int KhungGioId { get; set; }
        public int PhimId { get; set; }

        public virtual Phim Phim { get; set; }
        public virtual KhungGio KhungGios { get; set; }

        public virtual List<Ve> Ves { get; set; }
        
    }
}
