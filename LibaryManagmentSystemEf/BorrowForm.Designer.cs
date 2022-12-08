namespace LibaryManagmentSystemEf
{
    partial class BorrowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.btnBorrow = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.rbReturn = new System.Windows.Forms.RadioButton();
            this.rbBorrow = new System.Windows.Forms.RadioButton();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.txtMemberName = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookTitle = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSearch);
            this.metroPanel1.Controls.Add(this.txtSearch);
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(798, 44);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(379, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(90, 10);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Ara...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(283, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Ara...";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnDelete);
            this.metroPanel2.Controls.Add(this.btnReturn);
            this.metroPanel2.Controls.Add(this.btnBorrow);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(807, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(346, 44);
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(255, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Kaydı Sil";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(137, 10);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Teslim Alındı";
            this.btnReturn.UseSelectable = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(19, 10);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(112, 23);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Teslim Edildi";
            this.btnBorrow.UseSelectable = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.rbReturn);
            this.metroPanel3.Controls.Add(this.rbBorrow);
            this.metroPanel3.Controls.Add(this.dtpReturnDate);
            this.metroPanel3.Controls.Add(this.dtpBorrowDate);
            this.metroPanel3.Controls.Add(this.txtMemberName);
            this.metroPanel3.Controls.Add(this.label6);
            this.metroPanel3.Controls.Add(this.label4);
            this.metroPanel3.Controls.Add(this.label3);
            this.metroPanel3.Controls.Add(this.txtBookTitle);
            this.metroPanel3.Controls.Add(this.label2);
            this.metroPanel3.Controls.Add(this.txtID);
            this.metroPanel3.Controls.Add(this.label1);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(807, 53);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(346, 615);
            this.metroPanel3.TabIndex = 11;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // rbReturn
            // 
            this.rbReturn.AutoSize = true;
            this.rbReturn.Location = new System.Drawing.Point(131, 288);
            this.rbReturn.Name = "rbReturn";
            this.rbReturn.Size = new System.Drawing.Size(116, 20);
            this.rbReturn.TabIndex = 13;
            this.rbReturn.TabStop = true;
            this.rbReturn.Text = "Teslim Alınıyor";
            this.rbReturn.UseVisualStyleBackColor = true;
            // 
            // rbBorrow
            // 
            this.rbBorrow.AutoSize = true;
            this.rbBorrow.Location = new System.Drawing.Point(131, 234);
            this.rbBorrow.Name = "rbBorrow";
            this.rbBorrow.Size = new System.Drawing.Size(117, 20);
            this.rbBorrow.TabIndex = 11;
            this.rbBorrow.TabStop = true;
            this.rbBorrow.Text = "Teslim Ediliyor";
            this.rbBorrow.UseVisualStyleBackColor = true;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(130, 260);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(204, 22);
            this.dtpReturnDate.TabIndex = 12;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(131, 204);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(204, 22);
            this.dtpBorrowDate.TabIndex = 10;
            // 
            // txtMemberName
            // 
            // 
            // 
            // 
            this.txtMemberName.CustomButton.Image = null;
            this.txtMemberName.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtMemberName.CustomButton.Name = "";
            this.txtMemberName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMemberName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMemberName.CustomButton.TabIndex = 1;
            this.txtMemberName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMemberName.CustomButton.UseSelectable = true;
            this.txtMemberName.CustomButton.Visible = false;
            this.txtMemberName.Lines = new string[0];
            this.txtMemberName.Location = new System.Drawing.Point(132, 169);
            this.txtMemberName.MaxLength = 32767;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PasswordChar = '\0';
            this.txtMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemberName.SelectedText = "";
            this.txtMemberName.SelectionLength = 0;
            this.txtMemberName.SelectionStart = 0;
            this.txtMemberName.ShortcutsEnabled = true;
            this.txtMemberName.Size = new System.Drawing.Size(204, 25);
            this.txtMemberName.TabIndex = 9;
            this.txtMemberName.UseSelectable = true;
            this.txtMemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemberName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(68, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Üye Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(4, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teslim Alma Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teslim Etme Tarihi:";
            // 
            // txtBookTitle
            // 
            // 
            // 
            // 
            this.txtBookTitle.CustomButton.Image = null;
            this.txtBookTitle.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtBookTitle.CustomButton.Name = "";
            this.txtBookTitle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBookTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookTitle.CustomButton.TabIndex = 1;
            this.txtBookTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookTitle.CustomButton.UseSelectable = true;
            this.txtBookTitle.CustomButton.Visible = false;
            this.txtBookTitle.Lines = new string[0];
            this.txtBookTitle.Location = new System.Drawing.Point(132, 138);
            this.txtBookTitle.MaxLength = 32767;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.PasswordChar = '\0';
            this.txtBookTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookTitle.SelectedText = "";
            this.txtBookTitle.SelectionLength = 0;
            this.txtBookTitle.SelectionStart = 0;
            this.txtBookTitle.ShortcutsEnabled = true;
            this.txtBookTitle.Size = new System.Drawing.Size(204, 25);
            this.txtBookTitle.TabIndex = 8;
            this.txtBookTitle.UseSelectable = true;
            this.txtBookTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(63, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Adı:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(133, 107);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PromptText = "Otomatik Oluşturulur";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(204, 25);
            this.txtID.TabIndex = 7;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMark = "Otomatik Oluşturulur";
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(103, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(3, 53);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.RowTemplate.Height = 24;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(798, 615);
            this.dgvBorrow.TabIndex = 12;
            this.dgvBorrow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellDoubleClick);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 671);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel1);
            this.Name = "BorrowForm";
            this.Text = "Kitap Yönetim Ekranı";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Controls.MetroButton btnBorrow;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox txtMemberName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtBookTitle;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.RadioButton rbReturn;
        private System.Windows.Forms.RadioButton rbBorrow;
        private MetroFramework.Controls.MetroButton btnDelete;
    }
}