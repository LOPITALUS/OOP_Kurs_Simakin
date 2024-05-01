namespace OOP_Kurs_Simakin
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

        /* public DataGridView GetMealsDGV()
         {
             return MealsTable;
         }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Exit = new Button();
            FiltersLabel = new Label();
            CategoryLabel = new Label();
            CuisineLabel = new Label();
            SetFiltersButton = new Button();
            SearchLabel = new Label();
            textBox1 = new TextBox();
            SearchButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            OpenCuisineForm = new Button();
            OpenCategoryForm = new Button();
            MealsTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            WeightColumn = new DataGridViewTextBoxColumn();
            KcalColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            CuisineColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MealsTable).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Location = new Point(14, 553);
            Exit.Margin = new Padding(3, 4, 3, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(86, 31);
            Exit.TabIndex = 1;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = true;
            // 
            // FiltersLabel
            // 
            FiltersLabel.AutoSize = true;
            FiltersLabel.Location = new Point(791, 67);
            FiltersLabel.Name = "FiltersLabel";
            FiltersLabel.RightToLeft = RightToLeft.No;
            FiltersLabel.Size = new Size(71, 20);
            FiltersLabel.TabIndex = 2;
            FiltersLabel.Text = "Фильтры";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(791, 109);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(130, 20);
            CategoryLabel.TabIndex = 3;
            CategoryLabel.Text = "Категория блюда";
            // 
            // CuisineLabel
            // 
            CuisineLabel.AutoSize = true;
            CuisineLabel.Location = new Point(791, 159);
            CuisineLabel.Name = "CuisineLabel";
            CuisineLabel.Size = new Size(78, 20);
            CuisineLabel.TabIndex = 4;
            CuisineLabel.Text = "Вид кухни";
            // 
            // SetFiltersButton
            // 
            SetFiltersButton.Location = new Point(791, 187);
            SetFiltersButton.Margin = new Padding(3, 4, 3, 4);
            SetFiltersButton.Name = "SetFiltersButton";
            SetFiltersButton.Size = new Size(110, 43);
            SetFiltersButton.TabIndex = 5;
            SetFiltersButton.Text = "Применить";
            SetFiltersButton.UseVisualStyleBackColor = true;
            SetFiltersButton.Click += SetFiltersButton_Click;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(791, 345);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(52, 20);
            SearchLabel.TabIndex = 6;
            SearchLabel.Text = "Поиск";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(791, 383);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 7;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(791, 433);
            SearchButton.Margin = new Padding(3, 4, 3, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(86, 31);
            SearchButton.TabIndex = 8;
            SearchButton.Text = "Найти запись";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(160, 543);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(142, 52);
            button1.TabIndex = 9;
            button1.Text = "Сохранить файл с данными БД";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(328, 533);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 61);
            button2.TabIndex = 10;
            button2.Text = "Удалить базу данных";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(554, 208);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(153, 53);
            button3.TabIndex = 11;
            button3.Text = "Добавить новое блюдо\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(471, 543);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(106, 52);
            button4.TabIndex = 12;
            button4.Text = "Создать базу данных?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(787, 487);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(120, 71);
            button5.TabIndex = 13;
            button5.Text = "Найти блюдо по названию";
            button5.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // OpenCuisineForm
            // 
            OpenCuisineForm.Location = new Point(554, 75);
            OpenCuisineForm.Margin = new Padding(3, 4, 3, 4);
            OpenCuisineForm.Name = "OpenCuisineForm";
            OpenCuisineForm.Size = new Size(153, 55);
            OpenCuisineForm.TabIndex = 14;
            OpenCuisineForm.Text = "Открыть \"Виды кухонь\"";
            OpenCuisineForm.UseVisualStyleBackColor = true;
            OpenCuisineForm.Click += AddNewCategory_Click;
            // 
            // OpenCategoryForm
            // 
            OpenCategoryForm.Location = new Point(554, 137);
            OpenCategoryForm.Margin = new Padding(3, 4, 3, 4);
            OpenCategoryForm.Name = "OpenCategoryForm";
            OpenCategoryForm.Size = new Size(153, 53);
            OpenCategoryForm.TabIndex = 15;
            OpenCategoryForm.Text = "Открыть \"Категории блюд\"";
            OpenCategoryForm.UseVisualStyleBackColor = true;
            OpenCategoryForm.Click += AddNewCuisine_Click;
            // 
            // MealsTable
            // 
            MealsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MealsTable.Columns.AddRange(new DataGridViewColumn[] { ID, NameColumn, WeightColumn, KcalColumn, PriceColumn, CuisineColumn, CategoryColumn });
            MealsTable.Location = new Point(14, 67);
            MealsTable.Margin = new Padding(3, 4, 3, 4);
            MealsTable.Name = "MealsTable";
            MealsTable.ReadOnly = true;
            MealsTable.RowHeadersWidth = 51;
            MealsTable.RowTemplate.Height = 25;
            MealsTable.Size = new Size(497, 200);
            MealsTable.TabIndex = 0;
            MealsTable.CellContentClick += MealsTable_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Название";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 125;
            // 
            // WeightColumn
            // 
            WeightColumn.HeaderText = "Масса";
            WeightColumn.MinimumWidth = 6;
            WeightColumn.Name = "WeightColumn";
            WeightColumn.ReadOnly = true;
            WeightColumn.Width = 125;
            // 
            // KcalColumn
            // 
            KcalColumn.HeaderText = "Кол-во ккал";
            KcalColumn.MinimumWidth = 6;
            KcalColumn.Name = "KcalColumn";
            KcalColumn.ReadOnly = true;
            KcalColumn.Width = 125;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Цена";
            PriceColumn.MinimumWidth = 6;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            PriceColumn.Width = 125;
            // 
            // CuisineColumn
            // 
            CuisineColumn.HeaderText = "Вид кухни";
            CuisineColumn.MinimumWidth = 6;
            CuisineColumn.Name = "CuisineColumn";
            CuisineColumn.ReadOnly = true;
            CuisineColumn.Width = 125;
            // 
            // CategoryColumn
            // 
            CategoryColumn.HeaderText = "Категория";
            CategoryColumn.MinimumWidth = 6;
            CategoryColumn.Name = "CategoryColumn";
            CategoryColumn.ReadOnly = true;
            CategoryColumn.Width = 125;
            // 
            // MealForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(OpenCategoryForm);
            Controls.Add(OpenCuisineForm);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SearchButton);
            Controls.Add(textBox1);
            Controls.Add(SearchLabel);
            Controls.Add(SetFiltersButton);
            Controls.Add(CuisineLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(FiltersLabel);
            Controls.Add(Exit);
            Controls.Add(MealsTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MealForm";
            Text = "Меню";
            Load += MealForm_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MealsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Exit;
        private Label FiltersLabel;
        private Label CategoryLabel;
        private Label CuisineLabel;
        private Button SetFiltersButton;
        private Label SearchLabel;
        private TextBox textBox1;
        private Button SearchButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private FileSystemWatcher fileSystemWatcher1;
        private Button OpenCategoryForm;
        private Button OpenCuisineForm;
        public DataGridView MealsTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn WeightColumn;
        private DataGridViewTextBoxColumn KcalColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn CuisineColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
    }
}