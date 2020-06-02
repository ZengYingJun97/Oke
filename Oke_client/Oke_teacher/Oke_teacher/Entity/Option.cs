using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 问题选项信息封装类
    /// </summary>
    [Serializable]
    public class Option
    {
        public int optionId { set; get; }

        public Question question { set; get; }

        public string optionType { set; get; }

        public string optionDescribe { set; get; }
    }
}
