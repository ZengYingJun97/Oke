using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Enums
{
    /// <summary>
    /// 用户登录提示消息
    /// </summary>
    public enum LoginEnum
    {
        [Display(Name = "用户名或密码不能为空")]
        NULLINPUT,
        [Display(Name = "用户名长度应8-20")]
        ERRORURN,
        [Display(Name = "密码长度应8-20")]
        ERRORPWD,
        [Display(Name = "用户名或密码不存在")]
        FAIL_LOGIN,
        [Display(Name = "登录成功")]
        SUCC_LOGIN
    }
}
