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
        //总人数
        public int total { set; get; }
        //正确人数
        public int correct { set; get; }
        //错误人数
        public int error { set; get; }
        //未提交人数
        public int unCommitted { set; get; }
    }
}
