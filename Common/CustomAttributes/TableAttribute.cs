using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute:Attribute
    {
        public string Name{get;protected set;}
        public TableAttribute(string tableName)
        {
            this.Name = tableName;
        }
        
    }
}
