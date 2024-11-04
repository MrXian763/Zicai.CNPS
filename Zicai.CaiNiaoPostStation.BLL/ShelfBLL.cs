using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.DAL;
using Zicai.CaiNiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.BLL
{
    public class ShelfBLL
    {
        ShelfDAL shelfDAL = new ShelfDAL();
        ExpressDAL expDAL = new ExpressDAL();

        /// <summary>
        /// 分页查询货架信息列表
        /// </summary>
        /// <param name="keywords">关键词：编码、名称、位置、描述</param>
        /// <param name="isShowDel">是否显示已删除数据</param>
        /// <param name="startIndex">起始索引</param>
        /// <param name="pageSize">每页数据大小</param>
        /// <returns>货架信息集合</returns>
        public PageModel<ShelfInfo> FindShelveList(string keywords, bool isShowDel, int startIndex, int pageSize)
        {
            int isDeleted = isShowDel ? 1 : 0;
            return shelfDAL.FindShelvesList(keywords, isDeleted, startIndex, pageSize);
        }

        /// <summary>
        ///  获取绑定下拉框的所有货架列表
        /// </summary>
        /// <param name="stationId">站点ID</param>
        /// <returns>货架列表</returns>
        public List<ShelfInfo> GetCboShelveList(int stationId)
        {
            return shelfDAL.GetCboShelveList(stationId);
        }

        /// <summary>
        /// 检查名称是否存在
        /// </summary>
        /// <param name="shelfName">货架名称</param>
        /// <param name="stationId">站点ID</param>
        /// <returns>是否存在</returns>
        public bool ExistShelfName(string shelfName, int stationId)
        {
            return shelfDAL.ExistShelfNoOrName(shelfName, false, stationId);
        }

        /// <summary>
        /// 检查编码是否存在
        /// </summary>
        /// <param name="shelfNo">站点编码</param>
        /// <returns>是否存在</returns>
        public bool ExistShelfNo(string shelfNo)
        {
            return shelfDAL.ExistShelfNoOrName(shelfNo, true);
        }

        /// <summary>
        /// 添加货架
        /// </summary>
        /// <param name="shelf">货架信息</param>
        /// <returns>1-添加成功</returns>
        public int AddShelf(ShelfInfo shelf)
        {
            return shelfDAL.AddShelf(shelf);
        }

        /// <summary>
        /// 修改货架
        /// </summary>
        /// <param name="shelf">货架信息</param>
        /// <returns>修改结果</returns>
        public bool UpdateShelf(ShelfInfo shelf)
        {
            return shelfDAL.Update(shelf, "");
        }

        /// <summary>
        /// 检查货架是否在使用中
        /// </summary>
        /// <param name="shelfId">货架ID</param>
        /// <returns>是否使用中</returns>
        public bool IsShelfUsing(int shelfId)
        {
            int count = expDAL.GetExpressCount(shelfId); // 获取货架上的快递数量
            return count > 0;
        }

        /// <summary>
        /// 删除货架信息（逻辑删除）
        /// </summary>
        /// <param name="shelves">要删除的货架列表</param>
        /// <param name="hasIds"></param>
        /// <returns>删除结果提示</returns>
        public string DeleteShelves(List<ShelfInfo> shelves, out List<int> hasIds)
        {
            string reStr = "";
            string hasNames = "";
            List<int> delIds = new List<int>(); // 可删除的编号集合
            hasIds = new List<int>(); // 不可删除的编号集合
            foreach (ShelfInfo shelf in shelves)
            {
                // 检查货架是否在使用中
                if (IsShelfUsing(shelf.ShelfId))
                {
                    if (hasNames != "")
                        hasNames += ",";
                    hasNames += shelf.ShelfName;
                    hasIds.Add(shelf.ShelfId); // 添加到不可删除编号集合
                }
                else
                    delIds.Add(shelf.ShelfId); // 添加到可删除编号集合
            }
            bool blDel = false;
            if (delIds.Count > 0) // 可删除集合数大于0
            {
                blDel = shelfDAL.UpdateShelfDelStates(delIds, 0, 1);
            }
            if (blDel)
            {
                if (hasIds.Count == 0)
                    reStr = "1"; // 删除成功
                else
                    reStr = "1;" + hasNames; // 只删除了一部分
            }
            else
            {
                if (delIds.Count > 0)
                    reStr = "0"; // 删除失败
                else
                {
                    reStr = "-1"; // 没有符合删除的货架信息
                }
            }
            return reStr;
        }

        /// <summary>
        /// 恢复货架
        /// </summary>
        /// <param name="shelfIds">要恢复的货架ID</param>
        /// <returns>恢复结果</returns>
        public bool RecoverShelves(List<int> shelfIds)
        {
            return shelfDAL.UpdateShelfDelStates(shelfIds, 0, 0);
        }

        /// <summary>
        /// 移除货架
        /// </summary>
        /// <param name="shelfIds">要移除的货架ID</param>
        /// <returns>移除结果</returns>
        public bool RemoveShelves(List<int> shelfIds)
        {
            return shelfDAL.UpdateShelfDelStates(shelfIds, 1, 2);
        }
    }
}
