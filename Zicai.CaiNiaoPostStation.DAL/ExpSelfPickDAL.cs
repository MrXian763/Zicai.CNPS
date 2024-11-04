using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.DAL.Base;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class ExpSelfPickDAL : BaseDAL<ExpSelfPickInfo>
    {
        /// <summary>
        /// 获取今日的总自提快递数
        /// </summary>
        /// <returns></returns>
        public int GetTodaySelfCount()
        {
            string sql = "select count(1) from ExpSelfPickInfos where left(convert(varchar,InsertTime,120),10)=left(convert(varchar,getdate(),120),10)";
            return SelectAndReIntValue(sql);
        }

        /// <summary>
        /// 获取指定的快递的自提信息
        /// </summary>
        /// <param name="expId">快递ID</param>
        /// <returns></returns>
        public ExpSelfPickInfo GetSelfPickInfo(int expId)
        {
            return GetModel("ExpId=" + expId + " and IsDeleted=0", "");
        }
    }
}
