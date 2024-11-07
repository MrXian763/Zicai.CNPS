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

        /// <summary>
        /// 按日统计快递数目
        /// </summary>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <returns>该月每日的快递统计数据</returns>
        public List<ExpDayCountInfo> StatExpressCountByDay(int year, int month)
        {
            List<ExpDayCountInfo> list = statisticsDAL.StatExpressCountByDay(year, month);
            int days = DateTime.DaysInMonth(year, month); // 当月的总天数
            List<ExpDayCountInfo> newList = new List<ExpDayCountInfo>(); // 本月每天顺序的快递数据集合
            // 筛选出所有日期
            List<string> dates = list.Select(e => e.InsertDate).Distinct().ToList(); // 有快递入库的日期(2022-11-12)集合
            for (int i = 1; i <= days; i++)
            {
                bool isExists = false; // i日是否存在
                // 2022-11-12
                foreach (string date in dates)
                {
                    int day = int.Parse(date.Substring(8, 2)); // 截取日
                    if (i == day)
                    {
                        isExists = true;
                        var subList = list.Where(e => e.InsertDate == date).ToList(); // 获取i日的快递集合
                        if (subList.Count > 0)
                        {
                            // i日的快递数据存在
                            int total = subList.Sum(e => e.ExpCount); // i日的总快递数目
                            int hasCount = 0, unCount = 0;
                            ExpDayCountInfo hasInfo = subList.Find(e => e.ExpState == "已完成");
                            if (hasInfo != null)
                                hasCount = hasInfo.ExpCount;
                            ExpDayCountInfo unhasInfo = subList.Find(e => e.ExpState == "未完成");
                            if (unhasInfo != null)
                                unCount = unhasInfo.ExpCount;
                            newList.Add(new ExpDayCountInfo()
                            {
                                InsertDate = date,
                                ExpCount = total,
                                HasCount = hasCount,
                                UnCount = unCount
                            });
                        }
                        break;
                    }
                }
                if (!isExists)
                {
                    // i日没有快递
                    string date = year + "-" + month.ToString("00") + "-" + i.ToString("00");
                    newList.Add(new ExpDayCountInfo()
                    {
                        InsertDate = date,
                        ExpCount = 0,
                        HasCount = 0,
                        UnCount = 0
                    });
                }
            }
            return newList;
        }

        /// <summary>
        /// 按周统计快递数目
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns>这一年每周的快递数据统计</returns>
        public List<ExpWeekCountInfo> StatExpressCountByWeek(int year)
        {
            List<ExpWeekCountInfo> list = statisticsDAL.StatExpressCountByWeek(year);
            int count = 52; // 一年的周数 365/7
            List<ExpWeekCountInfo> newList = new List<ExpWeekCountInfo>(); // 这一年每周顺序的快递数据
            List<int> weeks = list.Select(e => e.WeekNumber).Distinct().ToList(); // 有快递的周
            for (int i = 1; i <= count; i++) // 按顺序遍历每周
            {
                bool isExists = false;
                foreach (int weekNum in weeks)
                {
                    if (i == weekNum)
                    {
                        isExists = true;
                        var subList = list.Where(e => e.WeekNumber == weekNum).ToList(); // 获取本周的快递集合
                        if (subList.Count > 0)
                        {
                            // 本周存在快递
                            int total = subList.Sum(e => e.ExpCount); // 当周的总快递数目
                            int hasCount = 0, unCount = 0;
                            ExpWeekCountInfo hasInfo = subList.Find(e => e.ExpState == "已完成");
                            if (hasInfo != null)
                                hasCount = hasInfo.ExpCount;
                            ExpWeekCountInfo unhasInfo = subList.Find(e => e.ExpState == "未完成");
                            if (unhasInfo != null)
                                unCount = unhasInfo.ExpCount;
                            newList.Add(new ExpWeekCountInfo()
                            {
                                WeekNumber = weekNum,
                                ExpCount = total,
                                HasCount = hasCount,
                                UnCount = unCount
                            });
                        }
                        break;
                    }
                }
                if (!isExists)
                {
                    newList.Add(new ExpWeekCountInfo()
                    {
                        WeekNumber = i,
                        ExpCount = 0,
                        HasCount = 0,
                        UnCount = 0
                    });
                }
            }
            return newList;
        }

        /// <summary>
        /// 按月统计快递数目
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns>这一年每一个月的快递数据统计</returns>
        public List<ExpMonthCountInfo> StatExpressCountByMonth(int year)
        {
            List<ExpMonthCountInfo> list = statisticsDAL.StatExpressCountByMonth(year);
            int count = 12; // 一年12个月
            List<ExpMonthCountInfo> newList = new List<ExpMonthCountInfo>(); // 这一年每月顺序的快递数据
            List<int> months = list.Select(e => e.MonthNumber).Distinct().ToList(); // 有快递数据的月份
            for (int i = 1; i <= count; i++)
            {
                bool isExists = false;
                foreach (int month in months)
                {
                    if (i == month)
                    {
                        isExists = true;
                        var subList = list.Where(e => e.MonthNumber == month).ToList(); // 获取第i月的快递集合
                        if (subList.Count > 0)
                        {
                            // 第i月有快递
                            int total = subList.Sum(e => e.ExpCount); // 当月的总快递数目
                            int hasCount = 0, unCount = 0;
                            ExpMonthCountInfo hasInfo = subList.Find(e => e.ExpState == "已完成");
                            if (hasInfo != null)
                                hasCount = hasInfo.ExpCount;
                            ExpMonthCountInfo unhasInfo = subList.Find(e => e.ExpState == "未完成");
                            if (unhasInfo != null)
                                unCount = unhasInfo.ExpCount;
                            newList.Add(new ExpMonthCountInfo()
                            {
                                MonthNumber = month,
                                ExpCount = total,
                                HasCount = hasCount,
                                UnCount = unCount
                            });
                        }
                        break;
                    }
                }
                if (!isExists)
                {
                    newList.Add(new ExpMonthCountInfo()
                    {
                        MonthNumber = i,
                        ExpCount = 0,
                        HasCount = 0,
                        UnCount = 0
                    });
                }
            }
            return newList;
        }

        /// <summary>
        /// 统计员工快递数据
        /// </summary>
        /// <param name="year">当年的快递数据</param>
        /// <returns>员工快递统计总数据</returns>
        public EmpExpressStatInfo StatEmpExpressData(int year)
        {
            EmpExpressStatInfo empStat = statisticsDAL.StatEmpExpressData(year);
            var expList = empStat.EmpDisExpInfos; // 获取员工派送列表
            List<EmpStatInfo> empList = new List<EmpStatInfo>(); // 员工派送数据
            if (expList.Count > 0)
            {
                List<int> empIds = expList.Select(e => e.EmpId).Distinct().ToList(); // 获取员工派送列表中的员工ID集合
                // 统计每名员工的派送数据
                foreach (int empId in empIds)
                {
                    EmpStatInfo emp = new EmpStatInfo();
                    var subList = expList.Where(e => e.EmpId == empId).ToList(); // 获取某一员工的派送列表
                    if (subList.Count > 0)
                    {
                        // 该员工有派送数据
                        emp.EmpId = empId; // 员工ID
                        emp.EmpName = subList[0].EmpName; // 员工名称
                        emp.TotalCount = subList.Count; // 派送总量
                        emp.SignedCount = subList.Where(e => e.IsSignFor == true).Count(); // 已完成量
                        emp.UnSignCount = emp.TotalCount - emp.SignedCount; // 未完成量
                        empList.Add(emp);
                    }
                }
                int maxCount = empList.Max(e => e.SignedCount); // 最大已完成派送量
                if (maxCount > 0)
                {
                    int index = empList.FindIndex(e => e.SignedCount == maxCount); // 获取派送冠军的集合索引
                    empStat.SuperDisCount = maxCount;
                    empStat.SuperEmpName = empList[index].EmpName; // 冠军
                }
                else
                {
                    empStat.SuperDisCount = 0;
                    empStat.SuperEmpName = "";
                }
            }
            empStat.EmpStatInfos = empList;
            return empStat;
        }
    }
}
