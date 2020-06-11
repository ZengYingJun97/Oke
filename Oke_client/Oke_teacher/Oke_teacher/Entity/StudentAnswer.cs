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
        //学生
        public Student student { set; get; }
        //问题
        public Question question { set; get; }
        //回答内容
        public string answerContent { set; get; }
        //回答是否正确
        public int answerCorrect { set; get; }
        //回答的价值
        public float answerValue { set; get; }
    }
}
