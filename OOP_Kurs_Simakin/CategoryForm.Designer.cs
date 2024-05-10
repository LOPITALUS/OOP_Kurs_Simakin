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
            ((System.ComponentModel.ISupportInitialize)CategoriesTable).BeginInit();
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
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CategoriesTable);
            Controls.Add(AddCategoryBtn);
            Name = "CategoryForm";
            Text = "Категории блюд";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)CategoriesTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddCategoryBtn;
        public DataGridView CategoriesTable;
        private DataGridViewTextBoxColumn idCat;
        private DataGridViewTextBoxColumn nameCat;
        private DataGridViewTextBoxColumn descriptionCat;
    }
}