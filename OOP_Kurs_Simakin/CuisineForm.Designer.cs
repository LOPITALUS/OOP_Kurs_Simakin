namespace OOP_Kurs_Simakin
{
    partial class CuisineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuisineForm));
            CuisinesTable = new DataGridView();
            idCuis = new DataGridViewTextBoxColumn();
            nameCuis = new DataGridViewTextBoxColumn();
            descriptionCuis = new DataGridViewTextBoxColumn();
            AddCuisineBtn = new Button();
            SearchNameButton = new Button();
            IdForSearching = new NumericUpDown();
            SearchIdLabel = new Label();
            SearchNameLabel = new Label();
            SearchIdButton = new Button();
            NameForSearching = new TextBox();
            CancelFilters = new Button();
            ((System.ComponentModel.ISupportInitialize)CuisinesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).BeginInit();
            SuspendLayout();
            // 
            // CuisinesTable
            // 
            CuisinesTable.AllowUserToAddRows = false;
            CuisinesTable.AllowUserToDeleteRows = false;
            CuisinesTable.AllowUserToResizeColumns = false;
            CuisinesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CuisinesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CuisinesTable.BackgroundColor = SystemColors.GradientActiveCaption;
            CuisinesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CuisinesTable.Columns.AddRange(new DataGridViewColumn[] { idCuis, nameCuis, descriptionCuis });
            CuisinesTable.Location = new Point(55, 47);
            CuisinesTable.Name = "CuisinesTable";
            CuisinesTable.RowHeadersVisible = false;
            CuisinesTable.RowHeadersWidth = 51;
            CuisinesTable.RowTemplate.Height = 29;
            CuisinesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CuisinesTable.Size = new Size(805, 288);
            CuisinesTable.TabIndex = 0;
            CuisinesTable.CellClick += CuisinesTable_CellClick;
            // 
            // idCuis
            // 
            idCuis.FillWeight = 38.5979729F;
            idCuis.HeaderText = "ID";
            idCuis.MinimumWidth = 6;
            idCuis.Name = "idCuis";
            // 
            // nameCuis
            // 
            nameCuis.FillWeight = 70F;
            nameCuis.HeaderText = "Название";
            nameCuis.MinimumWidth = 6;
            nameCuis.Name = "nameCuis";
            // 
            // descriptionCuis
            // 
            descriptionCuis.FillWeight = 221.295044F;
            descriptionCuis.HeaderText = "Описание";
            descriptionCuis.MinimumWidth = 6;
            descriptionCuis.Name = "descriptionCuis";
            // 
            // AddCuisineBtn
            // 
            AddCuisineBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCuisineBtn.BackColor = SystemColors.Info;
            AddCuisineBtn.Location = new Point(73, 521);
            AddCuisineBtn.Name = "AddCuisineBtn";
            AddCuisineBtn.Size = new Size(170, 36);
            AddCuisineBtn.TabIndex = 1;
            AddCuisineBtn.Text = "Добавить кухню";
            AddCuisineBtn.UseVisualStyleBackColor = false;
            AddCuisineBtn.Click += AddCuisineBtn_Click;
            // 
            // SearchNameButton
            // 
            SearchNameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchNameButton.BackColor = SystemColors.Info;
            SearchNameButton.Location = new Point(371, 400);
            SearchNameButton.Margin = new Padding(3, 4, 3, 4);
            SearchNameButton.Name = "SearchNameButton";
            SearchNameButton.Size = new Size(86, 31);
            SearchNameButton.TabIndex = 25;
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
            IdForSearching.TabIndex = 24;
            // 
            // SearchIdLabel
            // 
            SearchIdLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchIdLabel.AutoSize = true;
            SearchIdLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchIdLabel.Location = new Point(515, 403);
            SearchIdLabel.Name = "SearchIdLabel";
            SearchIdLabel.Size = new Size(98, 20);
            SearchIdLabel.TabIndex = 23;
            SearchIdLabel.Text = "Поиск по ID:";
            // 
            // SearchNameLabel
            // 
            SearchNameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchNameLabel.AutoSize = true;
            SearchNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchNameLabel.Location = new Point(55, 403);
            SearchNameLabel.Name = "SearchNameLabel";
            SearchNameLabel.Size = new Size(158, 20);
            SearchNameLabel.TabIndex = 22;
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
            SearchIdButton.TabIndex = 21;
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
            NameForSearching.TabIndex = 20;
            // 
            // CancelFilters
            // 
            CancelFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelFilters.BackColor = SystemColors.Info;
            CancelFilters.Enabled = false;
            CancelFilters.Location = new Point(705, 521);
            CancelFilters.Name = "CancelFilters";
            CancelFilters.Size = new Size(154, 36);
            CancelFilters.TabIndex = 26;
            CancelFilters.Text = "Снять фильтры";
            CancelFilters.UseVisualStyleBackColor = false;
            CancelFilters.Click += CancelFilters_Click;
            // 
            // CuisineForm
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
            Controls.Add(AddCuisineBtn);
            Controls.Add(CuisinesTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(932, 644);
            Name = "CuisineForm";
            Text = "Виды кухонь ";
            Load += CuisineForm_Load;
            ((System.ComponentModel.ISupportInitialize)CuisinesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        /// <summary>
        /// Таблица кухонь
        /// </summary>
        public DataGridView CuisinesTable;

        /// <summary>
        /// Кнопка открытия окна добавления
        /// </summary>
        private Button AddCuisineBtn;

        /// <summary>
        /// Кнопка поиска по названию
        /// </summary>
        private Button SearchNameButton;

        /// <summary>
        /// Поле ввода id для входа
        /// </summary>
        private NumericUpDown IdForSearching;

        /// <summary>
        /// Текст у поля ввода id для поиска
        /// </summary>
        private Label SearchIdLabel;

        /// <summary>
        /// Текст у поля ввода названия
        /// </summary>
        private Label SearchNameLabel;

        /// <summary>
        /// Кнопка поиска по id
        /// </summary>
        private Button SearchIdButton;

        /// <summary>
        /// Текст у поля ввода названия
        /// </summary>
        private TextBox NameForSearching;

        /// <summary>
        /// Кнопка снятия фильтров
        /// </summary>
        private Button CancelFilters;

        /// <summary>
        /// Колонка - id кухни
        /// </summary>
        private DataGridViewTextBoxColumn idCuis;

        /// <summary>
        /// Колонка - название кухни
        /// </summary>
        private DataGridViewTextBoxColumn nameCuis;

        /// <summary>
        /// Колонка - описание кухни
        /// </summary>
        private DataGridViewTextBoxColumn descriptionCuis;
        //private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}