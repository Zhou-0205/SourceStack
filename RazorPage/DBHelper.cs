using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RazorPage.Entities;
using System.Data;

namespace RazorPage
{
    public class DBHelper
    {
        //连接字符串
        private const string strConnection = @"Data Source=.;
                                                Initial Catalog=17bang;
                                                Integrated security=true;";

        #region 执行查询，返回DataTable对象-----------------------

        public static DataTable GetTable(string strSQL)
        {
            return GetTable(strSQL, null);
        }
        public static DataTable GetTable(string strSQL, SqlParameter[] sqlParameters)
        {
            return GetTable(strSQL, sqlParameters, CommandType.Text);
        }
        /// <summary>
        /// 执行查询，返回DataTable对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="sqlParameters">参数数组</param>
        /// <param name="cmdType">Command类型</param>
        /// <returns>DataTable对象</returns>
        public static DataTable GetTable(string strSQL, SqlParameter[] sqlParameters, CommandType cmdType)
        {
            DataTable dataTable = new DataTable(); ;
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection);
                dataAdapter.SelectCommand.CommandType = cmdType;
                if (sqlParameters != null)
                {
                    dataAdapter.SelectCommand.Parameters.AddRange(sqlParameters);
                }
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }


        #endregion


        #region 执行查询，返回DataSet对象-------------------------

        public static DataSet GetDataSet(string strSQL)
        {
            return GetDataSet(strSQL, null);
        }
        public static DataSet GetDataSet(string strSQL, SqlParameter[] sqlParameters)
        {
            return GetDataSet(strSQL, sqlParameters, CommandType.Text);
        }
        /// <summary>
        /// 执行查询，返回DataSet对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="sqlParameters">参数数组</param>
        /// <param name="cmdType">Command类型</param>
        /// <returns>DataSet对象</returns>
        public static DataSet GetDataSet(string strSQL, SqlParameter[] sqlParameters, CommandType cmdType)
        {
            DataSet dataSet = new DataSet(); ;
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, sqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = cmdType;
                if (sqlParameters != null)
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddRange(sqlParameters);
                }
                sqlDataAdapter.Fill(dataSet);
            }
            return dataSet;
        }


        #endregion


        #region 执行非查询存储过程和SQL语句-----------------------------

        public static int ExcuteProc(string procName)
        {
            return ExcuteSQL(procName, null, CommandType.StoredProcedure);
        }
        public static int ExcuteProc(string procName, SqlParameter[] sqlParameters)
        {
            return ExcuteSQL(procName, sqlParameters, CommandType.StoredProcedure);
        }
        public static int ExcuteSQL(string strSQL)
        {
            return ExcuteSQL(strSQL, null);
        }
        public static int ExcuteSQL(string strSQL, SqlParameter[] sqlParameters)
        {
            return ExcuteSQL(strSQL, sqlParameters, CommandType.Text);
        }

        /// 执行非查询存储过程和SQL语句
        /// 增、删、改
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="sqlParameters">参数列表，没有参数填入null</param>
        /// <param name="cmdType">Command类型</param>
        /// <returns>返回影响行数</returns>
        public static int ExcuteSQL(string strSQL, SqlParameter[] sqlParameters, CommandType cmdType)
        {
            int i = 0;
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);
                sqlCommand.CommandType = cmdType;
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                sqlConnection.Open();
                i = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return i;
        }


        #endregion


        #region 执行查询返回第一行，第一列---------------------------------

        public static int ExcuteScalarSQL(string strSQL)
        {
            return ExcuteScalarSQL(strSQL, null);
        }
        public static int ExcuteScalarSQL(string strSQL, SqlParameter[] sqlParameters)
        {
            return ExcuteScalarSQL(strSQL, sqlParameters, CommandType.Text);
        }
        public static int ExcuteScalarProc(string strSQL, SqlParameter[] sqlParameters)
        {
            return ExcuteScalarSQL(strSQL, sqlParameters, CommandType.StoredProcedure);
        }
        /// <summary>
        /// 执行SQL语句，返回第一行，第一列
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="sqlParameters">参数列表，没有参数填入null</param>
        /// <returns>返回影响行数</returns>
        public static int ExcuteScalarSQL(string strSQL, SqlParameter[] sqlParameters, CommandType cmdType)
        {
            int i = 0;
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);
                sqlCommand.CommandType = cmdType;
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                sqlConnection.Open();
                i = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlConnection.Close();
            }
            return i;
        }


        #endregion


        #region 查询获取单个值------------------------------------

        /// <summary>
        /// 调用不带参数的存储过程获取单个值
        /// </summary>
        /// <param name="procName"></param>
        /// <returns></returns>
        public static object GetObjectByProc(string procName)
        {
            return GetObjectByProc(procName, null);
        }
        /// <summary>
        /// 调用带参数的存储过程获取单个值
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public static object GetObjectByProc(string procName, SqlParameter[] sqlParameters)
        {
            return GetObject(procName, sqlParameters, CommandType.StoredProcedure);
        }
        /// <summary>
        /// 根据sql语句获取单个值
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static object GetObject(string strSQL)
        {
            return GetObject(strSQL, null);
        }
        /// <summary>
        /// 根据sql语句 和 参数数组获取单个值
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public static object GetObject(string strSQL, SqlParameter[] sqlParameters)
        {
            return GetObject(strSQL, sqlParameters, CommandType.Text);
        }
        /// <summary>
        /// 执行SQL语句，返回首行首列
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="sqlParameters">参数列表，没有参数填入null</param>
        /// <returns>返回的首行首列</returns>
        public static object GetObject(string strSQL, SqlParameter[] sqlParameters, CommandType cmdType)
        {
            object obj = null;
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);
                sqlCommand.CommandType = cmdType;
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                sqlConnection.Open();
                obj = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
            }
            return obj;
        }


        #endregion


        #region 查询获取DataReader------------------------------------

        /// <summary>
        /// 调用不带参数的存储过程，返回DataReader对象
        /// </summary>
        /// <param name="procName">存储过程名称</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReaderByProc(string procName)
        {
            return GetReaderByProc(procName, null);
        }
        /// <summary>
        /// 调用带有参数的存储过程，返回DataReader对象
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="sqlParameters">参数数组</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReaderByProc(string procName, SqlParameter[] sqlParameters)
        {
            return GetReader(procName, sqlParameters, CommandType.StoredProcedure);
        }
        /// <summary>
        /// 根据sql语句返回DataReader对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReader(string strSQL)
        {
            return GetReader(strSQL, null);
        }
        /// <summary>
        /// 根据sql语句和参数返回DataReader对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="sqlParameters">参数数组</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReader(string strSQL, SqlParameter[] sqlParameters)
        {
            return GetReader(strSQL, sqlParameters, CommandType.Text);
        }
        /// <summary>
        /// 查询SQL语句获取DataReader
        /// </summary>
        /// <param name="strSQL">查询的SQL语句</param>
        /// <param name="sqlParameters">参数列表，没有参数填入null</param>
        /// <returns>查询到的DataReader（关闭该对象的时候，自动关闭连接）</returns>
        public static SqlDataReader GetReader(string strSQL, SqlParameter[] sqlParameters, CommandType cmdType)
        {
            SqlDataReader sqlDataReader = null;
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);
            sqlCommand.CommandType = cmdType;
            if (sqlParameters != null)
            {
                sqlCommand.Parameters.AddRange(sqlParameters);
            }
            sqlConnection.Open();
            //CommandBehavior.CloseConnection的作用是如果关联的DataReader对象关闭，则连接自动关闭
            sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return sqlDataReader;
        }


        #endregion


        #region 批量插入数据---------------------------------------------

        /// <summary>
        /// 往数据库中批量插入数据
        /// </summary>
        /// <param name="sourceDataTable">数据源表</param>
        /// <param name="targetTable">服务器上目标表</param>
        public static void BulkToDB(DataTable sourceDataTable, string targetTable)
        {
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(sqlConnection);   //用其它源的数据有效批量加载sql server表中
            sqlBulkCopy.DestinationTableName = targetTable;    //服务器上目标表的名称
            sqlBulkCopy.BatchSize = sourceDataTable.Rows.Count;   //每一批次中的行数
            try
            {
                sqlConnection.Open();
                if (sourceDataTable != null && sourceDataTable.Rows.Count != 0)
                    sqlBulkCopy.WriteToServer(sourceDataTable);   //将提供的数据源中的所有行复制到目标表中
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
                if (sqlBulkCopy != null)
                    sqlBulkCopy.Close();
            }
        }


        #endregion
    }
}
