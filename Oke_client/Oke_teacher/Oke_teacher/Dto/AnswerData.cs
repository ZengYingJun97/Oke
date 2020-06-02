using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 答题情况数据类
    /// </summary>
    [Serializable]
    public class AnswerData
    {
        public int total { set; get; }
        public int correct { set; get; }
        public int error { set; get; }
        public int unCommitted { set; get; }
    }
}
