using Nzh.Knight.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.Model
{
    [Table("t_Menu")]
    public class MenuModel : Entity
    {
        public string MenuName { get; set; }

        public string MenuUrl { get; set; }

        public string MenuIcon { get; set; }

        public int ParentId { get; set; }

        public int OrderNo { get; set; }

        [Computed]
        public string MenuActionHtml { get; set; }

        [Computed]
        public bool IsChecked { get; set; }
    }
}
