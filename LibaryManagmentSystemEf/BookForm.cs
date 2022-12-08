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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        LibaryManagmentSystemEntities1 db = new LibaryManagmentSystemEntities1();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != null)
            {
                TblBook b = new TblBook();
                b.Title = txtBookName.Text;
                b.ISBN = txtBookISBN.Text;
                b.Quantity = Convert.ToInt32(txtQuantity.Text);
                b.Author = txtAuthor.Text;
                b.Publication = txtPubisher.Text;
                db.TblBook.Add(b);
                db.SaveChanges();
                MessageBox.Show("Kitap sisteme eklenmiştir !");
                ClearMethod();
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Kitap adı giriniz !");
            }
            
        }

        public void FillDataGridView()
        {
            dgvBook.DataSource = db.TblBook.ToList();
            dgvBook.Columns[6].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null)
            {
                int id = Convert.ToInt32(txtID.Text);
                var b = db.TblBook.Find(id);
                db.TblBook.Remove(b);
                db.SaveChanges();
                MessageBox.Show("Kitap sistemden silinmiştir !");
                ClearMethod();
                FillDataGridView();
            }
            else if (txtID.Text == null)
            {
                MessageBox.Show("Silmek istediğiniz kitabın ID'sini giriniz.");
            }
            else
            {
                MessageBox.Show("Kitabın veri tabanındaki bağlantılarını  Kitap işlem sayfasından silmeniz gerekiyor !");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && txtBookName.Text != null)
            {
                int id = Convert.ToInt32(txtID.Text);
                var b = db.TblBook.Find(id);
                b.Title = txtBookName.Text;
                b.ISBN = txtBookISBN.Text;
                b.Quantity = Convert.ToInt32(txtQuantity.Text);
                b.Author = txtAuthor.Text;
                b.Publication = txtPubisher.Text;
                db.SaveChanges();
                MessageBox.Show("Kitap bilgileri güncellenmiştir!");
                ClearMethod();
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Güneclleme işlemi için gerekli alanları doldurunuz !");
            }
            
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = dgvBook.SelectedCells[0].RowIndex;
            txtID.Text = dgvBook.Rows[rowid].Cells[0].Value.ToString();
            txtBookName.Text = dgvBook.Rows[rowid].Cells[1].Value.ToString();
            txtAuthor.Text = dgvBook.Rows[rowid].Cells[2].Value.ToString();
            txtBookISBN.Text = dgvBook.Rows[rowid].Cells[3].Value.ToString();
            txtPubisher.Text = dgvBook.Rows[rowid].Cells[4].Value.ToString();
            txtQuantity.Text = dgvBook.Rows[rowid].Cells[5].Value.ToString();
        }

        private void ClearMethod()
        {
            txtAuthor.Text = "";
            txtBookISBN.Text = "";
            txtBookName.Text = "";
            txtID.Text = "";
            txtPubisher.Text = "";
            txtQuantity.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvBook.DataSource = db.TblBook.Where(x => x.Title == txtSearch.Text).ToList();
        }
    }
}
