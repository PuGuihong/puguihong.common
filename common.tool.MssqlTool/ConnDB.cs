using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace common.tool.MssqlTool
{
    public class ConnDB
    {
          protected SqlConnection Connection;
          private string connectionString;

          /// <summary>
          /// 默认构造函数
          /// </summary>
          public ConnDB()
          {
           string connStr;

           connStr = ConfigurationManager.AppSettings["connStr"].ToString();

           connectionString = connStr;
           Connection = new SqlConnection(connectionString);
          }


          /// <summary>
          /// 带参数的构造函数
          /// </summary>
          /// <param >数据库联接字符串</param>
          public ConnDB(string newConnectionString)
          {
           connectionString = newConnectionString;
           Connection = new SqlConnection(connectionString);
          }


          /// <summary>
          /// 完成SqlCommand对象的实例化
          /// </summary>
          /// <param ></param>
          /// <param ></param>
          /// <returns></returns>
          private SqlCommand BuildCommand(string storedProcName,IDataParameter[] parameters)
          {
           SqlCommand command = BuildQueryCommand(storedProcName,parameters);
           command.Parameters.Add(new SqlParameter("ReturnValue",SqlDbType.Int,4,ParameterDirection.ReturnValue,false,0,0,string.Empty,DataRowVersion.Default,null));
           return command;
          }


          /// <summary>
          /// 创建新的SQL命令对象(存储过程)
          /// </summary>
          /// <param ></param>
          /// <param ></param>
          /// <returns></returns>
          private SqlCommand BuildQueryCommand(string storedProcName,IDataParameter[] parameters)
          {
           SqlCommand command = new SqlCommand(storedProcName,Connection);
           command.CommandType = CommandType.StoredProcedure;
           foreach (SqlParameter parameter in parameters)
           {
            command.Parameters.Add(parameter);
           }
           return command;
          }


          /// <summary>
          /// 执行存储过程,无返回值
          /// </summary>
          /// <param ></param>
          /// <param ></param>
          public void ExecuteProcedure(string storedProcName,IDataParameter[] parameters)
          {
           Connection.Open();
           SqlCommand command;
           command=BuildQueryCommand(storedProcName,parameters);
           command.ExecuteNonQuery();
           Connection.Close();
          }


          /// <summary>
          /// 执行存储过程，返回执行操作影响的行数目
          /// </summary>
          /// <param ></param>
          /// <param ></param>
          /// <param ></param>
          /// <returns></returns>
          public int RunProcedure(string storedProcName,IDataParameter[] parameters,out int rowsAffected)
          {
           int result;
           Connection.Open();
           SqlCommand command = BuildCommand(storedProcName,parameters);
           rowsAffected = command.ExecuteNonQuery();
           result = (int)command.Parameters["ReturnValue"].Value;
           Connection.Close();

           return result;
          }
 

          /// <summary>
          /// 重载RunProcedure把执行存储过程的结果放在SqlDataReader中
          /// </summary>
          /// <param ></param>
          /// <param ></param>
          /// <returns></returns>
          public SqlDataReader RunProcedure(string storedProcName,IDataParameter[] parameters)
          {
           SqlDataReader returnReader;
           Connection.Open();
           SqlCommand command = BuildQueryCommand(storedProcName,parameters);
           command.CommandType = CommandType.StoredProcedure;
           returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
           return returnReader;
          }


          /// <summary>
          /// 重载RunProcedure把执行存储过程的结果存储在DataSet中和表tableName为可选参数
          /// </summary>
          /// <param ></param>
          /// <param ></param>
          /// <param ></param>
          /// <returns></returns>
          public DataSet RunProcedure(string storedProcName,IDataParameter[] parameters,params string[] tableName)
          {
           DataSet dataSet = new DataSet();
           Connection.Open();
           SqlDataAdapter sqlDA = new SqlDataAdapter();
           sqlDA.SelectCommand = BuildQueryCommand(storedProcName,parameters);
           string flag;
           flag = "";
           for(int i=0;i<tableName.Length;i++)
            flag = tableName[i];
           if (flag!="")
            sqlDA.Fill(dataSet,tableName[0]);
           else
            sqlDA.Fill(dataSet);
           Connection.Close();
           return dataSet;
          }

  
          /// <summary>
          /// 执行SQL语句，返回数据到DataSet中
          /// </summary>
          /// <param ></param>
          /// <returns></returns>
          public DataSet ReturnDataSet(string sql)
          {
           DataSet dataSet=new DataSet();
           Connection.Open();
           SqlDataAdapter sqlDA=new SqlDataAdapter(sql,Connection);
           sqlDA.Fill(dataSet,"objDataSet");
           Connection.Close();
           return dataSet;
          } 

          /// <summary>
          /// 执行SQL语句，返回 DataReader
          /// </summary>
          /// <param ></param>
          /// <returns></returns>
          public SqlDataReader ReturnDataReader(String sql)
          {
           Connection.Open();
           SqlCommand command = new SqlCommand(sql,Connection);
           SqlDataReader dataReader = command.ExecuteReader();

           return dataReader;
          }

          /// <summary>
          /// 执行SQL语句，返回记录数
          /// </summary>
          /// <param ></param>
          /// <returns></returns>
          public int ReturnRecordCount(string sql)
          {
           int recordCount = 0;

           Connection.Open();
           SqlCommand command = new SqlCommand(sql,Connection);
           SqlDataReader dataReader = command.ExecuteReader();

           while(dataReader.Read())
           {
            recordCount++;
           }
           dataReader.Close();
           Connection.Close();

           return recordCount;
          }

          /// <summary>
          /// 执行SQL语句
          /// </summary>
          /// <param ></param>
          /// <returns></returns>
          public bool EditDatabase(string sql)
          {
           bool successState = false;

           Connection.Open();
           SqlTransaction myTrans = Connection.BeginTransaction();
           SqlCommand command = new SqlCommand(sql,Connection,myTrans);
           try
           {
            command.ExecuteNonQuery();
            myTrans.Commit();
            successState = true;
           }
           catch
           {
            myTrans.Rollback();
           }
           finally
           {
            Connection.Close();
           }

           return successState;
          }

          /// <summary>
          /// 关闭数据库联接
          /// </summary>
          public void Close()
          {
           Connection.Close();
          }
    }
}
