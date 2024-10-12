using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute:Attribute
    {
        public string ColName { get; protected set; }
        public ColumnAttribute(string colName)
        {
            this.ColName = colName;
        }
    }
}
