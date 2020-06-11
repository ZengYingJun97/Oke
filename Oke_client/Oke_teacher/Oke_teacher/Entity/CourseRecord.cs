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
        //所上课的信息
        public Course course { set; get; }
        //学生
        public Student student { set; get; }
        //上课时间
        public DateTime onlineTime { set; get; }
        //下课时间
        public DateTime offlineTime { set; get; }
    }
}
