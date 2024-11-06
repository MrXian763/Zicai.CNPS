using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.DAL;
using Zicai.CaiNiaoPostStation.Models.UIModels;

namespace Zicai.CaiNiaoPostStation.BLL
{
    public class ExpStatisticsBLL
    {
        ExpStatisticsDAL statisticsDAL = new ExpStatisticsDAL();

        /// <summary>
        /// 快递完成度数量统计 
        /// </summary>
        /// <param name="stationId">站点ID</param>
        /// <returns>[0]-已完成数；[1]-未完成数</returns>
        public List<ExpressCountInfo> StatExpressCountData(int stationId = 0)
        {
            int[] reCounts = statisticsDAL.StatExpressCountData(stationId);
            List<ExpressCountInfo> statList = new List<ExpressCountInfo>();
            statList.Add(new ExpressCountInfo() { ExpState = "已完成数", ExpCount = reCounts[0] });
            statList.Add(new ExpressCountInfo() { ExpState = "未完成数", ExpCount = reCounts[1] });
            return statList;
        }

        /// <summary>
        /// 根据是否完成获取指定的快递列表
        /// </summary>
        /// <param name="isComplete">是否已完成</param>
        /// <param name="stationId">站点ID</param>
        /// <returns>快递数据列表</returns>
        public List<ExpressComInfo> GetExpressListByCount(bool isComplete, int stationId)
        {
            int isCompleted = isComplete ? 1 : 0;
            return statisticsDAL.GetExpressListByCount(isCompleted, stationId);
        }
    }
}
