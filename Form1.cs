using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            todoList.Columns.Add("������");
            dataGridView1.DataSource = todoList;
        }

        private void entryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Title"] = entryBox.Text;
            }
            else
            {
                todoList.Rows.Add(entryBox.Text);
            }
            entryBox.Text = "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
