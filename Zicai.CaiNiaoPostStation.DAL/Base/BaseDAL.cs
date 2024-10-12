using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace Zhaoxi.CainiaoPostStation.DAL.Base
{
    public  class BaseDAL<T>:BQuery<T> where T:class
    {
        //增  单条    批量
        public int Add(T model, string cols, int isReturn)
        {
            if (model == null)
                return 0;
            SqlModel insert = CreateSql.CreateInsertSql<T>(model, cols, isReturn);
            string sql = insert.Sql;
            SqlParameter[] paras = insert.Paras;
            if (isReturn == 0)
                return SqlHelper.ExecuteNonQuery(sql, 1, paras);
            else
            {
                object oId = SqlHelper.ExecuteScalar(sql, 1, paras);
                return oId.GetInt();
            }
        }

        /// <summary>
        /// 批量插入信息
        /// </summary>
        /// <param name="list"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public bool AddList(List<T> list, string cols)
        {
            List<CommandInfo> comList = new List<CommandInfo>();
            foreach (T t in list)
            {
                SqlModel insert = CreateSql.CreateInsertSql<T>(t, cols, 0);
                CommandInfo com = new CommandInfo()
                {
                    CommandText = insert.Sql,
                    IsProc = false,
                    Paras = insert.Paras
                };
                comList.Add(com);
            }
            return SqlHelper.ExecuteTrans(comList);
        }

        //改
        /// <summary>
        /// 根据条件修改信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cols"></param>
        /// <param name="strWhere"></param>
        /// <param name="paras">附加的参数</param>
        /// <returns></returns>
        public bool Update(T model, string cols, string strWhere, params SqlParameter[] paras)
        {
            if (model == null)
                return false;
            SqlModel update = CreateSql.CreateUpdateSql<T>(model, cols, strWhere);
            string sql = update.Sql;
            SqlParameter[] paras0 = update.Paras;
            List<SqlParameter> listParas = paras0.ToList();
            if (paras != null && paras.Length > 0)
            {
                listParas.AddRange(paras);
            }
            return SqlHelper.ExecuteNonQuery(sql, 1, listParas.ToArray()) > 0;
        }

        /// <summary>
        /// 修改单个信息
        /// </summary>
        /// <param name="t"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public bool Update(T t, string cols)
        {
            return Update(t, cols, "");
        }

        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="list"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public bool UpdateList(List<T> list, string cols)
        {
            List<CommandInfo> comList = new List<CommandInfo>();
            foreach (T t in list)
            {
                SqlModel update = CreateSql.CreateUpdateSql<T>(t, cols, "");
                CommandInfo com = new CommandInfo()
                {
                    CommandText = update.Sql,
                    IsProc = false,
                    Paras = update.Paras
                };
                comList.Add(com);
            }
            return SqlHelper.ExecuteTrans(comList);
        }

        //删
        /// <summary>
        /// 条件删除
        /// </summary>
        /// <param name="delType">0 update  1  delete </param>
        /// <param name="strWhere">条件</param>
        /// <param name="isDeleted">0 1    2</param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public bool Delete(int delType, string strWhere, int isDeleted, params SqlParameter[] paras)
        {
            string delSql = "";
            if (delType == 0)
                delSql = CreateSql.CreateLogicDeleteSql<T>(strWhere, isDeleted);
            else if (delType == 1)
                delSql = CreateSql.CreateDeleteSql<T>(strWhere);
            List<CommandInfo> comList = GetCommandList(delSql, false, paras);
            return SqlHelper.ExecuteTrans(comList);
        }


        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public bool Delete(int id, int delType, int isDeleted)
        {
            Type type = typeof(T);
            string primaryKey = type.GetPrimaryName();
            string strWhere = $"{primaryKey}={id} ";
            return Delete(delType, strWhere, isDeleted);
        }

        /// <summary>
        /// 批量按主键删除
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public bool DeleteList(List<int> idList, int delType, int isDeleted)
        {
            List<string> sqlList = new List<string>();
            Type type = typeof(T);
            string primaryKey = type.GetPrimaryName();
            //1.
            //foreach (int id in idList)
            //{
            //    string strWhere = $"{primaryKey}={id} ";
            //    string delSql = "";
            //    if (delType == 0)
            //        delSql = CreateSql.CreateLogicDeleteSql<T>(strWhere, isDeleted);
            //    else if (delType == 1)
            //        delSql = CreateSql.CreateDeleteSql<T>(strWhere);
            //    sqlList.Add(delSql);
            //}
            //2.
            string strIds = string.Join(",", idList);
            string delSql = "";
            string strWhere = $"{primaryKey} in ({strIds}) ";
            if (delType == 0)
                delSql = CreateSql.CreateLogicDeleteSql<T>(strWhere, isDeleted);
            else if (delType == 1)
                delSql = CreateSql.CreateDeleteSql<T>(strWhere);
            sqlList.Add(delSql);

            return SqlHelper.ExecuteTrans(sqlList);
        }

        /// <summary>
        /// 生成删除sql(级联删除) 主表中不包括多层次关系
        /// </summary>
        /// <param name="delType"></param>
        /// <param name="strWhere"></param>
        /// <param name="isDeleted"></param>
        /// <param name="tables"></param>
        /// <returns></returns>
        public List<string> GetDeleteSql(int delType, string strWhere, int isDeleted, string[] tables)
        {
            List<string> sqlList = new List<string>();
            if (delType == 0)
            {
                foreach (string table in tables)
                {
                    sqlList.Add($"update {table} set IsDeleted={isDeleted} where {strWhere}");
                }
            }
            else
            {
                foreach (string table in tables)
                {
                    sqlList.Add($"delete from  {table} where {strWhere}");
                }
            }
            return sqlList;
        }

        /// <summary>
        /// 生成按主键删除的sql(级联删除) 主表中不包括多层次关系
        /// </summary>
        /// <param name="delType"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="tables"></param>
        /// <returns></returns>
        public List<string> GetDeleteSql(int delType, int id, int isDeleted, string[] tables)
        {
            Type type = typeof(T);
            string primaryKey = type.GetPrimaryName();
            string strWhere = $"{primaryKey}={id}";
            return GetDeleteSql(delType, strWhere, isDeleted, tables);
        }

        /// <summary>
        ///  批量 生成按主键删除的sql(级联删除) 主表中不包括多层次关系
        /// </summary>
        /// <param name="delType"></param>
        /// <param name="Ids"></param>
        /// <param name="isDeleted"></param>
        /// <param name="tables"></param>
        /// <returns></returns>
        public List<string> GetDeleteListSql(int delType, List<int> Ids, int isDeleted, string[] tables)
        {
            List<string> sqlList = new List<string>();
            foreach (int id in Ids)
            {
                sqlList.AddRange(GetDeleteSql(delType, id, isDeleted, tables));
            }
            return sqlList;
        }

        private List<CommandInfo> GetCommandList(string sql, bool isProc, params SqlParameter[] paras)
        {
            List<CommandInfo> comList = new List<CommandInfo>();
            CommandInfo comInfo = null;
            if (paras != null && paras.Length > 0)
                comInfo = new CommandInfo() { CommandText = sql, IsProc = isProc, Paras = paras };
            else
                comInfo = new CommandInfo() { CommandText = sql, IsProc = isProc };
            comList.Add(comInfo);
            return comList;
        }
    }
}
