using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Enums
{
    public enum RegisterEnum
    {
        [Display(Name = "主要信息不能为空")]
        NULLINPUT,
        [Display(Name = "两次输入密码不一致")]
        DIFFPWD,
        [Display(Name = "用户名长度应8-20")]
        ERRORURN,
        [Display(Name = "密码长度应8-20")]
        ERRORPWD
    }
}
