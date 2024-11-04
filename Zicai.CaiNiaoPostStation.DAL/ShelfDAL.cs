using Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.Models;
using ZiCai.CainiaoPostStation.DAL.Base;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class ShelfDAL : BaseDAL<ShelfInfo>
    {
        /// <summary>
        /// 分页查询货架信息列表
        /// </summary>
        /// <param name="keywords">查询关键词</param>
        /// <param name="isDeleted">是否查询已删除数据</param>
        /// <param name="startIndex">起始索引</param>
        /// <param name="pageSize">每页大小</param>
        /// <returns>货架信息列表</returns>
        public PageModel<ShelfInfo> FindShelvesList(string keywords, int isDeleted, int startIndex, int pageSize)
        {
            string strWhere = $"IsDeleted = {isDeleted}";
            if (!string.IsNullOrEmpty(keywords))
            {
                // 构造查询语句条件
                strWhere += " and (ShelfNo like @keywords or ShelfName  like @keywords  or Address  like @keywords or Remark  like @keywords )";
            }
            SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
            string cols = CreateSql.GetColNames<ShelfInfo>("");
            return GetRowsModelList<ShelfInfo>(strWhere, cols, "Id", "ShelfId", startIndex, pageSize, para);
        }

        /// <summary>
        /// 获取绑定站点下拉框的货架列表
        /// </summary>
        /// <param name="stationId">站点ID</param>
        /// <returns>货架列表</returns>
        public List<ShelfInfo> GetCboShelveList(int stationId)
        {
            string strWhere = "IsDeleted = 0";
            if (stationId > 0)
                strWhere += " and StationId=" + stationId; // 查询属于该站点的货架
            return GetModelList(strWhere, "ShelfId,ShelfName", "");
        }

        /// <summary>
        /// 添加货架信息
        /// </summary>
        /// <param name="shelf">要添加的货架信息</param>
        /// <returns>1-新增成功</returns>
        public int AddShelf(ShelfInfo shelf)
        {
            string cols = CreateSql.GetColNames<ShelfInfo>("ShelfId");
            return Add(shelf, cols, 1);
        }

        /// <summary>
        /// 检查编码或名称是否已存在
        /// </summary>
        /// <param name="value">货架编码、货架名称</param>
        /// <param name="isNo">是否是货架编码</param>
        /// <param name="stationId">站点ID</param>
        /// <returns>是否已存在</returns>
        public bool ExistShelfNoOrName(string value, bool isNo, int stationId = 0)
        {
            if (isNo)
            {
                return ExistsByName("ShelfNo", value);
            }
            else
            {
                if (stationId == 0)
                    return ExistsByName("ShelfName", value);
                else
                    return ExistsByName("ShelfName", value, "StationId", stationId);
            }
        }

        /// <summary>
        /// 删除货架(可多个)
        /// </summary>
        /// <param name="shelfIds">要删除的货架ID集合</param>
        /// <param name="delType">删除类型 0-逻辑删除</param>
        /// <param name="isDeleted">1-逻辑删除；0-恢复</param>
        /// <returns></returns>
        public bool UpdateShelfDelStates(List<int> shelfIds, int delType, int isDeleted)
        {
            string strIds = string.Join(",", shelfIds);
            string strWhere = $"ShelfId in ({strIds})";
            List<string> sqlList = new List<string>();
            if (delType == 0)
            {
                sqlList.Add(CreateSql.CreateLogicDeleteSql<ShelfInfo>(strWhere, isDeleted));
            }
            else
            {
                sqlList.Add(CreateSql.CreateDeleteSql<ShelfInfo>(strWhere));
            }
            return SqlHelper.ExecuteTrans(sqlList);
        }
    }
}
