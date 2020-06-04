using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 学生投票信息封装类
    /// </summary>
    [Serializable]
    public class VoteStudent
    {
        public Student student { set; get; }

        public Vote vote { set; get; }

        public VoteChoice voteChoice { set; get; }
    }
}
