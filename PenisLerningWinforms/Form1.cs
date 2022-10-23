using PenisLerningWinforms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace PenisLerningWinforms
{
    public partial class Form1 : Form
    {
        private static DataBase db = new DataBase("46.39.232.190", "MarketPlace_Database", "WeedFieldsLord422", "vag!na21519687##");
        public static bool IsPooping = false;

        public Form1()
        {
            InitializeComponent();
            DataBase.LogConsole = LogConsole;
            db.tables.ForEach(x => TableSelectComboBox.Items.Add(x));
            if (TableSelectComboBox.Items.Count > 0)
                TableSelectComboBox.SelectedIndex = 0;
            pictureBox1.Controls.Add(siticoneHtmlLabel1);
        }


        private void UpdateComboboxes()
        {
            ScalarColumnComboxBox.Items.Clear();
            db.Update();
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
            if (db.values.Count == 0 | db.values == null) return;
            for (int id = 0; id < db.values[0].Count; id++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(TableGridView);
                for (int i = 0; i < db.values.Count - 1; i++)
                {
                    newRow.Cells[i].Value = db.values
                        [i][id];
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
                if (PoopingMode.Checked)
                {
                    
                    db.InsertRow(db.columns.Skip(1).ToList().Select(x => "0").ToList());
                    return;
                }
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

        private void PoopingMode_CheckedChanged(object sender, EventArgs e) => IsPooping = PoopingMode.Checked;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            siticoneHtmlLabel1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

            if (backgroundWorker1.IsBusy == true)
                return;
            timer1.Start();
            pictureBox1.Image = Resources.rat_spinning;
            siticoneHtmlLabel1.Text = "СРЕМ...";
            ShitIntoBd();
            backgroundWorker1.RunWorkerAsync();
            UpdateTableView();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //ShitIntoBd(sender as BackgroundWorker);
        }

        public void ShitIntoBd()
        {
            Random r = new Random();
            List<string> linescopy = Clipboard.GetText().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var lines = new List<string>();
            lines.AddRange(linescopy);
            List<string> linesSend = new List<string>();


            DataBase.LogEnabled = false;
            foreach (var i in db.tables)
                db.Execute($"alter table [dbo].[{i}] nocheck constraint all");


            db.SwitchTable(db.tables[0]);
            foreach (var table in db.tables)
            {
                db.SwitchTable(table);
                db.Execute($"DELETE FROM [dbo].[{db.table}]");
                while (lines.Count != 0)
                {
                    int linesToTake = db.columns.Skip(1).ToList().Count <= lines.Count - 1 ? db.columns.Skip(1).ToList().Count : Math.Max(0, lines.Count);
                    List<string> values = lines.Take(linesToTake).Select(x => "").ToList();

                    values = values.Select(x => x + string.Join(" ", lines.Take(linesToTake).ToArray())).ToList();
                    values = values.Select(x => linesSend.Select(a => a.ToLower()).Contains(x.ToLower()) ? x + " ." : x).ToList();
                    lines.RemoveRange(0, linesToTake);
                    MessageBox.Show(values.Count.ToString());
                    db.InsertRow(values);
                    linesSend.AddRange(values);
                }
                lines.Clear();
                linesSend.Clear();
                lines.AddRange(linescopy);
            }
            foreach (var i in db.tables)
                db.Execute($"alter table [dbo].[{i}] check constraint all");
            DataBase.LogEnabled = true;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(3000);
            pictureBox1.Image = Resources.rat_spinning__1_;
            timer1.Stop();
            siticoneHtmlLabel1.ForeColor = Color.FromArgb(255, 255, 255, 255);
            siticoneHtmlLabel1.Text = "НАСРАТЬ В БД";
            MessageBox.Show("Насранно");
        }
    }
}
