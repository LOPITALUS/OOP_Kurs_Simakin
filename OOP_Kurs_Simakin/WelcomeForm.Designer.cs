namespace OOP_Kurs_Simakin
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.Info;
            ExitButton.Location = new Point(139, 248);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(86, 31);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Ок!";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 60);
            label1.Name = "label1";
            label1.Size = new Size(207, 27);
            label1.TabIndex = 1;
            label1.Text = "Приложение БД \"Меню\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 163);
            label2.Name = "label2";
            label2.Size = new Size(319, 20);
            label2.TabIndex = 2;
            label2.Text = "Разработал: Симакин Константин 22ВП1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 112);
            label3.Name = "label3";
            label3.Size = new Size(319, 20);
            label3.TabIndex = 3;
            label3.Text = "Предметная область: ресторан";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(366, 325);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}