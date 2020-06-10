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
        //登录时sessionId
        public string sessionId { set; get; }
        //上课的课程信息
        public Course data { set; get; }
        //上课码
        public string classCode { set; get; }
        //静态单例
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
