using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.Models.VModels;

namespace Zicai.CaiNiaoPostStation.Utility
{
    /// <summary>
    /// 修改或新增快递信息提交后刷新快递信息的事件参数类
    /// </summary>
    public class ExpressArgs : EventArgs
    {
        public ViewExpressInfo VExpressInfo { get; set; }
        public int ActType { get; set; }
        public ExpressArgs(ViewExpressInfo vexp, int actType)
        {
            VExpressInfo = vexp;
            ActType = actType;
        }
    }
}
