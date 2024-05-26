namespace OOP_Kurs_Simakin
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Обязательная переменная дизайнера
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Очищает ресурсы
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
        ///  Методы формы
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            ExitButton = new Button();
            ProgramNameLabel = new Label();
            AuthorLabel = new Label();
            SubjectLabel = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.Info;
            ExitButton.Location = new Point(139, 248);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(86, 31);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Ок!";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ProgramNameLabel
            // 
            ProgramNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProgramNameLabel.Location = new Point(75, 60);
            ProgramNameLabel.Name = "ProgramNameLabel";
            ProgramNameLabel.Size = new Size(207, 27);
            ProgramNameLabel.TabIndex = 1;
            ProgramNameLabel.Text = "Приложение БД \"Меню\"";
            ProgramNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthorLabel
            // 
            AuthorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AuthorLabel.Location = new Point(23, 163);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(319, 20);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Разработал: Симакин Константин 22ВП1";
            AuthorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubjectLabel
            // 
            SubjectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SubjectLabel.Location = new Point(24, 112);
            SubjectLabel.Name = "SubjectLabel";
            SubjectLabel.Size = new Size(319, 20);
            SubjectLabel.TabIndex = 3;
            SubjectLabel.Text = "Предметная область: ресторан";
            SubjectLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(366, 325);
            Controls.Add(SubjectLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(ProgramNameLabel);
            Controls.Add(ExitButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
        }

        #endregion
        /// <summary>
        /// Кнопка закрытия окна
        /// </summary>
        private Button ExitButton;

        /// <summary>
        /// Текст с названием программы
        /// </summary>
        private Label ProgramNameLabel;

        /// <summary>
        /// Текст с автором программы
        /// </summary>
        private Label AuthorLabel;

        /// <summary>
        /// Текст с названием предметной области
        /// </summary>
        private Label SubjectLabel;
    }
}