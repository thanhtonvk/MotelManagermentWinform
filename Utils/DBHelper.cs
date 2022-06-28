using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKiTucXa.Utils
{
    internal class DBHelper
    {
        const string ConnectionString = @"Data Source=DESKTOP-9DCUPJF\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        public static DataTable Query(String consulta, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da;
            try
            {
                command.Connection = connection;
                command.CommandText = consulta;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return dt;
        }

        public static int NonQuery(string query, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = query;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
