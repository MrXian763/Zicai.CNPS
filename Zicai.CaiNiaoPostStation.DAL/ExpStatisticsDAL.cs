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
        /// <param name="stationId">站点ID</param>
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

        /// <summary>
        /// 按日统计快递数目
        /// </summary>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <returns>该月每日的快递统计数据</returns>
        public List<ExpDayCountInfo> StatExpressCountByDay(int year, int month)
        {
            string sql = "StatisticsExpCountByDay";
            SqlParameter[] paras =
            {
                new SqlParameter("@year",year),
                new SqlParameter("@month",month)
            };
            DataTable dt = SqlHelper.GetDataTable(sql, 2, paras);
            return DbConvert.DataTableToList<ExpDayCountInfo>(dt, "InsertDate,ExpCount,ExpState");
        }

        /// <summary>
        /// 按周统计快递数目
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns>这一年每周的快递数据统计</returns>
        public List<ExpWeekCountInfo> StatExpressCountByWeek(int year)
        {
            string sql = "StatisticsExpCountByWeek";
            SqlParameter[] paras =
            {
                new SqlParameter("@year",year)
            };
            DataTable dt = SqlHelper.GetDataTable(sql, 2, paras);
            return DbConvert.DataTableToList<ExpWeekCountInfo>(dt, "WeekNumber,ExpCount,ExpState");
        }

        /// <summary>
        /// 按月统计快递数目
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns>这一年每一个月的快递数据统计</returns>
        public List<ExpMonthCountInfo> StatExpressCountByMonth(int year)
        {
            string sql = "StatisticsExpCountByMonth";
            SqlParameter[] paras =
            {
                new SqlParameter("@year",year)
            };
            DataTable dt = SqlHelper.GetDataTable(sql, 2, paras);
            return DbConvert.DataTableToList<ExpMonthCountInfo>(dt, "MonthNumber,ExpCount,ExpState");
        }
    }
}
