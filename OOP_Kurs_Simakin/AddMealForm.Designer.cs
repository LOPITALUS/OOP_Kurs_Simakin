namespace OOP_Kurs_Simakin
{
    partial class AddMealForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMealForm));
            ExitAddMealForm = new Button();
            NameLabel = new Label();
            WeightLabel = new Label();
            KcalLabel = new Label();
            PriceLabel = new Label();
            CuisineIdLabel = new Label();
            CategoryIdLabel = new Label();
            NewMealName = new TextBox();
            NewMealWeight = new NumericUpDown();
            NewMealKcal = new NumericUpDown();
            NewMealPrice = new NumericUpDown();
            ApplyAddMealForm = new Button();
            CuisineId = new NumericUpDown();
            CategoryId = new NumericUpDown();
            OpenCategoriesForm = new Button();
            OpenCuisinesForm = new Button();
            ((System.ComponentModel.ISupportInitialize)NewMealWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMealKcal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMealPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CuisineId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategoryId).BeginInit();
            SuspendLayout();
            // 
            // ExitAddMealForm
            // 
            ExitAddMealForm.BackColor = SystemColors.Info;
            ExitAddMealForm.Location = new Point(592, 392);
            ExitAddMealForm.Margin = new Padding(3, 4, 3, 4);
            ExitAddMealForm.Name = "ExitAddMealForm";
            ExitAddMealForm.Size = new Size(111, 29);
            ExitAddMealForm.TabIndex = 1;
            ExitAddMealForm.Text = "Выход";
            ExitAddMealForm.UseVisualStyleBackColor = false;
            ExitAddMealForm.Click += button1_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(30, 56);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(81, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Название:";
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WeightLabel.Location = new Point(30, 107);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(77, 20);
            WeightLabel.TabIndex = 3;
            WeightLabel.Text = "Масса (г):";
            // 
            // KcalLabel
            // 
            KcalLabel.AutoSize = true;
            KcalLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            KcalLabel.Location = new Point(30, 157);
            KcalLabel.Name = "KcalLabel";
            KcalLabel.Size = new Size(98, 20);
            KcalLabel.TabIndex = 4;
            KcalLabel.Text = "Кол-во ккал:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.Location = new Point(30, 209);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(50, 20);
            PriceLabel.TabIndex = 5;
            PriceLabel.Text = "Цена:";
            // 
            // CuisineIdLabel
            // 
            CuisineIdLabel.AutoSize = true;
            CuisineIdLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CuisineIdLabel.Location = new Point(30, 260);
            CuisineIdLabel.Name = "CuisineIdLabel";
            CuisineIdLabel.Size = new Size(115, 20);
            CuisineIdLabel.TabIndex = 6;
            CuisineIdLabel.Text = "Вид кухни (ID):";
            // 
            // CategoryIdLabel
            // 
            CategoryIdLabel.AutoSize = true;
            CategoryIdLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryIdLabel.Location = new Point(30, 311);
            CategoryIdLabel.Name = "CategoryIdLabel";
            CategoryIdLabel.Size = new Size(165, 20);
            CategoryIdLabel.TabIndex = 7;
            CategoryIdLabel.Text = "Категория блюда (ID):";
            // 
            // NewMealName
            // 
            NewMealName.Location = new Point(206, 56);
            NewMealName.Margin = new Padding(3, 4, 3, 4);
            NewMealName.MaxLength = 100;
            NewMealName.Name = "NewMealName";
            NewMealName.Size = new Size(137, 27);
            NewMealName.TabIndex = 8;
            // 
            // NewMealWeight
            // 
            NewMealWeight.DecimalPlaces = 3;
            NewMealWeight.Location = new Point(206, 107);
            NewMealWeight.Margin = new Padding(3, 4, 3, 4);
            NewMealWeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NewMealWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMealWeight.Name = "NewMealWeight";
            NewMealWeight.Size = new Size(137, 27);
            NewMealWeight.TabIndex = 9;
            NewMealWeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NewMealKcal
            // 
            NewMealKcal.DecimalPlaces = 3;
            NewMealKcal.Location = new Point(206, 157);
            NewMealKcal.Margin = new Padding(3, 4, 3, 4);
            NewMealKcal.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NewMealKcal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMealKcal.Name = "NewMealKcal";
            NewMealKcal.Size = new Size(137, 27);
            NewMealKcal.TabIndex = 10;
            NewMealKcal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NewMealPrice
            // 
            NewMealPrice.DecimalPlaces = 3;
            NewMealPrice.Location = new Point(206, 209);
            NewMealPrice.Margin = new Padding(3, 4, 3, 4);
            NewMealPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NewMealPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMealPrice.Name = "NewMealPrice";
            NewMealPrice.Size = new Size(137, 27);
            NewMealPrice.TabIndex = 11;
            NewMealPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ApplyAddMealForm
            // 
            ApplyAddMealForm.BackColor = SystemColors.Info;
            ApplyAddMealForm.Location = new Point(133, 392);
            ApplyAddMealForm.Margin = new Padding(3, 4, 3, 4);
            ApplyAddMealForm.Name = "ApplyAddMealForm";
            ApplyAddMealForm.Size = new Size(111, 29);
            ApplyAddMealForm.TabIndex = 14;
            ApplyAddMealForm.Text = "Добавить";
            ApplyAddMealForm.UseVisualStyleBackColor = false;
            ApplyAddMealForm.Click += ApplyAddMealForm_Click;
            // 
            // CuisineId
            // 
            CuisineId.Location = new Point(206, 260);
            CuisineId.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            CuisineId.Name = "CuisineId";
            CuisineId.Size = new Size(137, 27);
            CuisineId.TabIndex = 16;
            // 
            // CategoryId
            // 
            CategoryId.Location = new Point(206, 311);
            CategoryId.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            CategoryId.Name = "CategoryId";
            CategoryId.Size = new Size(137, 27);
            CategoryId.TabIndex = 17;
            // 
            // OpenCategoriesForm
            // 
            OpenCategoriesForm.BackColor = SystemColors.Info;
            OpenCategoriesForm.Location = new Point(489, 224);
            OpenCategoriesForm.Name = "OpenCategoriesForm";
            OpenCategoriesForm.Size = new Size(208, 55);
            OpenCategoriesForm.TabIndex = 18;
            OpenCategoriesForm.Text = "Открыть \"Категории блюд\"";
            OpenCategoriesForm.UseVisualStyleBackColor = false;
            OpenCategoriesForm.Click += OpenCategoriesForm_Click;
            // 
            // OpenCuisinesForm
            // 
            OpenCuisinesForm.BackColor = SystemColors.Info;
            OpenCuisinesForm.Location = new Point(489, 123);
            OpenCuisinesForm.Name = "OpenCuisinesForm";
            OpenCuisinesForm.Size = new Size(208, 55);
            OpenCuisinesForm.TabIndex = 19;
            OpenCuisinesForm.Text = "Открыть \"Виды кухонь\"";
            OpenCuisinesForm.UseVisualStyleBackColor = false;
            OpenCuisinesForm.Click += OpenCuisinesForm_Click;
            // 
            // AddMealForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(819, 459);
            Controls.Add(OpenCuisinesForm);
            Controls.Add(OpenCategoriesForm);
            Controls.Add(CategoryId);
            Controls.Add(CuisineId);
            Controls.Add(ApplyAddMealForm);
            Controls.Add(NewMealPrice);
            Controls.Add(NewMealKcal);
            Controls.Add(NewMealWeight);
            Controls.Add(NewMealName);
            Controls.Add(CategoryIdLabel);
            Controls.Add(CuisineIdLabel);
            Controls.Add(PriceLabel);
            Controls.Add(KcalLabel);
            Controls.Add(WeightLabel);
            Controls.Add(NameLabel);
            Controls.Add(ExitAddMealForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(835, 495);
            Name = "AddMealForm";
            Text = "Добавление нового блюда";
            ((System.ComponentModel.ISupportInitialize)NewMealWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewMealKcal).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewMealPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)CuisineId).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategoryId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        /// <summary>
        /// Кнопка закрытия формы
        /// </summary>
        private Button ExitAddMealForm;

        /// <summary>
        /// Текст у поля ввода названия
        /// </summary>
        private Label NameLabel;

        /// <summary>
        /// Текст у поля ввода массы
        /// </summary>
        private Label WeightLabel;

        /// <summary>
        /// Текст у поля ввода ккал
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
        private TextBox NewMealName;

        /// <summary>
        /// Поле ввода массы
        /// </summary>
        private NumericUpDown NewMealWeight;

        /// <summary>
        /// Поле ввода кол-ва ккал
        /// </summary>
        private NumericUpDown NewMealKcal;

        /// <summary>
        /// Поле ввода цены
        /// </summary>
        private NumericUpDown NewMealPrice;

        /// <summary>
        /// Кнопка добавления
        /// </summary>
        private Button ApplyAddMealForm;

        /// <summary>
        /// Поле ввода id кухни
        /// </summary>
        private NumericUpDown CuisineId;

        /// <summary>
        /// Поле ввода id категории
        /// </summary>
        private NumericUpDown CategoryId;

        /// <summary>
        /// Кнопка открытия окна категорий
        /// </summary>
        private Button OpenCategoriesForm;

        /// <summary>
        /// Кнопка открытия окна кухонь
        /// </summary>
        private Button OpenCuisinesForm;
    }
}