using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Utility
{
    /// <summary>
    /// 快递类别选择事件参数类
    /// </summary>
    public class ChooseExpTypeArgs
    {
        public string ChoosedExpType { get; set; }
        public ChooseExpTypeArgs(string choosedExpType)
        {
            ChoosedExpType = choosedExpType;
        }
    }
}
