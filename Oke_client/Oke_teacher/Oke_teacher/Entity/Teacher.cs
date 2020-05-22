using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    public class Teacher
    {
        public int teacherId { set; get; }

        public string teacherName { set; get; }

        public string teacherTitle { set; get; }

        public User user { set; get; }

    }
}
