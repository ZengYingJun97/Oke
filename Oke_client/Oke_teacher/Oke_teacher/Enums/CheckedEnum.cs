using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Enums
{
    /// <summary>
    /// 是否被选择的颜色
    /// </summary>
    public enum CheckedEnum
    {
        //被选择颜色
        CHECKED = 152 + 251 * 256 + 152 * 256 * 256,
        //没被选择颜色
        NOCHECKED = 211 + 211 * 256 + 211 * 256 * 256
    }
}
