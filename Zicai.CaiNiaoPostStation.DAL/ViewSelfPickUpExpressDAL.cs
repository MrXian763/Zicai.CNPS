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
    public class ViewSelfPickUpExpressDAL : BQuery<ViewSelfPickUpExpressInfo>
    {
        /// <summary>
        /// 分页查询快递自提信息列表
        /// </summary>
        /// <param name="keywords">查询关键词</param>
        /// <param name="stationId">站点ID</param>
        /// <param name="recPhone">收件人电话</param>
        /// <param name="expState">快递状态</param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns>快递自提信息列表</returns>
        public PageModel<ViewSelfPickUpExpressInfo> FindSelfPickUpExpressList(string keywords, int stationId, string recPhone, string expState, int startIndex, int pageSize)
        {
            string strWhere = $"IsDeleted=0";
            List<SqlParameter> listParas = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and (ExpNumber like @keywords or Receiver  like @keywords  or ReceiverPhone like  @keywords  or ReceiveAddress like @keywords or ExpRemark  like @keywords  or PickingCode  like @keywords)";
                listParas.Add(new SqlParameter("@keywords", $"%{keywords}%"));
            }
            if (!string.IsNullOrEmpty(recPhone))
            {
                strWhere += " and ReceiverPhone like  @recPhone";
                listParas.Add(new SqlParameter("@recPhone", $"%{recPhone}%"));
            }
            if (stationId > 0)
            {
                strWhere += "and StationId=" + stationId;
            }
            if (!string.IsNullOrEmpty(expState))
            {
                strWhere += " and ExpState= @expState";
                listParas.Add(new SqlParameter("@expState", expState));
            }
            string cols = "ExpId,ExpNumber,Receiver,ReceiverPhone,ReceiveAddress,StationName,ShelfName,PickingCode,IsPickUp,PickingTime";
            return GetRowsModelList<ViewSelfPickUpExpressInfo>(strWhere, cols, "Id", "ExpId", startIndex, pageSize, listParas.ToArray());
        }
    }
}
