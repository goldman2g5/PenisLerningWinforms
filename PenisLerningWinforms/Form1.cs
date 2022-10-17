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
        private static DataBase db = new DataBase();
        private static List<string> tables = db.tables; //УЗНАВАТЬ АВТОМАТИЧЕСКИ ИМЯ БД
        string table;
        List<string> columns;
        List<List<string>> values;

        
        public Form1()
        {
            InitializeComponent();
            DataBase.LogConsole = richTextBox1;
            tables.ForEach(x => TableSelectComboBox.Items.Add(x));
            if (TableSelectComboBox.Items.Count > 0)
                TableSelectComboBox.SelectedIndex = 0;
        }


        private void UpdateTableView()
        {
            columns = db.columns;
            values = db.values;
            TableGridView.Rows.Clear();
            TableGridView.Columns.Clear();
            List<DataGridViewTextBoxColumn> columnObjects = db.columns.Select(x => new DataGridViewTextBoxColumn()).ToList();
            columnObjects.ForEach(x => x.HeaderText = db.columns[columnObjects.IndexOf(x)]);
            TableGridView.Columns.AddRange(columnObjects.ToArray());

            for (int id = 0; id < values[0].Count; id++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(TableGridView);
                for (int j = 0; j < values.Count - 1; j++)
                {
                    newRow.Cells[j].Value = values[j][id];
                }
                TableGridView.Rows.Add(newRow);
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (columns.Skip(1).ToList().Any(x => TableGridView.CurrentRow.Cells[columns.ToList().IndexOf(x)].Value is null))
                return;

            if (TableGridView.CurrentRow.Cells[0].Value is null)
            {
                db.InsertRow(columns.Skip(1).ToList().Select(x => TableGridView.CurrentRow.Cells[columns.IndexOf(x)].Value.ToString()).ToList());
                return;
            }
            
            db.UpdateRow(TableGridView.CurrentRow.Cells[0].Value.ToString(), columns.Select(x => TableGridView.CurrentRow.Cells[columns.IndexOf(x)].Value.ToString()).ToList());
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            db.DeleteRow(e.Row.Cells[0].Value.ToString());
        }

        private void TableSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.SwitchTable(TableSelectComboBox.Items[TableSelectComboBox.SelectedIndex].ToString());
            UpdateTableView();
        }
    }
}
