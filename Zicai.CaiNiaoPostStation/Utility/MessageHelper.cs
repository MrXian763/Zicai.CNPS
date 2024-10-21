using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiCai.CaiNiaoPostStation.Utility
{
    /// <summary>
    /// 封装三种消息提示框
    /// </summary>
    public  class MessageHelper
    {
        /// <summary>
        /// 显示成功的提示信息
        /// </summary>
        /// <param name="title"></param>
        /// <param name="msg"></param>
        public static void Info(string title,string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 显示错误的提示信息
        /// </summary>
        /// <param name="title"></param>
        /// <param name="msg"></param>
        public static void Error(string title, string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 显示询问的提示信息
        /// </summary>
        /// <param name="title"></param>
        /// <param name="msg"></param>
        public static DialogResult Confirm(string title, string msg)
        {
           return MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
