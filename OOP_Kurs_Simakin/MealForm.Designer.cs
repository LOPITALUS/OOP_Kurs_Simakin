namespace OOP_Kurs_Simakin
{
    partial class MealForm
    {
        /// <summary>
        /// Обязательная переменная дизайнера
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очищает ресурсы
        /// </summary>
        /// <param name="disposing">true если ресурсы должны быть очищены иначе false</param>
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
        /// Методы формы
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealForm));
            Exit = new Button();
            CuisineLabel = new Label();
            SetFiltersButton = new Button();
            NameForSearching = new TextBox();
            SearchIdButton = new Button();
            DeleteDb = new Button();
            AddMealButton = new Button();
            CreateDb = new Button();
           // fileSystemWatcher1 = new FileSystemWatcher();
            OpenCuisineForm = new Button();
            OpenCategoryForm = new Button();
            NameSearchLabel = new Label();
            IdSearchLabel = new Label();
            IdForSearching = new NumericUpDown();
            SearchNameButton = new Button();
            CancelFilters = new Button();
            SortLabel = new Label();
            IdSort = new CheckBox();
            SortButton = new Button();
            UpSort = new RadioButton();
            DownSort = new RadioButton();
            WeightSort = new CheckBox();
            NameSort = new CheckBox();
            PriceSort = new CheckBox();
            CuisineSort = new CheckBox();
            KcalSort = new CheckBox();
            CategorySort = new CheckBox();
            WeightLabel = new Label();
            KcalLabel = new Label();
            PriceLabel = new Label();
            WeightFilterMin = new NumericUpDown();
            WeightFilterMax = new NumericUpDown();
            KcalFilterMax = new NumericUpDown();
            KcalFilterMin = new NumericUpDown();
            PriceFilterMin = new NumericUpDown();
            PriceFilterMax = new NumericUpDown();
            WeightMaxLabel = new Label();
            KcalMaxLabel = new Label();
            PriceMaxLabel = new Label();
            WeightMinLabel = new Label();
            KcalMinLabel = new Label();
            PriceMinLabel = new Label();
            SortPanel = new Panel();
            FiltersPanel = new Panel();
            FiltersLabel = new Label();
            SearchPanel = new Panel();
            SearchLabel = new Label();
            MealsTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            WeightColumn = new DataGridViewTextBoxColumn();
            KcalColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            CuisineColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
           // ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
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
            // AddMealButton
            // 
            AddMealButton.BackColor = SystemColors.Info;
            AddMealButton.Location = new Point(40, 197);
            AddMealButton.Margin = new Padding(3, 4, 3, 4);
            AddMealButton.Name = "AddMealButton";
            AddMealButton.Size = new Size(153, 53);
            AddMealButton.TabIndex = 11;
            AddMealButton.Text = "Добавить новое блюдо\r\n";
            AddMealButton.UseVisualStyleBackColor = false;
            AddMealButton.Click += AddMealButton_Click;
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
            //// 
            //// fileSystemWatcher1
            //// 
            //fileSystemWatcher1.EnableRaisingEvents = true;
            //fileSystemWatcher1.SynchronizingObject = this;
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
            // NameSearchLabel
            // 
            NameSearchLabel.AutoSize = true;
            NameSearchLabel.Location = new Point(7, 47);
            NameSearchLabel.Name = "NameSearchLabel";
            NameSearchLabel.Size = new Size(110, 20);
            NameSearchLabel.TabIndex = 16;
            NameSearchLabel.Text = "По названию: ";
            // 
            // IdSearchLabel
            // 
            IdSearchLabel.AutoSize = true;
            IdSearchLabel.Location = new Point(7, 101);
            IdSearchLabel.Name = "IdSearchLabel";
            IdSearchLabel.Size = new Size(150, 20);
            IdSearchLabel.TabIndex = 17;
            IdSearchLabel.Text = "По идентификатору:";
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
            CancelFilters.Enabled = false;
            CancelFilters.Location = new Point(1216, 400);
            CancelFilters.Name = "CancelFilters";
            CancelFilters.Size = new Size(216, 51);
            CancelFilters.TabIndex = 20;
            CancelFilters.Text = "Снять все фильтры с таблицы";
            CancelFilters.UseVisualStyleBackColor = false;
            CancelFilters.Click += CancelFilters_Click;
            // 
            // SortLabel
            // 
            SortLabel.AutoSize = true;
            SortLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SortLabel.Location = new Point(19, 12);
            SortLabel.Name = "SortLabel";
            SortLabel.Size = new Size(99, 20);
            SortLabel.TabIndex = 21;
            SortLabel.Text = "Сортировка:";
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
            // SortButton
            // 
            SortButton.BackColor = SystemColors.Info;
            SortButton.Location = new Point(138, 259);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(113, 29);
            SortButton.TabIndex = 23;
            SortButton.Text = "Сортировать";
            SortButton.UseVisualStyleBackColor = false;
            SortButton.Click += SortButton_Click;
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
            // WeightLabel
            // 
            WeightLabel.Anchor = AnchorStyles.None;
            WeightLabel.Location = new Point(3, 49);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(53, 20);
            WeightLabel.TabIndex = 32;
            WeightLabel.Text = "Масса";
            // 
            // KcalLabel
            // 
            KcalLabel.Anchor = AnchorStyles.None;
            KcalLabel.Location = new Point(3, 76);
            KcalLabel.Name = "KcalLabel";
            KcalLabel.Size = new Size(101, 21);
            KcalLabel.TabIndex = 33;
            KcalLabel.Text = "Кол-во ккал";
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.None;
            PriceLabel.Location = new Point(3, 104);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(45, 20);
            PriceLabel.TabIndex = 34;
            PriceLabel.Text = "Цена";
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
            // WeightMaxLabel
            // 
            WeightMaxLabel.Anchor = AnchorStyles.None;
            WeightMaxLabel.Location = new Point(238, 53);
            WeightMaxLabel.Name = "WeightMaxLabel";
            WeightMaxLabel.Size = new Size(26, 20);
            WeightMaxLabel.TabIndex = 41;
            WeightMaxLabel.Text = "до";
            // 
            // KcalMaxLabel
            // 
            KcalMaxLabel.Anchor = AnchorStyles.None;
            KcalMaxLabel.Location = new Point(238, 83);
            KcalMaxLabel.Name = "KcalMaxLabel";
            KcalMaxLabel.Size = new Size(26, 20);
            KcalMaxLabel.TabIndex = 42;
            KcalMaxLabel.Text = "до";
            // 
            // PriceMaxLabel
            // 
            PriceMaxLabel.Anchor = AnchorStyles.None;
            PriceMaxLabel.Location = new Point(238, 108);
            PriceMaxLabel.Name = "PriceMaxLabel";
            PriceMaxLabel.Size = new Size(26, 20);
            PriceMaxLabel.TabIndex = 43;
            PriceMaxLabel.Text = "до";
            // 
            // WeightMinLabel
            // 
            WeightMinLabel.Anchor = AnchorStyles.None;
            WeightMinLabel.Location = new Point(111, 53);
            WeightMinLabel.Name = "WeightMinLabel";
            WeightMinLabel.Size = new Size(24, 20);
            WeightMinLabel.TabIndex = 44;
            WeightMinLabel.Text = "от";
            // 
            // KcalMinLabel
            // 
            KcalMinLabel.Anchor = AnchorStyles.None;
            KcalMinLabel.Location = new Point(111, 83);
            KcalMinLabel.Name = "KcalMinLabel";
            KcalMinLabel.Size = new Size(24, 20);
            KcalMinLabel.TabIndex = 45;
            KcalMinLabel.Text = "от";
            // 
            // PriceMinLabel
            // 
            PriceMinLabel.Anchor = AnchorStyles.None;
            PriceMinLabel.Location = new Point(111, 107);
            PriceMinLabel.Name = "PriceMinLabel";
            PriceMinLabel.Size = new Size(24, 20);
            PriceMinLabel.TabIndex = 46;
            PriceMinLabel.Text = "от";
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
            SortPanel.Controls.Add(SortButton);
            SortPanel.Controls.Add(IdSort);
            SortPanel.Controls.Add(SortLabel);
            SortPanel.Location = new Point(21, 291);
            SortPanel.Name = "SortPanel";
            SortPanel.Size = new Size(408, 303);
            SortPanel.TabIndex = 47;
            // 
            // FiltersPanel
            // 
            FiltersPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FiltersPanel.BorderStyle = BorderStyle.FixedSingle;
            FiltersPanel.Controls.Add(FiltersLabel);
            FiltersPanel.Controls.Add(PriceMinLabel);
            FiltersPanel.Controls.Add(KcalMinLabel);
            FiltersPanel.Controls.Add(WeightMinLabel);
            FiltersPanel.Controls.Add(PriceMaxLabel);
            FiltersPanel.Controls.Add(KcalMaxLabel);
            FiltersPanel.Controls.Add(WeightMaxLabel);
            FiltersPanel.Controls.Add(PriceFilterMax);
            FiltersPanel.Controls.Add(PriceFilterMin);
            FiltersPanel.Controls.Add(KcalFilterMin);
            FiltersPanel.Controls.Add(KcalFilterMax);
            FiltersPanel.Controls.Add(WeightFilterMax);
            FiltersPanel.Controls.Add(WeightFilterMin);
            FiltersPanel.Controls.Add(PriceLabel);
            FiltersPanel.Controls.Add(KcalLabel);
            FiltersPanel.Controls.Add(WeightLabel);
            FiltersPanel.Controls.Add(SetFiltersButton);
            FiltersPanel.Controls.Add(CuisineLabel);
            FiltersPanel.Location = new Point(434, 291);
            FiltersPanel.Name = "FiltersPanel";
            FiltersPanel.Size = new Size(380, 303);
            FiltersPanel.TabIndex = 48;
            // 
            // FiltersLabel
            // 
            FiltersLabel.AutoSize = true;
            FiltersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FiltersLabel.Location = new Point(3, 12);
            FiltersLabel.Name = "FiltersLabel";
            FiltersLabel.Size = new Size(80, 20);
            FiltersLabel.TabIndex = 32;
            FiltersLabel.Text = "Фильтры:";
            // 
            // SearchPanel
            // 
            SearchPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(SearchLabel);
            SearchPanel.Controls.Add(SearchNameButton);
            SearchPanel.Controls.Add(IdForSearching);
            SearchPanel.Controls.Add(IdSearchLabel);
            SearchPanel.Controls.Add(NameSearchLabel);
            SearchPanel.Controls.Add(SearchIdButton);
            SearchPanel.Controls.Add(NameForSearching);
            SearchPanel.Location = new Point(821, 291);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(380, 303);
            SearchPanel.TabIndex = 49;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchLabel.Location = new Point(7, 12);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(57, 20);
            SearchLabel.TabIndex = 47;
            SearchLabel.Text = "Поиск:";
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
            Controls.Add(AddMealButton);
            Controls.Add(DeleteDb);
            Controls.Add(Exit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1461, 644);
            Name = "MealForm";
            Text = "Меню";
            Load += MealForm_Load;
            //((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        /// <summary>
        /// Кнопка закрытия окна
        /// </summary>
        private Button Exit;

        /// <summary>
        /// Текст названия кухни
        /// </summary>
        private Label CuisineLabel;

        /// <summary>
        /// Кнопка установки фильтров
        /// </summary>
        private Button SetFiltersButton;

        /// <summary>
        /// Поле ввода названия для поиска
        /// </summary>
        private TextBox NameForSearching;

        /// <summary>
        /// Кнопка поиска по id
        /// </summary>
        private Button SearchIdButton;

        /// <summary>
        /// Кнопка удаления базы данных
        /// </summary>
        private Button DeleteDb;

        /// <summary>
        /// Кнопка открытия окна добавления блюда
        /// </summary>
        private Button AddMealButton;

        /// <summary>
        /// Кнопка создания базы данных
        /// </summary>
        private Button CreateDb;

        //private FileSystemWatcher fileSystemWatcher1;
        
        /// <summary>
        /// Кнопка открытия окна "Виды кухонь"
        /// </summary>
        private Button OpenCategoryForm;

        /// <summary>
        /// Кнопка открытия окна "Категории блюд"
        /// </summary>
        private Button OpenCuisineForm;

        /// <summary>
        /// Поле ввода id для поиска
        /// </summary>
        private NumericUpDown IdForSearching;

        /// <summary>
        /// Текст у поля ввода id для поиска
        /// </summary>
        private Label IdSearchLabel;

        /// <summary>
        /// Текст у ввода названия для поиска
        /// </summary>
        private Label NameSearchLabel;

        /// <summary>
        /// Кнопка поиска по навзванию
        /// </summary>
        private Button SearchNameButton;

        /// <summary>
        /// Кнопка снятия фильтров
        /// </summary>
        private Button CancelFilters;

        /// <summary>
        /// Радио-кнопка для выбора сортировки по убыванию
        /// </summary>
        private RadioButton DownSort;

        /// <summary>
        /// Радио-кнопка для выбора сортировки по возрастанию
        /// </summary>
        private RadioButton UpSort;

        /// <summary>
        /// Кнопка для сортировки
        /// </summary>
        private Button SortButton;

        /// <summary>
        /// Чекбокс для сортировки по id
        /// </summary>
        private CheckBox IdSort;

        /// <summary>
        /// Текст у блока сортироки
        /// </summary>
        private Label SortLabel;

        /// <summary>
        /// Чекбокс для сортировки по массе
        /// </summary>
        private CheckBox WeightSort;

        /// <summary>
        /// Чекбокс для сортировки по цене
        /// </summary>
        private CheckBox PriceSort;

        /// <summary>
        /// Чекбокс для сортировки по id кухни
        /// </summary>
        private CheckBox CuisineSort;

        /// <summary>
        /// Чекбокс для сортировки по кол-ву ккал
        /// </summary>
        private CheckBox KcalSort;

        /// <summary>
        /// Чекбокс для сортировки по названию
        /// </summary>
        private CheckBox NameSort;

        /// <summary>
        /// Чекбокс для сортировки по id категории
        /// </summary>
        private CheckBox CategorySort;

        /// <summary>
        /// Текст у фильтра по цене
        /// </summary>
        private Label PriceLabel;

        /// <summary>
        /// Текст у фильтра по кол-ву ккал
        /// </summary>
        private Label KcalLabel;

        /// <summary>
        /// Текст у фильтра по массе
        /// </summary>
        private Label WeightLabel;

        /// <summary>
        /// Макс. значения фильтра по цене
        /// </summary>
        private NumericUpDown PriceFilterMax;

        /// <summary>
        /// Мин. значение фильтра по цене
        /// </summary>
        private NumericUpDown PriceFilterMin;

        /// <summary>
        /// Мин. значения фильтра по кол-ву ккал
        /// </summary>
        private NumericUpDown KcalFilterMin;

        /// <summary>
        /// Макс. значение фильтра по кол-ву ккал
        /// </summary>
        private NumericUpDown KcalFilterMax;

        /// <summary>
        /// Макс. значение фильтра по массе
        /// </summary>
        private NumericUpDown WeightFilterMax;

        /// <summary>
        /// Мин. значение фильтра по массе
        /// </summary>
        private NumericUpDown WeightFilterMin;

        /// <summary>
        /// Текст у поля ввода мин. значения цены при фильтрации
        /// </summary>
        private Label PriceMinLabel;

        /// <summary>
        /// Текст у поля ввода мин. значения кол-ва ккал при фильтрации
        /// </summary>
        private Label KcalMinLabel;

        /// <summary>
        /// Текст у поля ввода мин. значения массы при фильтрации
        /// </summary>
        private Label WeightMinLabel;

        /// <summary>
        /// Текст у поля ввода макс. значения цены при фильтрации
        /// </summary>
        private Label PriceMaxLabel;

        /// <summary>
        /// Текст у поля ввода макс. значения кол-ва ккал при фильтрации
        /// </summary>
        private Label KcalMaxLabel;

        /// <summary>
        /// Текст у поля ввода макс. значения массы при фильтрации
        /// </summary>
        private Label WeightMaxLabel;

        /// <summary>
        /// Панель с элементами сортировки
        /// </summary>
        private Panel SortPanel;

        /// <summary>
        /// Панель с элементами поиска
        /// </summary>
        private Panel SearchPanel;

        /// <summary>
        /// Панель с элементами фильтрации
        /// </summary>
        private Panel FiltersPanel;

        /// <summary>
        /// Текст панели с фильтрами
        /// </summary>
        private Label FiltersLabel;

        /// <summary>
        /// Текст панели с поиском
        /// </summary>
        private Label SearchLabel;

        /// <summary>
        /// Таблица с блюдами
        /// </summary>
        public DataGridView MealsTable;

        /// <summary>
        /// Колонка - id блюда
        /// </summary>
        private DataGridViewTextBoxColumn ID;

        /// <summary>
        /// Колонка - название
        /// </summary>
        private DataGridViewTextBoxColumn NameColumn;

        /// <summary>
        /// Колонка - вес
        /// </summary>
        private DataGridViewTextBoxColumn WeightColumn;

        /// <summary>
        /// Колонка - кол-во ккал
        /// </summary>
        private DataGridViewTextBoxColumn KcalColumn;

        /// <summary>
        /// Колонка - цена
        /// </summary>
        private DataGridViewTextBoxColumn PriceColumn;

        /// <summary>
        /// Колонка - id кухни
        /// </summary>
        private DataGridViewTextBoxColumn CuisineColumn;

        /// <summary>
        /// Колонка - id категории
        /// </summary>
        private DataGridViewTextBoxColumn CategoryColumn;
    }
}