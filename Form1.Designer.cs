namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            addButton = new Button();
            deleteButton = new Button();
            entryBox = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(380, 33);
            label1.TabIndex = 0;
            label1.Text = "Список дел";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 74);
            addButton.Name = "addButton";
            addButton.Size = new Size(87, 42);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(105, 74);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(95, 42);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // entryBox
            // 
            entryBox.Location = new Point(12, 45);
            entryBox.Name = "entryBox";
            entryBox.Size = new Size(380, 23);
            entryBox.TabIndex = 3;
            entryBox.TextChanged += entryBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(380, 446);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 580);
            Controls.Add(dataGridView1);
            Controls.Add(entryBox);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addButton;
        private Button deleteButton;
        private TextBox entryBox;
        private DataGridView dataGridView1;
    }
}
