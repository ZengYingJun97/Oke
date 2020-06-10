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
        //学生
        public Student student { set; get; }
        //投票
        public Vote vote { set; get; }
        //学生的选择
        public VoteChoice voteChoice { set; get; }
    }
}
