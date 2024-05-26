namespace OOP_Kurs_Simakin
{
    partial class MealEntityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealEntityForm));
            NameLabel = new Label();
            WeightLabel = new Label();
            KcalLabel = new Label();
            PriceLabel = new Label();
            CuisineIdLabel = new Label();
            CategoryIdLabel = new Label();
            EditedMealName = new TextBox();
            EditedMealWeight = new NumericUpDown();
            EditedMealKcal = new NumericUpDown();
            EditedMealPrice = new NumericUpDown();
            ApplyChanges = new Button();
            ExitMealEntityForm = new Button();
            Delete = new Button();
            OpenCuisinesForm = new Button();
            OpenCategoriesForm = new Button();
            CuisineId = new NumericUpDown();
            CategoryId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)EditedMealWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditedMealKcal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditedMealPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CuisineId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategoryId).BeginInit();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(30, 56);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(81, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Название:";
            // 
            // WeightLabel
            // 
            WeightLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WeightLabel.AutoSize = true;
            WeightLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WeightLabel.Location = new Point(30, 107);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(77, 20);
            WeightLabel.TabIndex = 1;
            WeightLabel.Text = "Масса (г):";
            // 
            // KcalLabel
            // 
            KcalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KcalLabel.AutoSize = true;
            KcalLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            KcalLabel.Location = new Point(30, 157);
            KcalLabel.Name = "KcalLabel";
            KcalLabel.Size = new Size(98, 20);
            KcalLabel.TabIndex = 2;
            KcalLabel.Text = "Кол-во ккал:";
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.Location = new Point(30, 209);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(50, 20);
            PriceLabel.TabIndex = 3;
            PriceLabel.Text = "Цена:";
            PriceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CuisineIdLabel
            // 
            CuisineIdLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CuisineIdLabel.AutoSize = true;
            CuisineIdLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CuisineIdLabel.Location = new Point(30, 260);
            CuisineIdLabel.Name = "CuisineIdLabel";
            CuisineIdLabel.Size = new Size(115, 20);
            CuisineIdLabel.TabIndex = 4;
            CuisineIdLabel.Text = "Вид кухни (ID):";
            // 
            // CategoryIdLabel
            // 
            CategoryIdLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryIdLabel.AutoSize = true;
            CategoryIdLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryIdLabel.Location = new Point(30, 311);
            CategoryIdLabel.Name = "CategoryIdLabel";
            CategoryIdLabel.Size = new Size(165, 20);
            CategoryIdLabel.TabIndex = 5;
            CategoryIdLabel.Text = "Категория блюда (ID):";
            // 
            // EditedMealName
            // 
            EditedMealName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditedMealName.Location = new Point(206, 56);
            EditedMealName.MaxLength = 100;
            EditedMealName.Name = "EditedMealName";
            EditedMealName.Size = new Size(137, 27);
            EditedMealName.TabIndex = 6;
            // 
            // EditedMealWeight
            // 
            EditedMealWeight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditedMealWeight.DecimalPlaces = 3;
            EditedMealWeight.Location = new Point(206, 107);
            EditedMealWeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            EditedMealWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EditedMealWeight.Name = "EditedMealWeight";
            EditedMealWeight.Size = new Size(136, 27);
            EditedMealWeight.TabIndex = 7;
            EditedMealWeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditedMealKcal
            // 
            EditedMealKcal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditedMealKcal.DecimalPlaces = 3;
            EditedMealKcal.Location = new Point(206, 157);
            EditedMealKcal.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            EditedMealKcal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EditedMealKcal.Name = "EditedMealKcal";
            EditedMealKcal.Size = new Size(136, 27);
            EditedMealKcal.TabIndex = 8;
            EditedMealKcal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditedMealPrice
            // 
            EditedMealPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditedMealPrice.DecimalPlaces = 3;
            EditedMealPrice.Location = new Point(206, 209);
            EditedMealPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            EditedMealPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EditedMealPrice.Name = "EditedMealPrice";
            EditedMealPrice.Size = new Size(136, 27);
            EditedMealPrice.TabIndex = 9;
            EditedMealPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ApplyChanges
            // 
            ApplyChanges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ApplyChanges.BackColor = SystemColors.Info;
            ApplyChanges.Location = new Point(133, 392);
            ApplyChanges.Name = "ApplyChanges";
            ApplyChanges.Size = new Size(111, 29);
            ApplyChanges.TabIndex = 12;
            ApplyChanges.Text = "Сохранить изменения";
            ApplyChanges.UseVisualStyleBackColor = false;
            ApplyChanges.Click += ApplyChanges_Click;
            // 
            // ExitMealEntityForm
            // 
            ExitMealEntityForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExitMealEntityForm.BackColor = SystemColors.Info;
            ExitMealEntityForm.Location = new Point(592, 392);
            ExitMealEntityForm.Name = "ExitMealEntityForm";
            ExitMealEntityForm.Size = new Size(111, 29);
            ExitMealEntityForm.TabIndex = 13;
            ExitMealEntityForm.Text = "Выход";
            ExitMealEntityForm.UseVisualStyleBackColor = false;
            ExitMealEntityForm.Click += ExitMealEntityForm_Click;
            // 
            // Delete
            // 
            Delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Delete.BackColor = SystemColors.Info;
            Delete.Location = new Point(362, 392);
            Delete.Name = "Delete";
            Delete.Size = new Size(111, 29);
            Delete.TabIndex = 14;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // OpenCuisinesForm
            // 
            OpenCuisinesForm.BackColor = SystemColors.Info;
            OpenCuisinesForm.Location = new Point(489, 123);
            OpenCuisinesForm.Name = "OpenCuisinesForm";
            OpenCuisinesForm.Size = new Size(208, 55);
            OpenCuisinesForm.TabIndex = 20;
            OpenCuisinesForm.Text = "Открыть \"Виды кухонь\"";
            OpenCuisinesForm.UseVisualStyleBackColor = false;
            OpenCuisinesForm.Click += OpenCuisinesForm_Click;
            // 
            // OpenCategoriesForm
            // 
            OpenCategoriesForm.BackColor = SystemColors.Info;
            OpenCategoriesForm.Location = new Point(489, 224);
            OpenCategoriesForm.Name = "OpenCategoriesForm";
            OpenCategoriesForm.Size = new Size(208, 55);
            OpenCategoriesForm.TabIndex = 21;
            OpenCategoriesForm.Text = "Открыть \"Категории блюд\"";
            OpenCategoriesForm.UseVisualStyleBackColor = false;
            OpenCategoriesForm.Click += OpenCategoriesForm_Click;
            // 
            // CuisineId
            // 
            CuisineId.Location = new Point(206, 260);
            CuisineId.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            CuisineId.Name = "CuisineId";
            CuisineId.Size = new Size(137, 27);
            CuisineId.TabIndex = 22;
            // 
            // CategoryId
            // 
            CategoryId.Location = new Point(206, 311);
            CategoryId.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            CategoryId.Name = "CategoryId";
            CategoryId.Size = new Size(137, 27);
            CategoryId.TabIndex = 23;
            // 
            // MealEntityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(817, 451);
            Controls.Add(CategoryId);
            Controls.Add(CuisineId);
            Controls.Add(OpenCategoriesForm);
            Controls.Add(OpenCuisinesForm);
            Controls.Add(Delete);
            Controls.Add(ExitMealEntityForm);
            Controls.Add(ApplyChanges);
            Controls.Add(EditedMealPrice);
            Controls.Add(EditedMealKcal);
            Controls.Add(EditedMealWeight);
            Controls.Add(EditedMealName);
            Controls.Add(CategoryIdLabel);
            Controls.Add(CuisineIdLabel);
            Controls.Add(PriceLabel);
            Controls.Add(KcalLabel);
            Controls.Add(WeightLabel);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MealEntityForm";
            Text = "MealEntityForm";
            Load += MealEntityForm_Load;
            ((System.ComponentModel.ISupportInitialize)EditedMealWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditedMealKcal).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditedMealPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)CuisineId).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategoryId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        /// <summary>
        /// Текст у поля ввода названия
        /// </summary>
        private Label NameLabel;

        /// <summary>
        /// Текст у поля ввода массы
        /// </summary>
        private Label WeightLabel;

        /// <summary>
        /// Текст у поля ввода кол-ва ккал
        /// </summary>
        private Label KcalLabel;

        /// <summary>
        /// Текст у поля ввода цены
        /// </summary>
        private Label PriceLabel;

        /// <summary>
        /// Текст у поля ввода id кухни
        /// </summary>
        private Label CuisineIdLabel;

        /// <summary>
        /// Текст у поля ввода id категории
        /// </summary>
        private Label CategoryIdLabel;

        /// <summary>
        /// Поле ввода названия
        /// </summary>
        private TextBox EditedMealName;

        /// <summary>
        /// Поле ввода массы
        /// </summary>
        private NumericUpDown EditedMealWeight;

        /// <summary>
        /// Поле ввода кол-ва ккал
        /// </summary>
        private NumericUpDown EditedMealKcal;

        /// <summary>
        /// Поле ввода цены
        /// </summary>
        private NumericUpDown EditedMealPrice;

        /// <summary>
        /// Кнопка сохранения изменений
        /// </summary>
        private Button ApplyChanges;

        /// <summary>
        /// Кнопка закрытия формы
        /// </summary>
        private Button ExitMealEntityForm;

        /// <summary>
        /// Кнопка удаления
        /// </summary>
        private Button Delete;

        /// <summary>
        /// Кнопка открытия окна "Виды кухонь"
        /// </summary>
        private Button OpenCuisinesForm;

        /// <summary>
        /// Кнопка открытия окна "Категории блюд" 
        /// </summary>
        private Button OpenCategoriesForm;

        /// <summary>
        /// Окно ввода id кухни
        /// </summary>
        private NumericUpDown CuisineId;

        /// <summary>
        /// Окно ввода id категории
        /// </summary>
        private NumericUpDown CategoryId;
    }
}