namespace Система_за_управление_на_библиотека
{
    partial class DashboardForm
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
            labelWelcome = new Label();
            labelInfo = new Label();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWelcome.Location = new Point(30, 40);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(653, 46);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Добре дошли в библиотечната система";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo.ForeColor = Color.Gray;
            labelInfo.Location = new Point(35, 90);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(356, 25);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Използвайте менюто вляво за навигация.";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(labelInfo);
            Controls.Add(labelWelcome);
            Name = "DashboardForm";
            Text = "Начало";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelInfo;
    }
}