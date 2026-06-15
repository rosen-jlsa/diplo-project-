namespace Система_за_управление_на_библиотека
{
    partial class BooksForm
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
            groupBoxBookInfo = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            labelCopies = new Label();
            labelYear = new Label();
            comboBoxGenre = new ComboBox();
            textBoxAuthor = new TextBox();
            labelGenre = new Label();
            labelAuthor = new Label();
            textBoxTitle = new TextBox();
            labelTitle = new Label();
            buttonAddBook = new Button();
            buttonEditBook = new Button();
            buttonDeleteBook = new Button();
            buttonClearBook = new Button();
            dataGridViewBooks = new DataGridView();
            groupBoxBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // groupBoxBookInfo
            // 
            groupBoxBookInfo.Controls.Add(numericUpDown2);
            groupBoxBookInfo.Controls.Add(numericUpDown1);
            groupBoxBookInfo.Controls.Add(labelCopies);
            groupBoxBookInfo.Controls.Add(labelYear);
            groupBoxBookInfo.Controls.Add(comboBoxGenre);
            groupBoxBookInfo.Controls.Add(textBoxAuthor);
            groupBoxBookInfo.Controls.Add(labelGenre);
            groupBoxBookInfo.Controls.Add(labelAuthor);
            groupBoxBookInfo.Controls.Add(textBoxTitle);
            groupBoxBookInfo.Controls.Add(labelTitle);
            groupBoxBookInfo.Location = new Point(20, 20);
            groupBoxBookInfo.Name = "groupBoxBookInfo";
            groupBoxBookInfo.Size = new Size(520, 280);
            groupBoxBookInfo.TabIndex = 0;
            groupBoxBookInfo.TabStop = false;
            groupBoxBookInfo.Text = "Информация за книга";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(140, 215);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(140, 170);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // labelCopies
            // 
            labelCopies.AutoSize = true;
            labelCopies.Location = new Point(20, 220);
            labelCopies.Name = "labelCopies";
            labelCopies.Size = new Size(64, 20);
            labelCopies.TabIndex = 7;
            labelCopies.Text = "Бройки:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(20, 175);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(62, 20);
            labelYear.TabIndex = 6;
            labelYear.Text = "Година:";
            labelYear.Click += label1_Click;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(140, 125);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(250, 28);
            comboBoxGenre.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(140, 80);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(250, 27);
            textBoxAuthor.TabIndex = 4;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(20, 130);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(51, 20);
            labelGenre.TabIndex = 3;
            labelGenre.Text = "Жанр:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(20, 85);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(54, 20);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Автор:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(140, 35);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(250, 27);
            textBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(20, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(75, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Заглавие:";
            // 
            // buttonAddBook
            // 
            buttonAddBook.Cursor = Cursors.Hand;
            buttonAddBook.FlatStyle = FlatStyle.Flat;
            buttonAddBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAddBook.ForeColor = Color.FromArgb(59, 130, 246);
            buttonAddBook.Location = new Point(580, 40);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(120, 40);
            buttonAddBook.TabIndex = 10;
            buttonAddBook.Text = "Добави";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // buttonEditBook
            // 
            buttonEditBook.Cursor = Cursors.Hand;
            buttonEditBook.FlatStyle = FlatStyle.Flat;
            buttonEditBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEditBook.ForeColor = Color.FromArgb(245, 158, 11);
            buttonEditBook.Location = new Point(580, 95);
            buttonEditBook.Name = "buttonEditBook";
            buttonEditBook.Size = new Size(120, 40);
            buttonEditBook.TabIndex = 11;
            buttonEditBook.Text = "Редактирай";
            buttonEditBook.UseVisualStyleBackColor = true;
            buttonEditBook.Click += buttonEditBook_Click;
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.Cursor = Cursors.Hand;
            buttonDeleteBook.FlatStyle = FlatStyle.Flat;
            buttonDeleteBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDeleteBook.ForeColor = Color.FromArgb(239, 68, 68);
            buttonDeleteBook.Location = new Point(580, 150);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(120, 40);
            buttonDeleteBook.TabIndex = 12;
            buttonDeleteBook.Text = "Изтрий";
            buttonDeleteBook.UseVisualStyleBackColor = true;
            buttonDeleteBook.Click += buttonDeleteBook_Click;
            // 
            // buttonClearBook
            // 
            buttonClearBook.Cursor = Cursors.Hand;
            buttonClearBook.FlatStyle = FlatStyle.Flat;
            buttonClearBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClearBook.ForeColor = Color.FromArgb(156, 163, 175);
            buttonClearBook.Location = new Point(580, 205);
            buttonClearBook.Name = "buttonClearBook";
            buttonClearBook.Size = new Size(120, 40);
            buttonClearBook.TabIndex = 13;
            buttonClearBook.Text = "Изчисти";
            buttonClearBook.UseVisualStyleBackColor = true;
            buttonClearBook.Click += buttonClearBook_Click_1;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.BackgroundColor = Color.White;
            dataGridViewBooks.BorderStyle = BorderStyle.None;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(20, 330);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(1240, 420);
            dataGridViewBooks.TabIndex = 14;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewBooks);
            Controls.Add(buttonClearBook);
            Controls.Add(buttonDeleteBook);
            Controls.Add(buttonEditBook);
            Controls.Add(buttonAddBook);
            Controls.Add(groupBoxBookInfo);
            Name = "BooksForm";
            Text = "Книги";
            Load += BooksForm_Load;
            groupBoxBookInfo.ResumeLayout(false);
            groupBoxBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxBookInfo;
        private Label labelTitle;
        private ComboBox comboBoxGenre;
        private TextBox textBoxAuthor;
        private Label labelGenre;
        private Label labelAuthor;
        private TextBox textBoxTitle;
        private Label labelYear;
        private Label labelCopies;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button buttonAddBook;
        private Button buttonEditBook;
        private Button buttonDeleteBook;
        private Button buttonClearBook;
        private DataGridView dataGridViewBooks;
    }
}