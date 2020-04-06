using Nzh.Knight.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.Model
{
    [Table("t_Role")]
    public class RoleModel : Entity
    {
        /// <summary>
        /// 角色编码
        /// </summary>
        [Display(Name = "角色编码")]
        public string RoleCode { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [Display(Name = "角色名称")]
        public string RoleName { get; set; }
        /// <summary>
        /// 角色描述
        /// </summary>
        [Display(Name = "角色描述")]
        public string Remark { get; set; }
    }
}
