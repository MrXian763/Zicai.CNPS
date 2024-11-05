using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.DAL;
using ZiCai.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.Models.VModels;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.BLL
{
    public class ExpressBLL
    {

        ViewExpressDAL viewExpressDAL = new ViewExpressDAL();
        ExpressDAL expressDAL = new ExpressDAL();
        ExpSelfPickDAL expSelfPickDAL = new ExpSelfPickDAL();

        /// <summary>
        /// 分页查询快递信息
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="expType"></param>
        /// <param name="stationId"></param>
        /// <param name="expState"></param>
        /// <param name="expNumber"></param>
        /// <param name="receiver"></param>
        /// <param name="receivePhone"></param>
        /// <param name="pickWay"></param>
        /// <param name="blShowDel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageModel<ViewExpressInfo> FindExpressList(string keywords, string expType, int stationId, string expState, string expNumber, string receiver, string receivePhone, string pickWay, bool blShowDel, int startIndex, int pageSize)
        {
            int isDeleted = blShowDel ? 1 : 0;
            return viewExpressDAL.FindExpressList(keywords, expType, stationId, expState, expNumber, receiver, receivePhone, pickWay, isDeleted, startIndex, pageSize);
        }

        /// <summary>
        /// 检查快递单号是否存在
        /// </summary>
        /// <param name="expNumber"></param>
        /// <returns></returns>
        public bool ExistExpressNumber(string expNumber)
        {
            return expressDAL.ExistExpressNumber(expNumber);
        }

        /// <summary>
        /// 添加快递信息---取件方式：派送
        /// </summary>
        /// <param name="expInfo"></param>
        /// <returns></returns>
        public int AddExpressInfo(ExpressInfo expInfo)
        {
            return expressDAL.AddExpressInfo(expInfo);
        }

        /// <summary>
        /// 添加快递信息---取件方式：自提
        /// </summary>
        /// <param name="expInfo"></param>
        /// <param name="selfPick"></param>
        /// <returns></returns>
        public int AddExpressInfo(ExpressInfo expInfo, ExpSelfPickInfo selfPick)
        {
            return expressDAL.AddExpressInfo(expInfo, selfPick);
        }

        /// <summary>
        /// 修改快递信息,之前已是派送或自提，这里只更新快递信息
        /// </summary>
        /// <param name="expInfo"></param>
        /// <returns></returns>
        public bool UpdateExpressInfo(ExpressInfo expInfo)
        {
            return expressDAL.UpdateExpressInfo(expInfo);

        }

        /// <summary>
        /// 修改快递信息，改为自提或还是自提（更新取件）
        /// </summary>
        /// <param name="expInfo"></param>
        /// <param name="selfPick"></param>
        /// <returns></returns>
        public bool UpdateExpressInfo(ExpressInfo expInfo, ExpSelfPickInfo selfPick)
        {
            return expressDAL.UpdateExpressInfo(expInfo, selfPick);

        }

        /// <summary>
        /// 修改快递信息，并删除之前的自提记录
        /// </summary>
        /// <param name="expInfo"></param>
        /// <param name="selfPickId"></param>
        /// <returns></returns>
        public bool UpdateExpressInfo(ExpressInfo expInfo, int selfPickId)
        {
            return expressDAL.UpdateExpressInfo(expInfo, selfPickId);

        }

        /// <summary>
        /// 派送签收
        /// </summary>
        /// <param name="expIds"></param>
        /// <param name="signTime"></param>
        /// <returns></returns>
        public bool SignExpress(List<int> expIds, DateTime signTime)
        {
            return expressDAL.SignExpress(expIds, false, signTime.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        /// <summary>
        /// 自提签收
        /// </summary>
        /// <param name="expId">快递ID</param>
        /// <param name="pickingCode">自提码</param>
        /// <param name="signTime">签收时间</param>
        /// <returns></returns>
        public bool SignExpress(int expId, string pickingCode, DateTime signTime)
        {
            List<int> ids = new List<int>();
            ids.Add(expId);
            return expressDAL.SignExpress(ids, true, signTime.ToString("yyyy-MM-dd HH:mm:ss"), pickingCode);
        }

        /// <summary>
        /// 获取指定的快递信息
        /// </summary>
        /// <param name="expId"></param>
        /// <returns></returns>
        public ExpressInfo GetExpressInfo(int expId)
        {
            return expressDAL.GetById(expId, "");
        }

        /// <summary>
        ///   获取指定的自提信息
        /// </summary>
        /// <param name="expId"></param>
        /// <returns></returns>
        public ExpSelfPickInfo GetSelfPickInfo(int expId)
        {
            return expSelfPickDAL.GetSelfPickInfo(expId);
        }

        /// <summary>
        /// 删除快递信息
        /// </summary>
        /// <param name="expressess">要删除的快递信息集合</param>
        /// <returns>删除结果提示词</returns>
        public string DeleteExpresses(List<ViewExpressInfo> expressess)
        {
            string reStr = "";
            string hasNames = ""; // 存储未签收的快递单号字符串
            List<int> delIds = new List<int>(); // 存储符合删除的快递编号
            foreach (ViewExpressInfo exp in expressess)
            {
                if (exp.ExpState != "已签收")
                {
                    if (hasNames != "")
                        hasNames += ",";
                    hasNames += exp.ExpNumber;
                }
                else
                    delIds.Add(exp.ExpId);
            }
            bool blDel = false;
            if (delIds.Count > 0)
            {
                blDel = expressDAL.UpdateExpressesDelState(delIds, 0, 1); // 删除快递列表
            }
            if (blDel)
            {
                if (hasNames == "")
                    reStr = "1"; // 删除成功
                else
                    reStr = "1;" + hasNames; // 删除成功，但存在不能删除的快递
            }
            else
            {
                if (delIds.Count > 0)
                    reStr = "0"; // 删除失败
                else
                {
                    reStr = "-1;"; // 所有选择的快递都不能删除
                }
            }
            return reStr;
        }

        /// <summary>
        /// 恢复快递信息
        /// </summary>
        /// <param name="expIds">要恢复的快递ID列表</param>
        /// <returns></returns>
        public bool RecoverExpresses(List<int> expIds)
        {
            return expressDAL.UpdateExpressesDelState(expIds, 0, 0);
        }

        /// <summary>
        /// 移除快递信息（真删除）
        /// </summary>
        /// <param name="expIds">要移除的快递ID列表</param>
        /// <returns></returns>
        public bool RemoveExpresses(List<int> expIds)
        {
            return expressDAL.UpdateExpressesDelState(expIds, 1, 2);
        }

        /// <summary>
        /// 获取今日的总自提快递数
        /// </summary>
        /// <returns></returns>
        public int GetTodaySelfCount()
        {
            return expSelfPickDAL.GetTodaySelfCount();
        }
    }
}
