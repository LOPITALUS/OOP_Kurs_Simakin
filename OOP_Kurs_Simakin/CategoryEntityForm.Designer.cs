namespace OOP_Kurs_Simakin
{
    partial class CategoryEntityForm
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
            ApplyChanges = new Button();
            label2 = new Label();
            EditedCategoryDescription = new RichTextBox();
            EditedCategoryName = new TextBox();
            label1 = new Label();
            Delete = new Button();
            ExitCategoryEntityForm = new Button();
            SuspendLayout();
            // 
            // ApplyChanges
            // 
            ApplyChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyChanges.BackColor = SystemColors.Info;
            ApplyChanges.Location = new Point(49, 396);
            ApplyChanges.Name = "ApplyChanges";
            ApplyChanges.Size = new Size(111, 29);
            ApplyChanges.TabIndex = 0;
            ApplyChanges.Text = "Сохранить";
            ApplyChanges.UseVisualStyleBackColor = false;
            ApplyChanges.Click += ApplyChanges_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 10;
            label2.Text = "Описание:";
            // 
            // EditedCategoryDescription
            // 
            EditedCategoryDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditedCategoryDescription.Location = new Point(231, 69);
            EditedCategoryDescription.Margin = new Padding(3, 4, 3, 4);
            EditedCategoryDescription.Name = "EditedCategoryDescription";
            EditedCategoryDescription.Size = new Size(503, 292);
            EditedCategoryDescription.TabIndex = 9;
            EditedCategoryDescription.Text = "";
            // 
            // EditedCategoryName
            // 
            EditedCategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditedCategoryName.Location = new Point(231, 13);
            EditedCategoryName.Margin = new Padding(3, 4, 3, 4);
            EditedCategoryName.Name = "EditedCategoryName";
            EditedCategoryName.Size = new Size(503, 27);
            EditedCategoryName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 7;
            label1.Text = "Название категории блюд:";
            // 
            // Delete
            // 
            Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Delete.BackColor = SystemColors.Info;
            Delete.Location = new Point(362, 396);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 16;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // ExitCategoryEntityForm
            // 
            ExitCategoryEntityForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitCategoryEntityForm.BackColor = SystemColors.Info;
            ExitCategoryEntityForm.Location = new Point(657, 396);
            ExitCategoryEntityForm.Name = "ExitCategoryEntityForm";
            ExitCategoryEntityForm.Size = new Size(94, 29);
            ExitCategoryEntityForm.TabIndex = 15;
            ExitCategoryEntityForm.Text = "Выход";
            ExitCategoryEntityForm.UseVisualStyleBackColor = false;
            ExitCategoryEntityForm.Click += ExitCategoryEntityForm_Click;
            // 
            // CategoryEntityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Delete);
            Controls.Add(ExitCategoryEntityForm);
            Controls.Add(label2);
            Controls.Add(EditedCategoryDescription);
            Controls.Add(EditedCategoryName);
            Controls.Add(label1);
            Controls.Add(ApplyChanges);
            MinimumSize = new Size(818, 497);
            Name = "CategoryEntityForm";
            Text = "CategoryEntityForm";
            Load += CategoryEntityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ApplyChanges;
        private Label label2;
        private RichTextBox EditedCategoryDescription;
        private TextBox EditedCategoryName;
        private Label label1;
        private Button Delete;
        private Button ExitCategoryEntityForm;
    }
}