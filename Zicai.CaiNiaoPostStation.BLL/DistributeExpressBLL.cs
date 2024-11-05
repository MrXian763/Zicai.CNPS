using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.DAL;
using ZiCai.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.Models.VModels;

namespace Zicai.CaiNiaoPostStation.BLL
{
    public class DistributeExpressBLL
    {
        ViewDistributeExpressDAL ViewDistributeExpressDAL = new ViewDistributeExpressDAL();
        ExpDistributeDAL distributeDAL = new ExpDistributeDAL();

        /// <summary>
        /// 分页查询快递派送信息列表 
        /// </summary>
        /// <param name="keywords">查询关键词</param>
        /// <param name="recPhone">收件人电话</param>
        /// <param name="expState">快递状态</param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns>快递派送信息列表</returns>
        public PageModel<ViewDistributeExpressInfo> FindDistributeExpressList(string keywords, int stationId, string recPhone, string expState, int startIndex, int pageSize)
        {
            return ViewDistributeExpressDAL.FindDistributeExpressList(keywords, stationId, recPhone, expState, startIndex, pageSize);
        }

        /// <summary>
        /// 保存派送安排
        /// </summary>
        /// <param name="expIds">快递ID集合</param>
        /// <param name="empId">派送员工ID</param>
        /// <param name="disTime">派送时间</param>
        /// <returns>保存结果</returns>
        public bool SaveDistributeAssignSet(List<int> expIds, int empId, DateTime disTime)
        {
            return distributeDAL.SaveDistributeAssignSet(expIds, empId, disTime);
        }
    }
}
