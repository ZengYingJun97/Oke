using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 老师信息封装类
    /// </summary>
    [Serializable]
    public class Teacher
    {
        //老师id
        public int teacherId { set; get; }
        //老师姓名
        public string teacherName { set; get; }
        //老师职称
        public string teacherTitle { set; get; }
        //老师账号
        public User user { set; get; }
    }
}
