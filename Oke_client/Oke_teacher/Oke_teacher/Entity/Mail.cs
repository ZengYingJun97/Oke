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
        //邮件ID
        public int mailId { set; get; }
        //邮件主题
        public string mailTitle { set; get; }
        //邮件描述
        public string mailDescribe { set; get; }
        //邮件发起方
        public User mailFromUser { set; get; }
        //邮件接收方
        public User mailToUser { set; get; }
    }
}
