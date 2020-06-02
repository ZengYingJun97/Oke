using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Enums
{
    /// <summary>
    /// 按钮名字
    /// </summary>
    public enum ButtonNameEnum
    {
        [Display(Name = "发 布")]
        SUMBIT,
        [Display(Name = "答 案")]
        GETANS
    }
}
