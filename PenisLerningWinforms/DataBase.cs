using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PenisLerningWinforms
{
    internal class DataBase
    {

        public static RichTextBox LogConsole;
        public List<string> tables;
        private string table;
        public List<string> columns;
        public List<List<string>> values;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        

        public DataBase(string dataSource, string initialCatalog, string userId, string password)
        {
            connectionString =
                $"Data Source = {dataSource}; Initial Catalog = {initialCatalog};User Id = {userId}; Password = {password};";
            tables = GetTables(initialCatalog);

        }

        public DataBase()
        {
            tables = GetTables("Timur");
        }

        public static void Log(string str)
        {
            if (!(LogConsole is null))
                LogConsole.AppendText(str + "\n");
        } 

        public List<List<string>> Execute(string queryString)
        {
            List<List<string>> result = new List<List<string>>();
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
                                catch (Exception)
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
            catch (SqlException e)
            {
                
                Log("--------------------\n\n\n" + queryString + "\n" + e.Message + "\n\n\n--------------------");
                MessageBox.Show(e.Message);
                return null;
            }

        }

        public string GetScalarValue(string command, string column)
        {
            string queryString = "";

            if (command == "Count")
                queryString = $"SELECT {command.ToUpper()}(*) FROM TBL.{table}";
            if (command == "Min" | command == "Max" | command == "Sum")
                queryString = $"SELECT {command.ToUpper()}({column}) FROM TBL.{table}";
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Log(queryString);
                    return new SqlCommand(@queryString, connection).ExecuteScalar().ToString();
                }
                
            }
            catch (Exception e)
            {
                Log("--------------------\n\n\n" + queryString + "\n" + e.Message + "\n\n\n--------------------");
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public void SwitchTable(string newTable)
        {
            table = newTable;
            Update();

        }

        public void Update()
        {
            columns = GetColumns();
            values = GetValues();
        }

        private List<string> GetTables(string initialCatalog) => Execute($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = '{initialCatalog}'")[0];

        private List<string> GetColumns() => Execute($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}'")[0];

        private List<List<string>> GetValues() => Execute($"SELECT *  FROM TBL.{table}");

        public void DeleteRow(string id) => Execute($"DELETE TBL.{table} WHERE {GetColumns()[0]}='{id}'");

        public void InsertRow(List<string> values) => Execute($"INSERT INTO TBL.{table} ({GetColumns().Skip(1).Aggregate((x, y) => x + "," + y)}) VALUES ({values.Select(x => $"'{x}'").Aggregate((x, y) => x + "," + y)})");

        public void UpdateRow(string id, List<string> values) => Execute($"UPDATE TBL.{table} " + $"SET {GetColumns().Skip(1).Select(x => $"{x}='{values.Skip(1).ToList()[GetColumns().Skip(1).ToList().IndexOf(x)]}'").Aggregate((i, j) => i + "," + j).Trim()} WHERE {GetColumns()[0]}='{id}'");


    }
}
