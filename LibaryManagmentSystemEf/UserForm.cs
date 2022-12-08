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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        LibaryManagmentSystemEntities1 db = new LibaryManagmentSystemEntities1();

        public void ClearMethod()
        {
            txtID.Text = "";
            txtUsername.Text = "";
            txtUserPassword.Text = "";
            txtUserType.Text = "";
        }

        public void FillDataGridView()
        {
            dgvUser.DataSource = db.TblUser.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TblUser u = new TblUser();
            u.UserType = txtUserType.Text;
            u.UserName = txtUsername.Text;
            u.UserPassword = txtUserPassword.Text;
            db.TblUser.Add(u);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı sisteme eklenmiştir !");
            ClearMethod();
            FillDataGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var m = db.TblUser.Find(id); ;
            db.TblUser.Remove(m);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı sistemden silinmiştir !");
            ClearMethod();
            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var m = db.TblUser.Find(id);
            m.UserType = txtUserType.Text;
            m.UserName = txtUsername.Text;
            m.UserPassword = txtUserPassword.Text;
            db.SaveChanges();
            ClearMethod();
            FillDataGridView();
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = dgvUser.SelectedCells[0].RowIndex;
            txtID.Text = dgvUser.Rows[rowid].Cells[0].Value.ToString();
            txtUsername.Text = dgvUser.Rows[rowid].Cells[1].Value.ToString();
            txtUserPassword.Text = dgvUser.Rows[rowid].Cells[2].Value.ToString();
            txtUserType.Text = dgvUser.Rows[rowid].Cells[3].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = db.TblUser.Where(x => x.UserName == txtSearch.Text).ToList();
        }
    }
}
