using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 学生信息封住类
    /// </summary>
    [Serializable]
    public class Student
    {
        //学生id
        public int studentId { set; get; }
        //学号
        public string studentNumber { set; get; }
        //学生姓名
        public string studentName { set; get; }
        //学生班级
        public string studentClass { set; get; }
        //学生账号
        public User user { set; get; }
    }
}
