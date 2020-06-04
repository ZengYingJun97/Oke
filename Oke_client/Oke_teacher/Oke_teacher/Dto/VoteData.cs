using Oke_teacher.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 投票信息数据类
    /// </summary>
    [Serializable]
    public class VoteData
    {
        public Vote vote { set; get; }

        public List<VoteChoice> voteChoiceList { set; get; }
    }
}
