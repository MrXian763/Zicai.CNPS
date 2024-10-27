using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.DAL.Base;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class ExpressDAL : BaseDAL<ExpressInfo>
    {
        /// <summary>
        /// 获取指定货架上的快递数量
        /// </summary>
        /// <param name="shelfId">货架ID</param>
        /// <returns>快递数量</returns>
        public int GetExpressCount(int shelfId)
        {
            string sql = $"select count(1) from ExpressInfos where ShelfId = {shelfId} and IsDeleted=0  and ExpState in ('已入库','未取件')";
            return SelectAndReIntValue(sql);
        }
    }
}
