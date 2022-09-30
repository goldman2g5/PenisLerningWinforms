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

        public Form1()
        {
            InitializeComponent();
            BDANITDROCH.logfield = richTextBox1;           
            tables.ForEach(x => comboBox1.Items.Add(x));

        }



        private void updateZalupa()
        {
            string table = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            List<string> columns = BDANITDROCH.Execute($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}' ORDER BY ORDINAL_POSITION")[0];
            List<List<string>> values = BDANITDROCH.Execute($"SELECT *  FROM TBL.{table}"); //УЗНАВАТЬ АВТОМАТИЧЕСКИ TBL
            foreach (var i in values)
                foreach (var j in i)
                    richTextBox1.AppendText(j);
                

            //foreach (var i in columns)
            //    richTextBox1.AppendText(i);
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
            updateZalupa();
        }
    }
}
