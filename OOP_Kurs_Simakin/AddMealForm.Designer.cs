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
            NewMealCuisine = new TextBox();
            NewMealCategory = new TextBox();
            ApplyAddMealForm = new Button();
            ((System.ComponentModel.ISupportInitialize)NewMealWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMealKcal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMealPrice).BeginInit();
            SuspendLayout();
            // 
            // ExitAddMealForm
            // 
            ExitAddMealForm.Location = new Point(70, 387);
            ExitAddMealForm.Name = "ExitAddMealForm";
            ExitAddMealForm.Size = new Size(92, 25);
            ExitAddMealForm.TabIndex = 1;
            ExitAddMealForm.Text = "Выход";
            ExitAddMealForm.UseVisualStyleBackColor = true;
            ExitAddMealForm.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Название:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 93);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Масса:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 132);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 4;
            label4.Text = "Кол-во ккал:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 163);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "Цена:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 200);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 6;
            label6.Text = "Вид кухни:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 234);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 7;
            label7.Text = "Тип блюда:";
            // 
            // NewMealName
            // 
            NewMealName.Location = new Point(103, 62);
            NewMealName.Name = "NewMealName";
            NewMealName.Size = new Size(100, 23);
            NewMealName.TabIndex = 8;
            // 
            // NewMealWeight
            // 
            NewMealWeight.Location = new Point(83, 93);
            NewMealWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NewMealWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMealWeight.Name = "NewMealWeight";
            NewMealWeight.Size = new Size(120, 23);
            NewMealWeight.TabIndex = 9;
            NewMealWeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NewMealKcal
            // 
            NewMealKcal.Location = new Point(109, 130);
            NewMealKcal.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            NewMealKcal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMealKcal.Name = "NewMealKcal";
            NewMealKcal.Size = new Size(120, 23);
            NewMealKcal.TabIndex = 10;
            NewMealKcal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NewMealPrice
            // 
            NewMealPrice.Location = new Point(70, 161);
            NewMealPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            NewMealPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMealPrice.Name = "NewMealPrice";
            NewMealPrice.Size = new Size(120, 23);
            NewMealPrice.TabIndex = 11;
            NewMealPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NewMealCuisine
            // 
            NewMealCuisine.Location = new Point(97, 200);
            NewMealCuisine.Name = "NewMealCuisine";
            NewMealCuisine.Size = new Size(100, 23);
            NewMealCuisine.TabIndex = 12;
            // 
            // NewMealCategory
            // 
            NewMealCategory.Location = new Point(101, 234);
            NewMealCategory.Name = "NewMealCategory";
            NewMealCategory.Size = new Size(100, 23);
            NewMealCategory.TabIndex = 13;
            // 
            // ApplyAddMealForm
            // 
            ApplyAddMealForm.Location = new Point(320, 389);
            ApplyAddMealForm.Name = "ApplyAddMealForm";
            ApplyAddMealForm.Size = new Size(75, 23);
            ApplyAddMealForm.TabIndex = 14;
            ApplyAddMealForm.Text = "Добавить";
            ApplyAddMealForm.UseVisualStyleBackColor = true;
            ApplyAddMealForm.Click += button2_Click;
            // 
            // AddMealForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ApplyAddMealForm);
            Controls.Add(NewMealCategory);
            Controls.Add(NewMealCuisine);
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
            Name = "AddMealForm";
            Text = "Добавление нового блюда";
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
        private TextBox NewMealCuisine;
        private TextBox NewMealCategory;
        private Button ApplyAddMealForm;
    }
}