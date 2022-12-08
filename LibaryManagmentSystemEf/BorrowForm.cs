using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibaryManagmentSystemEf
{
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        LibaryManagmentSystemEntities1 db = new LibaryManagmentSystemEntities1();

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (rbBorrow.Checked == true)
            {
                TblBorrow b = new TblBorrow();
                b.BookID = db.TblBook.Where(x => x.Title == txtBookTitle.Text).Select(x => x.BookID).SingleOrDefault();
                b.MemberID = db.TblMember.Where(x => x.MemberName == txtMemberName.Text).Select(x => x.MemberID).SingleOrDefault();
                b.DateBorrow = Convert.ToDateTime(dtpBorrowDate.Value);
                b.DateReturn = null;
                db.TblBorrow.Add(b);
                int id = db.TblBook.Where(x => x.Title == txtBookTitle.Text).Select(x => x.BookID).SingleOrDefault();
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
            ClearMethod();
            FillDataGridView();

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (rbReturn.Checked == true)
            {
                TblBorrow b = new TblBorrow();
                b.BookID = db.TblBook.Where(x => x.Title == txtBookTitle.Text).Select(x => x.BookID).SingleOrDefault();
                b.MemberID = db.TblMember.Where(x => x.MemberName == txtMemberName.Text).Select(x => x.MemberID).SingleOrDefault();
                b.DateBorrow = null;
                b.DateReturn = Convert.ToDateTime(dtpReturnDate.Value);
                db.TblBorrow.Add(b);
                int id = db.TblBook.Where(x => x.Title == txtBookTitle.Text).Select(x => x.BookID).SingleOrDefault();
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
            ClearMethod();
            FillDataGridView();
        }

        public void FillDataGridView()
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSearch.Text);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null)
            {
                int id = Convert.ToInt32(txtID.Text);
                var b = db.TblBorrow.Find(id);
                db.TblBorrow.Remove(b);
                db.SaveChanges();
                MessageBox.Show("Kayıt sistemden silinmiştir !");
                ClearMethod();
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydın ID'sini giriniz !");
            }

        }

        private void dgvBorrow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = dgvBorrow.SelectedCells[0].RowIndex;
            txtID.Text = dgvBorrow.Rows[rowid].Cells[0].Value.ToString();
            txtBookTitle.Text = dgvBorrow.Rows[rowid].Cells[1].Value.ToString();
            txtMemberName.Text = dgvBorrow.Rows[rowid].Cells[2].Value.ToString();
        }
        public void ClearMethod()
        {
            txtID.Text = "";
            txtBookTitle.Text = "";
            txtMemberName.Text = "";
        }

    }
}
