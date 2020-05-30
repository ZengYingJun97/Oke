using Oke_teacher.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Info
{
    public class CourseInfo
    {
        public string sessionId { set; get; }

        public Course data { set; get; }

        public string classCode { set; get; }

        private static CourseInfo _CurrentUser;

        public static CourseInfo CurrentUser
        {
            get
            {
                if (_CurrentUser == null)
                {
                    _CurrentUser = new CourseInfo();
                }
                return _CurrentUser;
            }
        }
    }
}
