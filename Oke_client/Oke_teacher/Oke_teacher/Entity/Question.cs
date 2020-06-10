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
        //问题id
        public int questionId { set; get; }
        //问题所属课程
        public Course course { set; get; }
        //问题类型(0:单选题, 1:多选题, 2:判断题, 3:填空题, 4:简答题)
        public int questionType { set; get; }
        //问题描述
        public string questionDescribe { set; get; }
        //问题答案
        public string questionAnswer { set; get; }
        //问题分数
        public int questionScore { set; get; }
        //问题限时
        public int questionLimitTime { set; get; }
    }
}
