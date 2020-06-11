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
        //投票信息
        public Vote vote { set; get; }
        //投票的选项
        public List<VoteChoice> voteChoiceList { set; get; }
    }
}
