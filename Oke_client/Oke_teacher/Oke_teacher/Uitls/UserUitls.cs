using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Uitls
{
    public static class UserUitls
    {

        #region 用户名格式判断
        /// <summary>
        /// 用户名格式判断
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool IsOkUsername(string username)
        {
            return username.Length >= 8 && username.Length <= 20;
        }
        #endregion

        #region 密码格式判断
        /// <summary>
        /// 密码格式判断
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsOkPassword(string password)
        {
            return password.Length >= 8 && password.Length <= 20;
        }
        #endregion

        public static bool IsOkInfo(string name, string title)
        {
            return name.Length >= 2 && name.Length <= 10 && title.Length >= 2 && title.Length <= 10;
        }
    }
}
