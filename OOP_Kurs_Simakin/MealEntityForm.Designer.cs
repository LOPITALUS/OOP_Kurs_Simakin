﻿namespace OOP_Kurs_Simakin
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
            EditedMealCuisines = new ComboBox();
            EditedMealCategories = new ComboBox();
            ApplyChanges = new Button();
            ExitMealEntityForm = new Button();
            ((System.ComponentModel.ISupportInitialize)EditedMealWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditedMealKcal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditedMealPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 62);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 115);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Масса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 170);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Кол-во ккал";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 226);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Цена";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 275);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Вид кухни";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 316);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 5;
            label6.Text = "Тип блюда";
            // 
            // EditedMealName
            // 
            EditedMealName.Location = new Point(152, 61);
            EditedMealName.Name = "EditedMealName";
            EditedMealName.Size = new Size(125, 27);
            EditedMealName.TabIndex = 6;
            // 
            // EditedMealWeight
            // 
            EditedMealWeight.Location = new Point(143, 113);
            EditedMealWeight.Name = "EditedMealWeight";
            EditedMealWeight.Size = new Size(150, 27);
            EditedMealWeight.TabIndex = 7;
            // 
            // EditedMealKcal
            // 
            EditedMealKcal.Location = new Point(151, 174);
            EditedMealKcal.Name = "EditedMealKcal";
            EditedMealKcal.Size = new Size(150, 27);
            EditedMealKcal.TabIndex = 8;
            // 
            // EditedMealPrice
            // 
            EditedMealPrice.Location = new Point(138, 229);
            EditedMealPrice.Name = "EditedMealPrice";
            EditedMealPrice.Size = new Size(150, 27);
            EditedMealPrice.TabIndex = 9;
            // 
            // EditedMealCuisines
            // 
            EditedMealCuisines.FormattingEnabled = true;
            EditedMealCuisines.Location = new Point(137, 275);
            EditedMealCuisines.Name = "EditedMealCuisines";
            EditedMealCuisines.Size = new Size(151, 28);
            EditedMealCuisines.TabIndex = 10;
            // 
            // EditedMealCategories
            // 
            EditedMealCategories.FormattingEnabled = true;
            EditedMealCategories.Location = new Point(136, 316);
            EditedMealCategories.Name = "EditedMealCategories";
            EditedMealCategories.Size = new Size(151, 28);
            EditedMealCategories.TabIndex = 11;
            // 
            // ApplyChanges
            // 
            ApplyChanges.Location = new Point(84, 392);
            ApplyChanges.Name = "ApplyChanges";
            ApplyChanges.Size = new Size(94, 29);
            ApplyChanges.TabIndex = 12;
            ApplyChanges.Text = "Сохранить изменения";
            ApplyChanges.UseVisualStyleBackColor = true;
            // 
            // ExitMealEntityForm
            // 
            ExitMealEntityForm.Location = new Point(521, 392);
            ExitMealEntityForm.Name = "ExitMealEntityForm";
            ExitMealEntityForm.Size = new Size(94, 29);
            ExitMealEntityForm.TabIndex = 13;
            ExitMealEntityForm.Text = "Выход";
            ExitMealEntityForm.UseVisualStyleBackColor = true;
            // 
            // MealEntityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitMealEntityForm);
            Controls.Add(ApplyChanges);
            Controls.Add(EditedMealCategories);
            Controls.Add(EditedMealCuisines);
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
            Name = "MealEntityForm";
            Text = "MealEntityForm";
            ((System.ComponentModel.ISupportInitialize)EditedMealWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditedMealKcal).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditedMealPrice).EndInit();
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
        private ComboBox EditedMealCuisines;
        private ComboBox EditedMealCategories;
        private Button ApplyChanges;
        private Button ExitMealEntityForm;
    }
}