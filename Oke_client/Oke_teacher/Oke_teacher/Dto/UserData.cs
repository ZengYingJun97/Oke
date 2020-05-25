using Oke_teacher.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// Data.bin存储对象
    /// </summary>
    [Serializable]
    public class UserData
    {
        public bool isSaveUser { set; get; }

        public User user { set; get; }
    }
}
