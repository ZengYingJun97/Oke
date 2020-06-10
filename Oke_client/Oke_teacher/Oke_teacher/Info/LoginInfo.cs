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
        //登录时的sessionId
        public string sessionId { set; get; }
        //老师信息
        public Teacher data { set; get; }
        //静态单例
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
