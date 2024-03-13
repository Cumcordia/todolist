using System.Net.Cache;
using System.Text.Json;

namespace WinFormsApp2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class Json
    {
        public string Task { get; set; }
        public int Time { get; set; }

        public Json(string task, int time)
        {
            Task = task;
            Time = time;
        }
    }

}