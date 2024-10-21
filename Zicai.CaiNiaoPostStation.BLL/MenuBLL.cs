using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.DAL;
using Zicai.CaiNiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.BLL
{
    public class MenuBLL
    {
        MenuDAL menuDAL = new MenuDAL();

        /// <summary>
        /// 获取所有菜单数据
        /// </summary>
        /// <returns>菜单集合</returns>
        public List<MenuInfo> GetMenuList()
        {
            return menuDAL.GetMenuList();
        }
    }
}
