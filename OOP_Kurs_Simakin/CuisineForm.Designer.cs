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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)CuisinesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdForSearching).BeginInit();
            SuspendLayout();
            // 
            // CuisinesTable
            // 
            CuisinesTable.AllowUserToAddRows = false;
            CuisinesTable.AllowUserToDeleteRows = false;
            CuisinesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CuisinesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CuisinesTable.BackgroundColor = SystemColors.GradientActiveCaption;
            CuisinesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CuisinesTable.Columns.AddRange(new DataGridViewColumn[] { idCuis, nameCuis, descriptionCuis });
            CuisinesTable.Location = new Point(48, 35);
            CuisinesTable.Margin = new Padding(3, 2, 3, 2);
            CuisinesTable.Name = "CuisinesTable";
            CuisinesTable.RowHeadersVisible = false;
            CuisinesTable.RowHeadersWidth = 51;
            CuisinesTable.RowTemplate.Height = 29;
            CuisinesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CuisinesTable.Size = new Size(704, 216);
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
            AddCuisineBtn.Location = new Point(64, 391);
            AddCuisineBtn.Margin = new Padding(3, 2, 3, 2);
            AddCuisineBtn.Name = "AddCuisineBtn";
            AddCuisineBtn.Size = new Size(149, 27);
            AddCuisineBtn.TabIndex = 1;
            AddCuisineBtn.Text = "Добавить кухню";
            AddCuisineBtn.UseVisualStyleBackColor = false;
            AddCuisineBtn.Click += AddCuisineBtn_Click;
            // 
            // SearchNameButton
            // 
            SearchNameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchNameButton.BackColor = SystemColors.Info;
            SearchNameButton.Location = new Point(325, 300);
            SearchNameButton.Name = "SearchNameButton";
            SearchNameButton.Size = new Size(75, 23);
            SearchNameButton.TabIndex = 25;
            SearchNameButton.Text = "Найти запись";
            SearchNameButton.UseVisualStyleBackColor = false;
            SearchNameButton.Click += SearchNameButton_Click;
            // 
            // IdForSearching
            // 
            IdForSearching.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            IdForSearching.Location = new Point(540, 300);
            IdForSearching.Margin = new Padding(3, 2, 3, 2);
            IdForSearching.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            IdForSearching.Name = "IdForSearching";
            IdForSearching.Size = new Size(131, 23);
            IdForSearching.TabIndex = 24;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(451, 302);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 23;
            label2.Text = "Поиск по ID:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 302);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 22;
            label1.Text = "Поиск по названию: ";
            // 
            // SearchIdButton
            // 
            SearchIdButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchIdButton.BackColor = SystemColors.Info;
            SearchIdButton.Location = new Point(676, 300);
            SearchIdButton.Name = "SearchIdButton";
            SearchIdButton.Size = new Size(75, 23);
            SearchIdButton.TabIndex = 21;
            SearchIdButton.Text = "Найти запись";
            SearchIdButton.UseVisualStyleBackColor = false;
            SearchIdButton.Click += SearchIdButton_Click;
            // 
            // NameForSearching
            // 
            NameForSearching.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NameForSearching.Location = new Point(189, 300);
            NameForSearching.MaxLength = 100;
            NameForSearching.Name = "NameForSearching";
            NameForSearching.Size = new Size(131, 23);
            NameForSearching.TabIndex = 20;
            // 
            // CancelFilters
            // 
            CancelFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelFilters.BackColor = SystemColors.Info;
            CancelFilters.Location = new Point(617, 391);
            CancelFilters.Margin = new Padding(3, 2, 3, 2);
            CancelFilters.Name = "CancelFilters";
            CancelFilters.Size = new Size(135, 27);
            CancelFilters.TabIndex = 26;
            CancelFilters.Text = "Снять фильтры";
            CancelFilters.UseVisualStyleBackColor = false;
            CancelFilters.Click += CancelFilters_Click;
            // 
            // CuisineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(802, 456);
            Controls.Add(CancelFilters);
            Controls.Add(SearchNameButton);
            Controls.Add(IdForSearching);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchIdButton);
            Controls.Add(NameForSearching);
            Controls.Add(AddCuisineBtn);
            Controls.Add(CuisinesTable);
            MinimumSize = new Size(818, 495);
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
        private Button SearchNameButton;
        private NumericUpDown IdForSearching;
        private Label label2;
        private Label label1;
        private Button SearchIdButton;
        private TextBox NameForSearching;
        private Button CancelFilters;
        private DataGridViewTextBoxColumn idCuis;
        private DataGridViewTextBoxColumn nameCuis;
        private DataGridViewTextBoxColumn descriptionCuis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}