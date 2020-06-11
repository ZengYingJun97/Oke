using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 课堂信息封装类
    /// </summary>
    [Serializable]
    public class Course
    {
        //课程号
        public string courseNumber { set; get; }
        //课程名
        public string courseName { set; get; }
        //课程创建时间
        public DateTime? courseCreateTime { set; get; }
        //课程结束时间
        public DateTime? courseEndTime { set; get; }
        //课程所属老师
        public Teacher teacher { set; get; }
    }
}
