using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Zhaoxi.CainiaoPostStation.Models.UIModels;

namespace Zhaoxi.CainiaoPostStation.DAL.Base
{
    public class BQuery<T> where T:class
    {
        /// <summary>
        /// 条件查询单条数据  实体
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="cols"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public T GetModel(string strWhere, string cols, params SqlParameter[] paras)
        {
            //生成sql语句
            string sql = CreateSql.CreateSelectSql<T>(cols, strWhere, "");
            //执行   SqlDataReader
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1, paras);
            // 实体   DbConvert 转换
            T model = DbConvert.DataReaderToModel<T>(dr, cols);
            return model;
        }

        /// <summary>
        /// 根据主键查询数据  实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public T GetById(int id, string cols)
        {
            Type type = typeof(T);
            string primaryKey = type.GetPrimaryName();
            string strWhere = $"{primaryKey}={id} and IsDeleted=0";
            return GetModel(strWhere, cols);
        }

        /// <summary>
        /// 条件判断是否存在
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public bool Exists(string strWhere, params SqlParameter[] paras)
        {
            string sql = $"select count(1) from {typeof(T).GetTName()} where {strWhere}";
            object oCount = SqlHelper.ExecuteScalar(sql, 1, paras);
            return oCount.GetInt() > 0;
        }

        /// <summary>
        /// 判断某一字段值是否存在
        /// </summary>
        /// <param name="sName">列名</param>
        /// <param name="vName">值</param>
        /// <returns></returns>
        public bool ExistsByName(string sName, string vName)
        {
            string strWhere = $"{sName}=@vName and IsDeleted=0";
            SqlParameter para = new SqlParameter("@vName", vName);
            return Exists(strWhere, para);
        }

        /// <summary>
        /// 同一级别下，名称是否已存在
        /// </summary>
        /// <param name="sName"></param>
        /// <param name="vName"></param>
        /// <param name="sParent">父级列名</param>
        /// <param name="parId">父级编号</param>
        /// <returns></returns>
        public bool ExistsByName(string sName, string vName, string sParent, int parId)
        {
            string strWhere = $"{ sName}= @vName and {sParent}={parId} and IsDeleted = 0";
            SqlParameter para = new SqlParameter("@vName", vName);
            return Exists(strWhere, para);
        }

        /// <summary>
        /// 执行查询，返回一个int值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int SelectAndReIntValue(string sql)
        {
            object oCount = SqlHelper.ExecuteScalar(sql, 1);
            int count = 0;
            if (oCount != null && oCount.ToString() != "")
                count = (int)oCount;
            return count;
        }

        /// <summary>
        /// 条件查询数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="strCols"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public List<T> GetModelList(string strWhere, string cols, string orderBy, params SqlParameter[] paras)
        {
            string sql = CreateSql.CreateSelectSql<T>(cols, strWhere, orderBy);
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1, paras);
            //转换  List<T>
            List<T> list = DbConvert.DataReaderToList<T>(dr, cols);
            return list;
        }

        /// <summary>
        /// 查询所有数据（有效/已删除）
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="orderBy"></param>
        /// <param name="IsDeleted"></param>
        /// <returns></returns>
        public List<T> GetAllModelList(string cols, string orderBy, int IsDeleted)
        {
            string strWhere = $"IsDeleted={IsDeleted}";
            return GetModelList(strWhere, cols, orderBy);
        }

        /// <summary>
        /// 生成带行号的分页数据列表
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="strWhere"></param>
        /// <param name="cols"></param>
        /// <param name="rowName"></param>
        /// <param name="orderbyCol"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public List<S> GetRowsModelList<S>(string strWhere, string cols, string rowName, string orderbyCol,params SqlParameter[] paras)
        {
            string sql = CreateSql.CreateRowSelectSql<T>(cols, strWhere, rowName, orderbyCol);
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1, paras);
            List<S> list = DbConvert.DataReaderToList<S>(dr, cols + "," + rowName);
            return list;
        }

        /// <summary>
        /// 返回带行号的数据列表  不带条件
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="cols"></param>
        /// <param name="IsDeleted"></param>
        /// <param name="rowName"></param>
        /// <param name="orderbyCol"></param>
        /// <returns></returns>
        public List<S> GetRowsModelList<S>(string cols, int IsDeleted, string rowName, string orderbyCol)
        {
            string strWhere = $"IsDeleted={IsDeleted}";
            return GetRowsModelList<S>(strWhere, cols, rowName, orderbyCol);
        }

        /// <summary>
        /// 返回DataTable  单个结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataTable GetDt(string sql, int isProc, params SqlParameter[] paras)
        {
            return SqlHelper.GetDataTable(sql, isProc, paras);
        }

        /// <summary>
        /// 返回DataSet  多个结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataSet GetDs(string sql, int isProc, params SqlParameter[] paras)
        {
            return SqlHelper.GetDataSet(sql, isProc, paras);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="strWhere"></param>
        /// <param name="cols"></param>
        /// <param name="rowName"></param>
        /// <param name="orderbyCol"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public PageModel<S> GetRowsModelList<S>(string strWhere, string cols, string rowName, string orderbyCol, int startIndex, int pageSize, params SqlParameter[] paras)
        {
            //生成带行号结果集的Sql
            string sql = CreateSql.CreateRowSelectSql<T>(cols, strWhere, rowName, orderbyCol);
            //生成查询分页的sql(两部分，1.获取总记录数  2 获取当页列表)
            string sqlNew = $"select count(1) from ({sql}) as temp;select * from  ({sql}) as temp where   {rowName} between {startIndex} and {startIndex + pageSize - 1} ";
            DataSet ds = GetDs(sqlNew, 1, paras);
            int totalCount = ds.Tables[0].Rows[0][0].GetInt();
            DataTable dtList = ds.Tables[1];
            List<S> list = DbConvert.DataTableToList<S>(dtList, cols + "," + rowName);
            return new PageModel<S>() { TotalCount = totalCount, PageList = list };
        }
    }
}
