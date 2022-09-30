using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenisLerningWinforms
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private List<string> tables = BDANITDROCH.Execute(
        $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'Timur'")[0]; //УЗНАВАТЬ АВТОМАТИЧЕСКИ ИМЯ БД
        string table;
        List<string> columns;
        List<List<string>> values;


        public Form1()
        {
            InitializeComponent();
            BDANITDROCH.logfield = richTextBox1;           
            tables.ForEach(x => comboBox1.Items.Add(x));

        }



        private void updateZalupa()
        {
            values = BDANITDROCH.Execute($"SELECT *  FROM TBL.{table}");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            List<DataGridViewTextBoxColumn> columnObjects = columns.Select(x => new DataGridViewTextBoxColumn()).ToList();
            columnObjects.ForEach(x => x.HeaderText = columns[columnObjects.IndexOf(x)]);
            dataGridView1.Columns.AddRange(columnObjects.ToArray());

            for (int id = 0; id < values[0].Count; id++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                for (int j = 0; j < values.Count - 1; j++)
                {
                    newRow.Cells[j].Value = values[j][id];
                }
                dataGridView1.Rows.Add(newRow);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tables = BDANITDROCH.Execute($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'Timur'")[0];
            foreach (var i in tables)
                richTextBox1.AppendText(i + "");
            //var result = BDANITDROCH.Execute("SELECT First_Name, Second_Name, Middle_Name FROM TBL.Emploee");
            //foreach(var i in result)
            //{
            //    richTextBox1.AppendText(" ");
            //    foreach (var j in i) 
            //        richTextBox1.AppendText(j);
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            table = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            columns = BDANITDROCH.Execute($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}' ORDER BY ORDINAL_POSITION")[0];
            updateZalupa();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var columnsNoId = columns.Skip(1).ToList();
            if (dataGridView1.CurrentRow.Cells[0].Value is null & !columnsNoId.Any(x => dataGridView1.CurrentRow.Cells[columns.IndexOf(x)].Value is null))
            {
                BDANITDROCH.Execute($"INSERT INTO TBL.{table}({columnsNoId.Aggregate((i, j) => i + "," + j)}) VALUES({columnsNoId.Select(x => $"'{dataGridView1.CurrentRow.Cells[columns.IndexOf(x)].Value}'").Aggregate((i, j) => i + "," + j)})");
            }
            BDANITDROCH.Execute($"UPDATE TBL.{table} " + $"SET {columnsNoId.Select(x => $"{x}='{dataGridView1.CurrentRow.Cells[columns.IndexOf(x)].Value}'").Aggregate((i, j) => i + "," + j).Trim()} WHERE {columns[0]}={dataGridView1.CurrentRow.Cells[0].Value}");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            BDANITDROCH.Execute($"DELETE TBL.{table} WHERE {columns[0]}='{e.Row.Cells[0].Value}'");
            
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //string table = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            //List<string> columns = BDANITDROCH.Execute($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}' ORDER BY ORDINAL_POSITION")[0];
            //List<string> columnsNoId = columns.Skip(1).ToList();
            //string zapros = $"INSERT INTO TBL.{table}({columnsNoId.Aggregate((i, j) => i + "," + j).Trim()}) VALUES({columnsNoId.Select(x => dataGridView1.CurrentRow.Cells[columnsNoId.IndexOf(x)].Value != null ? dataGridView1.CurrentRow.Cells[columnsNoId.IndexOf(x)].Value : "null").Aggregate((i, j) => i + "," + j)})";
            //BDANITDROCH.Execute(zapros);
            //richTextBox1.AppendText(zapros + "\n");
        }
    }
}
