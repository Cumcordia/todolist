﻿namespace WinFormsApp2
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
            timeBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(380, 33);
            label1.TabIndex = 0;
            label1.Text = "Список дел";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            addButton.Location = new Point(13, 119);
            addButton.Name = "addButton";
            addButton.Size = new Size(87, 42);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(106, 119);
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
            entryBox.Size = new Size(523, 23);
            entryBox.TabIndex = 3;
            entryBox.TextChanged += entryBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(523, 401);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // timeBox
            // 
            timeBox.Location = new Point(12, 90);
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(523, 23);
            timeBox.TabIndex = 5;
            timeBox.TextChanged += timeBox_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(53, 16);
            label2.TabIndex = 6;
            label2.Text = "Время";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 26);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 7;
            label3.Text = "Задача";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 580);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(timeBox);
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
        private TextBox timeBox;
        private Label label2;
        private Label label3;
    }
}
