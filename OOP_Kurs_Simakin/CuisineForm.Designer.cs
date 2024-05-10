namespace OOP_Kurs_Simakin
{
    partial class CuisineForm
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
            CuisinesTable = new DataGridView();
            idCuis = new DataGridViewTextBoxColumn();
            nameCuis = new DataGridViewTextBoxColumn();
            descriptionCuis = new DataGridViewTextBoxColumn();
            AddCuisineBtn = new Button();
            SearchNameButton = new Button();
            IdForSearching = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
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
            CuisinesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CuisinesTable.Columns.AddRange(new DataGridViewColumn[] { idCuis, nameCuis, descriptionCuis });
            CuisinesTable.Location = new Point(55, 47);
            CuisinesTable.Name = "CuisinesTable";
            CuisinesTable.RowHeadersWidth = 51;
            CuisinesTable.RowTemplate.Height = 29;
            CuisinesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CuisinesTable.Size = new Size(428, 188);
            CuisinesTable.TabIndex = 0;
            CuisinesTable.CellClick += CuisinesTable_CellClick;
            // 
            // idCuis
            // 
            idCuis.HeaderText = "ID";
            idCuis.MinimumWidth = 6;
            idCuis.Name = "idCuis";
            idCuis.Width = 125;
            // 
            // nameCuis
            // 
            nameCuis.HeaderText = "Название";
            nameCuis.MinimumWidth = 6;
            nameCuis.Name = "nameCuis";
            nameCuis.Width = 125;
            // 
            // descriptionCuis
            // 
            descriptionCuis.HeaderText = "Описание";
            descriptionCuis.MinimumWidth = 6;
            descriptionCuis.Name = "descriptionCuis";
            descriptionCuis.Width = 125;
            // 
            // AddCuisineBtn
            // 
            AddCuisineBtn.Location = new Point(55, 521);
            AddCuisineBtn.Name = "AddCuisineBtn";
            AddCuisineBtn.Size = new Size(170, 36);
            AddCuisineBtn.TabIndex = 1;
            AddCuisineBtn.Text = "Добавить кухню";
            AddCuisineBtn.UseVisualStyleBackColor = true;
            AddCuisineBtn.Click += AddCuisineBtn_Click;
            // 
            // SearchNameButton
            // 
            SearchNameButton.Location = new Point(352, 310);
            SearchNameButton.Margin = new Padding(3, 4, 3, 4);
            SearchNameButton.Name = "SearchNameButton";
            SearchNameButton.Size = new Size(86, 31);
            SearchNameButton.TabIndex = 25;
            SearchNameButton.Text = "Найти запись";
            SearchNameButton.UseVisualStyleBackColor = true;
            SearchNameButton.Click += SearchNameButton_Click;
            // 
            // IdForSearching
            // 
            IdForSearching.Location = new Point(176, 379);
            IdForSearching.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            IdForSearching.Name = "IdForSearching";
            IdForSearching.Size = new Size(150, 27);
            IdForSearching.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 379);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 23;
            label2.Text = "Поиск по ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 310);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 22;
            label1.Text = "Поиск по названию: ";
            // 
            // SearchIdButton
            // 
            SearchIdButton.Location = new Point(331, 379);
            SearchIdButton.Margin = new Padding(3, 4, 3, 4);
            SearchIdButton.Name = "SearchIdButton";
            SearchIdButton.Size = new Size(86, 31);
            SearchIdButton.TabIndex = 21;
            SearchIdButton.Text = "Найти запись";
            SearchIdButton.UseVisualStyleBackColor = true;
            SearchIdButton.Click += SearchIdButton_Click;
            // 
            // NameForSearching
            // 
            NameForSearching.Location = new Point(232, 310);
            NameForSearching.Margin = new Padding(3, 4, 3, 4);
            NameForSearching.Name = "NameForSearching";
            NameForSearching.Size = new Size(114, 27);
            NameForSearching.TabIndex = 20;
            // 
            // CancelFilters
            // 
            CancelFilters.Location = new Point(352, 521);
            CancelFilters.Name = "CancelFilters";
            CancelFilters.Size = new Size(122, 34);
            CancelFilters.TabIndex = 26;
            CancelFilters.Text = "Снять фильтры";
            CancelFilters.UseVisualStyleBackColor = true;
            CancelFilters.Click += CancelFilters_Click;
            // 
            // CuisineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(CancelFilters);
            Controls.Add(SearchNameButton);
            Controls.Add(IdForSearching);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchIdButton);
            Controls.Add(NameForSearching);
            Controls.Add(AddCuisineBtn);
            Controls.Add(CuisinesTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CuisineForm";
            Text = "Виды кухонь ";
            Load += CuisineForm_Load;
            ((System.ComponentModel.ISupportInitialize)CuisinesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView CuisinesTable;
        private Button AddCuisineBtn;
        private DataGridViewTextBoxColumn idCuis;
        private DataGridViewTextBoxColumn nameCuis;
        private DataGridViewTextBoxColumn descriptionCuis;
        private Button SearchNameButton;
        private NumericUpDown IdForSearching;
        private Label label2;
        private Label label1;
        private Button SearchIdButton;
        private TextBox NameForSearching;
        private Button CancelFilters;
    }
}