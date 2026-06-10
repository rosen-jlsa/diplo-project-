namespace Система_за_управление_на_библиотека
{
    partial class MainForm
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
            panelSidebar = new Panel();
            buttonDashboard = new Button();
            buttonBooks = new Button();
            buttonReaders = new Button();
            buttonLoans = new Button();
            buttonExit = new Button();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelContent = new Panel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(243, 244, 246);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.ForeColor = Color.FromArgb(243, 244, 246);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 653);
            panelSidebar.TabIndex = 0;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.White;
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDashboard.ForeColor = Color.FromArgb(17, 24, 39);
            buttonDashboard.Location = new Point(10, 120);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(200, 45);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "Начало";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonBooks
            // 
            buttonBooks.BackColor = Color.White;
            buttonBooks.Cursor = Cursors.Hand;
            buttonBooks.FlatStyle = FlatStyle.Flat;
            buttonBooks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonBooks.ForeColor = Color.FromArgb(17, 24, 39);
            buttonBooks.Location = new Point(10, 180);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Size = new Size(200, 45);
            buttonBooks.TabIndex = 2;
            buttonBooks.Text = "Книги";
            buttonBooks.UseVisualStyleBackColor = false;
            buttonBooks.Click += ButtonBooks_Click;
            // 
            // buttonReaders
            // 
            buttonReaders.BackColor = Color.White;
            buttonReaders.Cursor = Cursors.Hand;
            buttonReaders.FlatStyle = FlatStyle.Flat;
            buttonReaders.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonReaders.ForeColor = Color.FromArgb(17, 24, 39);
            buttonReaders.Location = new Point(10, 240);
            buttonReaders.Name = "buttonReaders";
            buttonReaders.Size = new Size(200, 45);
            buttonReaders.TabIndex = 3;
            buttonReaders.Text = "Читатели";
            buttonReaders.UseVisualStyleBackColor = false;
            buttonReaders.Click += ButtonReaders_Click;
            // 
            // buttonLoans
            // 
            buttonLoans.BackColor = Color.White;
            buttonLoans.Cursor = Cursors.Hand;
            buttonLoans.FlatStyle = FlatStyle.Flat;
            buttonLoans.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLoans.ForeColor = Color.FromArgb(17, 24, 39);
            buttonLoans.Location = new Point(10, 300);
            buttonLoans.Name = "buttonLoans";
            buttonLoans.Size = new Size(200, 45);
            buttonLoans.TabIndex = 4;
            buttonLoans.Text = "Заемания";
            buttonLoans.UseVisualStyleBackColor = false;
            buttonLoans.Click += buttonLoans_Click;
            // 
            // buttonExit
            // 
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.ForeColor = Color.FromArgb(17, 24, 39);
            buttonExit.Location = new Point(10, 380);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(200, 45);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Изход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = Color.FromArgb(0, 1, 180, 211);
            panelHeader.Location = new Point(220, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(862, 70);
            panelHeader.TabIndex = 6;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(569, 41);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Система за управление на библиотека";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(250, 250, 250);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(220, 70);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(862, 583);
            panelContent.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1082, 653);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(buttonExit);
            Controls.Add(buttonLoans);
            Controls.Add(buttonReaders);
            Controls.Add(buttonBooks);
            Controls.Add(buttonDashboard);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Система за управление на библиотека";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button buttonDashboard;
        private Button buttonBooks;
        private Button buttonReaders;
        private Button buttonLoans;
        private Button buttonExit;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelContent;
    }
}
