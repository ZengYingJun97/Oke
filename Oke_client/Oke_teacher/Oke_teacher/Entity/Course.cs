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
        public string courseNumber { set; get; }

        public string courseName { set; get; }

        public DateTime courseCreateTime { set; get; }

        public DateTime courseEndTime { set; get; }

        public Teacher teacher { set; get; }
    }
}
