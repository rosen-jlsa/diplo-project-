namespace Система_за_управление_на_библиотека
{
    partial class LoansForm
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
            comboBoxBooks = new ComboBox();
            comboBoxReaders = new ComboBox();
            dateTimePickerLoanDate = new DateTimePicker();
            dateTimePickerReturnDate = new DateTimePicker();
            dataGridViewLoans = new DataGridView();
            labelBook = new Label();
            labelReader = new Label();
            labelLoanDate = new Label();
            labelReturnDate = new Label();
            buttonLoanBook = new Button();
            buttonReturnBook = new Button();
            buttonCleanLoan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans).BeginInit();
            SuspendLayout();
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(140, 35);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(250, 28);
            comboBoxBooks.TabIndex = 0;
            // 
            // comboBoxReaders
            // 
            comboBoxReaders.FormattingEnabled = true;
            comboBoxReaders.Location = new Point(140, 85);
            comboBoxReaders.Name = "comboBoxReaders";
            comboBoxReaders.Size = new Size(250, 28);
            comboBoxReaders.TabIndex = 1;
            // 
            // dateTimePickerLoanDate
            // 
            dateTimePickerLoanDate.CalendarForeColor = Color.Black;
            dateTimePickerLoanDate.CalendarMonthBackground = Color.White;
            dateTimePickerLoanDate.CalendarTitleForeColor = Color.Black;
            dateTimePickerLoanDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerLoanDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerLoanDate.Location = new Point(140, 135);
            dateTimePickerLoanDate.Name = "dateTimePickerLoanDate";
            dateTimePickerLoanDate.Size = new Size(250, 27);
            dateTimePickerLoanDate.TabIndex = 2;
            // 
            // dateTimePickerReturnDate
            // 
            dateTimePickerReturnDate.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerReturnDate.CalendarForeColor = Color.Black;
            dateTimePickerReturnDate.CalendarMonthBackground = Color.White;
            dateTimePickerReturnDate.CalendarTitleForeColor = Color.Black;
            dateTimePickerReturnDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerReturnDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerReturnDate.Location = new Point(140, 185);
            dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            dateTimePickerReturnDate.Size = new Size(250, 27);
            dateTimePickerReturnDate.TabIndex = 3;
            // 
            // dataGridViewLoans
            // 
            dataGridViewLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoans.BackgroundColor = Color.White;
            dataGridViewLoans.BorderStyle = BorderStyle.None;
            dataGridViewLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoans.Location = new Point(20, 300);
            dataGridViewLoans.Name = "dataGridViewLoans";
            dataGridViewLoans.ReadOnly = true;
            dataGridViewLoans.RowHeadersWidth = 51;
            dataGridViewLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLoans.Size = new Size(1240, 450);
            dataGridViewLoans.TabIndex = 15;
            // 
            // labelBook
            // 
            labelBook.AutoSize = true;
            labelBook.Location = new Point(20, 40);
            labelBook.Name = "labelBook";
            labelBook.Size = new Size(53, 20);
            labelBook.TabIndex = 16;
            labelBook.Text = "Книга:";
            // 
            // labelReader
            // 
            labelReader.AutoSize = true;
            labelReader.Location = new Point(20, 90);
            labelReader.Name = "labelReader";
            labelReader.Size = new Size(67, 20);
            labelReader.TabIndex = 17;
            labelReader.Text = "Читател:";
            // 
            // labelLoanDate
            // 
            labelLoanDate.AutoSize = true;
            labelLoanDate.BackColor = Color.Transparent;
            labelLoanDate.Location = new Point(20, 140);
            labelLoanDate.Name = "labelLoanDate";
            labelLoanDate.Size = new Size(107, 20);
            labelLoanDate.TabIndex = 18;
            labelLoanDate.Text = "Дата заемане:";
            // 
            // labelReturnDate
            // 
            labelReturnDate.AutoSize = true;
            labelReturnDate.Location = new Point(20, 190);
            labelReturnDate.Name = "labelReturnDate";
            labelReturnDate.Size = new Size(91, 20);
            labelReturnDate.TabIndex = 19;
            labelReturnDate.Text = "Краен срок:";
            // 
            // buttonLoanBook
            // 
            buttonLoanBook.BackColor = SystemColors.Control;
            buttonLoanBook.Cursor = Cursors.Hand;
            buttonLoanBook.FlatStyle = FlatStyle.Flat;
            buttonLoanBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLoanBook.ForeColor = Color.Black;
            buttonLoanBook.Location = new Point(420, 35);
            buttonLoanBook.Name = "buttonLoanBook";
            buttonLoanBook.Size = new Size(120, 40);
            buttonLoanBook.TabIndex = 20;
            buttonLoanBook.Text = "Заеми";
            buttonLoanBook.UseVisualStyleBackColor = false;
            buttonLoanBook.Click += buttonLoanBook_Click;
            // 
            // buttonReturnBook
            // 
            buttonReturnBook.Cursor = Cursors.Hand;
            buttonReturnBook.FlatStyle = FlatStyle.Flat;
            buttonReturnBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonReturnBook.ForeColor = Color.Black;
            buttonReturnBook.Location = new Point(420, 95);
            buttonReturnBook.Name = "buttonReturnBook";
            buttonReturnBook.Size = new Size(120, 40);
            buttonReturnBook.TabIndex = 21;
            buttonReturnBook.Text = "Върни";
            buttonReturnBook.UseVisualStyleBackColor = true;
            buttonReturnBook.Click += buttonReturnBook_Click;
            // 
            // buttonCleanLoan
            // 
            buttonCleanLoan.Cursor = Cursors.Hand;
            buttonCleanLoan.FlatStyle = FlatStyle.Flat;
            buttonCleanLoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCleanLoan.ForeColor = Color.Black;
            buttonCleanLoan.Location = new Point(420, 155);
            buttonCleanLoan.Name = "buttonCleanLoan";
            buttonCleanLoan.Size = new Size(120, 40);
            buttonCleanLoan.TabIndex = 22;
            buttonCleanLoan.Text = "Изчисти";
            buttonCleanLoan.UseVisualStyleBackColor = true;
            buttonCleanLoan.Click += buttonCleanLoan_Click;
            // 
            // LoansForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCleanLoan);
            Controls.Add(buttonReturnBook);
            Controls.Add(buttonLoanBook);
            Controls.Add(labelReturnDate);
            Controls.Add(labelLoanDate);
            Controls.Add(labelReader);
            Controls.Add(labelBook);
            Controls.Add(dataGridViewLoans);
            Controls.Add(dateTimePickerReturnDate);
            Controls.Add(dateTimePickerLoanDate);
            Controls.Add(comboBoxReaders);
            Controls.Add(comboBoxBooks);
            Name = "LoansForm";
            Text = "Заемания";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBooks;
        private ComboBox comboBoxReaders;
        private DateTimePicker dateTimePickerLoanDate;
        private DateTimePicker dateTimePickerReturnDate;
        private DataGridView dataGridViewLoans;
        private Label labelBook;
        private Label labelReader;
        private Label labelLoanDate;
        private Label labelReturnDate;
        private Button buttonLoanBook;
        private Button buttonReturnBook;
        private Button buttonCleanLoan;
    }
}