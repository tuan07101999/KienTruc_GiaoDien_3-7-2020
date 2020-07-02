using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.List
{
    public class ListKhungGio
    {
        public static List<KhungGio> GetDSKG()
        {
            var ds = new List<KhungGio>();
            ds.Add(new KhungGio
            {
                KhungGioId = 1,
                TenKhungGio = "11h"
            });
            ds.Add(new KhungGio
            {
                KhungGioId = 2,
                TenKhungGio = "14h30"
            });
            ds.Add(new KhungGio
            {
                KhungGioId = 3,
                TenKhungGio = "19h"
            });
            return ds;
        }
    }
}
