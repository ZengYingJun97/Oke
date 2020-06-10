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
        //选项id
        public int optionId { set; get; }
        //选项所属的问题
        public Question question { set; get; }
        //选项类型
        public string optionType { set; get; }
        //选项描述
        public string optionDescribe { set; get; }
    }
}
