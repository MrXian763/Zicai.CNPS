using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZiCai.CainiaoPostStation.DAL.Base
{
    public class DbConvert
    {
        /// <summary>
        ///  DataRow 转换为指定类型 T 的模型对象
        /// </summary>
        /// <typeparam name="T">数据模型</typeparam>
        /// <param name="dr">要转换的数据行</param>
        /// <param name="cols">列数据</param>
        /// <returns>要转换为的类型</returns>
        public static T DataRowToModel<T>(DataRow dr, string cols)
        {
            T model = Activator.CreateInstance<T>(); // 反射创建模型实例
            PropertyInfo[] properties = PropertyHelper.GetProperties<T>(cols); // 获取属性信息
            if (dr != null)
            {
                foreach (PropertyInfo p in properties)
                {
                    string colName = p.GetColName();
                    if (dr[colName] is DBNull)
                        p.SetValue(model, null);
                    else
                        SetPropertyValue(p, model, dr[colName]); // 设置属性值
                }
                return model; // 返回填充好的模型实例
            }
            else
                return default(T); // 如果 DataRow 为空，返回类型 T 的默认值
        }

        /// <summary>
        /// 将DataTable转换为List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static List<T> DataTableToList<T>(DataTable dt, string cols)
        {
            List<T> list = new List<T>();
            if (dt.Rows.Count > 0) // 检查数据表是否有数据
            {
                foreach (DataRow dr in dt.Rows)
                {
                    T model = DataRowToModel<T>(dr, cols);
                    list.Add(model);
                }
            }
            return list;
        }

        /// <summary>
        /// 将SqlDataReader转换为Model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static T DataReaderToModel<T>(SqlDataReader dr, string cols)
        {
            T model = Activator.CreateInstance<T>();
            PropertyInfo[] properties = PropertyHelper.GetProperties<T>(cols);
            if (dr != null&&dr.Read())
            {
                foreach (PropertyInfo p in properties)
                {
                    string colName = p.GetColName();
                    if (dr[colName] is DBNull)
                        p.SetValue(model, null);
                    else
                    {
                        SetPropertyValue(p, model, dr[colName]);
                    }
                }
                dr.Close();
                return model;
            }
            else
                return default(T);

        }

        /// <summary>
        /// 将SqlDataReader转换为List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static List<T> DataReaderToList<T>(SqlDataReader dr, string cols)
        {
            List<T> list = new List<T>();
            PropertyInfo[] properties = PropertyHelper.GetProperties<T>(cols);
            if (dr != null)
            {
                while (dr.Read())
                {
                    T model = Activator.CreateInstance<T>();
                    foreach (PropertyInfo p in properties)
                    {
                        string colName = p.GetColName();
                        if (dr[colName] is DBNull)
                            p.SetValue(model, null);
                        else
                        {
                            SetPropertyValue(p, model, dr[colName]);
                        }
                    }
                    list.Add(model);
                }
                dr.Close();

            }
            return list;
        }

        /// <summary>
        /// 将值赋给指定对象的属性
        /// </summary>
        /// <param name="p">要设置值的属性信息</param>
        /// <param name="model">目标对象实例</param>
        /// <param name="val">要赋值的对象，可以是任何类型</param>
        private static void SetPropertyValue(PropertyInfo p, object model, object val)
        {
            // 泛型以及可空类型检查
            if (p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                p.SetValue(model, Convert.ChangeType(val, Nullable.GetUnderlyingType(p.PropertyType)));
            }
            else
                p.SetValue(model, Convert.ChangeType(val, p.PropertyType));
        }
    }
}
