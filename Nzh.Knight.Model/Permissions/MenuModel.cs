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
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }
        /// <summary>
        /// 菜单路径
        /// </summary>
        public string MenuUrl { get; set; }
        /// <summary>
        /// 菜单图标
        /// </summary>
        public string MenuIcon { get; set; }
        /// <summary>
        /// 父菜单
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public int OrderNo { get; set; }
        /// <summary>
        /// 菜单操作字符串
        /// </summary>
        [Computed]
        public string MenuActionHtml { get; set; }
        [Computed]
        public bool IsChecked { get; set; }
    }
}
