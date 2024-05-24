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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
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
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(248, 20);
            label1.TabIndex = 0;
            label1.Text = "Название новой категории блюд:";
            // 
            // NewCategoryName
            // 
            NewCategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCategoryName.Location = new Point(272, 13);
            NewCategoryName.Margin = new Padding(3, 4, 3, 4);
            NewCategoryName.MaxLength = 100;
            NewCategoryName.Name = "NewCategoryName";
            NewCategoryName.Size = new Size(463, 27);
            NewCategoryName.TabIndex = 1;
            // 
            // ExitAddCategoryForm
            // 
            ExitAddCategoryForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitAddCategoryForm.BackColor = SystemColors.Info;
            ExitAddCategoryForm.Location = new Point(657, 396);
            ExitAddCategoryForm.Margin = new Padding(3, 4, 3, 4);
            ExitAddCategoryForm.Name = "ExitAddCategoryForm";
            ExitAddCategoryForm.Size = new Size(94, 29);
            ExitAddCategoryForm.TabIndex = 2;
            ExitAddCategoryForm.Text = "Выход";
            ExitAddCategoryForm.UseVisualStyleBackColor = false;
            ExitAddCategoryForm.Click += ExitAddCategoryForm_Click;
            // 
            // ApplyAddCategoryForm
            // 
            ApplyAddCategoryForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyAddCategoryForm.BackColor = SystemColors.Info;
            ApplyAddCategoryForm.Location = new Point(49, 396);
            ApplyAddCategoryForm.Margin = new Padding(3, 4, 3, 4);
            ApplyAddCategoryForm.Name = "ApplyAddCategoryForm";
            ApplyAddCategoryForm.Size = new Size(111, 29);
            ApplyAddCategoryForm.TabIndex = 3;
            ApplyAddCategoryForm.Text = "Добавить";
            ApplyAddCategoryForm.UseVisualStyleBackColor = false;
            ApplyAddCategoryForm.Click += ApplyAddCategoryForm_Click;
            // 
            // NewCategoryDescription
            // 
            NewCategoryDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCategoryDescription.Location = new Point(271, 69);
            NewCategoryDescription.Margin = new Padding(3, 4, 3, 4);
            NewCategoryDescription.MaxLength = 1000;
            NewCategoryDescription.Name = "NewCategoryDescription";
            NewCategoryDescription.Size = new Size(463, 292);
            NewCategoryDescription.TabIndex = 5;
            NewCategoryDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "Описание:";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(802, 459);
            Controls.Add(label2);
            Controls.Add(NewCategoryDescription);
            Controls.Add(ApplyAddCategoryForm);
            Controls.Add(ExitAddCategoryForm);
            Controls.Add(NewCategoryName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(818, 495);
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