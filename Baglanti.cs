namespace StudentRegistration
{
    using System;
    using System.Data;
    using System.IO;
    using System.Data.SqlClient;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Configuration;

    public class Baglanti
    {
        public static SqlConnection connection;
        public Baglanti()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["StudentRegistration"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public static DataTable Select(string sql, List<SqlParameter> parameters)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (parameters != null && parameters.Count > 0)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
            CloseConnection();
            return dt;
        }

        public static void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public static void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public static int InsertOrUpdate(string sql, List<SqlParameter> parameters)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (parameters != null && parameters.Count > 0)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                }
            }
            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
            CloseConnection();
            return result;
        }
    }

}
