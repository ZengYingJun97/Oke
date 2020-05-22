using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Uitls
{
    public static class UserUitls
    {
        public static bool IsOkUsername(string username)
        {
            return username.Length >= 8 && username.Length <= 20;
        }

        public static bool IsOkPassword(string password)
        {
            return password.Length >= 8 && password.Length <= 20;
        }
    }
}
