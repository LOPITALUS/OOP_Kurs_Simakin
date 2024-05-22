namespace OOP_Kurs_Simakin
{
    partial class MealEntityForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 56);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 107);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Масса (г):";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 157);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Кол-во ккал:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 209);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Цена:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 260);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 4;
            label5.Text = "Вид кухни (ID):";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 311);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 5;
            label6.Text = "Категория блюда (ID):";
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
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox EditedMealName;
        private NumericUpDown EditedMealWeight;
        private NumericUpDown EditedMealKcal;
        private NumericUpDown EditedMealPrice;
        private Button ApplyChanges;
        private Button ExitMealEntityForm;
        private Button Delete;
        private Button OpenCuisinesForm;
        private Button OpenCategoriesForm;
        private NumericUpDown CuisineId;
        private NumericUpDown CategoryId;
    }
}