using Oke_teacher.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Dto
{
    /// <summary>
    /// 学生上课记录数据类
    /// </summary>
    [Serializable]
    public class CourseRecordData
    {
        public CourseRecord courseRecord { set; get; }

        public int score { set; get; }
    }
}
