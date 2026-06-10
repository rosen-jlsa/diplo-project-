namespace Система_за_управление_на_библиотека
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            OpenForm(new DashboardForm());
        }
        private void OpenForm(Form form)
        {
            panelContent.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            panelContent.Controls.Add(form);
            form.Show();
        }

        private void ButtonBooks_Click(object sender, EventArgs e)
        {
            OpenForm(new BooksForm());
        }

        private void ButtonReaders_Click(object sender, EventArgs e)
        {
            OpenForm(new ReadersForm());
        }

        private void buttonLoans_Click(object sender, EventArgs e)
        {
            OpenForm(new LoansForm());
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm());
        }
    }
}
