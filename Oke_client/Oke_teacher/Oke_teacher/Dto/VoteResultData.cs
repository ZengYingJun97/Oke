using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 投票情况数据类
    /// </summary>
    [Serializable]
    public class VoteResultData
    {
        public int total { set; get; }
        public List<int> ints {set;get;}
    }
}
