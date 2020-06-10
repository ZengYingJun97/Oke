using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 用户账号封装类
    /// </summary>
    [Serializable]
    public class User
    {
        //用户名
        public string username { set; get; }
        //密码
        public string password { set; get; }
    }
}
