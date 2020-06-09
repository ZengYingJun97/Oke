using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Entity
{
    /// <summary>
    /// 投稿信息封装类
    /// </summary>
    public class Mail
    {
        public int mailId { set; get; }

        public string mailTitle { set; get; }

        public string mailDescribe { set; get; }
        
        public User mailFromUser { set; get; }

        public User mailToUser { set; get; }
    }
}
