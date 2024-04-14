﻿namespace OOP_Kurs_Simakin
{
    partial class MealForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Exit = new Button();
            FiltersLabel = new Label();
            CategoryLabel = new Label();
            CuisineLabel = new Label();
            SetFiltersButton = new Button();
            SearchLabel = new Label();
            textBox1 = new TextBox();
            SearchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Exit
            // 
            Exit.Location = new Point(12, 415);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 1;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = true;
            // 
            // FiltersLabel
            // 
            FiltersLabel.AutoSize = true;
            FiltersLabel.Location = new Point(692, 50);
            FiltersLabel.Name = "FiltersLabel";
            FiltersLabel.RightToLeft = RightToLeft.No;
            FiltersLabel.Size = new Size(57, 15);
            FiltersLabel.TabIndex = 2;
            FiltersLabel.Text = "Фильтры";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(692, 82);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(102, 15);
            CategoryLabel.TabIndex = 3;
            CategoryLabel.Text = "Категория блюда";
            // 
            // CuisineLabel
            // 
            CuisineLabel.AutoSize = true;
            CuisineLabel.Location = new Point(692, 119);
            CuisineLabel.Name = "CuisineLabel";
            CuisineLabel.Size = new Size(62, 15);
            CuisineLabel.TabIndex = 4;
            CuisineLabel.Text = "Вид кухни";
            // 
            // SetFiltersButton
            // 
            SetFiltersButton.Location = new Point(692, 140);
            SetFiltersButton.Name = "SetFiltersButton";
            SetFiltersButton.Size = new Size(96, 32);
            SetFiltersButton.TabIndex = 5;
            SetFiltersButton.Text = "Применить";
            SetFiltersButton.UseVisualStyleBackColor = true;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(692, 259);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(42, 15);
            SearchLabel.TabIndex = 6;
            SearchLabel.Text = "Поиск";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(692, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(692, 325);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 8;
            SearchButton.Text = "Найти запись";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // Meal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchButton);
            Controls.Add(textBox1);
            Controls.Add(SearchLabel);
            Controls.Add(SetFiltersButton);
            Controls.Add(CuisineLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(FiltersLabel);
            Controls.Add(Exit);
            Controls.Add(dataGridView1);
            Name = "Meal";
            Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Exit;
        private Label FiltersLabel;
        private Label CategoryLabel;
        private Label CuisineLabel;
        private Button SetFiltersButton;
        private Label SearchLabel;
        private TextBox textBox1;
        private Button SearchButton;
    }
}