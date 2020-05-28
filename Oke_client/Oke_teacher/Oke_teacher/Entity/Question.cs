using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 问题信息封装类
    /// </summary>
    [Serializable]
    public class Question
    {
        public int questionId { set; get; }

        public Course course { set; get; }

        public int questionType { set; get; }

        public string questionDescribe { set; get; }

        public string questionAnswer { set; get; }

        public int questionScore { set; get; }

        public int questionLimitTime { set; get; }
    }
}
