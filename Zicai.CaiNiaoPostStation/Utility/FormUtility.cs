using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zicai.CaiNiaoPostStation.Utility
{
    public static class FormUtility
    {
        /// <summary>
        /// 显示异常信息
        /// </summary>
        /// <param name="lblErr">要显示的标签</param>
        /// <param name="msg">异常信息</param>
        public static void SerErrorMsg(this Label lblErr, string msg)
        {
            if (!lblErr.Visible)
                lblErr.Visible = true;
            lblErr.Text = msg;
        }
    }
}
