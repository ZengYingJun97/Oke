using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 用于传输登录状态的数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class SessionData<T>
    {
        public string sessionId { set; get; }

        public T data { set; get; }
    }
}
