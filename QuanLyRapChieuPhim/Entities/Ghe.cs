using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ghe
    {
        public int GheId { get; set; }

        public string TenGhe { get; set; }
        public double Gia { get; set; }
        public bool TrangThai { get; set; }

        public virtual List<Ve> Ves { get; set; }
    }
}
