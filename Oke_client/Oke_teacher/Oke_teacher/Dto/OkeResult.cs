using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 接收服务器传回数据封装
    /// </summary>
    public class OkeResult<T>
    {
        public bool success { set; get; }

        public T data { set; get; }

        public string error { set; get; }
    }
}
