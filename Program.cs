using System.Net.Cache;
using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp2;
using Newtonsoft.Json;
using Npgsql;

namespace WinFormsApp2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            CreateOrUpdateTable();
        }

        static bool TableExists(NpgsqlConnection conn, string tableName)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT EXISTS (SELECT 1 FROM information_schema.tables WHERE table_schema = 'public' AND table_name = @tableName)";
                cmd.Parameters.AddWithValue("@tableName", tableName);
                return (bool)cmd.ExecuteScalar();
            }
        }

        static void CreateMyTable(NpgsqlConnection conn)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "CREATE TABLE todolist (id serial PRIMARY KEY, Task VARCHAR(255), Time VARCHAR(255), Date VARCHAR(255))";
                cmd.ExecuteNonQuery();
            }
        }

        static void CreateOrUpdateTable()
        {
            string connString = "Host=localhost;Username=postgres;Password=123;Database=postgres";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                if (!TableExists(conn, "todolist"))
                {
                    CreateMyTable(conn);
                    Console.WriteLine("Таблица успешно создана.");
                }
                else
                {
                    Console.WriteLine("Таблица уже существует.");
                }
            }
        }
    }
}