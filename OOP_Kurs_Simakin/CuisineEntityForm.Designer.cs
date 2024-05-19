namespace OOP_Kurs_Simakin
{
    partial class CuisineEntityForm
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
            Delete = new Button();
            ExitCuisineEntityForm = new Button();
            label2 = new Label();
            EditedCuisineDescription = new RichTextBox();
            EditedCuisineName = new TextBox();
            label1 = new Label();
            ApplyChanges = new Button();
            SuspendLayout();
            // 
            // Delete
            // 
            Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Delete.BackColor = SystemColors.Info;
            Delete.Location = new Point(317, 297);
            Delete.Margin = new Padding(3, 2, 3, 2);
            Delete.Name = "Delete";
            Delete.Size = new Size(82, 22);
            Delete.TabIndex = 23;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // ExitCuisineEntityForm
            // 
            ExitCuisineEntityForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitCuisineEntityForm.BackColor = SystemColors.Info;
            ExitCuisineEntityForm.Location = new Point(575, 297);
            ExitCuisineEntityForm.Margin = new Padding(3, 2, 3, 2);
            ExitCuisineEntityForm.Name = "ExitCuisineEntityForm";
            ExitCuisineEntityForm.Size = new Size(82, 22);
            ExitCuisineEntityForm.TabIndex = 22;
            ExitCuisineEntityForm.Text = "Выход";
            ExitCuisineEntityForm.UseVisualStyleBackColor = false;
            ExitCuisineEntityForm.Click += ExitCuisineEntityForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 52);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 21;
            label2.Text = "Описание:";
            // 
            // EditedCuisineDescription
            // 
            EditedCuisineDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditedCuisineDescription.Location = new Point(162, 52);
            EditedCuisineDescription.MaxLength = 1000;
            EditedCuisineDescription.Name = "EditedCuisineDescription";
            EditedCuisineDescription.Size = new Size(481, 220);
            EditedCuisineDescription.TabIndex = 20;
            EditedCuisineDescription.Text = "";
            // 
            // EditedCuisineName
            // 
            EditedCuisineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditedCuisineName.Location = new Point(162, 10);
            EditedCuisineName.MaxLength = 100;
            EditedCuisineName.Name = "EditedCuisineName";
            EditedCuisineName.Size = new Size(481, 23);
            EditedCuisineName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 18;
            label1.Text = "Название вида кухни:";
            // 
            // ApplyChanges
            // 
            ApplyChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyChanges.BackColor = SystemColors.Info;
            ApplyChanges.Location = new Point(43, 297);
            ApplyChanges.Margin = new Padding(3, 2, 3, 2);
            ApplyChanges.Name = "ApplyChanges";
            ApplyChanges.Size = new Size(97, 22);
            ApplyChanges.TabIndex = 17;
            ApplyChanges.Text = "Сохранить";
            ApplyChanges.UseVisualStyleBackColor = false;
            ApplyChanges.Click += ApplyChanges_Click;
            // 
            // CuisineEntityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(702, 344);
            Controls.Add(Delete);
            Controls.Add(ExitCuisineEntityForm);
            Controls.Add(label2);
            Controls.Add(EditedCuisineDescription);
            Controls.Add(EditedCuisineName);
            Controls.Add(label1);
            Controls.Add(ApplyChanges);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(718, 383);
            Name = "CuisineEntityForm";
            Text = "CuisineEntityForm";
            Load += CuisineEntityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Delete;
        private Button ExitCuisineEntityForm;
        private Label label2;
        private RichTextBox EditedCuisineDescription;
        private TextBox EditedCuisineName;
        private Label label1;
        private Button ApplyChanges;
    }
}