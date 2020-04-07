using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.Model
{
    public class Pager
    {
        public static dynamic Paging(IEnumerable<dynamic> list, long total)
        {
            return new { code = 0, count = total, data = list };
        }
    }

    public class PageInfo
    {
        public int page { get; set; }

        public int limit { get; set; }

        public string field { get; set; }

        public string order { get; set; }

        public string returnFields { get; set; }

        public string prefix { get; set; }
    }
}
