using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 投票选择信息封装类
    /// </summary>
    [Serializable]
    public class VoteChoice
    {
        public int voteChoiceId { set; get; }

        public Vote vote { set; get; }

        public string voteChoiceType { set; get; }

        public string voteChoiceDescribe { set; get; }
    }
}
