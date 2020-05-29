using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oke_teacher.Entity;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 用于传输登录状态的数据类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class SessionData<T>
    {
        public string sessionId { set; get; }

        public T data { set; get; }

        public static implicit operator SessionData<T>(Course v)
        {
            throw new NotImplementedException();
        }
    }
}
