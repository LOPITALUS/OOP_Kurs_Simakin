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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Exit = new Button();
            CuisineLabel = new Label();
            SetFiltersButton = new Button();
            NameForSearching = new TextBox();
            SearchIdButton = new Button();
            DeleteDb = new Button();
            button3 = new Button();
            CreateDb = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            OpenCuisineForm = new Button();
            OpenCategoryForm = new Button();
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
            SortPanel = new Panel();
            FiltersPanel = new Panel();
            label13 = new Label();
            SearchPanel = new Panel();
            label14 = new Label();
            MealsTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            WeightColumn = new DataGridViewTextBoxColumn();
            KcalColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            CuisineColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightFilterMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightFilterMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalFilterMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalFilterMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceFilterMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceFilterMax).BeginInit();
            SortPanel.SuspendLayout();
            FiltersPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MealsTable).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Exit.BackColor = SystemColors.Info;
            Exit.Location = new Point(1346, 563);
            Exit.Margin = new Padding(3, 4, 3, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(86, 31);
            Exit.TabIndex = 1;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // CuisineLabel
            // 
            CuisineLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CuisineLabel.Location = new Point(94, 95);
            CuisineLabel.Name = "CuisineLabel";
            CuisineLabel.Size = new Size(0, 20);
            CuisineLabel.TabIndex = 4;
            // 
            // SetFiltersButton
            // 
            SetFiltersButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SetFiltersButton.BackColor = SystemColors.Info;
            SetFiltersButton.Location = new Point(135, 259);
            SetFiltersButton.Margin = new Padding(3, 4, 3, 4);
            SetFiltersButton.Name = "SetFiltersButton";
            SetFiltersButton.Size = new Size(106, 29);
            SetFiltersButton.TabIndex = 5;
            SetFiltersButton.Text = "Применить";
            SetFiltersButton.UseVisualStyleBackColor = false;
            SetFiltersButton.Click += SetFiltersButton_Click;
            // 
            // NameForSearching
            // 
            NameForSearching.Location = new Point(123, 40);
            NameForSearching.Margin = new Padding(3, 4, 3, 4);
            NameForSearching.MaxLength = 100;
            NameForSearching.Name = "NameForSearching";
            NameForSearching.Size = new Size(157, 27);
            NameForSearching.TabIndex = 7;
            // 
            // SearchIdButton
            // 
            SearchIdButton.BackColor = SystemColors.Info;
            SearchIdButton.Location = new Point(286, 96);
            SearchIdButton.Margin = new Padding(3, 4, 3, 4);
            SearchIdButton.Name = "SearchIdButton";
            SearchIdButton.Size = new Size(86, 31);
            SearchIdButton.TabIndex = 8;
            SearchIdButton.Text = "Найти запись";
            SearchIdButton.UseVisualStyleBackColor = false;
            SearchIdButton.Click += SearchIdButton_Click;
            // 
            // DeleteDb
            // 
            DeleteDb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteDb.BackColor = SystemColors.Info;
            DeleteDb.Location = new Point(1237, 80);
            DeleteDb.Margin = new Padding(3, 4, 3, 4);
            DeleteDb.Name = "DeleteDb";
            DeleteDb.Size = new Size(152, 55);
            DeleteDb.TabIndex = 10;
            DeleteDb.Text = "Удалить базу данных";
            DeleteDb.UseVisualStyleBackColor = false;
            DeleteDb.Click += DeleteDb_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(40, 197);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(153, 53);
            button3.TabIndex = 11;
            button3.Text = "Добавить новое блюдо\r\n";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // CreateDb
            // 
            CreateDb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateDb.BackColor = SystemColors.Info;
            CreateDb.Location = new Point(1237, 179);
            CreateDb.Margin = new Padding(3, 4, 3, 4);
            CreateDb.Name = "CreateDb";
            CreateDb.Size = new Size(152, 55);
            CreateDb.TabIndex = 12;
            CreateDb.Text = "Создать базу данных";
            CreateDb.UseVisualStyleBackColor = false;
            CreateDb.Click += CreateDb_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // OpenCuisineForm
            // 
            OpenCuisineForm.BackColor = SystemColors.Info;
            OpenCuisineForm.Location = new Point(40, 52);
            OpenCuisineForm.Margin = new Padding(3, 4, 3, 4);
            OpenCuisineForm.Name = "OpenCuisineForm";
            OpenCuisineForm.Size = new Size(153, 55);
            OpenCuisineForm.TabIndex = 14;
            OpenCuisineForm.Text = "Открыть \"Виды кухонь\"";
            OpenCuisineForm.UseVisualStyleBackColor = false;
            OpenCuisineForm.Click += OpenCuisineForm_Click;
            // 
            // OpenCategoryForm
            // 
            OpenCategoryForm.BackColor = SystemColors.Info;
            OpenCategoryForm.Location = new Point(40, 125);
            OpenCategoryForm.Margin = new Padding(3, 4, 3, 4);
            OpenCategoryForm.Name = "OpenCategoryForm";
            OpenCategoryForm.Size = new Size(153, 53);
            OpenCategoryForm.TabIndex = 15;
            OpenCategoryForm.Text = "Открыть \"Категории блюд\"";
            OpenCategoryForm.UseVisualStyleBackColor = false;
            OpenCategoryForm.Click += OpenCategoryForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 47);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 16;
            label1.Text = "По названию: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 101);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 17;
            label2.Text = "По идентификатору:";
            // 
            // IdForSearching
            // 
            IdForSearching.Location = new Point(163, 97);
            IdForSearching.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            IdForSearching.Name = "IdForSearching";
            IdForSearching.Size = new Size(117, 27);
            IdForSearching.TabIndex = 18;
            // 
            // SearchNameButton
            // 
            SearchNameButton.BackColor = SystemColors.Info;
            SearchNameButton.Location = new Point(286, 37);
            SearchNameButton.Margin = new Padding(3, 4, 3, 4);
            SearchNameButton.Name = "SearchNameButton";
            SearchNameButton.Size = new Size(86, 31);
            SearchNameButton.TabIndex = 19;
            SearchNameButton.Text = "Найти запись";
            SearchNameButton.UseVisualStyleBackColor = false;
            SearchNameButton.Click += SearchNameButton_Click;
            // 
            // CancelFilters
            // 
            CancelFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelFilters.BackColor = SystemColors.Info;
            CancelFilters.Location = new Point(1216, 400);
            CancelFilters.Name = "CancelFilters";
            CancelFilters.Size = new Size(216, 51);
            CancelFilters.TabIndex = 20;
            CancelFilters.Text = "Снять все фильтры с таблицы";
            CancelFilters.UseVisualStyleBackColor = false;
            CancelFilters.Click += CancelFilters_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 12);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 21;
            label3.Text = "Сортировка:";
            // 
            // IdSort
            // 
            IdSort.AutoSize = true;
            IdSort.Location = new Point(21, 47);
            IdSort.Name = "IdSort";
            IdSort.Size = new Size(46, 24);
            IdSort.TabIndex = 22;
            IdSort.Text = "ID";
            IdSort.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Info;
            button6.Location = new Point(138, 259);
            button6.Name = "button6";
            button6.Size = new Size(113, 29);
            button6.TabIndex = 23;
            button6.Text = "Сортировать";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // UpSort
            // 
            UpSort.AutoSize = true;
            UpSort.Checked = true;
            UpSort.Location = new Point(198, 47);
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
            DownSort.Location = new Point(198, 76);
            DownSort.Name = "DownSort";
            DownSort.Size = new Size(127, 24);
            DownSort.TabIndex = 25;
            DownSort.Text = "По убыванию";
            DownSort.UseVisualStyleBackColor = true;
            // 
            // WeightSort
            // 
            WeightSort.AutoSize = true;
            WeightSort.Location = new Point(21, 105);
            WeightSort.Name = "WeightSort";
            WeightSort.Size = new Size(74, 24);
            WeightSort.TabIndex = 26;
            WeightSort.Text = "Масса";
            WeightSort.UseVisualStyleBackColor = true;
            // 
            // NameSort
            // 
            NameSort.AutoSize = true;
            NameSort.Location = new Point(21, 76);
            NameSort.Name = "NameSort";
            NameSort.Size = new Size(99, 24);
            NameSort.TabIndex = 27;
            NameSort.Text = "Название";
            NameSort.UseVisualStyleBackColor = true;
            // 
            // PriceSort
            // 
            PriceSort.AutoSize = true;
            PriceSort.Location = new Point(21, 167);
            PriceSort.Name = "PriceSort";
            PriceSort.Size = new Size(67, 24);
            PriceSort.TabIndex = 30;
            PriceSort.Text = "Цена";
            PriceSort.UseVisualStyleBackColor = true;
            // 
            // CuisineSort
            // 
            CuisineSort.AutoSize = true;
            CuisineSort.Location = new Point(21, 196);
            CuisineSort.Name = "CuisineSort";
            CuisineSort.Size = new Size(100, 24);
            CuisineSort.TabIndex = 29;
            CuisineSort.Text = "Вид кухни";
            CuisineSort.UseVisualStyleBackColor = true;
            // 
            // KcalSort
            // 
            KcalSort.AutoSize = true;
            KcalSort.Location = new Point(21, 136);
            KcalSort.Name = "KcalSort";
            KcalSort.Size = new Size(114, 24);
            KcalSort.TabIndex = 28;
            KcalSort.Text = "Кол-во ккал";
            KcalSort.UseVisualStyleBackColor = true;
            // 
            // CategorySort
            // 
            CategorySort.AutoSize = true;
            CategorySort.Location = new Point(21, 225);
            CategorySort.Name = "CategorySort";
            CategorySort.Size = new Size(103, 24);
            CategorySort.TabIndex = 31;
            CategorySort.Text = "Категория";
            CategorySort.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Location = new Point(13, 49);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 32;
            label4.Text = "Масса";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Location = new Point(13, 77);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 33;
            label5.Text = "Кол-во ккал";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Location = new Point(13, 104);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 34;
            label6.Text = "Цена";
            // 
            // WeightFilterMin
            // 
            WeightFilterMin.Anchor = AnchorStyles.None;
            WeightFilterMin.DecimalPlaces = 3;
            WeightFilterMin.Location = new Point(151, 47);
            WeightFilterMin.Maximum = new decimal(new int[] { 99999999, 0, 0, 196608 });
            WeightFilterMin.Name = "WeightFilterMin";
            WeightFilterMin.Size = new Size(77, 27);
            WeightFilterMin.TabIndex = 35;
            WeightFilterMin.ValueChanged += WeightFilterMin_ValueChanged;
            // 
            // WeightFilterMax
            // 
            WeightFilterMax.Anchor = AnchorStyles.None;
            WeightFilterMax.DecimalPlaces = 3;
            WeightFilterMax.Location = new Point(282, 47);
            WeightFilterMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            WeightFilterMax.Name = "WeightFilterMax";
            WeightFilterMax.Size = new Size(82, 27);
            WeightFilterMax.TabIndex = 36;
            // 
            // KcalFilterMax
            // 
            KcalFilterMax.Anchor = AnchorStyles.None;
            KcalFilterMax.DecimalPlaces = 3;
            KcalFilterMax.Location = new Point(282, 75);
            KcalFilterMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            KcalFilterMax.Name = "KcalFilterMax";
            KcalFilterMax.Size = new Size(82, 27);
            KcalFilterMax.TabIndex = 37;
            // 
            // KcalFilterMin
            // 
            KcalFilterMin.Anchor = AnchorStyles.None;
            KcalFilterMin.DecimalPlaces = 3;
            KcalFilterMin.Location = new Point(151, 75);
            KcalFilterMin.Maximum = new decimal(new int[] { 99999999, 0, 0, 196608 });
            KcalFilterMin.Name = "KcalFilterMin";
            KcalFilterMin.Size = new Size(77, 27);
            KcalFilterMin.TabIndex = 38;
            KcalFilterMin.ValueChanged += KcalFilterMin_ValueChanged;
            // 
            // PriceFilterMin
            // 
            PriceFilterMin.Anchor = AnchorStyles.None;
            PriceFilterMin.DecimalPlaces = 3;
            PriceFilterMin.Location = new Point(151, 101);
            PriceFilterMin.Maximum = new decimal(new int[] { 99999999, 0, 0, 196608 });
            PriceFilterMin.Name = "PriceFilterMin";
            PriceFilterMin.Size = new Size(77, 27);
            PriceFilterMin.TabIndex = 39;
            PriceFilterMin.ValueChanged += PriceFilterMin_ValueChanged;
            // 
            // PriceFilterMax
            // 
            PriceFilterMax.Anchor = AnchorStyles.None;
            PriceFilterMax.DecimalPlaces = 3;
            PriceFilterMax.Location = new Point(282, 101);
            PriceFilterMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            PriceFilterMax.Name = "PriceFilterMax";
            PriceFilterMax.Size = new Size(82, 27);
            PriceFilterMax.TabIndex = 40;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Location = new Point(238, 53);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 41;
            label7.Text = "до";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Location = new Point(238, 83);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 42;
            label8.Text = "до";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Location = new Point(238, 108);
            label9.Name = "label9";
            label9.Size = new Size(26, 20);
            label9.TabIndex = 43;
            label9.Text = "до";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.Location = new Point(111, 53);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 44;
            label10.Text = "от";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.Location = new Point(111, 83);
            label11.Name = "label11";
            label11.Size = new Size(24, 20);
            label11.TabIndex = 45;
            label11.Text = "от";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.Location = new Point(111, 107);
            label12.Name = "label12";
            label12.Size = new Size(24, 20);
            label12.TabIndex = 46;
            label12.Text = "от";
            // 
            // SortPanel
            // 
            SortPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SortPanel.BorderStyle = BorderStyle.FixedSingle;
            SortPanel.Controls.Add(CategorySort);
            SortPanel.Controls.Add(PriceSort);
            SortPanel.Controls.Add(CuisineSort);
            SortPanel.Controls.Add(KcalSort);
            SortPanel.Controls.Add(NameSort);
            SortPanel.Controls.Add(WeightSort);
            SortPanel.Controls.Add(DownSort);
            SortPanel.Controls.Add(UpSort);
            SortPanel.Controls.Add(button6);
            SortPanel.Controls.Add(IdSort);
            SortPanel.Controls.Add(label3);
            SortPanel.Location = new Point(21, 291);
            SortPanel.Name = "SortPanel";
            SortPanel.Size = new Size(408, 303);
            SortPanel.TabIndex = 47;
            // 
            // FiltersPanel
            // 
            FiltersPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FiltersPanel.BorderStyle = BorderStyle.FixedSingle;
            FiltersPanel.Controls.Add(label13);
            FiltersPanel.Controls.Add(label12);
            FiltersPanel.Controls.Add(label11);
            FiltersPanel.Controls.Add(label10);
            FiltersPanel.Controls.Add(label9);
            FiltersPanel.Controls.Add(label8);
            FiltersPanel.Controls.Add(label7);
            FiltersPanel.Controls.Add(PriceFilterMax);
            FiltersPanel.Controls.Add(PriceFilterMin);
            FiltersPanel.Controls.Add(KcalFilterMin);
            FiltersPanel.Controls.Add(KcalFilterMax);
            FiltersPanel.Controls.Add(WeightFilterMax);
            FiltersPanel.Controls.Add(WeightFilterMin);
            FiltersPanel.Controls.Add(label6);
            FiltersPanel.Controls.Add(label5);
            FiltersPanel.Controls.Add(label4);
            FiltersPanel.Controls.Add(SetFiltersButton);
            FiltersPanel.Controls.Add(CuisineLabel);
            FiltersPanel.Location = new Point(434, 291);
            FiltersPanel.Name = "FiltersPanel";
            FiltersPanel.Size = new Size(380, 303);
            FiltersPanel.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(13, 12);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 32;
            label13.Text = "Фильтры:";
            // 
            // SearchPanel
            // 
            SearchPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(label14);
            SearchPanel.Controls.Add(SearchNameButton);
            SearchPanel.Controls.Add(IdForSearching);
            SearchPanel.Controls.Add(label2);
            SearchPanel.Controls.Add(label1);
            SearchPanel.Controls.Add(SearchIdButton);
            SearchPanel.Controls.Add(NameForSearching);
            SearchPanel.Location = new Point(821, 291);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(380, 303);
            SearchPanel.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(7, 12);
            label14.Name = "label14";
            label14.Size = new Size(57, 20);
            label14.TabIndex = 47;
            label14.Text = "Поиск:";
            // 
            // MealsTable
            // 
            MealsTable.AllowUserToAddRows = false;
            MealsTable.AllowUserToDeleteRows = false;
            MealsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MealsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MealsTable.BackgroundColor = SystemColors.GradientActiveCaption;
            MealsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MealsTable.Columns.AddRange(new DataGridViewColumn[] { ID, NameColumn, WeightColumn, KcalColumn, PriceColumn, CuisineColumn, CategoryColumn });
            MealsTable.GridColor = SystemColors.Info;
            MealsTable.Location = new Point(219, 52);
            MealsTable.Margin = new Padding(3, 4, 3, 4);
            MealsTable.Name = "MealsTable";
            MealsTable.ReadOnly = true;
            MealsTable.RowHeadersVisible = false;
            MealsTable.RowHeadersWidth = 51;
            MealsTable.RowTemplate.Height = 25;
            MealsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MealsTable.Size = new Size(962, 209);
            MealsTable.TabIndex = 0;
            MealsTable.CellClick += MealsTable_CellClick;
            // 
            // ID
            // 
            ID.FillWeight = 100.143784F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.FillWeight = 99.62005F;
            NameColumn.HeaderText = "Название";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // WeightColumn
            // 
            WeightColumn.FillWeight = 100.177521F;
            WeightColumn.HeaderText = "Масса";
            WeightColumn.MinimumWidth = 6;
            WeightColumn.Name = "WeightColumn";
            WeightColumn.ReadOnly = true;
            // 
            // KcalColumn
            // 
            KcalColumn.FillWeight = 100.152092F;
            KcalColumn.HeaderText = "Кол-во ккал";
            KcalColumn.MinimumWidth = 6;
            KcalColumn.Name = "KcalColumn";
            KcalColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            PriceColumn.FillWeight = 100.130295F;
            PriceColumn.HeaderText = "Цена";
            PriceColumn.MinimumWidth = 6;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            // 
            // CuisineColumn
            // 
            CuisineColumn.FillWeight = 99.6085739F;
            CuisineColumn.HeaderText = "Вид кухни";
            CuisineColumn.MinimumWidth = 6;
            CuisineColumn.Name = "CuisineColumn";
            CuisineColumn.ReadOnly = true;
            // 
            // CategoryColumn
            // 
            CategoryColumn.FillWeight = 100.167618F;
            CategoryColumn.HeaderText = "Категория";
            CategoryColumn.MinimumWidth = 6;
            CategoryColumn.Name = "CategoryColumn";
            CategoryColumn.ReadOnly = true;
            // 
            // MealForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1446, 608);
            Controls.Add(MealsTable);
            Controls.Add(CancelFilters);
            Controls.Add(SearchPanel);
            Controls.Add(FiltersPanel);
            Controls.Add(SortPanel);
            Controls.Add(OpenCategoryForm);
            Controls.Add(OpenCuisineForm);
            Controls.Add(CreateDb);
            Controls.Add(button3);
            Controls.Add(DeleteDb);
            Controls.Add(Exit);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1461, 644);
            Name = "MealForm";
            Text = "Меню";
            Load += MealForm_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightFilterMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightFilterMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalFilterMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalFilterMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceFilterMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceFilterMax).EndInit();
            SortPanel.ResumeLayout(false);
            SortPanel.PerformLayout();
            FiltersPanel.ResumeLayout(false);
            FiltersPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MealsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Exit;
        private Label CuisineLabel;
        private Button SetFiltersButton;
        private TextBox NameForSearching;
        private Button SearchIdButton;
        private Button DeleteDb;
        private Button button3;
        private Button CreateDb;
        private FileSystemWatcher fileSystemWatcher1;
        private Button OpenCategoryForm;
        private Button OpenCuisineForm;
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
        private Panel SortPanel;
        private Panel SearchPanel;
        private Panel FiltersPanel;
        private Label label13;
        private Label label14;
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