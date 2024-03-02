using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VdovichenkoAI.Sprint7.Project.V11.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string opened_file_path = "";
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAddData_VAI_Click(object sender, EventArgs e)
        {
            DataTable data_source = this.dataGridViewTable_VAI.DataSource as DataTable;
            if (data_source == null)
                return;

            if (!data_source.Columns.Contains("Отработанные часы"))
            {
                data_source.Columns.Add("Отработанные часы", typeof(int));
            }
                DataRow new_row = data_source.NewRow();
            new_row["Фамилия"] = textBoxSurname_VAI.Text;
            new_row["Имя"] = textBoxName_VAI.Text;
            new_row["Отчество"] = textBoxPatronymic_VAI.Text;
            new_row["Адрес"] = textBoxAdress_VAI.Text;
            new_row["Номер Телефона"] = textBoxNumberPhone_VAI.Text;
            new_row["Дата рождения"] = dateTimePickerBirthday_VAI.Value.ToShortDateString();
            new_row["Должность"] = textBoxJobTitle_VAI.Text;
            new_row["Отработанные часы"] = 0;
            data_source.Rows.Add(new_row);
        }

        private void ToolStripMenuItemExit_VAI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemSaveAs_VAI_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "%HOMEPATH%";
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ds.SaveDataGridViewToCsv(saveFileDialog.FileName, this.dataGridViewTable_VAI);
                    opened_file_path = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }
        }

        private void ToolStripMenuItemSave_VAI_Click(object sender, EventArgs e)
        {
            if (opened_file_path == string.Empty)
            {
                ToolStripMenuItemSaveAs_VAI_Click(sender, e);
                return;
            }
            ds.SaveDataGridViewToCsv(opened_file_path, this.dataGridViewTable_VAI);
        }

        private void ToolStripMenuItemOpenFile_VAI_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "%HOMEPATH%";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    opened_file_path = openFileDialog.FileName;
                    ds.LoadCsvDataToDataGridView(openFileDialog.FileName, this.dataGridViewTable_VAI);
                }
                else
                {
                    return;
                }

            }
        }

        private void ToolStripMenuItemCreateFile_VAI_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            this.dataGridViewTable_VAI.DataSource = ds.CreateEmptyTable();
        }

        private void ToolStripMenuItemAboutProgram_VAI_Click(object sender, EventArgs e)
        {
            FormAboutProgram_VAI formAbout = new FormAboutProgram_VAI();
            formAbout.ShowDialog();
        }

        private void ToolStripMenuTip_VAI_Click(object sender, EventArgs e)
        {
            FormTip_VAI formTip = new FormTip_VAI();
            formTip.ShowDialog();
        }

        private void buttonChart_VAI_Click(object sender, EventArgs e)
        {
            chartData_VAI.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Отработанные часы");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewTable_VAI.Rows)
            {
                if (!row.IsNewRow && row.Cells["Отработанные часы"] != null && row.Cells["Отработанные часы"].Value != null)
                {
                    string label = row.Cells["Фамилия"].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells["Отработанные часы"].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chartData_VAI.Series.Add(series);
        }

        private void buttonAddHours_VAI_Click(object sender, EventArgs e)
        {
            int row_index = 0;
            int hours_number = 0;
            if (!int.TryParse(this.textBoxRows_VAI.Text, out row_index))
            {
                MessageBox.Show("Ошибка при добавлении количества часов\nНомер строки не является числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(this.textBoxHours_VAI.Text, out hours_number))
            {
                MessageBox.Show("Ошибка при добавлении количества часов\nКоличество часов не является числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable ds = this.dataGridViewTable_VAI.DataSource as DataTable;
            if (ds != null)
            {
                if (row_index < 1 || row_index > ds.Rows.Count)
                    return;
                if (ds.Rows[row_index - 1]["Отработанные часы"] != null)
                {
                    ds.Rows[row_index - 1]["Отработанные часы"] = int.Parse(ds.Rows[row_index - 1]["Отработанные часы"].ToString()) + hours_number;
                }
                else
                {
                    ds.Rows[row_index]["Отработанные часы"] = hours_number;
                }
            }
        }

        private void labelRow_VAI_Click(object sender, EventArgs e)
        {

        }
    }
}
