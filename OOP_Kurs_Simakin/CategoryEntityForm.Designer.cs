namespace OOP_Kurs_Simakin
{
    partial class CategoryEntityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryEntityForm));
            ApplyChanges = new Button();
            DescriptionLabel = new Label();
            EditedCategoryDescription = new RichTextBox();
            EditedCategoryName = new TextBox();
            NameLabel = new Label();
            Delete = new Button();
            ExitCategoryEntityForm = new Button();
            SuspendLayout();
            // 
            // ApplyChanges
            // 
            ApplyChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyChanges.BackColor = SystemColors.Info;
            ApplyChanges.Location = new Point(49, 396);
            ApplyChanges.Name = "ApplyChanges";
            ApplyChanges.Size = new Size(111, 29);
            ApplyChanges.TabIndex = 0;
            ApplyChanges.Text = "Сохранить";
            ApplyChanges.UseVisualStyleBackColor = false;
            ApplyChanges.Click += ApplyChanges_Click;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(17, 69);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(83, 20);
            DescriptionLabel.TabIndex = 10;
            DescriptionLabel.Text = "Описание:";
            // 
            // EditedCategoryDescription
            // 
            EditedCategoryDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditedCategoryDescription.Location = new Point(231, 69);
            EditedCategoryDescription.Margin = new Padding(3, 4, 3, 4);
            EditedCategoryDescription.MaxLength = 1000;
            EditedCategoryDescription.Name = "EditedCategoryDescription";
            EditedCategoryDescription.Size = new Size(503, 292);
            EditedCategoryDescription.TabIndex = 9;
            EditedCategoryDescription.Text = "";
            // 
            // EditedCategoryName
            // 
            EditedCategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditedCategoryName.Location = new Point(231, 13);
            EditedCategoryName.Margin = new Padding(3, 4, 3, 4);
            EditedCategoryName.MaxLength = 100;
            EditedCategoryName.Name = "EditedCategoryName";
            EditedCategoryName.Size = new Size(503, 27);
            EditedCategoryName.TabIndex = 8;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(17, 17);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(200, 20);
            NameLabel.TabIndex = 7;
            NameLabel.Text = "Название категории блюд:";
            // 
            // Delete
            // 
            Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Delete.BackColor = SystemColors.Info;
            Delete.Location = new Point(362, 396);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 16;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // ExitCategoryEntityForm
            // 
            ExitCategoryEntityForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitCategoryEntityForm.BackColor = SystemColors.Info;
            ExitCategoryEntityForm.Location = new Point(657, 396);
            ExitCategoryEntityForm.Name = "ExitCategoryEntityForm";
            ExitCategoryEntityForm.Size = new Size(94, 29);
            ExitCategoryEntityForm.TabIndex = 15;
            ExitCategoryEntityForm.Text = "Выход";
            ExitCategoryEntityForm.UseVisualStyleBackColor = false;
            ExitCategoryEntityForm.Click += ExitCategoryEntityForm_Click;
            // 
            // CategoryEntityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(802, 459);
            Controls.Add(Delete);
            Controls.Add(ExitCategoryEntityForm);
            Controls.Add(DescriptionLabel);
            Controls.Add(EditedCategoryDescription);
            Controls.Add(EditedCategoryName);
            Controls.Add(NameLabel);
            Controls.Add(ApplyChanges);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(818, 495);
            Name = "CategoryEntityForm";
            Text = "CategoryEntityForm";
            Load += CategoryEntityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        /// <summary>
        /// Кнопка сохранения
        /// </summary>
        private Button ApplyChanges;

        /// <summary>
        /// Текст у поля ввода описания
        /// </summary>
        private Label DescriptionLabel;

        /// <summary>
        /// Поле ввода описания
        /// </summary>
        private RichTextBox EditedCategoryDescription;

        /// <summary>
        /// Поле ввода навзвания
        /// </summary>
        private TextBox EditedCategoryName;

        /// <summary>
        /// Текст у поля ввода названия
        /// </summary>
        private Label NameLabel;

        /// <summary>
        /// Кнопка удаления
        /// </summary>
        private Button Delete;

        /// <summary>
        /// Кнопка закрытия окна
        /// </summary>
        private Button ExitCategoryEntityForm;
    }
}