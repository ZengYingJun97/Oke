using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oke_teacher.Entity;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 用于传输问题的数据类
    /// </summary>
    [Serializable]
    public class QuestionData
    {
        //问题
        public Question question { set; get; }
        //选项
        public List<Option> optionList { set; get; }
    }
}
