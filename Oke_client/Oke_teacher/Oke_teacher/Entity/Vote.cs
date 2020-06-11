using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 投票信息封装类
    /// </summary>
    [Serializable]
    public class Vote
    {
        //投票id
        public int voteId { set; get; }
        //所属课程
        public Course course { set; get; }
        //投票描述
        public string voteDescribe { set; get; }
        //投票限时
        public int voteLimitTime { set; get; }
    }
}
