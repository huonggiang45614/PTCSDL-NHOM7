using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQUANAO
{
    internal class Database
    {
        private static SqlConnection connection = new SqlConnection(@"Data Source=Admin\SQLEXPRESS;Initial Catalog=QLCHQA1;Integrated Security=True");

        public static void Execute(String sql, Dictionary<string, object> parameter = null)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            if (parameter != null)
            {
                foreach (string key in parameter.Keys)
                {
                    command.Parameters.Add(new SqlParameter(key, parameter[key]));
                }
            }
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable Query(String sql, Dictionary<string, object> parameter = null)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            if (parameter != null)
            {
                foreach (string key in parameter.Keys)
                {
                    command.Parameters.Add(new SqlParameter(key, parameter[key]));
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
