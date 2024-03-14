//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.VisualBasic.ApplicationServices;
//using Npgsql;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

//namespace Posgresql
//{
//    public class Connect
//    {
//        static void MainConn(string[] args)
//        {
//            string connectionString = "user=posgres;password=123;Database=todolist";
//            string createTable = @"
//            CREATE TABLE IF NOT EXISTS TodolistDb (
//                ID SERIAL PRIMARY KEY,
//                Task VARCHAR(50),
//                Time INT,
//                Date DATE
//            )";

//            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
//            {
//                try
//                {
//                    connection.Open();
//                    using (NpgsqlCommand command = new NpgsqlCommand(createTable, connection))
//                    {
//                        command.ExecuteNonQuery();
//                        Console.WriteLine("Таблица успешно создана!");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Ошибка: {ex.Message}");
//                }
//            }
//        }

//        public static void Insert(string[] args)
//        {
//            string insertQuery = "INSERT INTO TodolistDb (Task, Time, Date) VALUES (@name, @age)";

//        }
//    }
//}
