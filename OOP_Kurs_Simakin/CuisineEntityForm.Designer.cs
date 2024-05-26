namespace OOP_Kurs_Simakin
{
    partial class CuisineEntityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuisineEntityForm));
            Delete = new Button();
            ExitCuisineEntityForm = new Button();
            DescriptionLabel = new Label();
            EditedCuisineDescription = new RichTextBox();
            EditedCuisineName = new TextBox();
            NameLabel = new Label();
            ApplyChanges = new Button();
            SuspendLayout();
            // 
            // Delete
            // 
            Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Delete.BackColor = SystemColors.Info;
            Delete.Location = new Point(362, 396);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 23;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // ExitCuisineEntityForm
            // 
            ExitCuisineEntityForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitCuisineEntityForm.BackColor = SystemColors.Info;
            ExitCuisineEntityForm.Location = new Point(657, 396);
            ExitCuisineEntityForm.Name = "ExitCuisineEntityForm";
            ExitCuisineEntityForm.Size = new Size(94, 29);
            ExitCuisineEntityForm.TabIndex = 22;
            ExitCuisineEntityForm.Text = "Выход";
            ExitCuisineEntityForm.UseVisualStyleBackColor = false;
            ExitCuisineEntityForm.Click += ExitCuisineEntityForm_Click;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(17, 69);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(83, 20);
            DescriptionLabel.TabIndex = 21;
            DescriptionLabel.Text = "Описание:";
            // 
            // EditedCuisineDescription
            // 
            EditedCuisineDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditedCuisineDescription.Location = new Point(185, 69);
            EditedCuisineDescription.Margin = new Padding(3, 4, 3, 4);
            EditedCuisineDescription.MaxLength = 1000;
            EditedCuisineDescription.Name = "EditedCuisineDescription";
            EditedCuisineDescription.Size = new Size(549, 292);
            EditedCuisineDescription.TabIndex = 20;
            EditedCuisineDescription.Text = "";
            // 
            // EditedCuisineName
            // 
            EditedCuisineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditedCuisineName.Location = new Point(185, 13);
            EditedCuisineName.Margin = new Padding(3, 4, 3, 4);
            EditedCuisineName.MaxLength = 100;
            EditedCuisineName.Name = "EditedCuisineName";
            EditedCuisineName.Size = new Size(549, 27);
            EditedCuisineName.TabIndex = 19;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(17, 17);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(165, 20);
            NameLabel.TabIndex = 18;
            NameLabel.Text = "Название вида кухни:";
            // 
            // ApplyChanges
            // 
            ApplyChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyChanges.BackColor = SystemColors.Info;
            ApplyChanges.Location = new Point(49, 396);
            ApplyChanges.Name = "ApplyChanges";
            ApplyChanges.Size = new Size(111, 29);
            ApplyChanges.TabIndex = 17;
            ApplyChanges.Text = "Сохранить";
            ApplyChanges.UseVisualStyleBackColor = false;
            ApplyChanges.Click += ApplyChanges_Click;
            // 
            // CuisineEntityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(802, 459);
            Controls.Add(Delete);
            Controls.Add(ExitCuisineEntityForm);
            Controls.Add(DescriptionLabel);
            Controls.Add(EditedCuisineDescription);
            Controls.Add(EditedCuisineName);
            Controls.Add(NameLabel);
            Controls.Add(ApplyChanges);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(818, 495);
            Name = "CuisineEntityForm";
            Text = "CuisineEntityForm";
            Load += CuisineEntityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        /// <summary>
        /// Кнопка удаления
        /// </summary>
        private Button Delete;

        /// <summary>
        /// Кнопка закрытия формы
        /// </summary>
        private Button ExitCuisineEntityForm;

        /// <summary>
        /// Текст у поля ввода описания
        /// </summary>
        private Label DescriptionLabel;

        /// <summary>
        /// Поле ввода описания
        /// </summary>
        private RichTextBox EditedCuisineDescription;

        /// <summary>
        /// Поле ввода названия
        /// </summary>
        private TextBox EditedCuisineName;

        /// <summary>
        /// Текст у поля ввода названия
        /// </summary>
        private Label NameLabel;

        /// <summary>
        /// Кнопка сохранения
        /// </summary>
        private Button ApplyChanges;
    }
}