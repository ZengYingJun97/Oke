using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 奖品信息封装类
    /// </summary>
    [Serializable]
    public class Prize
    {
        public int prizeId { set; get; }

        public Scratcher scratcher { set; get; }

        public string prizeDescribe { set; get; }

        public int prizeCount { set; get; }
    }
}
