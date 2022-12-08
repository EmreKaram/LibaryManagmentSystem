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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        LibaryManagmentSystemEntities1 db = new LibaryManagmentSystemEntities1();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void ClearMethod()
        {
            txtID.Text = "";
            txtMemberName.Text = "";
            txtMemberSurname.Text = "";
            mtxtMemberPhone.Text = "";
            txtEmail.Text = "";
        }
        
        public void FillDataGridView()
        {
            dgvMember.DataSource = db.TblMember.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TblMember m = new TblMember();
            m.MemberName = txtMemberName.Text;
            m.MemberSurname = txtMemberSurname.Text;
            m.MemberPhone = mtxtMemberPhone.Text;
            m.MemberEmail = txtEmail.Text;
            db.TblMember.Add(m);
            db.SaveChanges();
            MessageBox.Show("Üye sisteme eklenmiştir !");
            ClearMethod();
            FillDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var m = db.TblMember.Find(id);
            db.TblMember.Remove(m);
            db.SaveChanges();
            MessageBox.Show("Üye sistemden silinmiştir !");
            ClearMethod();
            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var m = db.TblMember.Find(id);
            m.MemberName = txtMemberName.Text;
            m.MemberSurname = txtMemberSurname.Text;
            m.MemberPhone = mtxtMemberPhone.Text;
            m.MemberEmail = txtEmail.Text;
            db.SaveChanges();
            MessageBox.Show("Üye bilgileri güncellenmiştir!");
            ClearMethod();
            FillDataGridView();
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = dgvMember.SelectedCells[0].RowIndex;
            txtID.Text = dgvMember.Rows[rowid].Cells[0].Value.ToString();
            txtMemberName.Text = dgvMember.Rows[rowid].Cells[1].Value.ToString();
            txtMemberSurname.Text = dgvMember.Rows[rowid].Cells[2].Value.ToString();
            mtxtMemberPhone.Text = dgvMember.Rows[rowid].Cells[3].Value.ToString();
            txtEmail.Text = dgvMember.Rows[rowid].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvMember.DataSource = db.TblMember.Where(x => x.MemberName == txtSearch.Text | x.MemberSurname == txtSearch.Text).ToList();
        }
    }
}
