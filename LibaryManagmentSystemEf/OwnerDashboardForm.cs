using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryManagmentSystemEf
{
    public partial class OwnerDashboardForm : Form
    {
        public OwnerDashboardForm()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            MemberForm memberForm = new MemberForm();
            memberForm.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.ShowDialog();
        }

    }
}
