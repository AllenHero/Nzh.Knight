using Nzh.Knight.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyAttribute = Nzh.Knight.Extension.KeyAttribute;

namespace Nzh.Knight.Model
{
    public class Entity
    {
        [Key(true)]
        public virtual int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Display(Name = "创建时间")]
        public DateTime CreateOn { get; set; }

        [Display(Name = "修改时间")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public virtual DateTime UpdateOn { get; set; }

        [Display(Name = "创建人")]
        public virtual int CreateBy { get; set; }

        [Display(Name = "修改人")]
        public virtual int UpdateBy { get; set; }

        [Display(Name = "状态")]
        public bool? Status { get; set; }

        [Computed]
        public string StartEndDate { get; set; }
    }
}
