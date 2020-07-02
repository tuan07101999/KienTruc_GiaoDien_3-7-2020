using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RapPhim
    {
        public int RapPhimId { get; set; }

        public string TenRap { get; set; }
        public int SoluongGhe { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoaiLienHe { get; set; }
        
        public virtual List<Phim> Phims { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
