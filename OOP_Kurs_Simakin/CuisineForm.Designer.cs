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
            ((System.ComponentModel.ISupportInitialize)CuisinesTable).BeginInit();
            SuspendLayout();
            // 
            // CuisinesTable
            // 
            CuisinesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CuisinesTable.Columns.AddRange(new DataGridViewColumn[] { idCuis, nameCuis, descriptionCuis });
            CuisinesTable.Location = new Point(44, 46);
            CuisinesTable.Name = "CuisinesTable";
            CuisinesTable.RowHeadersWidth = 51;
            CuisinesTable.RowTemplate.Height = 29;
            CuisinesTable.Size = new Size(428, 188);
            CuisinesTable.TabIndex = 0;
            // 
            // idCuis
            // 
            idCuis.HeaderText = "Название";
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
            // CuisineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(AddCuisineBtn);
            Controls.Add(CuisinesTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CuisineForm";
            Text = "Виды кухонь ";
            Load += CuisineForm_Load;
            ((System.ComponentModel.ISupportInitialize)CuisinesTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CuisinesTable;
        private Button AddCuisineBtn;
        private DataGridViewTextBoxColumn idCuis;
        private DataGridViewTextBoxColumn nameCuis;
        private DataGridViewTextBoxColumn descriptionCuis;
    }
}