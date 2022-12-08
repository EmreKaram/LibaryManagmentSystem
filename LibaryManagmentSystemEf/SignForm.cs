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
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
        }

        LibaryManagmentSystemEntities1 db = new LibaryManagmentSystemEntities1();

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != null)
            {
                TblUser u = new TblUser();
                u.UserName = txtUserName.Text;
                u.UserPassword = txtPassword.Text;
                u.UserType = "user";
                db.TblUser.Add(u);
                db.SaveChanges();
                MessageBox.Show("Üye başarıyla kayıt edildi");
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
