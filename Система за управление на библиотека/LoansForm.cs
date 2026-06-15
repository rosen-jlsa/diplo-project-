using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Система_за_управление_на_библиотека
{
    public partial class LoansForm : Form
    {
        public LoansForm()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void buttonLoanBook_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {

        }

        private void buttonCleanLoan_Click(object sender, EventArgs e)
        {

        }
    }
}
