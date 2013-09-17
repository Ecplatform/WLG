using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace WLG.DAL
{
    internal class DataProvide
    {
        private static string connString = ConfigurationManager.AppSettings["dbconn"].ToString();

        public static int ExecuteSql(string strSQL)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(strSQL, conn))
                {
                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public static int ExecuteSql(string strSQL, params MySqlParameter[] cmdParms)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, conn, null, strSQL, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public static int ExecuteSqlTran(string[] strSQLS)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                MySqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    int count = 0;
                    for (int n = 0; n < strSQLS.Length; n++)
                    {
                        string strsql = strSQLS[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return count;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static object GetFieldData(string strSQL)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(strSQL, conn))
                {
                    try
                    {
                        conn.Open();
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public static DataTable Query(string strSQL)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    MySqlDataAdapter command = new MySqlDataAdapter(strSQL, conn);
                    command.Fill(ds, "0");
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return ds.Tables[0];
            }
        }

        public static DataSet QueryBatch(string[] strSQLS)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    for (int i = 0; i < strSQLS.Length; i++)
                    {
                        MySqlDataAdapter command = new MySqlDataAdapter(strSQLS[i], conn);
                        command.Fill(ds, i.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return ds;
            }
        }

        private static void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, string cmdText, MySqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {
                foreach (MySqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }

    }
}
