using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenisLerningWinforms
{
    static class BDANITDROCH
    {
        public static string getTables = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'Timur'";

        public static RichTextBox logfield;
        public static void LogN(string str) => logfield.AppendText(str + "\n");
        public static void Log(string str) => logfield.AppendText(str);

        public static List<List<string>> Execute(string queryString)
        {
            List<List<string>> result = new List<List<string>>();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //LogN(connectionString);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    //LogN($"Зашел в {connection.Database}");
                    int index = 0;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            while(true)
                            {
                                try
                                {
                                    while (index >= result.Count)
                                        result.Add(new List<string>());
                                    result[index].Add(reader[index].ToString());
                                    //Log($"{reader[index]} ");
                                    index++;
                                }
                                catch (Exception ex)
                                {
                                    //LogN(ex.Message);
                                    break;
                                }
                            }
                            //LogN("");
                            index = 0;

                           
                        }
                    }
                    return result;
                }
            }
            catch (SqlException ex)
            {
                //LogN(ex.Message);
                return null;
            }
        }

    }
}
