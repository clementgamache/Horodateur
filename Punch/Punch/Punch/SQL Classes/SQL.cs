using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punch.SQL_Classes
{
    static class SQL
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\programs\Horodateur\Punch\Punch\Punch\databalse.mdf;Integrated Security=True";


        public static List<List<string>> get(string query, int columns)
        {
            List<List<string>> ret = new List<List<string>>();
            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> tempList = new List<string>();
                        for (int i = 0; i < columns; i++)
                        {
                            tempList.Add(reader[i].ToString());
                        }
                        ret.Add(tempList);
                    }
                }
                connection.Close();
            }
            if (ret.Count == 0)
            {
                ret.Add(null);
            }
            return ret;
        }

        public static void run(string query)
        {
            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static string getDateTimeString(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss:fff");
        }

        public static string getNullTimeString()
        {
            return getDateTimeString(DateTime.MinValue);
        }
    }
}
