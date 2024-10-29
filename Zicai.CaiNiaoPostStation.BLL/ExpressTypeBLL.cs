using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.DAL;
using Zicai.CaiNiaoPostStation.Models.VModels;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.BLL
{
    public class ExpressTypeBLL
    {
        ExpressTypeDAL expTypeDAL = new ExpressTypeDAL();
        ViewExpressTypeDAL viewExpressTypeDAL = new ViewExpressTypeDAL();

        /// <summary>
        ///  获取所有类别列表
        /// </summary>
        /// <param name="keywords">查询关键词</param>
        /// <param name="showDel">是否查询已删除数据</param>
        /// <returns>类别列表视图数据</returns>
        public List<ViewExpressTypeInfo> GetExpressTypeList(string keywords, bool showDel)
        {
            int isDeleted = showDel ? 1 : 0;
            return viewExpressTypeDAL.GetExpressTypeList(keywords, isDeleted);
        }

        /// <summary>
        /// 获取绑定下拉框的所有类别列表，默认查询所有父类别
        /// </summary>
        /// <returns></returns>
        public List<ExpressTypeInfo> GetCboExpTypes(int isDefault = 0)
        {
            return expTypeDAL.GetCboExpTypes(isDefault);
        }

        /// <summary>
        /// 检查类别名称是否存在
        /// </summary>
        /// <param name="name">类别名</param>
        /// <param name="parentId">父类别ID</param>
        /// <returns></returns>
        public bool ExistExpType(string name, int parentId)
        {
            return expTypeDAL.ExistExpType(name, parentId);
        }

        /// <summary>
        /// 添加快递类别
        /// </summary>
        /// <param name="expType">快递类别信息</param>
        /// <returns>1-添加成功</returns>
        public int AddExpType(ExpressTypeInfo expType)
        {
            return expTypeDAL.AddExpType(expType);
        }

        /// <summary>
        /// 修改快递类别
        /// </summary>
        /// <param name="expType">快递类别信息</param>
        /// <returns>1-修改成功</returns>
        public bool UpdateExpType(ExpressTypeInfo expType)
        {
            return expTypeDAL.Update(expType, "");
        }

        /// <summary>
        /// 删除快递类别
        /// </summary>
        /// <param name="eTypes">要删除的快递类别集合</param>
        /// <param name="hasIds">不能删除的快递类别ID集合</param>
        /// <returns>删除结果提示词</returns>
        public string DeleteExpressTypes(List<ViewExpressTypeInfo> eTypes, out List<int> hasIds)
        {
            string reStr = "";
            string hasNames = "";
            List<int> delIds = new List<int>(); // 可删除的编号集合
            hasIds = new List<int>(); // 不可删除的编号集合
            foreach (ViewExpressTypeInfo type in eTypes)
            {
                // 检查类别是否包含子类别
                if (expTypeDAL.GetChildCount(type.ExpTypeId) > 0)
                {
                    if (hasNames != "")
                        hasNames += ",";
                    hasNames += type.ExpTypeName;
                    hasIds.Add(type.ExpTypeId); // 有子类别的父类别不能删除
                }
                else
                    delIds.Add(type.ExpTypeId);
            }
            bool blDel = false;
            if (delIds.Count > 0)
                blDel = expTypeDAL.UpdateExpTypeDelState(delIds, 0, 1);
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
                    reStr = "-1"; // 没有符合删除的类别信息
            }
            return reStr;
        }

        /// <summary>
        /// 恢复快递类别
        /// </summary>
        /// <param name="typeIds">要删除的快递类别ID</param>
        /// <returns></returns>
        public bool RecoverExpressTypes(List<int> typeIds)
        {
            return expTypeDAL.UpdateExpTypeDelState(typeIds, 0, 0);
        }

        /// <summary>
        /// 移除快递类别
        /// </summary>
        /// <param name="typeIds"></param>
        /// <returns></returns>
        public bool RemoveExpressTypes(List<int> typeIds)
        {
            return expTypeDAL.UpdateExpTypeDelState(typeIds, 1, 2);
        }
    }
}
