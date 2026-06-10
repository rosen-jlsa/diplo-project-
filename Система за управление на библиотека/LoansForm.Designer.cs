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
            dateTimePickerLoan = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridViewLoans = new DataGridView();
            labelBook = new Label();
            labelReader = new Label();
            labelLoanDate = new Label();
            labelReturnDate = new Label();
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
            // dateTimePickerLoan
            // 
            dateTimePickerLoan.Location = new Point(140, 135);
            dateTimePickerLoan.Name = "dateTimePickerLoan";
            dateTimePickerLoan.Size = new Size(250, 27);
            dateTimePickerLoan.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(140, 185);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 3;
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
            // LoansForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelReturnDate);
            Controls.Add(labelLoanDate);
            Controls.Add(labelReader);
            Controls.Add(labelBook);
            Controls.Add(dataGridViewLoans);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePickerLoan);
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
        private DateTimePicker dateTimePickerLoan;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridViewLoans;
        private Label labelBook;
        private Label labelReader;
        private Label labelLoanDate;
        private Label labelReturnDate;
    }
}