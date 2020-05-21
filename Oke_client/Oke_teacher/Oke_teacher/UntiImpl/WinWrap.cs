using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oke_teacher.UntiImpl
{
    public class WinWrap : IWin32Window
    {
        private IntPtr m_Handle;
        public IntPtr Handle
        {
            get { return m_Handle; }
        }
        //构造函数，参数是父窗口的句柄
        public WinWrap(int handle)
        {
            this.m_Handle = new IntPtr(handle);
        }
    }
}
