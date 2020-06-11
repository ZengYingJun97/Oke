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
        //投票选项id
        public int voteChoiceId { set; get; }
        //所属投票
        public Vote vote { set; get; }
        //投票选项类型
        public string voteChoiceType { set; get; }
        //投票选项描述
        public string voteChoiceDescribe { set; get; }
    }
}
