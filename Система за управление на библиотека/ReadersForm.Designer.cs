namespace Система_за_управление_на_библиотека
{
    partial class ReadersForm
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
            textBoxReaderName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            dateTimePickerRegister = new DateTimePicker();
            dataGridViewReaders = new DataGridView();
            groupBoxReaderInfo = new GroupBox();
            labelRegister = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            label1 = new Label();
            buttonAddReader = new Button();
            buttonEditReader = new Button();
            buttonDeleteReader = new Button();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders).BeginInit();
            groupBoxReaderInfo.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxReaderName
            // 
            textBoxReaderName.Location = new Point(140, 75);
            textBoxReaderName.Name = "textBoxReaderName";
            textBoxReaderName.Size = new Size(125, 27);
            textBoxReaderName.TabIndex = 0;
            textBoxReaderName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(140, 35);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(140, 115);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 2;
            // 
            // dateTimePickerRegister
            // 
            dateTimePickerRegister.CalendarFont = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dateTimePickerRegister.CalendarForeColor = Color.Black;
            dateTimePickerRegister.CalendarMonthBackground = Color.White;
            dateTimePickerRegister.CalendarTitleBackColor = SystemColors.ActiveBorder;
            dateTimePickerRegister.CalendarTitleForeColor = Color.Black;
            dateTimePickerRegister.CustomFormat = "dd.MM.yyyy";
            dateTimePickerRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerRegister.Format = DateTimePickerFormat.Custom;
            dateTimePickerRegister.Location = new Point(170, 155);
            dateTimePickerRegister.Name = "dateTimePickerRegister";
            dateTimePickerRegister.Size = new Size(250, 30);
            dateTimePickerRegister.TabIndex = 3;
            // 
            // dataGridViewReaders
            // 
            dataGridViewReaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReaders.BackgroundColor = Color.White;
            dataGridViewReaders.BorderStyle = BorderStyle.None;
            dataGridViewReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReaders.Location = new Point(20, 300);
            dataGridViewReaders.Name = "dataGridViewReaders";
            dataGridViewReaders.ReadOnly = true;
            dataGridViewReaders.RowHeadersWidth = 51;
            dataGridViewReaders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReaders.Size = new Size(1240, 450);
            dataGridViewReaders.TabIndex = 15;
            // 
            // groupBoxReaderInfo
            // 
            groupBoxReaderInfo.Controls.Add(labelRegister);
            groupBoxReaderInfo.Controls.Add(labelPhone);
            groupBoxReaderInfo.Controls.Add(labelEmail);
            groupBoxReaderInfo.Controls.Add(label1);
            groupBoxReaderInfo.Controls.Add(textBoxReaderName);
            groupBoxReaderInfo.Controls.Add(dateTimePickerRegister);
            groupBoxReaderInfo.Controls.Add(textBoxEmail);
            groupBoxReaderInfo.Controls.Add(textBoxPhone);
            groupBoxReaderInfo.Location = new Point(20, 20);
            groupBoxReaderInfo.Name = "groupBoxReaderInfo";
            groupBoxReaderInfo.Size = new Size(580, 250);
            groupBoxReaderInfo.TabIndex = 16;
            groupBoxReaderInfo.TabStop = false;
            groupBoxReaderInfo.Text = "Данни за читател";
            groupBoxReaderInfo.Enter += groupBoxReaderInfo_Enter;
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.BackColor = Color.Transparent;
            labelRegister.ForeColor = Color.Black;
            labelRegister.Location = new Point(20, 160);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(136, 20);
            labelRegister.TabIndex = 7;
            labelRegister.Text = "Дата регистрация:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.BackColor = Color.Transparent;
            labelPhone.Location = new Point(20, 120);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(72, 20);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Телефон:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Location = new Point(20, 80);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(59, 20);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Имейл:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "Име:";
            // 
            // buttonAddReader
            // 
            buttonAddReader.Cursor = Cursors.Hand;
            buttonAddReader.FlatStyle = FlatStyle.Flat;
            buttonAddReader.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAddReader.ForeColor = Color.FromArgb(59, 130, 246);
            buttonAddReader.Location = new Point(600, 40);
            buttonAddReader.Name = "buttonAddReader";
            buttonAddReader.Size = new Size(120, 40);
            buttonAddReader.TabIndex = 18;
            buttonAddReader.Text = "Добави";
            buttonAddReader.UseVisualStyleBackColor = true;
            buttonAddReader.Click += buttonAddReader_Click;
            // 
            // buttonEditReader
            // 
            buttonEditReader.Cursor = Cursors.Hand;
            buttonEditReader.FlatStyle = FlatStyle.Flat;
            buttonEditReader.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEditReader.ForeColor = Color.FromArgb(255, 192, 128);
            buttonEditReader.Location = new Point(600, 90);
            buttonEditReader.Name = "buttonEditReader";
            buttonEditReader.Size = new Size(120, 40);
            buttonEditReader.TabIndex = 19;
            buttonEditReader.Text = "Редактирай";
            buttonEditReader.UseVisualStyleBackColor = true;
            buttonEditReader.Click += buttonEditReader_Click;
            // 
            // buttonDeleteReader
            // 
            buttonDeleteReader.Cursor = Cursors.Hand;
            buttonDeleteReader.FlatStyle = FlatStyle.Flat;
            buttonDeleteReader.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDeleteReader.ForeColor = Color.Red;
            buttonDeleteReader.Location = new Point(600, 140);
            buttonDeleteReader.Name = "buttonDeleteReader";
            buttonDeleteReader.Size = new Size(120, 40);
            buttonDeleteReader.TabIndex = 20;
            buttonDeleteReader.Text = "Изтрий";
            buttonDeleteReader.UseVisualStyleBackColor = true;
            buttonDeleteReader.Click += buttonDeleteReader_Click;
            // 
            // buttonClear
            // 
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClear.ForeColor = SystemColors.ControlDarkDark;
            buttonClear.Location = new Point(600, 190);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(120, 40);
            buttonClear.TabIndex = 21;
            buttonClear.Text = "Изчисти";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // ReadersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(buttonDeleteReader);
            Controls.Add(buttonEditReader);
            Controls.Add(buttonAddReader);
            Controls.Add(dataGridViewReaders);
            Controls.Add(groupBoxReaderInfo);
            Name = "ReadersForm";
            Text = "Читатели";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders).EndInit();
            groupBoxReaderInfo.ResumeLayout(false);
            groupBoxReaderInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxReaderName;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private DateTimePicker dateTimePickerRegister;
        private DataGridView dataGridViewReaders;
        private GroupBox groupBoxReaderInfo;
        private Label label1;
        private Label labelRegister;
        private Label labelPhone;
        private Label labelEmail;
        private Button buttonAddReader;
        private Button buttonEditReader;
        private Button buttonDeleteReader;
        private Button buttonClear;
    }
}