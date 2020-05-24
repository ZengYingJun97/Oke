using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Enums
{
    public static class EnumExtend
    {
        /// <summary>
        /// 获取Enum上的display
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string GetDisplayText(this Enum t)
        {
            var t_type = t.GetType();
            var fieldName = Enum.GetName(t_type, t);
            var objs = t_type.GetField(fieldName).GetCustomAttributes(typeof(DisplayAttribute), false);
            return objs.Length > 0 ? ((DisplayAttribute)objs[0]).Name : null;
        }
    }
}
