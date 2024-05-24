namespace OOP_Kurs_Simakin
{
    partial class AddMealForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMealForm));
            ExitAddMealForm = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 56);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Название:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 107);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Масса (г):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 157);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 4;
            label4.Text = "Кол-во ккал:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 209);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "Цена:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 260);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 6;
            label6.Text = "Вид кухни (ID):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(30, 311);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 7;
            label7.Text = "Категория блюда (ID):";
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
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Button ExitAddMealForm;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox NewMealName;
        private NumericUpDown NewMealWeight;
        private NumericUpDown NewMealKcal;
        private NumericUpDown NewMealPrice;
        private Button ApplyAddMealForm;
        private NumericUpDown CuisineId;
        private NumericUpDown CategoryId;
        private Button OpenCategoriesForm;
        private Button OpenCuisinesForm;
    }
}