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
        private static DataBase db = new DataBase();

        public Form1()
        {
            InitializeComponent();
            DataBase.LogConsole = LogConsole;
            db.tables.ForEach(x => TableSelectComboBox.Items.Add(x));
            if (TableSelectComboBox.Items.Count > 0)
                TableSelectComboBox.SelectedIndex = 0;
           
        }


        private void UpdateComboboxes()
        {
            ScalarColumnComboxBox.Items.Clear();
            db.columns.Skip(1).ToList().ForEach(x => ScalarColumnComboxBox.Items.Add(x));
        }

        private void UpdateTableView()
        {
            UpdateComboboxes();
            TableGridView.Rows.Clear();
            TableGridView.Columns.Clear();
            List<DataGridViewTextBoxColumn> columnObjects = db.columns.Select(x => new DataGridViewTextBoxColumn()).ToList();
            columnObjects.ForEach(x => x.HeaderText = db.columns[columnObjects.IndexOf(x)]);
            TableGridView.Columns.AddRange(columnObjects.ToArray());
            if (db.values.Count <= 0) return;
            for (int id = 0; id < db.values[0].Count; id++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(TableGridView);
                for (int i = 0; i < db.values.Count - 1; i++)
                {
                    newRow.Cells[i].Value = db.values[i][id];
                }
                TableGridView.Rows.Add(newRow);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (db.columns.Skip(1).ToList().Any(x => TableGridView.CurrentRow.Cells[db.columns.ToList().IndexOf(x)].Value is null))
                return;

            if (TableGridView.CurrentRow.Cells[0].Value is null)
            {
                db.InsertRow(db.columns.Skip(1).ToList().Select(x => TableGridView.CurrentRow.Cells[db.columns.IndexOf(x)].Value.ToString()).ToList());
                UpdateTableView();
                return;
            }
            
            db.UpdateRow(TableGridView.CurrentRow.Cells[0].Value.ToString(), db.columns.Select(x => TableGridView.CurrentRow.Cells[db.columns.IndexOf(x)].Value.ToString()).ToList());
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
        
        private void ScalarValueExecuteButton_Click(object sender, EventArgs e)
        {
            if (ScalarColumnComboxBox.SelectedIndex == -1 & ScalarCommandComboBox.SelectedIndex == -1)
                return;
            string text = db.GetScalarValue(ScalarCommandComboBox.SelectedItem.ToString(),
                ScalarColumnComboxBox.SelectedItem.ToString());
            if (text != null)
                MessageBox.Show(text, "Scalar Value");

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            db.ParameterInsert(siticoneTextBox1.Text, siticoneTextBox2.Text);
        }

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
