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
            idCat = new DataGridViewTextBoxColumn();
            nameCat = new DataGridViewTextBoxColumn();
            descriptionCat = new DataGridViewTextBoxColumn();
            CancelFilters = new Button();
            SearchNameButton = new Button();
            IdForSearching = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            SearchIdButton = new Button();
            NameForSearching = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CategoriesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).BeginInit();
            SuspendLayout();
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.Location = new Point(29, 401);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(196, 37);
            AddCategoryBtn.TabIndex = 0;
            AddCategoryBtn.Text = "Добавить категорию";
            AddCategoryBtn.UseVisualStyleBackColor = true;
            AddCategoryBtn.Click += AddCategoryBtn_Click;
            // 
            // CategoriesTable
            // 
            CategoriesTable.AllowUserToAddRows = false;
            CategoriesTable.AllowUserToDeleteRows = false;
            CategoriesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriesTable.Columns.AddRange(new DataGridViewColumn[] { idCat, nameCat, descriptionCat });
            CategoriesTable.Location = new Point(46, 38);
            CategoriesTable.Name = "CategoriesTable";
            CategoriesTable.RowHeadersWidth = 51;
            CategoriesTable.RowTemplate.Height = 29;
            CategoriesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoriesTable.Size = new Size(428, 188);
            CategoriesTable.TabIndex = 1;
            CategoriesTable.CellClick += CategoriesTable_CellClick;
            // 
            // idCat
            // 
            idCat.HeaderText = "ID";
            idCat.MinimumWidth = 6;
            idCat.Name = "idCat";
            idCat.Width = 125;
            // 
            // nameCat
            // 
            nameCat.HeaderText = "Название";
            nameCat.MinimumWidth = 6;
            nameCat.Name = "nameCat";
            nameCat.Width = 125;
            // 
            // descriptionCat
            // 
            descriptionCat.HeaderText = "Название";
            descriptionCat.MinimumWidth = 6;
            descriptionCat.Name = "descriptionCat";
            descriptionCat.Width = 125;
            // 
            // CancelFilters
            // 
            CancelFilters.Location = new Point(457, 388);
            CancelFilters.Name = "CancelFilters";
            CancelFilters.Size = new Size(122, 34);
            CancelFilters.TabIndex = 34;
            CancelFilters.Text = "Снять фильтры";
            CancelFilters.UseVisualStyleBackColor = true;
            CancelFilters.Click += CancelFilters_Click;
            // 
            // SearchNameButton
            // 
            SearchNameButton.Location = new Point(339, 247);
            SearchNameButton.Margin = new Padding(3, 4, 3, 4);
            SearchNameButton.Name = "SearchNameButton";
            SearchNameButton.Size = new Size(86, 31);
            SearchNameButton.TabIndex = 33;
            SearchNameButton.Text = "Найти запись";
            SearchNameButton.UseVisualStyleBackColor = true;
            SearchNameButton.Click += SearchNameButton_Click;
            // 
            // IdForSearching
            // 
            IdForSearching.Location = new Point(148, 313);
            IdForSearching.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            IdForSearching.Name = "IdForSearching";
            IdForSearching.Size = new Size(150, 27);
            IdForSearching.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 313);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 31;
            label2.Text = "Поиск по ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 247);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 30;
            label1.Text = "Поиск по названию: ";
            // 
            // SearchIdButton
            // 
            SearchIdButton.Location = new Point(314, 315);
            SearchIdButton.Margin = new Padding(3, 4, 3, 4);
            SearchIdButton.Name = "SearchIdButton";
            SearchIdButton.Size = new Size(86, 31);
            SearchIdButton.TabIndex = 29;
            SearchIdButton.Text = "Найти запись";
            SearchIdButton.UseVisualStyleBackColor = true;
            SearchIdButton.Click += SearchIdButton_Click;
            // 
            // NameForSearching
            // 
            NameForSearching.Location = new Point(209, 247);
            NameForSearching.Margin = new Padding(3, 4, 3, 4);
            NameForSearching.Name = "NameForSearching";
            NameForSearching.Size = new Size(114, 27);
            NameForSearching.TabIndex = 28;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelFilters);
            Controls.Add(SearchNameButton);
            Controls.Add(IdForSearching);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchIdButton);
            Controls.Add(NameForSearching);
            Controls.Add(CategoriesTable);
            Controls.Add(AddCategoryBtn);
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
        private DataGridViewTextBoxColumn idCat;
        private DataGridViewTextBoxColumn nameCat;
        private DataGridViewTextBoxColumn descriptionCat;
        private Button CancelFilters;
        private Button SearchNameButton;
        private NumericUpDown IdForSearching;
        private Label label2;
        private Label label1;
        private Button SearchIdButton;
        private TextBox NameForSearching;
    }
}