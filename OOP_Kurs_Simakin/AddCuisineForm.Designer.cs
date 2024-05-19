namespace OOP_Kurs_Simakin
{
    partial class AddCuisineForm
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
            NewCuisineName = new TextBox();
            ApplyAddCuisinelForm = new Button();
            ExitAddCuisineForm = new Button();
            NewCuisineDescription = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 0;
            label1.Text = "Название нового вида кухни:";
            // 
            // NewCuisineName
            // 
            NewCuisineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCuisineName.Location = new Point(217, 10);
            NewCuisineName.MaxLength = 100;
            NewCuisineName.Name = "NewCuisineName";
            NewCuisineName.Size = new Size(426, 23);
            NewCuisineName.TabIndex = 1;
            // 
            // ApplyAddCuisinelForm
            // 
            ApplyAddCuisinelForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyAddCuisinelForm.BackColor = SystemColors.Info;
            ApplyAddCuisinelForm.Location = new Point(43, 297);
            ApplyAddCuisinelForm.Name = "ApplyAddCuisinelForm";
            ApplyAddCuisinelForm.Size = new Size(97, 22);
            ApplyAddCuisinelForm.TabIndex = 2;
            ApplyAddCuisinelForm.Text = "Добавить";
            ApplyAddCuisinelForm.UseVisualStyleBackColor = false;
            ApplyAddCuisinelForm.Click += ApplyAddCuisinelForm_Click;
            // 
            // ExitAddCuisineForm
            // 
            ExitAddCuisineForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitAddCuisineForm.BackColor = SystemColors.Info;
            ExitAddCuisineForm.Location = new Point(575, 297);
            ExitAddCuisineForm.Name = "ExitAddCuisineForm";
            ExitAddCuisineForm.Size = new Size(82, 22);
            ExitAddCuisineForm.TabIndex = 3;
            ExitAddCuisineForm.Text = "Выход";
            ExitAddCuisineForm.UseVisualStyleBackColor = false;
            ExitAddCuisineForm.Click += ExitAddCuisineForm_Click;
            // 
            // NewCuisineDescription
            // 
            NewCuisineDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCuisineDescription.Location = new Point(217, 52);
            NewCuisineDescription.MaxLength = 1000;
            NewCuisineDescription.Name = "NewCuisineDescription";
            NewCuisineDescription.Size = new Size(426, 220);
            NewCuisineDescription.TabIndex = 4;
            NewCuisineDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 52);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "Описание:";
            // 
            // AddCuisineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(702, 344);
            Controls.Add(label2);
            Controls.Add(NewCuisineDescription);
            Controls.Add(ExitAddCuisineForm);
            Controls.Add(ApplyAddCuisinelForm);
            Controls.Add(NewCuisineName);
            Controls.Add(label1);
            MinimumSize = new Size(718, 383);
            Name = "AddCuisineForm";
            Text = "Добавление нового вида кухни в БД";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewCuisineName;
        private Button ApplyAddCuisinelForm;
        private Button ExitAddCuisineForm;
        private RichTextBox NewCuisineDescription;
        private Label label2;
    }
}