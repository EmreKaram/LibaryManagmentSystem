using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Providers.Entities;
using System.Windows.Forms;

namespace LibaryManagmentSystemEf
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        LibaryManagmentSystemEntities1 db = new LibaryManagmentSystemEntities1();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var myUser = db.TblUser
                .FirstOrDefault(u => u.UserName == txtUserName.Text
                && u.UserPassword == txtPassword.Text);
            if (myUser != null && myUser.UserType == "admin")
            {
                AdminForm admin = new AdminForm();
                admin.ShowDialog();
                //Pek emin değilim dön bir bak.
                LoginForm loginForm = new LoginForm();
                loginForm.Hide();

            }
            if (myUser != null && myUser.UserType == "owner")
            {
                OwnerDashboardForm ownerDashboardForm = new OwnerDashboardForm();
                ownerDashboardForm.ShowDialog();
                this.Close();
            }
            if (myUser != null && myUser.UserType == "user")
            {
                BorrowForm borrowForm = new BorrowForm();
                borrowForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir şeyleri yanlış yaptın");
            }
            
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            SignForm signForm = new SignForm();
            signForm.ShowDialog();
            this.Close();
        }
    }
}
