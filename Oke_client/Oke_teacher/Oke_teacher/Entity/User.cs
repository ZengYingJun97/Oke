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
        public string username { set; get; }

        public string password { set; get; }
    }
}
