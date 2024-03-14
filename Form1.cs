using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private DataTable todoList = new DataTable();
        private string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=123";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            LoadDataFromDatabase();
        }

        private void InitializeDataTable()
        {
            todoList.Columns.Add("Задача");
            todoList.Columns.Add("Время");
            todoList.Columns.Add("Дата");
            dataGridView1.DataSource = todoList;
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Task, Time, Date FROM todolist";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string task = reader.GetString(0);
                            string time = reader.GetString(1);
                            string date = reader.GetString(2);
                            todoList.Rows.Add(task, time, date);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string task = entryBox.Text;
            string time = timeBox.Text;
            string date = dateTime.Text;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO todolist (Task, Time, Date) VALUES (@task, @time, @date)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@task", task);
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@date", date);
                        command.ExecuteNonQuery();
                    }

                    todoList.Rows.Add(task, time, date);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления данных: {ex.Message}");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string task = selectedRow.Cells["Задача"].Value.ToString();
                string time = selectedRow.Cells["Время"].Value.ToString();
                string date = selectedRow.Cells["Дата"].Value.ToString();

                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM todolist WHERE Task = @task AND Time = @time AND Date = @date";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@task", task);
                            command.Parameters.AddWithValue("@time", time);
                            command.Parameters.AddWithValue("@date", date);
                            command.ExecuteNonQuery();
                        }

                        dataGridView1.Rows.Remove(selectedRow);

                        MessageBox.Show("Данные успешно удалены!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления данных: {ex.Message}");
                }
            }
        }


        private void timeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ':' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
