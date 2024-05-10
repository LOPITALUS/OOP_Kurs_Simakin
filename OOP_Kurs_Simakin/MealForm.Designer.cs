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
            CuisineLabel = new Label();
            SetFiltersButton = new Button();
            NameForSearching = new TextBox();
            SearchIdButton = new Button();
            button1 = new Button();
            DeleteDb = new Button();
            button3 = new Button();
            CreateDb = new Button();
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
            label1 = new Label();
            label2 = new Label();
            IdForSearching = new NumericUpDown();
            SearchNameButton = new Button();
            CancelFilters = new Button();
            label3 = new Label();
            IdSort = new CheckBox();
            button6 = new Button();
            UpSort = new RadioButton();
            DownSort = new RadioButton();
            WeightSort = new CheckBox();
            NameSort = new CheckBox();
            PriceSort = new CheckBox();
            CuisineSort = new CheckBox();
            KcalSort = new CheckBox();
            CategorySort = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            WeightFilterMin = new NumericUpDown();
            WeightFilterMax = new NumericUpDown();
            KcalFilterMax = new NumericUpDown();
            KcalFilterMin = new NumericUpDown();
            PriceFilterMin = new NumericUpDown();
            PriceFilterMax = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MealsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightFilterMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightFilterMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalFilterMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalFilterMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceFilterMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceFilterMax).BeginInit();
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
            Exit.Click += Exit_Click;
            // 
            // FiltersLabel
            // 
            FiltersLabel.AutoSize = true;
            FiltersLabel.Location = new Point(922, 424);
            FiltersLabel.Name = "FiltersLabel";
            FiltersLabel.RightToLeft = RightToLeft.No;
            FiltersLabel.Size = new Size(155, 20);
            FiltersLabel.TabIndex = 2;
            FiltersLabel.Text = "Настроить просмотр";
            // 
            // CuisineLabel
            // 
            CuisineLabel.AutoSize = true;
            CuisineLabel.Location = new Point(998, 503);
            CuisineLabel.Name = "CuisineLabel";
            CuisineLabel.Size = new Size(0, 20);
            CuisineLabel.TabIndex = 4;
            // 
            // SetFiltersButton
            // 
            SetFiltersButton.Location = new Point(991, 548);
            SetFiltersButton.Margin = new Padding(3, 4, 3, 4);
            SetFiltersButton.Name = "SetFiltersButton";
            SetFiltersButton.Size = new Size(110, 43);
            SetFiltersButton.TabIndex = 5;
            SetFiltersButton.Text = "Применить";
            SetFiltersButton.UseVisualStyleBackColor = true;
            SetFiltersButton.Click += SetFiltersButton_Click;
            // 
            // NameForSearching
            // 
            NameForSearching.Location = new Point(173, 355);
            NameForSearching.Margin = new Padding(3, 4, 3, 4);
            NameForSearching.Name = "NameForSearching";
            NameForSearching.Size = new Size(114, 27);
            NameForSearching.TabIndex = 7;
            // 
            // SearchIdButton
            // 
            SearchIdButton.Location = new Point(272, 424);
            SearchIdButton.Margin = new Padding(3, 4, 3, 4);
            SearchIdButton.Name = "SearchIdButton";
            SearchIdButton.Size = new Size(86, 31);
            SearchIdButton.TabIndex = 8;
            SearchIdButton.Text = "Найти запись";
            SearchIdButton.UseVisualStyleBackColor = true;
            SearchIdButton.Click += SearchIdButton_Click;
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
            // DeleteDb
            // 
            DeleteDb.Location = new Point(328, 533);
            DeleteDb.Margin = new Padding(3, 4, 3, 4);
            DeleteDb.Name = "DeleteDb";
            DeleteDb.Size = new Size(114, 61);
            DeleteDb.TabIndex = 10;
            DeleteDb.Text = "Удалить базу данных";
            DeleteDb.UseVisualStyleBackColor = true;
            DeleteDb.Click += DeleteDb_Click;
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
            // CreateDb
            // 
            CreateDb.Location = new Point(471, 543);
            CreateDb.Margin = new Padding(3, 4, 3, 4);
            CreateDb.Name = "CreateDb";
            CreateDb.Size = new Size(106, 52);
            CreateDb.TabIndex = 12;
            CreateDb.Text = "Создать базу данных";
            CreateDb.UseVisualStyleBackColor = true;
            CreateDb.Click += CreateDb_Click;
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
            OpenCuisineForm.Click += OpenCuisineForm_Click;
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
            OpenCategoryForm.Click += OpenCategoryForm_Click;
            // 
            // MealsTable
            // 
            MealsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MealsTable.Columns.AddRange(new DataGridViewColumn[] { ID, NameColumn, WeightColumn, KcalColumn, PriceColumn, CuisineColumn, CategoryColumn });
            MealsTable.Location = new Point(14, 75);
            MealsTable.Margin = new Padding(3, 4, 3, 4);
            MealsTable.Name = "MealsTable";
            MealsTable.ReadOnly = true;
            MealsTable.RowHeadersWidth = 51;
            MealsTable.RowTemplate.Height = 25;
            MealsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MealsTable.Size = new Size(497, 200);
            MealsTable.TabIndex = 0;
            MealsTable.CellClick += MealsTable_CellClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 355);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 16;
            label1.Text = "Поиск по названию: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 424);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 17;
            label2.Text = "Поиск по ID:";
            // 
            // IdForSearching
            // 
            IdForSearching.Location = new Point(117, 424);
            IdForSearching.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            IdForSearching.Name = "IdForSearching";
            IdForSearching.Size = new Size(150, 27);
            IdForSearching.TabIndex = 18;
            // 
            // SearchNameButton
            // 
            SearchNameButton.Location = new Point(293, 355);
            SearchNameButton.Margin = new Padding(3, 4, 3, 4);
            SearchNameButton.Name = "SearchNameButton";
            SearchNameButton.Size = new Size(86, 31);
            SearchNameButton.TabIndex = 19;
            SearchNameButton.Text = "Найти запись";
            SearchNameButton.UseVisualStyleBackColor = true;
            SearchNameButton.Click += SearchNameButton_Click;
            // 
            // CancelFilters
            // 
            CancelFilters.Location = new Point(541, 320);
            CancelFilters.Name = "CancelFilters";
            CancelFilters.Size = new Size(226, 43);
            CancelFilters.TabIndex = 20;
            CancelFilters.Text = "Снять все фильтры с таблицы";
            CancelFilters.UseVisualStyleBackColor = true;
            CancelFilters.Click += CancelFilters_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(963, 75);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 21;
            label3.Text = "Сортировка:";
            // 
            // IdSort
            // 
            IdSort.AutoSize = true;
            IdSort.Location = new Point(963, 107);
            IdSort.Name = "IdSort";
            IdSort.Size = new Size(46, 24);
            IdSort.TabIndex = 22;
            IdSort.Text = "ID";
            IdSort.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(963, 333);
            button6.Name = "button6";
            button6.Size = new Size(113, 29);
            button6.TabIndex = 23;
            button6.Text = "Сортировать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // UpSort
            // 
            UpSort.AutoSize = true;
            UpSort.Checked = true;
            UpSort.Location = new Point(1141, 107);
            UpSort.Name = "UpSort";
            UpSort.Size = new Size(146, 24);
            UpSort.TabIndex = 24;
            UpSort.TabStop = true;
            UpSort.Text = "По возрастанию";
            UpSort.UseVisualStyleBackColor = true;
            // 
            // DownSort
            // 
            DownSort.AutoSize = true;
            DownSort.Location = new Point(1141, 136);
            DownSort.Name = "DownSort";
            DownSort.Size = new Size(127, 24);
            DownSort.TabIndex = 25;
            DownSort.Text = "По убыванию";
            DownSort.UseVisualStyleBackColor = true;
            // 
            // WeightSort
            // 
            WeightSort.AutoSize = true;
            WeightSort.Location = new Point(963, 165);
            WeightSort.Name = "WeightSort";
            WeightSort.Size = new Size(74, 24);
            WeightSort.TabIndex = 26;
            WeightSort.Text = "Масса";
            WeightSort.UseVisualStyleBackColor = true;
            // 
            // NameSort
            // 
            NameSort.AutoSize = true;
            NameSort.Location = new Point(963, 136);
            NameSort.Name = "NameSort";
            NameSort.Size = new Size(99, 24);
            NameSort.TabIndex = 27;
            NameSort.Text = "Название";
            NameSort.UseVisualStyleBackColor = true;
            // 
            // PriceSort
            // 
            PriceSort.AutoSize = true;
            PriceSort.Location = new Point(963, 227);
            PriceSort.Name = "PriceSort";
            PriceSort.Size = new Size(67, 24);
            PriceSort.TabIndex = 30;
            PriceSort.Text = "Цена";
            PriceSort.UseVisualStyleBackColor = true;
            // 
            // CuisineSort
            // 
            CuisineSort.AutoSize = true;
            CuisineSort.Location = new Point(963, 256);
            CuisineSort.Name = "CuisineSort";
            CuisineSort.Size = new Size(100, 24);
            CuisineSort.TabIndex = 29;
            CuisineSort.Text = "Вид кухни";
            CuisineSort.UseVisualStyleBackColor = true;
            // 
            // KcalSort
            // 
            KcalSort.AutoSize = true;
            KcalSort.Location = new Point(963, 196);
            KcalSort.Name = "KcalSort";
            KcalSort.Size = new Size(114, 24);
            KcalSort.TabIndex = 28;
            KcalSort.Text = "Кол-во ккал";
            KcalSort.UseVisualStyleBackColor = true;
            // 
            // CategorySort
            // 
            CategorySort.AutoSize = true;
            CategorySort.Location = new Point(963, 285);
            CategorySort.Name = "CategorySort";
            CategorySort.Size = new Size(103, 24);
            CategorySort.TabIndex = 31;
            CategorySort.Text = "Категория";
            CategorySort.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(917, 457);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 32;
            label4.Text = "Масса";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(917, 485);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 33;
            label5.Text = "Кол-во ккал";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(917, 512);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 34;
            label6.Text = "Цена";
            // 
            // WeightFilterMin
            // 
            WeightFilterMin.Location = new Point(1055, 455);
            WeightFilterMin.Name = "WeightFilterMin";
            WeightFilterMin.Size = new Size(46, 27);
            WeightFilterMin.TabIndex = 35;
            WeightFilterMin.ValueChanged += WeightFilterMin_ValueChanged;
            // 
            // WeightFilterMax
            // 
            WeightFilterMax.Location = new Point(1151, 455);
            WeightFilterMax.Name = "WeightFilterMax";
            WeightFilterMax.Size = new Size(46, 27);
            WeightFilterMax.TabIndex = 36;
            // 
            // KcalFilterMax
            // 
            KcalFilterMax.Location = new Point(1151, 483);
            KcalFilterMax.Name = "KcalFilterMax";
            KcalFilterMax.Size = new Size(46, 27);
            KcalFilterMax.TabIndex = 37;
            // 
            // KcalFilterMin
            // 
            KcalFilterMin.Location = new Point(1055, 483);
            KcalFilterMin.Name = "KcalFilterMin";
            KcalFilterMin.Size = new Size(46, 27);
            KcalFilterMin.TabIndex = 38;
            KcalFilterMin.ValueChanged += KcalFilterMin_ValueChanged;
            // 
            // PriceFilterMin
            // 
            PriceFilterMin.Location = new Point(1055, 509);
            PriceFilterMin.Name = "PriceFilterMin";
            PriceFilterMin.Size = new Size(46, 27);
            PriceFilterMin.TabIndex = 39;
            PriceFilterMin.ValueChanged += PriceFilterMin_ValueChanged;
            // 
            // PriceFilterMax
            // 
            PriceFilterMax.Location = new Point(1151, 509);
            PriceFilterMax.Name = "PriceFilterMax";
            PriceFilterMax.Size = new Size(46, 27);
            PriceFilterMax.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1107, 457);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 41;
            label7.Text = "до";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1107, 485);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 42;
            label8.Text = "до";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1107, 517);
            label9.Name = "label9";
            label9.Size = new Size(26, 20);
            label9.TabIndex = 43;
            label9.Text = "до";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1013, 457);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 44;
            label10.Text = "от";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1013, 491);
            label11.Name = "label11";
            label11.Size = new Size(24, 20);
            label11.TabIndex = 45;
            label11.Text = "от";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1013, 517);
            label12.Name = "label12";
            label12.Size = new Size(24, 20);
            label12.TabIndex = 46;
            label12.Text = "от";
            // 
            // MealForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 600);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(PriceFilterMax);
            Controls.Add(PriceFilterMin);
            Controls.Add(KcalFilterMin);
            Controls.Add(KcalFilterMax);
            Controls.Add(WeightFilterMax);
            Controls.Add(WeightFilterMin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CategorySort);
            Controls.Add(PriceSort);
            Controls.Add(CuisineSort);
            Controls.Add(KcalSort);
            Controls.Add(NameSort);
            Controls.Add(WeightSort);
            Controls.Add(DownSort);
            Controls.Add(UpSort);
            Controls.Add(button6);
            Controls.Add(IdSort);
            Controls.Add(label3);
            Controls.Add(CancelFilters);
            Controls.Add(SearchNameButton);
            Controls.Add(IdForSearching);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OpenCategoryForm);
            Controls.Add(OpenCuisineForm);
            Controls.Add(CreateDb);
            Controls.Add(button3);
            Controls.Add(DeleteDb);
            Controls.Add(button1);
            Controls.Add(SearchIdButton);
            Controls.Add(NameForSearching);
            Controls.Add(SetFiltersButton);
            Controls.Add(CuisineLabel);
            Controls.Add(FiltersLabel);
            Controls.Add(Exit);
            Controls.Add(MealsTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MealForm";
            Text = "Меню";
            Load += MealForm_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MealsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightFilterMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightFilterMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalFilterMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalFilterMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceFilterMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceFilterMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Exit;
        private Label FiltersLabel;
        private Label CuisineLabel;
        private Button SetFiltersButton;
        private TextBox NameForSearching;
        private Button SearchIdButton;
        private Button button1;
        private Button DeleteDb;
        private Button button3;
        private Button CreateDb;
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
        private NumericUpDown IdForSearching;
        private Label label2;
        private Label label1;
        private Button SearchNameButton;
        private Button CancelFilters;
        private RadioButton DownSort;
        private RadioButton UpSort;
        private Button button6;
        private CheckBox IdSort;
        private Label label3;
        private CheckBox WeightSort;
        private CheckBox PriceSort;
        private CheckBox CuisineSort;
        private CheckBox KcalSort;
        private CheckBox NameSort;
        private CheckBox CategorySort;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown PriceFilterMax;
        private NumericUpDown PriceFilterMin;
        private NumericUpDown KcalFilterMin;
        private NumericUpDown KcalFilterMax;
        private NumericUpDown WeightFilterMax;
        private NumericUpDown WeightFilterMin;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}