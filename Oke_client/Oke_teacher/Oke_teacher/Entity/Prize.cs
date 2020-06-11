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
        //奖品ID
        public int prizeId { set; get; }
        //所属抽奖
        public Scratcher scratcher { set; get; }
        //奖品描述
        public string prizeDescribe { set; get; }
        //奖品数量
        public int prizeCount { set; get; }
    }
}
