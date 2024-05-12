namespace OOP_Kurs_Simakin
{
    partial class CategoryForm
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
            AddCategoryBtn = new Button();
            CategoriesTable = new DataGridView();
            CancelFilters = new Button();
            SearchNameButton = new Button();
            IdForSearching = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            SearchIdButton = new Button();
            NameForSearching = new TextBox();
            idCat = new DataGridViewTextBoxColumn();
            nameCat = new DataGridViewTextBoxColumn();
            descriptionCat = new DataGridViewTextBoxColumn();
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
            CategoriesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoriesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoriesTable.BackgroundColor = SystemColors.GradientActiveCaption;
            CategoriesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriesTable.Columns.AddRange(new DataGridViewColumn[] { idCat, nameCat, descriptionCat });
            CategoriesTable.Location = new Point(55, 47);
            CategoriesTable.Name = "CategoriesTable";
            CategoriesTable.RowHeadersWidth = 51;
            CategoriesTable.RowTemplate.Height = 29;
            CategoriesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoriesTable.Size = new Size(804, 288);
            CategoriesTable.TabIndex = 1;
            CategoriesTable.CellClick += CategoriesTable_CellClick;
            // 
            // CancelFilters
            // 
            CancelFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelFilters.BackColor = SystemColors.Info;
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
            IdForSearching.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            IdForSearching.Name = "IdForSearching";
            IdForSearching.Size = new Size(150, 27);
            IdForSearching.TabIndex = 32;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(515, 403);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 31;
            label2.Text = "Поиск по ID:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(55, 402);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 30;
            label1.Text = "Поиск по названию: ";
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
            NameForSearching.Name = "NameForSearching";
            NameForSearching.Size = new Size(149, 27);
            NameForSearching.TabIndex = 28;
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
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(CancelFilters);
            Controls.Add(SearchNameButton);
            Controls.Add(IdForSearching);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchIdButton);
            Controls.Add(NameForSearching);
            Controls.Add(CategoriesTable);
            Controls.Add(AddCategoryBtn);
            MinimumSize = new Size(932, 647);
            Name = "CategoryForm";
            Text = "Категории блюд";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)CategoriesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddCategoryBtn;
        public DataGridView CategoriesTable;
        private Button CancelFilters;
        private Button SearchNameButton;
        private NumericUpDown IdForSearching;
        private Label label2;
        private Label label1;
        private Button SearchIdButton;
        private TextBox NameForSearching;
        private DataGridViewTextBoxColumn idCat;
        private DataGridViewTextBoxColumn nameCat;
        private DataGridViewTextBoxColumn descriptionCat;
    }
}