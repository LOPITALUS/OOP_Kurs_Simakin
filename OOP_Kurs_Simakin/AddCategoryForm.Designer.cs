namespace OOP_Kurs_Simakin
{
    partial class AddCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
            NameLabel = new Label();
            NewCategoryName = new TextBox();
            ExitAddCategoryForm = new Button();
            ApplyAddCategoryForm = new Button();
            NewCategoryDescription = new RichTextBox();
            DescriptionLabel = new Label();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(17, 17);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(248, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Название новой категории блюд:";
            // 
            // NewCategoryName
            // 
            NewCategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCategoryName.Location = new Point(272, 13);
            NewCategoryName.Margin = new Padding(3, 4, 3, 4);
            NewCategoryName.MaxLength = 100;
            NewCategoryName.Name = "NewCategoryName";
            NewCategoryName.Size = new Size(463, 27);
            NewCategoryName.TabIndex = 1;
            // 
            // ExitAddCategoryForm
            // 
            ExitAddCategoryForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitAddCategoryForm.BackColor = SystemColors.Info;
            ExitAddCategoryForm.Location = new Point(657, 396);
            ExitAddCategoryForm.Margin = new Padding(3, 4, 3, 4);
            ExitAddCategoryForm.Name = "ExitAddCategoryForm";
            ExitAddCategoryForm.Size = new Size(94, 29);
            ExitAddCategoryForm.TabIndex = 2;
            ExitAddCategoryForm.Text = "Выход";
            ExitAddCategoryForm.UseVisualStyleBackColor = false;
            ExitAddCategoryForm.Click += ExitAddCategoryForm_Click;
            // 
            // ApplyAddCategoryForm
            // 
            ApplyAddCategoryForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyAddCategoryForm.BackColor = SystemColors.Info;
            ApplyAddCategoryForm.Location = new Point(49, 396);
            ApplyAddCategoryForm.Margin = new Padding(3, 4, 3, 4);
            ApplyAddCategoryForm.Name = "ApplyAddCategoryForm";
            ApplyAddCategoryForm.Size = new Size(111, 29);
            ApplyAddCategoryForm.TabIndex = 3;
            ApplyAddCategoryForm.Text = "Добавить";
            ApplyAddCategoryForm.UseVisualStyleBackColor = false;
            ApplyAddCategoryForm.Click += ApplyAddCategoryForm_Click;
            // 
            // NewCategoryDescription
            // 
            NewCategoryDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCategoryDescription.Location = new Point(271, 69);
            NewCategoryDescription.Margin = new Padding(3, 4, 3, 4);
            NewCategoryDescription.MaxLength = 1000;
            NewCategoryDescription.Name = "NewCategoryDescription";
            NewCategoryDescription.Size = new Size(463, 292);
            NewCategoryDescription.TabIndex = 5;
            NewCategoryDescription.Text = "";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(17, 69);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(83, 20);
            DescriptionLabel.TabIndex = 6;
            DescriptionLabel.Text = "Описание:";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(802, 459);
            Controls.Add(DescriptionLabel);
            Controls.Add(NewCategoryDescription);
            Controls.Add(ApplyAddCategoryForm);
            Controls.Add(ExitAddCategoryForm);
            Controls.Add(NewCategoryName);
            Controls.Add(NameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(818, 495);
            Name = "AddCategoryForm";
            Text = "Добавление новой категории блюд в БД";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        /// <summary>
        /// Текст у поля ввода названия
        /// </summary>
        private Label NameLabel;

        /// <summary>
        /// Поле ввода названия
        /// </summary>
        private TextBox NewCategoryName;

        /// <summary>
        /// Кнопка закрытия формы
        /// </summary>
        private Button ExitAddCategoryForm;

        /// <summary>
        /// Кнопка добавления
        /// </summary>
        private Button ApplyAddCategoryForm;

        /// <summary>
        /// Поле ввода описания
        /// </summary>
        private RichTextBox NewCategoryDescription;

        /// <summary>
        /// Текст у поля ввода описания
        /// </summary>
        private Label DescriptionLabel;
    }
}