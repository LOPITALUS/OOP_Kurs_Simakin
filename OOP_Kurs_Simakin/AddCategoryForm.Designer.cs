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
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(195, 15);
            label1.TabIndex = 0;
            label1.Text = "Название новой категории блюд:";
            // 
            // NewCategoryName
            // 
            NewCategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCategoryName.Location = new Point(238, 10);
            NewCategoryName.MaxLength = 100;
            NewCategoryName.Name = "NewCategoryName";
            NewCategoryName.Size = new Size(406, 23);
            NewCategoryName.TabIndex = 1;
            // 
            // ExitAddCategoryForm
            // 
            ExitAddCategoryForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitAddCategoryForm.BackColor = SystemColors.Info;
            ExitAddCategoryForm.Location = new Point(575, 297);
            ExitAddCategoryForm.Name = "ExitAddCategoryForm";
            ExitAddCategoryForm.Size = new Size(82, 22);
            ExitAddCategoryForm.TabIndex = 2;
            ExitAddCategoryForm.Text = "Выход";
            ExitAddCategoryForm.UseVisualStyleBackColor = false;
            ExitAddCategoryForm.Click += ExitAddCategoryForm_Click;
            // 
            // ApplyAddCategoryForm
            // 
            ApplyAddCategoryForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyAddCategoryForm.BackColor = SystemColors.Info;
            ApplyAddCategoryForm.Location = new Point(43, 297);
            ApplyAddCategoryForm.Name = "ApplyAddCategoryForm";
            ApplyAddCategoryForm.Size = new Size(97, 22);
            ApplyAddCategoryForm.TabIndex = 3;
            ApplyAddCategoryForm.Text = "Добавить";
            ApplyAddCategoryForm.UseVisualStyleBackColor = false;
            ApplyAddCategoryForm.Click += ApplyAddCategoryForm_Click;
            // 
            // NewCategoryDescription
            // 
            NewCategoryDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCategoryDescription.Location = new Point(237, 52);
            NewCategoryDescription.MaxLength = 1000;
            NewCategoryDescription.Name = "NewCategoryDescription";
            NewCategoryDescription.Size = new Size(406, 220);
            NewCategoryDescription.TabIndex = 5;
            NewCategoryDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 52);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 6;
            label2.Text = "Описание:";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(702, 344);
            Controls.Add(label2);
            Controls.Add(NewCategoryDescription);
            Controls.Add(ApplyAddCategoryForm);
            Controls.Add(ExitAddCategoryForm);
            Controls.Add(NewCategoryName);
            Controls.Add(label1);
            MinimumSize = new Size(718, 383);
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