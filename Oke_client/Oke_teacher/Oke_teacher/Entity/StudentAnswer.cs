using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 学生回答封装类
    /// </summary>
    [Serializable]
    public class StudentAnswer
    {
        public Student student { set; get; }

        public Question question { set; get; }

        public string answerContent { set; get; }

        public int answerCorrect { set; get; }

        public float answerValue { set; get; }
    }
}
