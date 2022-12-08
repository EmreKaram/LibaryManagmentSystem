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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        LibaryManagmentSystemEntities1 db = new LibaryManagmentSystemEntities1();

        #region Refresh

        private void btnBookRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridViewBook();
        }

        private void btnMemberRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridViewMember();
        }

        private void btnBorrowRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridViewBorrow();
        }
        #endregion

        #region Search
        
        private void btnBorrowSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBorrowSearch.Text);
            var query = from d1 in db.TblBorrow
                        join d2 in db.TblBook
                        on d1.BookID equals d2.BookID
                        join d3 in db.TblMember
                        on d1.MemberID equals d3.MemberID
                        where d1.BorrowID == id
                        select new
                        {
                            TakipID = d1.BorrowID,
                            KitapAdı = d2.Title,
                            Kullanici = d3.MemberName + " " + d3.MemberSurname,
                            TeslimTarihi = d1.DateBorrow,
                            DonusTarihi = d1.DateReturn,
                            KalanMiktar = d2.Quantity
                        };
            dgvBorrow.DataSource = query.ToList();
        }

        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            dgvMember.DataSource = db.TblMember.Where(x => x.MemberName == txtMemberSearch.Text | x.MemberSurname == txtMemberSearch.Text).ToList();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            dgvBook.DataSource = db.TblBook.Where(x => x.Title == txtBookSearch.Text).ToList();
        }
        #endregion

        #region Save

        private void btnBookSave_Click(object sender, EventArgs e)
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
            ClearMethodBook();
            FillDataGridViewBook();
        }

        private void btnMemberSave_Click(object sender, EventArgs e)
        {
            TblMember m = new TblMember();
            m.MemberName = txtMemberName.Text;
            m.MemberSurname = txtMemberSurname.Text;
            m.MemberPhone = mtxtMemberPhone.Text;
            m.MemberEmail = txtEmail.Text;
            db.TblMember.Add(m);
            db.SaveChanges();
            MessageBox.Show("Üye sisteme eklenmiştir !");
            ClearMethodMember();
            FillDataGridViewMember();
        }
        #endregion

        #region Borrow-Return

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (rbBorrow.Checked == true)
            {
                TblBorrow b = new TblBorrow();
                b.BookID = db.TblBook.Where(x => x.Title == txtBorrowBookName.Text).Select(x => x.BookID).SingleOrDefault();
                b.MemberID = db.TblMember.Where(x => x.MemberName == txtBorrowMemberName.Text).Select(x => x.MemberID).SingleOrDefault();
                b.DateBorrow = Convert.ToDateTime(dtpBorrowDate.Value);
                b.DateReturn = null;
                db.TblBorrow.Add(b);
                int id = db.TblBook.Where(x => x.Title == txtBorrowBookName.Text).Select(x => x.BookID).SingleOrDefault();
                var z = db.TblBook.Find(id);
                z.Quantity--;
                db.SaveChanges();
                MessageBox.Show("Başarıyla !");
            }
            else
            {
                MessageBox.Show("Lütfen Teslim Etme Şıkkını işaretleyiniz ya da uygun butona tıklayınız");
                return;
            }
            ClearMethodBorrow();
            FillDataGridViewBorrow();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (rbReturn.Checked == true)
            {
                TblBorrow b = new TblBorrow();
                b.BookID = db.TblBook.Where(x => x.Title == txtBorrowBookName.Text).Select(x => x.BookID).SingleOrDefault();
                b.MemberID = db.TblMember.Where(x => x.MemberName == txtBorrowMemberName.Text).Select(x => x.MemberID).SingleOrDefault();
                b.DateBorrow = null;
                b.DateReturn = Convert.ToDateTime(dtpReturnDate.Value);
                db.TblBorrow.Add(b);
                int id = db.TblBook.Where(x => x.Title == txtBorrowBookName.Text).Select(x => x.BookID).SingleOrDefault();
                var z = db.TblBook.Find(id);
                z.Quantity++;
                db.SaveChanges();
                MessageBox.Show("Başarıyla !");
            }
            else
            {
                MessageBox.Show("Lütfen Teslim Alma Şıkkını işaretleyiniz ya da uygun butona tıklayınız");
                return;
            }
            ClearMethodBorrow();
            FillDataGridViewBorrow();
        }
        #endregion

        #region Delete

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(txtBookBookID.Text);
                var b = db.TblBook.Find(id);
                db.TblBook.Remove(b);
                db.SaveChanges();
                MessageBox.Show("Kitap sistemden silinmiştir !");
                ClearMethodBook();
                FillDataGridViewBook();
        }

        private void btnMemberDelete_Click(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(txtMemberMemberID.Text);
                var m = db.TblMember.Find(id);
                db.TblMember.Remove(m);
                db.SaveChanges();
                MessageBox.Show("Üye sistemden silinmiştir !");
                ClearMethodMember();
                FillDataGridViewMember();
        }

        private void btnBorrowDelete_Click(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(txtBorrowID.Text);
                var b = db.TblBorrow.Find(id);
                db.TblBorrow.Remove(b);
                db.SaveChanges();
                MessageBox.Show("Kayıt sistemden silinmiştir !");
        }
        #endregion

        #region Update

        private void btnMemberUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMemberMemberID.Text);
            var m = db.TblMember.Find(id);
            m.MemberName = txtMemberName.Text;
            m.MemberSurname = txtMemberSurname.Text;
            m.MemberPhone = mtxtMemberPhone.Text;
            m.MemberEmail = txtEmail.Text;
            db.SaveChanges();
            MessageBox.Show("Üye bilgileri güncellenmiştir!");
            ClearMethodMember();
            FillDataGridViewMember();
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBookBookID.Text);
            var b = db.TblBook.Find(id);
            b.Title = txtBookName.Text;
            b.ISBN = txtBookISBN.Text;
            b.Quantity = Convert.ToInt32(txtQuantity.Text);
            b.Author = txtAuthor.Text;
            b.Publication = txtPubisher.Text;
            db.SaveChanges();
            MessageBox.Show("Kitap bilgileri güncellenmiştir!");
            ClearMethodBook();
            FillDataGridViewBook();
        }
        #endregion

        #region FillDataGridView
        public void FillDataGridViewBorrow()
        {
            var query = from d1 in db.TblBorrow
                        join d2 in db.TblBook
                        on d1.BookID equals d2.BookID
                        join d3 in db.TblMember
                        on d1.MemberID equals d3.MemberID
                        select new
                        {
                            TakipID = d1.BorrowID,
                            KitapAdı = d2.Title,
                            Kullanici = d3.MemberName + " " + d3.MemberSurname,
                            TeslimTarihi = d1.DateBorrow,
                            DonusTarihi = d1.DateReturn,
                            KalanMiktar = d2.Quantity
                        };
            dgvBorrow.DataSource = query.ToList();
        }
        public void FillDataGridViewMember()
        {
            dgvMember.DataSource = db.TblMember.ToList();
        }
        public void FillDataGridViewBook()
        {
            dgvBook.DataSource = db.TblBook.ToList();
            dgvBook.Columns[6].Visible = false;
        }
        #endregion

        #region ClearMethod
        private void ClearMethodBook()
        {
            txtAuthor.Text = "";
            txtBookISBN.Text = "";
            txtBookName.Text = "";
            txtBookBookID.Text = "";
            txtPubisher.Text = "";
            txtQuantity.Text = "";
        }
        private void ClearMethodMember()
        {
            txtMemberMemberID.Text = "";
            txtMemberName.Text = "";
            txtMemberSurname.Text = "";
            mtxtMemberPhone.Text = "";
            txtEmail.Text = "";
        }
        public void ClearMethodBorrow()
        {
            txtBorrowID.Text = "";
            txtBorrowBookName.Text = "";
            txtBorrowMemberName.Text = "";
        }
        #endregion

        #region CellDoubleClick
        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = dgvBook.SelectedCells[0].RowIndex;
            txtBookBookID.Text = dgvBook.Rows[rowid].Cells[0].Value.ToString();
            txtBookName.Text = dgvBook.Rows[rowid].Cells[1].Value.ToString();
            txtAuthor.Text = dgvBook.Rows[rowid].Cells[2].Value.ToString();
            txtBookISBN.Text = dgvBook.Rows[rowid].Cells[3].Value.ToString();
            txtPubisher.Text = dgvBook.Rows[rowid].Cells[4].Value.ToString();
            txtQuantity.Text = dgvBook.Rows[rowid].Cells[5].Value.ToString();
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = dgvMember.SelectedCells[0].RowIndex;
            txtMemberMemberID.Text = dgvMember.Rows[rowid].Cells[0].Value.ToString();
            txtMemberName.Text = dgvMember.Rows[rowid].Cells[1].Value.ToString();
            txtMemberSurname.Text = dgvMember.Rows[rowid].Cells[2].Value.ToString();
            mtxtMemberPhone.Text = dgvMember.Rows[rowid].Cells[3].Value.ToString();
            txtEmail.Text = dgvMember.Rows[rowid].Cells[4].Value.ToString();
        }

        private void dgvBorrow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = dgvBorrow.SelectedCells[0].RowIndex;
            txtBorrowID.Text = dgvBorrow.Rows[rowid].Cells[0].Value.ToString();
            txtBorrowBookName.Text = dgvBorrow.Rows[rowid].Cells[1].Value.ToString();
            txtBorrowMemberName.Text = dgvBorrow.Rows[rowid].Cells[2].Value.ToString();
        }

        #endregion

    }
}
