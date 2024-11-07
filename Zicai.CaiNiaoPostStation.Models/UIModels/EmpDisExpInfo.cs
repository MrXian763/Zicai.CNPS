using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.UIModels
{
    /// <summary>
    /// 员工派送列表（简洁）
    /// </summary>
    public class EmpDisExpInfo
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int ExpId { get; set; }
        public bool IsSignFor { get; set; }
    }
}
