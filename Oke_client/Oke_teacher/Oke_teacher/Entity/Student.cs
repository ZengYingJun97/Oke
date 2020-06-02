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
        public int studentId { set; get; }

        public string studentNumber { set; get; }

        public string studentName { set; get; }

        public string studentClass { set; get; }

        public User user { set; get; }
    }
}
