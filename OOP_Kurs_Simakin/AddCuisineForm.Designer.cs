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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCuisineForm));
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
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 0;
            label1.Text = "Название нового вида кухни:";
            // 
            // NewCuisineName
            // 
            NewCuisineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCuisineName.Location = new Point(248, 13);
            NewCuisineName.Margin = new Padding(3, 4, 3, 4);
            NewCuisineName.MaxLength = 100;
            NewCuisineName.Name = "NewCuisineName";
            NewCuisineName.Size = new Size(486, 27);
            NewCuisineName.TabIndex = 1;
            // 
            // ApplyAddCuisinelForm
            // 
            ApplyAddCuisinelForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyAddCuisinelForm.BackColor = SystemColors.Info;
            ApplyAddCuisinelForm.Location = new Point(49, 396);
            ApplyAddCuisinelForm.Margin = new Padding(3, 4, 3, 4);
            ApplyAddCuisinelForm.Name = "ApplyAddCuisinelForm";
            ApplyAddCuisinelForm.Size = new Size(111, 29);
            ApplyAddCuisinelForm.TabIndex = 2;
            ApplyAddCuisinelForm.Text = "Добавить";
            ApplyAddCuisinelForm.UseVisualStyleBackColor = false;
            ApplyAddCuisinelForm.Click += ApplyAddCuisinelForm_Click;
            // 
            // ExitAddCuisineForm
            // 
            ExitAddCuisineForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitAddCuisineForm.BackColor = SystemColors.Info;
            ExitAddCuisineForm.Location = new Point(657, 396);
            ExitAddCuisineForm.Margin = new Padding(3, 4, 3, 4);
            ExitAddCuisineForm.Name = "ExitAddCuisineForm";
            ExitAddCuisineForm.Size = new Size(94, 29);
            ExitAddCuisineForm.TabIndex = 3;
            ExitAddCuisineForm.Text = "Выход";
            ExitAddCuisineForm.UseVisualStyleBackColor = false;
            ExitAddCuisineForm.Click += ExitAddCuisineForm_Click;
            // 
            // NewCuisineDescription
            // 
            NewCuisineDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewCuisineDescription.Location = new Point(248, 69);
            NewCuisineDescription.Margin = new Padding(3, 4, 3, 4);
            NewCuisineDescription.MaxLength = 1000;
            NewCuisineDescription.Name = "NewCuisineDescription";
            NewCuisineDescription.Size = new Size(486, 292);
            NewCuisineDescription.TabIndex = 4;
            NewCuisineDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "Описание:";
            // 
            // AddCuisineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(802, 459);
            Controls.Add(label2);
            Controls.Add(NewCuisineDescription);
            Controls.Add(ExitAddCuisineForm);
            Controls.Add(ApplyAddCuisinelForm);
            Controls.Add(NewCuisineName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(818, 495);
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