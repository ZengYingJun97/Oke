using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 课堂学生上传记录封装类
    /// </summary>
    [Serializable]
    public class CourseRecord
    {
        public Course course { set; get; }

        public Student student { set; get; }

        public DateTime onlineTime { set; get; }

        public DateTime offlineTime { set; get; }
    }
}
