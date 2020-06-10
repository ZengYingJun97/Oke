using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 接收服务器传回数据类
    /// </summary>
    public class OkeResult<T>
    {
        //响应是否成功
        public bool success { set; get; }
        //响应结果
        public T data { set; get; }
        //响应错误
        public string error { set; get; }
    }
}
