using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CustAttributes
{
    /// <summary>
    /// 主键特性
    /// </summary>
   [AttributeUsage(AttributeTargets.Class)]
    public   class PrimaryKeyAttribute:Attribute
    {
        public string KeyName { get; protected set; }
        public bool autoIncrement = false;//是否自增长
        public PrimaryKeyAttribute(string keyName)
        {
            this.KeyName = keyName;
        }
    }
}
