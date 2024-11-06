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
    public class ExpSelfPickUpBLL
    {
        ViewSelfPickUpExpressDAL selfPickUpExpressDAL = new ViewSelfPickUpExpressDAL();

        /// <summary>
        ///  分页查询快递自提信息列表
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
            PageModel<ViewSelfPickUpExpressInfo> pageModel = selfPickUpExpressDAL.FindSelfPickUpExpressList(keywords, stationId, recPhone, expState, startIndex, pageSize);
            if (pageModel.PageList.Count > 0)
            {
                pageModel.PageList.ForEach(info =>
                {
                    info.PickText = info.IsPickUp ? "" : "取件";
                });
            }
            return pageModel;
        }
    }
}
