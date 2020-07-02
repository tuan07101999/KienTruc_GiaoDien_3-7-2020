using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.List
{
    public class ListGhe
    {
        public static List<Ghe> DsGhe
        {
            get
            {
                List<Ghe> ds = new List<Ghe>();
                var words = new List<string>() { "A", "B", "C" };
                var ma = 1;
                foreach (var w in words)
                {
                    for (int i = 1; i <= 18; i++)
                    {
                        var name = w;
                        if (i < 10)
                            name += $"0{i}";
                        else
                            name += $"{i}";
                        var ghe = new Ghe
                        {
                            TrangThai = false,
                            Gia = 65000,
                            TenGhe = name,
                            GheId = ma
                        };
                        ds.Add(ghe);
                        ma++;
                    }
                }

                words = new List<string>() { "AA", "BB" };

                foreach (var w in words)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        var name = w;
                        if (i < 10)
                            name += $"0{i}";
                        else
                            name += $"{i}";
                        var ghe = new Ghe
                        {
                            TrangThai = false,
                            Gia = 105000,
                            TenGhe = name,
                            GheId = ma
                        };
                        ds.Add(ghe);
                        ma++;
                    }
                }

                return ds;
            }
        }
    }
}
