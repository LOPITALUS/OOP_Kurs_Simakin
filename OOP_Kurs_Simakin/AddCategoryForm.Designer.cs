namespace OOP_Kurs_Simakin
{
    partial class AddCategoryForm
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
            NewCategoryName = new TextBox();
            ExitAddCategoryForm = new Button();
            ApplyAddCategoryForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(235, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите название новой категории блюд:";
            // 
            // NewCategoryName
            // 
            NewCategoryName.Location = new Point(265, 47);
            NewCategoryName.Name = "NewCategoryName";
            NewCategoryName.Size = new Size(112, 23);
            NewCategoryName.TabIndex = 1;
            // 
            // ExitAddCategoryForm
            // 
            ExitAddCategoryForm.Location = new Point(29, 246);
            ExitAddCategoryForm.Name = "ExitAddCategoryForm";
            ExitAddCategoryForm.Size = new Size(75, 23);
            ExitAddCategoryForm.TabIndex = 2;
            ExitAddCategoryForm.Text = "Выход";
            ExitAddCategoryForm.UseVisualStyleBackColor = true;
            // 
            // ApplyAddCategoryForm
            // 
            ApplyAddCategoryForm.Location = new Point(232, 237);
            ApplyAddCategoryForm.Name = "ApplyAddCategoryForm";
            ApplyAddCategoryForm.Size = new Size(75, 23);
            ApplyAddCategoryForm.TabIndex = 3;
            ApplyAddCategoryForm.Text = "Добавить";
            ApplyAddCategoryForm.UseVisualStyleBackColor = true;
            ApplyAddCategoryForm.Click += ApplyAddCategoryForm_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ApplyAddCategoryForm);
            Controls.Add(ExitAddCategoryForm);
            Controls.Add(NewCategoryName);
            Controls.Add(label1);
            Name = "AddCategoryForm";
            Text = "Добавление новой категории блюд в БД";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewCategoryName;
        private Button ExitAddCategoryForm;
        private Button ApplyAddCategoryForm;
    }
}