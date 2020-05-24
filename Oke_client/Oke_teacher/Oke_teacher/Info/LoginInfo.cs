using Oke_teacher.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Info
{
    /// <summary>
    /// 单态模式保存用户信息
    /// </summary>
    public class LoginInfo
    {
        public string sessionId { set; get; }

        public Teacher teacher { set; get; }

        private static LoginInfo _CurrentUser;

        public static LoginInfo CurrentUser
        {
            get
            {
                if (_CurrentUser == null)
                {
                    _CurrentUser = new LoginInfo();
                }
                return _CurrentUser;
            }
        }
    }
}
