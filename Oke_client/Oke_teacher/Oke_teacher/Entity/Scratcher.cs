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
        //抽奖ID
        public int scratcherId { set; get; }
        //抽奖所属课程
        public Course course { set; get; }
        //奖品列表
        public List<Prize> prizeList { set; get; }
    }
}
