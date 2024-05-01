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
            Cuisines = new ComboBox();
            Categories = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)NewMealWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMealKcal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMealPrice).BeginInit();
            SuspendLayout();
            // 
            // ExitAddMealForm
            // 
            ExitAddMealForm.Location = new Point(80, 516);
            ExitAddMealForm.Margin = new Padding(3, 4, 3, 4);
            ExitAddMealForm.Name = "ExitAddMealForm";
            ExitAddMealForm.Size = new Size(105, 33);
            ExitAddMealForm.TabIndex = 1;
            ExitAddMealForm.Text = "Выход";
            ExitAddMealForm.UseVisualStyleBackColor = true;
            ExitAddMealForm.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 87);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Название:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 124);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Масса:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 176);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 4;
            label4.Text = "Кол-во ккал:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 217);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 5;
            label5.Text = "Цена:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 267);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 6;
            label6.Text = "Вид кухни:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 312);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 7;
            label7.Text = "Тип блюда:";
            // 
            // NewMealName
            // 
            NewMealName.Location = new Point(118, 83);
            NewMealName.Margin = new Padding(3, 4, 3, 4);
            NewMealName.Name = "NewMealName";
            NewMealName.Size = new Size(114, 27);
            NewMealName.TabIndex = 8;
            // 
            // NewMealWeight
            // 
            NewMealWeight.Location = new Point(95, 124);
            NewMealWeight.Margin = new Padding(3, 4, 3, 4);
            NewMealWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NewMealWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMealWeight.Name = "NewMealWeight";
            NewMealWeight.Size = new Size(137, 27);
            NewMealWeight.TabIndex = 9;
            NewMealWeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NewMealKcal
            // 
            NewMealKcal.Location = new Point(125, 173);
            NewMealKcal.Margin = new Padding(3, 4, 3, 4);
            NewMealKcal.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            NewMealKcal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMealKcal.Name = "NewMealKcal";
            NewMealKcal.Size = new Size(137, 27);
            NewMealKcal.TabIndex = 10;
            NewMealKcal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NewMealPrice
            // 
            NewMealPrice.Location = new Point(80, 215);
            NewMealPrice.Margin = new Padding(3, 4, 3, 4);
            NewMealPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            NewMealPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMealPrice.Name = "NewMealPrice";
            NewMealPrice.Size = new Size(137, 27);
            NewMealPrice.TabIndex = 11;
            NewMealPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ApplyAddMealForm
            // 
            ApplyAddMealForm.Location = new Point(366, 519);
            ApplyAddMealForm.Margin = new Padding(3, 4, 3, 4);
            ApplyAddMealForm.Name = "ApplyAddMealForm";
            ApplyAddMealForm.Size = new Size(86, 31);
            ApplyAddMealForm.TabIndex = 14;
            ApplyAddMealForm.Text = "Добавить";
            ApplyAddMealForm.UseVisualStyleBackColor = true;
            ApplyAddMealForm.Click += ApplyAddMealForm_Click;
            // 
            // Cuisines
            // 
            Cuisines.FormattingEnabled = true;
            Cuisines.Location = new Point(111, 263);
            Cuisines.Margin = new Padding(3, 4, 3, 4);
            Cuisines.Name = "Cuisines";
            Cuisines.Size = new Size(138, 28);
            Cuisines.TabIndex = 15;
            // 
            // Categories
            // 
            Categories.FormattingEnabled = true;
            Categories.Location = new Point(111, 308);
            Categories.Margin = new Padding(3, 4, 3, 4);
            Categories.Name = "Categories";
            Categories.Size = new Size(138, 28);
            Categories.TabIndex = 16;
            // 
            // AddMealForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Categories);
            Controls.Add(Cuisines);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddMealForm";
            Text = "Добавление нового блюда";
            Load += AddMealForm_Load;
            ((System.ComponentModel.ISupportInitialize)NewMealWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewMealKcal).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewMealPrice).EndInit();
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
        private ComboBox Cuisines;
        private ComboBox Categories;
    }
}