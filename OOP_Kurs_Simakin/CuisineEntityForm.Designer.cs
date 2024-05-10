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
            Delete.Location = new Point(304, 396);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 23;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // ExitCuisineEntityForm
            // 
            ExitCuisineEntityForm.Location = new Point(622, 396);
            ExitCuisineEntityForm.Name = "ExitCuisineEntityForm";
            ExitCuisineEntityForm.Size = new Size(94, 29);
            ExitCuisineEntityForm.TabIndex = 22;
            ExitCuisineEntityForm.Text = "Выход";
            ExitCuisineEntityForm.UseVisualStyleBackColor = true;
            ExitCuisineEntityForm.Click += ExitCuisineEntityForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 21;
            label2.Text = "Описание:";
            // 
            // EditedCuisineDescription
            // 
            EditedCuisineDescription.Location = new Point(292, 69);
            EditedCuisineDescription.Margin = new Padding(3, 4, 3, 4);
            EditedCuisineDescription.Name = "EditedCuisineDescription";
            EditedCuisineDescription.Size = new Size(246, 164);
            EditedCuisineDescription.TabIndex = 20;
            EditedCuisineDescription.Text = "";
            // 
            // EditedCuisineName
            // 
            EditedCuisineName.Location = new Point(292, 13);
            EditedCuisineName.Margin = new Padding(3, 4, 3, 4);
            EditedCuisineName.Name = "EditedCuisineName";
            EditedCuisineName.Size = new Size(246, 27);
            EditedCuisineName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 18;
            label1.Text = "Название вида кухни:";
            // 
            // ApplyChanges
            // 
            ApplyChanges.Location = new Point(49, 396);
            ApplyChanges.Name = "ApplyChanges";
            ApplyChanges.Size = new Size(111, 29);
            ApplyChanges.TabIndex = 17;
            ApplyChanges.Text = "Сохранить";
            ApplyChanges.UseVisualStyleBackColor = true;
            ApplyChanges.Click += ApplyChanges_Click;
            // 
            // CuisineEntityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Delete);
            Controls.Add(ExitCuisineEntityForm);
            Controls.Add(label2);
            Controls.Add(EditedCuisineDescription);
            Controls.Add(EditedCuisineName);
            Controls.Add(label1);
            Controls.Add(ApplyChanges);
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