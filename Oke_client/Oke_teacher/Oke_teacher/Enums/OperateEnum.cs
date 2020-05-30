using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Enums
{
    /// <summary>
    /// 操作权限提示信息
    /// </summary>
    public enum OperateEnum
    {
        [Display(Name = "未登录或未开启课堂")]
        NO_COURSE,
        [Display(Name = "操作成功")]
        OP_SUCC,
        [Display(Name = "操作失败")]
        OP_FAIL
    }
}
