using System.Net.Cache;
using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp2;
using Newtonsoft.Json;

namespace WinFormsApp2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}