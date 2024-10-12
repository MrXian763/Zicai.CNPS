using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.CainiaoPostStation.DAL.Base
{
    public  class CreateSql
    {
        //新增语句
        public static SqlModel CreateInsertSql<T>(T model, string cols, int isReturn)
        {
            string sql = "";
            Type type = typeof(T);
            string tableName = type.GetTName();
            string primaryKey = type.GetPrimaryName();//主键名
            PropertyInfo[] properties = null;
            if (type.IsAutoIncrement())
            {
                if (cols.Contains(primaryKey))
                {
                    //把主键列名移除
                    cols = cols.RemoveStrItem(primaryKey);
                }
            }
            else
            {
                if (!cols.Contains(primaryKey))
                {
                    //抛异常      
                    throw new Exception("主键列不能为空！");
                }
            }
            properties = PropertyHelper.GetProperties<T>(cols);
            string strCols = string.Join(",", properties.Select(p => p.GetColName()));
            string paraCols = string.Join(",", properties.Select(p => $"@{p.Name}"));
            sql = $"insert into [{tableName}] ({strCols}) values ({paraCols})";
            if (isReturn == 1)
                sql += ";select @@identity";

            //参数数组生成
            SqlParameter[] paras = properties.Select(p => new SqlParameter("@" + p.Name, p.GetValue(model) ?? DBNull.Value)).ToArray();

            return new SqlModel() { Sql = sql, Paras = paras };
        }

        /// <summary>
        /// 生成update语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="cols">要修改的列名，包括主键名</param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static SqlModel CreateUpdateSql<T>(T model, string cols, string strWhere)
        {
            string sql = "";
            Type type = typeof(T);
            string tableName = type.GetTName();
            string primaryKey = type.GetPrimaryName();//主键名
            PropertyInfo[] properties = null;

            properties = PropertyHelper.GetProperties<T>(cols);
            string strCols = string.Join(",", properties.Where(p => p.GetColName() != primaryKey).Select(p => string.Format("{0}=@{0}", p.GetColName())));

            if (string.IsNullOrEmpty(strWhere))
                strWhere = $"{primaryKey}=@{primaryKey}";

            sql = $"update [{tableName}] set {strCols} where {strWhere} ";
            //参数数组生成
            SqlParameter[] paras = properties.Select(p => new SqlParameter("@" + p.GetColName(), p.GetValue(model) ?? DBNull.Value)).ToArray();

            return new SqlModel() { Sql = sql, Paras = paras };
        }

        /// <summary>
        /// 生成Delete语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static string CreateDeleteSql<T>(string strWhere)
        {
            string sql = "";
            Type type = typeof(T);
            string tableName = type.GetTName();

            sql = $"delete from {tableName} where 1=1";
            if (!string.IsNullOrEmpty(strWhere))
                sql += " and " + strWhere;
            return sql;
        }

        /// <summary>
        /// 生成逻辑删除或恢复语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strWhere"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public static string CreateLogicDeleteSql<T>(string strWhere, int isDeleted,string delName="IsDeleted")
        {
            string sql = "";
            Type type = typeof(T);
            string tableName = type.GetTName();
            sql = $"update  {tableName} set {delName}={isDeleted} where 1=1";
            if (!string.IsNullOrEmpty(strWhere))
                sql += " and " + strWhere;
            return sql;
        }

        /// <summary>
        /// 生成查询语句（单表   简单查询）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cols"></param>
        /// <param name="strWhere"></param>
        /// <param name="orderby"></param>
        /// <returns></returns>
        public static string CreateSelectSql<T>(string cols, string strWhere, string orderby)
        {
            string sql = "";
            Type type = typeof(T);
            string tableName = type.GetTName();
            if (string.IsNullOrEmpty(cols))
            {
                var properties = PropertyHelper.GetProperties<T>("");
                cols = string.Join(",", properties.Select(p => p.GetColName()));
            }
            sql = $"select {cols} from {tableName} where 1=1";
            if (!string.IsNullOrEmpty(strWhere))
                sql += " and " + strWhere;
            if (!string.IsNullOrEmpty(orderby))
                sql += " order by " + orderby;
            return sql;
        }

        /// <summary>
        /// 生成带行号的查询语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cols"></param>
        /// <param name="strWhere"></param>
        /// <param name="rowName"></param>
        /// <param name="orderbyCol"></param>
        /// <returns></returns>
        public static string CreateRowSelectSql<T>(string cols, string strWhere, string rowName, string orderbyCol)
        {
            string sql = "";
            Type type = typeof(T);
            string tableName = type.GetTName();
            if (string.IsNullOrEmpty(cols))
            {
                var properties = PropertyHelper.GetProperties<T>("");
                cols = string.Join(",", properties.Select(p => p.GetColName()));
            }
            sql = $"select row_number() over (order by {orderbyCol} ) as {rowName}, {cols} from {tableName} where 1=1 ";
            if (!string.IsNullOrEmpty(strWhere))
                sql += " and " + strWhere;
            return sql;
        }

        /// <summary>
        /// 指定不包含列名 ，返回需要的列名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="notHasCols"></param>
        /// <returns></returns>
        public static string GetColNames<T>(string notHasCols)
        {
            string cols = "";
            Type type = typeof(T);//获取Type对象
            PropertyInfo[] properties = type.GetProperties();//获取所有公有属性
            if (!string.IsNullOrEmpty(notHasCols))
            {
                List<string> listCols = notHasCols.GetStrList(',', true);//转换成List<string>，并转换成小写
                properties = properties.Where(p => !listCols.Contains(p.GetColName().ToLower())).ToArray();
            }
            cols = string.Join(",", properties.Select(p => p.GetColName()));
            return cols;
        }
    }
}
