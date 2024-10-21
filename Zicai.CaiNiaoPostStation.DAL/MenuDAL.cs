using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.Models;
using ZiCai.CainiaoPostStation.DAL.Base;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class MenuDAL : BaseDAL<MenuInfo>
    {
        /// <summary>
        /// 获取所有菜单数据
        /// </summary>
        /// <returns>菜单集合</returns>
        public List<MenuInfo> GetMenuList()
        {
            return GetAllModelList("", "", 0);
        }
    }
}
