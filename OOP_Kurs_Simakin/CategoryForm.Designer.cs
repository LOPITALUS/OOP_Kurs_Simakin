namespace OOP_Kurs_Simakin
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            AddCategoryBtn = new Button();
            CategoriesTable = new DataGridView();
            idCat = new DataGridViewTextBoxColumn();
            nameCat = new DataGridViewTextBoxColumn();
            descriptionCat = new DataGridViewTextBoxColumn();
            CancelFilters = new Button();
            SearchNameButton = new Button();
            IdForSearching = new NumericUpDown();
            SearchIdLabel = new Label();
            SearchNameLabel = new Label();
            SearchIdButton = new Button();
            NameForSearching = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CategoriesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).BeginInit();
            SuspendLayout();
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCategoryBtn.BackColor = SystemColors.Info;
            AddCategoryBtn.Location = new Point(73, 521);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(170, 36);
            AddCategoryBtn.TabIndex = 0;
            AddCategoryBtn.Text = "Добавить категорию";
            AddCategoryBtn.UseVisualStyleBackColor = false;
            AddCategoryBtn.Click += AddCategoryBtn_Click;
            // 
            // CategoriesTable
            // 
            CategoriesTable.AllowUserToAddRows = false;
            CategoriesTable.AllowUserToDeleteRows = false;
            CategoriesTable.AllowUserToResizeColumns = false;
            CategoriesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoriesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoriesTable.BackgroundColor = SystemColors.GradientActiveCaption;
            CategoriesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriesTable.Columns.AddRange(new DataGridViewColumn[] { idCat, nameCat, descriptionCat });
            CategoriesTable.Location = new Point(55, 47);
            CategoriesTable.Name = "CategoriesTable";
            CategoriesTable.RowHeadersVisible = false;
            CategoriesTable.RowHeadersWidth = 51;
            CategoriesTable.RowTemplate.Height = 29;
            CategoriesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoriesTable.Size = new Size(805, 288);
            CategoriesTable.TabIndex = 1;
            CategoriesTable.CellClick += CategoriesTable_CellClick;
            // 
            // idCat
            // 
            idCat.FillWeight = 38.5979729F;
            idCat.HeaderText = "ID";
            idCat.MinimumWidth = 6;
            idCat.Name = "idCat";
            // 
            // nameCat
            // 
            nameCat.FillWeight = 70F;
            nameCat.HeaderText = "Название";
            nameCat.MinimumWidth = 6;
            nameCat.Name = "nameCat";
            // 
            // descriptionCat
            // 
            descriptionCat.FillWeight = 221.295044F;
            descriptionCat.HeaderText = "Описание";
            descriptionCat.MinimumWidth = 6;
            descriptionCat.Name = "descriptionCat";
            // 
            // CancelFilters
            // 
            CancelFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelFilters.BackColor = SystemColors.Info;
            CancelFilters.Enabled = false;
            CancelFilters.Location = new Point(705, 521);
            CancelFilters.Name = "CancelFilters";
            CancelFilters.Size = new Size(154, 36);
            CancelFilters.TabIndex = 34;
            CancelFilters.Text = "Снять фильтры";
            CancelFilters.UseVisualStyleBackColor = false;
            CancelFilters.Click += CancelFilters_Click;
            // 
            // SearchNameButton
            // 
            SearchNameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchNameButton.BackColor = SystemColors.Info;
            SearchNameButton.Location = new Point(371, 400);
            SearchNameButton.Margin = new Padding(3, 4, 3, 4);
            SearchNameButton.Name = "SearchNameButton";
            SearchNameButton.Size = new Size(86, 31);
            SearchNameButton.TabIndex = 33;
            SearchNameButton.Text = "Найти запись";
            SearchNameButton.UseVisualStyleBackColor = false;
            SearchNameButton.Click += SearchNameButton_Click;
            // 
            // IdForSearching
            // 
            IdForSearching.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            IdForSearching.Location = new Point(617, 400);
            IdForSearching.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            IdForSearching.Name = "IdForSearching";
            IdForSearching.Size = new Size(150, 27);
            IdForSearching.TabIndex = 32;
            // 
            // SearchIdLabel
            // 
            SearchIdLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchIdLabel.AutoSize = true;
            SearchIdLabel.Location = new Point(515, 403);
            SearchIdLabel.Name = "SearchIdLabel";
            SearchIdLabel.Size = new Size(96, 20);
            SearchIdLabel.TabIndex = 31;
            SearchIdLabel.Text = "Поиск по ID:";
            // 
            // SearchNameLabel
            // 
            SearchNameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchNameLabel.AutoSize = true;
            SearchNameLabel.Location = new Point(55, 403);
            SearchNameLabel.Name = "SearchNameLabel";
            SearchNameLabel.Size = new Size(155, 20);
            SearchNameLabel.TabIndex = 30;
            SearchNameLabel.Text = "Поиск по названию: ";
            // 
            // SearchIdButton
            // 
            SearchIdButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchIdButton.BackColor = SystemColors.Info;
            SearchIdButton.Location = new Point(773, 400);
            SearchIdButton.Margin = new Padding(3, 4, 3, 4);
            SearchIdButton.Name = "SearchIdButton";
            SearchIdButton.Size = new Size(86, 31);
            SearchIdButton.TabIndex = 29;
            SearchIdButton.Text = "Найти запись";
            SearchIdButton.UseVisualStyleBackColor = false;
            SearchIdButton.Click += SearchIdButton_Click;
            // 
            // NameForSearching
            // 
            NameForSearching.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NameForSearching.Location = new Point(216, 400);
            NameForSearching.Margin = new Padding(3, 4, 3, 4);
            NameForSearching.MaxLength = 100;
            NameForSearching.Name = "NameForSearching";
            NameForSearching.Size = new Size(149, 27);
            NameForSearching.TabIndex = 28;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(917, 608);
            Controls.Add(CancelFilters);
            Controls.Add(SearchNameButton);
            Controls.Add(IdForSearching);
            Controls.Add(SearchIdLabel);
            Controls.Add(SearchNameLabel);
            Controls.Add(SearchIdButton);
            Controls.Add(NameForSearching);
            Controls.Add(CategoriesTable);
            Controls.Add(AddCategoryBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(932, 644);
            Name = "CategoryForm";
            Text = "Категории блюд";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)CategoriesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        /// <summary>
        /// Кнопка открытия окна добавления
        /// </summary>
        private Button AddCategoryBtn;

        /// <summary>
        /// Таблица с категориями блюд
        /// </summary>
        public DataGridView CategoriesTable;

        /// <summary>
        /// Кнопка сброса всех фильтров
        /// </summary>
        private Button CancelFilters;

        /// <summary>
        /// Кнопка поиска по названию
        /// </summary>
        private Button SearchNameButton;

        /// <summary>
        /// Поле ввода id для поиска
        /// </summary>
        private NumericUpDown IdForSearching;

        /// <summary>
        /// Текст у поля ввода id для поиска
        /// </summary>
        private Label SearchIdLabel;

        /// <summary>
        /// Текст у поля ввода названия для поиска
        /// </summary>
        private Label SearchNameLabel;

        /// <summary>
        /// Кнопка поиска по id
        /// </summary>
        private Button SearchIdButton;

        /// <summary>
        /// Поле ввода названия для поиска
        /// </summary>
        private TextBox NameForSearching;

        /// <summary>
        /// Колонка таблицы - id
        /// </summary>
        private DataGridViewTextBoxColumn idCat;

        /// <summary>
        /// Колонка таблицы - название
        /// </summary>
        private DataGridViewTextBoxColumn nameCat;

        /// <summary>
        /// Колонка таблицы - описание
        /// </summary>
        private DataGridViewTextBoxColumn descriptionCat;
    }
}