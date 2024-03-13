using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            todoList.Columns.Add("Задача");
            todoList.Columns.Add("Время");
            todoList.Columns.Add("Дата");
            dataGridView1.DataSource = todoList;
            timeBox.KeyPress += timeBox_KeyPress;
        }

        private void entryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Задача"] = entryBox.Text;
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Время"] = timeBox.Text;
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Дата"] = timeBox.Text;
            }
            else
            {
                DataRow newRow = todoList.NewRow();
                newRow["Задача"] = entryBox.Text;
                newRow["Время"] = timeBox.Text;
                newRow["Дата"] = dateTime.Text;
                todoList.Rows.Add(newRow);
            }

            entryBox.Text = "";
            timeBox.Text = "";
            isEditing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void timeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SaveToJsonFile()
        {
            List<Json> jsonDataList = new List<Json>();

            foreach (DataRow row in todoList.Rows)
            {
                jsonDataList.Add(new Json(row["Задача"].ToString(), int.Parse(row["Время"].ToString())));
            }

            string json = JsonSerializer.Serialize(jsonDataList);

            File.WriteAllText("todo_list.json", json);

            MessageBox.Show("Данные успешно сохранены в файле todo_list.json");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveToJsonFile();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
