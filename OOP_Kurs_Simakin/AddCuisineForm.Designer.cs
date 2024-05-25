namespace OOP_Kurs_Simakin
{
    partial class AddCuisineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCuisineForm));
            NameLabel = new Label();
            NewCuisineName = new TextBox();
            ApplyAddCuisinelForm = new Button();
            ExitAddCuisineForm = new Button();
            NewCuisineDescription = new RichTextBox();
            DescriptionLabel = new Label();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(17, 17);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(219, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Название нового вида кухни:";
            // 
            // NewCuisineName
            // 
            NewCuisineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCuisineName.Location = new Point(248, 13);
            NewCuisineName.Margin = new Padding(3, 4, 3, 4);
            NewCuisineName.MaxLength = 100;
            NewCuisineName.Name = "NewCuisineName";
            NewCuisineName.Size = new Size(486, 27);
            NewCuisineName.TabIndex = 1;
            // 
            // ApplyAddCuisinelForm
            // 
            ApplyAddCuisinelForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyAddCuisinelForm.BackColor = SystemColors.Info;
            ApplyAddCuisinelForm.Location = new Point(49, 396);
            ApplyAddCuisinelForm.Margin = new Padding(3, 4, 3, 4);
            ApplyAddCuisinelForm.Name = "ApplyAddCuisinelForm";
            ApplyAddCuisinelForm.Size = new Size(111, 29);
            ApplyAddCuisinelForm.TabIndex = 2;
            ApplyAddCuisinelForm.Text = "Добавить";
            ApplyAddCuisinelForm.UseVisualStyleBackColor = false;
            ApplyAddCuisinelForm.Click += ApplyAddCuisinelForm_Click;
            // 
            // ExitAddCuisineForm
            // 
            ExitAddCuisineForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitAddCuisineForm.BackColor = SystemColors.Info;
            ExitAddCuisineForm.Location = new Point(657, 396);
            ExitAddCuisineForm.Margin = new Padding(3, 4, 3, 4);
            ExitAddCuisineForm.Name = "ExitAddCuisineForm";
            ExitAddCuisineForm.Size = new Size(94, 29);
            ExitAddCuisineForm.TabIndex = 3;
            ExitAddCuisineForm.Text = "Выход";
            ExitAddCuisineForm.UseVisualStyleBackColor = false;
            ExitAddCuisineForm.Click += ExitAddCuisineForm_Click;
            // 
            // NewCuisineDescription
            // 
            NewCuisineDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCuisineDescription.Location = new Point(248, 69);
            NewCuisineDescription.Margin = new Padding(3, 4, 3, 4);
            NewCuisineDescription.MaxLength = 1000;
            NewCuisineDescription.Name = "NewCuisineDescription";
            NewCuisineDescription.Size = new Size(486, 292);
            NewCuisineDescription.TabIndex = 4;
            NewCuisineDescription.Text = "";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(17, 69);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(83, 20);
            DescriptionLabel.TabIndex = 5;
            DescriptionLabel.Text = "Описание:";
            // 
            // AddCuisineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(802, 459);
            Controls.Add(DescriptionLabel);
            Controls.Add(NewCuisineDescription);
            Controls.Add(ExitAddCuisineForm);
            Controls.Add(ApplyAddCuisinelForm);
            Controls.Add(NewCuisineName);
            Controls.Add(NameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(818, 495);
            Name = "AddCuisineForm";
            Text = "Добавление нового вида кухни в БД";
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
        private TextBox NewCuisineName;

        /// <summary>
        /// Кнопка добавления
        /// </summary>
        private Button ApplyAddCuisinelForm;

        /// <summary>
        /// Кнопка закрытия окна
        /// </summary>
        private Button ExitAddCuisineForm;

        /// <summary>
        /// Поле ввода описания
        /// </summary>
        private RichTextBox NewCuisineDescription;
        
        /// <summary>
        /// Текст у поля ввода описания
        /// </summary>
        private Label DescriptionLabel;
    }
}