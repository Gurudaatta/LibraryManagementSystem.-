using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Books section clicked.");
            // You can later open a BookForm here
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Members section clicked.");
            // You can later open a MemberForm here
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transactions section clicked.");
            // You can later open a TransactionForm here
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}