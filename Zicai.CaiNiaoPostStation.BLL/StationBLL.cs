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
    public class StationBLL
    {
        StationDAL stationDAL = new StationDAL();

        /// <summary>
        /// 分页查询站点信息
        /// </summary>
        /// <param name="keywords">查询关键词</param>
        /// <param name="isShowDel">是否展示已删除数据</param>
        /// <param name="startIndex">开始页码</param>
        /// <param name="pageSize">页面数据大小</param>
        /// <returns>站点列表</returns>
        public PageModel<StationInfo> FindStationList(string keywords, bool isShowDel, int startIndex, int pageSize)
        {
            int isDeleted = isShowDel ? 1 : 0; // 0:未删除，1:已删除
            return stationDAL.FindStationList(keywords, isDeleted, startIndex, pageSize);
        }

        /// <summary>
        /// 获取绑定下拉框的所有站点列表
        /// </summary>
        /// <returns>站点列表</returns>
        public List<StationInfo> GetCboStationList()
        {
            return stationDAL.GetCboStationList();
        }

        /// <summary>
        /// 添加站点，返回站点编号
        /// </summary>
        /// <param name="station">站点信息</param>
        /// <returns>新添的站点编号</returns>
        /// <exception cref="Exception"></exception>
        public int AddStation(StationInfo station)
        {
            if (station == null)
                throw new Exception("站点信息不能为空！");
            return stationDAL.AddStation(station);
        }

        /// <summary>
        /// 修改站点
        /// </summary>
        /// <param name="station">站点信息</param>
        /// <returns>修改结果</returns>
        /// <exception cref="Exception"></exception>
        public bool UpdateStation(StationInfo station)
        {
            if (station == null)
                throw new Exception("站点信息不能为空！");
            return stationDAL.Update(station, "");
        }

        /// <summary>
        /// 判断站点编码是否存在
        /// </summary>
        /// <param name="stationNo">站点编码</param>
        /// <returns>结果</returns>
        public bool ExistStationNo(string stationNo)
        {
            return stationDAL.ExistStationNoOrName(stationNo, true);
        }

        /// <summary>
        /// 判断站点名称是否存在
        /// </summary>
        /// <param name="stationName">站点名称</param>
        /// <returns>结果</returns>
        public bool ExistStationName(string stationName)
        {
            return stationDAL.ExistStationNoOrName(stationName, false);
        }

        /// <summary>
        /// 获取指定站点信息
        /// </summary>
        /// <param name="stationId">站点ID</param>
        /// <returns>站点信息</returns>
        public StationInfo GetStation(int stationId)
        {
            return stationDAL.GetById(stationId, "");
        }

        /// <summary>
        /// 删除站点（逻辑删除）
        /// </summary>
        /// <param name="stations">要删除的站点列表</param>
        /// <returns>删除结果</returns>
        public string DeleteStations(List<StationInfo> stations)
        {
            string reStr = ""; // 删除结果提示词
            string hasNames = ""; // 存储运营中站点名称字符串
            List<int> stationIds = new List<int>(); // 存储符合删除的站点编号
            foreach (StationInfo station in stations)
            {
                if (station.IsRunning) // 站点运营中
                {
                    if (hasNames != "")
                        hasNames += ",";
                    hasNames += station.StationName;
                }
                else
                    stationIds.Add(station.StationId); // 加入符合删除站点编号列表
            }

            bool blDel = false; // 删除操作结果
            if (stationIds.Count > 0) // 有符合删除的数据
                blDel = stationDAL.UpdateStationDelState(stationIds, 0, 1); // 逻辑删除站点列表
            if (blDel)
            {
                if (hasNames == "") // 没有不能删除的站点
                    reStr = "1"; // 删除成功
                else
                    reStr = "1;" + hasNames; // 删除成功，但存在不能删除的站点
            }
            else
            {
                if (stationIds.Count > 0)
                    reStr = "0"; // 删除失败
                else
                    reStr = "-1;"; // 所有选择的站点都不能删除
            }
            return reStr;
        }

        /// <summary>
        /// 恢复站点
        /// </summary>
        /// <param name="stationIds">站点ID集合</param>
        /// <returns>操作结果</returns>
        public bool RecoverStations(List<int> stationIds)
        {
            return stationDAL.UpdateStationDelState(stationIds, 0, 0);
        }

        /// <summary>
        /// 移除站点（彻底删除）
        /// </summary>
        /// <param name="stationIds">站点ID集合</param>
        /// <returns>操作结果</returns>
        public bool RemoveStations(List<int> stationIds)
        {
            return stationDAL.UpdateStationDelState(stationIds, 1, 2);
        }
    }
}
