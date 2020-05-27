using Oke_teacher.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 用户传递新旧密码数据类
    /// </summary>
    [Serializable]
    public class UpdateUserData
    {
        public User user { set; get; }

        public string newPassword { set; get; }
    }
}
