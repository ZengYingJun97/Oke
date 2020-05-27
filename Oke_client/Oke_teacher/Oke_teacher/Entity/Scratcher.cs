using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 抽奖信息封装类
    /// </summary>
    [Serializable]
    public class Scratcher
    {
        public int scratcherId { set; get; }

        public Course course { set; get; }

        public List<Prize> prizeList { set; get; }
    }
}
