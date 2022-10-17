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
    class DataBase
    {

        public static RichTextBox LogConsole;
        private string table;
        private List<string> tables;
        private List<string> columns;
        private List<List<string>> values;
        private string temp = "Data Source = 46.39.232.190; Initial Catalog = Timur;User Id = WeedFieldsLord422; Password = vag!na21519687##;";

        public static void Log(string str)
        {
            if (!(LogConsole is null))
                LogConsole.AppendText(str + "\n");
        } 

        public static List<List<string>> Execute(string queryString)
        {
            List<List<string>> result = new List<List<string>>();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Log(connectionString.ToString());
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
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
                                    index++;
                                }
                                catch (Exception ex)
                                {
                                    break;
                                }
                            }
                            index = 0;

                           
                        }
                    }
                    Log(queryString);
                    return result;
                }
            }
            catch (SqlException ex)
            {
                Log("--------------------\n\n\n" + ex.Message + "\n\n\n--------------------");
                return null;
            }

        }

        public void SwitchTable(string table)
        {
            
        }

        public static List<string> GetTables() => Execute($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'Timur'")[0];

        public static List<string> GetColumns(string table) => Execute($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}' ORDER BY ORDINAL_POSITION")[0];

        public static void DeleteRow(string table, string id) => Execute($"DELETE TBL.{table} WHERE {GetColumns(table)[0]}='{id}'");

        public static void InsertRow(string table, List<string> values) => Execute($"INSERT INTO TBL.{table} ({GetColumns(table).Skip(1).Aggregate((x, y) => x + "," + y)}) VALUES ({values.Skip(1).Select(x => $"'{x}'").Aggregate((x, y) => x + "," + y)})");

        public static void UpdateRow(string table, string id, List<string> values) => Execute($"UPDATE TBL.{table} " + $"SET {GetColumns(table).Skip(1).Select(x => $"{x}='{values.Skip(1).ToList()[GetColumns(table).Skip(1).ToList().IndexOf(x)]}'").Aggregate((i, j) => i + "," + j).Trim()} WHERE {GetColumns(table)[0]}='{id}'");


    }
}
