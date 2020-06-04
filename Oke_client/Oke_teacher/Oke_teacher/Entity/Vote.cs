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
        public int voteId { set; get; }

        public Course course { set; get; }

        public string voteDescribe { set; get; }

        public int voteLimitTime { set; get; }
    }
}
