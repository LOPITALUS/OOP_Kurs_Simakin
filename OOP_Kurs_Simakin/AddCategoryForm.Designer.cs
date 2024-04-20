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
            NewCategoryDescription = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 0;
            label1.Text = "Название новой категории блюд:";
            // 
            // NewCategoryName
            // 
            NewCategoryName.Location = new Point(262, 26);
            NewCategoryName.Name = "NewCategoryName";
            NewCategoryName.Size = new Size(216, 23);
            NewCategoryName.TabIndex = 1;
            // 
            // ExitAddCategoryForm
            // 
            ExitAddCategoryForm.Location = new Point(713, 415);
            ExitAddCategoryForm.Name = "ExitAddCategoryForm";
            ExitAddCategoryForm.Size = new Size(75, 23);
            ExitAddCategoryForm.TabIndex = 2;
            ExitAddCategoryForm.Text = "Выход";
            ExitAddCategoryForm.UseVisualStyleBackColor = true;
            ExitAddCategoryForm.Click += ExitAddCategoryForm_Click;
            // 
            // ApplyAddCategoryForm
            // 
            ApplyAddCategoryForm.Location = new Point(12, 415);
            ApplyAddCategoryForm.Name = "ApplyAddCategoryForm";
            ApplyAddCategoryForm.Size = new Size(75, 23);
            ApplyAddCategoryForm.TabIndex = 3;
            ApplyAddCategoryForm.Text = "Добавить";
            ApplyAddCategoryForm.UseVisualStyleBackColor = true;
            ApplyAddCategoryForm.Click += ApplyAddCategoryForm_Click;
            // 
            // NewCategoryDescription
            // 
            NewCategoryDescription.Location = new Point(262, 68);
            NewCategoryDescription.Name = "NewCategoryDescription";
            NewCategoryDescription.Size = new Size(216, 124);
            NewCategoryDescription.TabIndex = 5;
            NewCategoryDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 6;
            label2.Text = "Описание:";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(NewCategoryDescription);
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
        private RichTextBox NewCategoryDescription;
        private Label label2;
    }
}