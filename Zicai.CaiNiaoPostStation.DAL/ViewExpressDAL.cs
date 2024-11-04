using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.Models.VModels;
using ZiCai.CainiaoPostStation.DAL.Base;
using ZiCai.CainiaoPostStation.Models.UIModels;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class ViewExpressDAL : BQuery<ViewExpressInfo>
    {
        /// <summary>
        /// 分页查询快递列表
        /// </summary>
        /// <param name="keywords">查询关键词</param>
        /// <param name="expType">快递类别</param>
        /// <param name="stationId">快递所在站点ID</param>
        /// <param name="expState">快递状态</param>
        /// <param name="expNumber">快递单号</param>
        /// <param name="receiver">收件人</param>
        /// <param name="receivePhone">收件人电话</param>
        /// <param name="pickWay">取件方式</param>
        /// <param name="isDeleted">是否已删除</param>
        /// <param name="startIndex">起始索引</param>
        /// <param name="pageSize">页面数据大小</param>
        /// <returns>快递数据列表</returns>
        public PageModel<ViewExpressInfo> FindExpressList(string keywords, string expType, int stationId, string expState, string expNumber, string receiver, string receivePhone, string pickWay, int isDeleted, int startIndex, int pageSize)
        {
            string strWhere = $"IsDeleted={isDeleted}";
            if (!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and (ExpNumber like @keywords  or SendAddress  like @keywords or ReceiveAddress   like @keywords  or ExpRemark like @keywords)";
            }
            if (!string.IsNullOrEmpty(expType))
            {
                strWhere += " and ExpType like @expType";
            }
            if (stationId > 0)
            {
                strWhere += " and StationId=" + stationId;
            }
            if (!string.IsNullOrEmpty(expState))
            {
                strWhere += " and ExpState=@expState";
            }
            if (!string.IsNullOrEmpty(pickWay))
            {
                strWhere += " and PickWay=@pickWay";
            }
            if (!string.IsNullOrEmpty(expNumber))
            {
                strWhere += " and ExpNumber like @expNumber";
            }
            if (!string.IsNullOrEmpty(receiver))
            {
                strWhere += " and Receiver = @receiver";
            }
            if (!string.IsNullOrEmpty(receivePhone))
            {
                strWhere += " and ReceiverPhone = @receiverPhone";
            }
            string cols = "ExpId,ExpNumber,ExpType,Receiver,ReceiverPhone,StationName,Sender,SenderPhone,ExpState,EnterTime,PickWay";
            SqlParameter[] paras =
            {
                new SqlParameter("@keywords", $"%{keywords}%"),
                new SqlParameter("@expType", $"%{expType}%"),
                new SqlParameter("@expState", expState),
                new SqlParameter("@expNumber", $"%{expNumber}%"),
                new SqlParameter("@receiver", receiver),
                new SqlParameter("@receiverPhone", receivePhone),
                new SqlParameter("@pickWay", pickWay)
            };
            return GetRowsModelList<ViewExpressInfo>(strWhere, cols, "Id", "ExpId", startIndex, pageSize, paras);
        }
    }
}
