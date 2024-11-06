using Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.DAL.Base;
using Zicai.CaiNiaoPostStation.Models.UIModels;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class ExpStatisticsDAL
    {
        /// <summary>
        /// 统计快递完成度数量
        /// </summary>
        /// <returns>[0]-已完成数；[1]-未完成数</returns>
        public int[] StatExpressCountData(int stationId = 0)
        {
            string sql = "select * from dbo.StatisticsExpCompletion(" + stationId + ")";
            DataTable dt = SqlHelper.GetDataTable(sql, 1);
            int[] reCounts = new int[2];
            if (dt.Rows.Count > 0)
            {
                reCounts[0] = (int)dt.Rows[0][0]; // 已完成数
                reCounts[1] = (int)dt.Rows[0][1]; // 未完成数
            }
            return reCounts;
        }

        /// <summary>
        /// 根据是否完成获取指定的快递列表
        /// </summary>
        /// <param name="isComplete">1-已完成</param>
        /// <returns>快递数据列表</returns>
        public List<ExpressComInfo> GetExpressListByCount(int isComplete, int stationId)
        {
            string sql = "GetExpressListByState";
            SqlParameter[] paras =
            {
                new SqlParameter("@isCompleted",isComplete),
                new SqlParameter("@stationId",stationId)
            };
            DataTable dt = SqlHelper.GetDataTable(sql, 2, paras);
            return DbConvert.DataTableToList<ExpressComInfo>(dt, "");
        }
    }
}
