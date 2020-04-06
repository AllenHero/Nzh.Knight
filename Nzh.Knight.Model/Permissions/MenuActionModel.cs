using Nzh.Knight.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.Model
{
    [Table("t_menu_action")]
    public class MenuActionModel
    {
        /// <summary>
        /// 菜单ID
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// 操作ID
        /// </summary>
        public int ActionId { get; set; }
    }
}
