using Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhaoxi.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.Models;
using ZiCai.CainiaoPostStation.DAL.Base;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class StationDAL : BaseDAL<StationInfo>
    {
        /// <summary>
        /// 分页条件查询站点信息
        /// </summary>
        /// <param name="keywords">查询关键词</param>
        /// <param name="isDeleted">是否已删除</param>
        /// <param name="startIndex">开始页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <returns>站点列表</returns>
        public PageModel<StationInfo> FindStationList(string keywords, int isDeleted, int startIndex, int pageSize)
        {
            string strWhere = $"IsDeleted = {isDeleted}";
            if (!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and (StationNo like @keywords or StationName like @keywords or StationPYNo like @keywords or Address like @keywords or Manager like @keywords or Phone like @keywords or Remark like @keywords)";
            }
            string cols = CreateSql.GetColNames<StationInfo>(""); // 查询全部属性
            SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
            return GetRowsModelList<StationInfo>(strWhere, cols, "Id", "StationId", startIndex, pageSize, para);
        }

        /// <summary>
        /// 获取所有站点列表（绑定下拉框）
        /// </summary>
        /// <returns>站点列表</returns>
        public List<StationInfo> GetCboStationList()
        {
            return GetModelList("IsRunning = 1 and IsDeleted = 0", "StationId,StationName", "");
        }

        /// <summary>
        /// 检查名称或编码是否存在
        /// </summary>
        /// <param name="value">要检查的值</param>
        /// <param name="isNo">是否编码</param>
        /// <returns></returns>
        public bool ExistStationNoOrName(string value, bool isNo)
        {
            if (isNo)
                return ExistsByName("StationNo", value); // 检查编码
            else
                return ExistsByName("StationName", value); // 检查名称
        }
         
        /// <summary>
        /// 添加站点
        /// </summary>
        /// <param name="station">站点</param>
        /// <returns>站点编号</returns>
        public int AddStation(StationInfo station)
        {
            // 要排除的字段
            string cols = CreateSql.GetColNames<StationInfo>("StationId");
            return Add(station, cols, 1);
        }

        /// <summary>
        /// 删除/恢复/移除站点信息
        /// </summary>
        /// <param name="stationIds"></param>
        /// <param name="delType">删除类别 0-假删除 1-真删除</param>
        /// <param name="isDeleted">0-恢复  1-删除  2-真删除</param>
        /// <returns></returns>
        public bool UpdateStationDelState(List<int> stationIds, int delType, int isDeleted)
        {
            string strIds = string.Join(",", stationIds); // 要删除的站点ID
            string strWhere = $"StationId in ({strIds})"; // 构造删除条件
            List<string> sqlList = new List<string>(); // 要执行的 SQL 语句集合
            if (delType == 0) // 逻辑删除
                sqlList.Add(CreateSql.CreateLogicDeleteSql<StationInfo>(strWhere, isDeleted));
            else // 彻底删除
                sqlList.Add(CreateSql.CreateDeleteSql<StationInfo>(strWhere));
            return SqlHelper.ExecuteTrans(sqlList);
        }
    }
}
