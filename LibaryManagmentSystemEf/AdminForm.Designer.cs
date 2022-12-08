namespace LibaryManagmentSystemEf
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPubisher = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookISBN = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookBookID = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnBookUpdate = new MetroFramework.Controls.MetroButton();
            this.btnBookSave = new MetroFramework.Controls.MetroButton();
            this.btnBookDelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnBookSearch = new MetroFramework.Controls.MetroButton();
            this.txtBookSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnBookRefresh = new MetroFramework.Controls.MetroButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.mtxtMemberPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtMemberSurname = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMemberName = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMemberMemberID = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.btnMemberUpdate = new MetroFramework.Controls.MetroButton();
            this.btnMemberSave = new MetroFramework.Controls.MetroButton();
            this.btnMemberDelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnMemberSearch = new MetroFramework.Controls.MetroButton();
            this.txtMemberSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnMemberRefresh = new MetroFramework.Controls.MetroButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.metroPanel9 = new MetroFramework.Controls.MetroPanel();
            this.rbReturn = new System.Windows.Forms.RadioButton();
            this.rbBorrow = new System.Windows.Forms.RadioButton();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.txtBorrowMemberName = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBorrowBookName = new MetroFramework.Controls.MetroTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBorrowID = new MetroFramework.Controls.MetroTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.btnBorrowSearch = new MetroFramework.Controls.MetroButton();
            this.txtBorrowSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnBorrowRefresh = new MetroFramework.Controls.MetroButton();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.btnBorrowDelete = new MetroFramework.Controls.MetroButton();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.btnBorrow = new MetroFramework.Controls.MetroButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.metroPanel6.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.metroPanel9.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1156, 671);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBook);
            this.tabPage1.Controls.Add(this.metroPanel3);
            this.tabPage1.Controls.Add(this.metroPanel2);
            this.tabPage1.Controls.Add(this.metroPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(0, 50);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(796, 592);
            this.dgvBook.TabIndex = 11;
            this.dgvBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellDoubleClick);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.txtAuthor);
            this.metroPanel3.Controls.Add(this.txtQuantity);
            this.metroPanel3.Controls.Add(this.label6);
            this.metroPanel3.Controls.Add(this.txtPubisher);
            this.metroPanel3.Controls.Add(this.label5);
            this.metroPanel3.Controls.Add(this.txtBookISBN);
            this.metroPanel3.Controls.Add(this.label4);
            this.metroPanel3.Controls.Add(this.label3);
            this.metroPanel3.Controls.Add(this.txtBookName);
            this.metroPanel3.Controls.Add(this.label2);
            this.metroPanel3.Controls.Add(this.txtBookBookID);
            this.metroPanel3.Controls.Add(this.label1);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(802, 50);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(346, 592);
            this.metroPanel3.TabIndex = 10;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txtAuthor
            // 
            // 
            // 
            // 
            this.txtAuthor.CustomButton.Image = null;
            this.txtAuthor.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtAuthor.CustomButton.Name = "";
            this.txtAuthor.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthor.CustomButton.TabIndex = 1;
            this.txtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthor.CustomButton.UseSelectable = true;
            this.txtAuthor.CustomButton.Visible = false;
            this.txtAuthor.Lines = new string[0];
            this.txtAuthor.Location = new System.Drawing.Point(120, 176);
            this.txtAuthor.MaxLength = 32767;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.SelectionLength = 0;
            this.txtAuthor.SelectionStart = 0;
            this.txtAuthor.ShortcutsEnabled = true;
            this.txtAuthor.Size = new System.Drawing.Size(204, 25);
            this.txtAuthor.TabIndex = 9;
            this.txtAuthor.UseSelectable = true;
            this.txtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(120, 290);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(204, 25);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(69, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Yazar:";
            // 
            // txtPubisher
            // 
            // 
            // 
            // 
            this.txtPubisher.CustomButton.Image = null;
            this.txtPubisher.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtPubisher.CustomButton.Name = "";
            this.txtPubisher.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPubisher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPubisher.CustomButton.TabIndex = 1;
            this.txtPubisher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPubisher.CustomButton.UseSelectable = true;
            this.txtPubisher.CustomButton.Visible = false;
            this.txtPubisher.Lines = new string[0];
            this.txtPubisher.Location = new System.Drawing.Point(120, 252);
            this.txtPubisher.MaxLength = 32767;
            this.txtPubisher.Name = "txtPubisher";
            this.txtPubisher.PasswordChar = '\0';
            this.txtPubisher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPubisher.SelectedText = "";
            this.txtPubisher.SelectionLength = 0;
            this.txtPubisher.SelectionStart = 0;
            this.txtPubisher.ShortcutsEnabled = true;
            this.txtPubisher.Size = new System.Drawing.Size(204, 25);
            this.txtPubisher.TabIndex = 11;
            this.txtPubisher.UseSelectable = true;
            this.txtPubisher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPubisher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(68, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Miktar:";
            // 
            // txtBookISBN
            // 
            // 
            // 
            // 
            this.txtBookISBN.CustomButton.Image = null;
            this.txtBookISBN.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtBookISBN.CustomButton.Name = "";
            this.txtBookISBN.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBookISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookISBN.CustomButton.TabIndex = 1;
            this.txtBookISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookISBN.CustomButton.UseSelectable = true;
            this.txtBookISBN.CustomButton.Visible = false;
            this.txtBookISBN.Lines = new string[0];
            this.txtBookISBN.Location = new System.Drawing.Point(120, 214);
            this.txtBookISBN.MaxLength = 32767;
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.PasswordChar = '\0';
            this.txtBookISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookISBN.SelectedText = "";
            this.txtBookISBN.SelectionLength = 0;
            this.txtBookISBN.SelectionStart = 0;
            this.txtBookISBN.ShortcutsEnabled = true;
            this.txtBookISBN.Size = new System.Drawing.Size(204, 25);
            this.txtBookISBN.TabIndex = 10;
            this.txtBookISBN.UseSelectable = true;
            this.txtBookISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(53, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yayınevi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(73, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ISBN:";
            // 
            // txtBookName
            // 
            // 
            // 
            // 
            this.txtBookName.CustomButton.Image = null;
            this.txtBookName.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtBookName.CustomButton.Name = "";
            this.txtBookName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookName.CustomButton.TabIndex = 1;
            this.txtBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookName.CustomButton.UseSelectable = true;
            this.txtBookName.CustomButton.Visible = false;
            this.txtBookName.Lines = new string[0];
            this.txtBookName.Location = new System.Drawing.Point(120, 138);
            this.txtBookName.MaxLength = 32767;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookName.SelectedText = "";
            this.txtBookName.SelectionLength = 0;
            this.txtBookName.SelectionStart = 0;
            this.txtBookName.ShortcutsEnabled = true;
            this.txtBookName.Size = new System.Drawing.Size(204, 25);
            this.txtBookName.TabIndex = 8;
            this.txtBookName.UseSelectable = true;
            this.txtBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Adı:";
            // 
            // txtBookBookID
            // 
            // 
            // 
            // 
            this.txtBookBookID.CustomButton.Image = null;
            this.txtBookBookID.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtBookBookID.CustomButton.Name = "";
            this.txtBookBookID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBookBookID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookBookID.CustomButton.TabIndex = 1;
            this.txtBookBookID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookBookID.CustomButton.UseSelectable = true;
            this.txtBookBookID.CustomButton.Visible = false;
            this.txtBookBookID.Lines = new string[0];
            this.txtBookBookID.Location = new System.Drawing.Point(120, 100);
            this.txtBookBookID.MaxLength = 32767;
            this.txtBookBookID.Name = "txtBookBookID";
            this.txtBookBookID.PasswordChar = '\0';
            this.txtBookBookID.PromptText = "Otomatik Oluşturulur";
            this.txtBookBookID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookBookID.SelectedText = "";
            this.txtBookBookID.SelectionLength = 0;
            this.txtBookBookID.SelectionStart = 0;
            this.txtBookBookID.ShortcutsEnabled = true;
            this.txtBookBookID.Size = new System.Drawing.Size(204, 25);
            this.txtBookBookID.TabIndex = 7;
            this.txtBookBookID.UseSelectable = true;
            this.txtBookBookID.WaterMark = "Otomatik Oluşturulur";
            this.txtBookBookID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookBookID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(91, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnBookUpdate);
            this.metroPanel2.Controls.Add(this.btnBookSave);
            this.metroPanel2.Controls.Add(this.btnBookDelete);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(802, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(346, 44);
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(181, 10);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnBookUpdate.TabIndex = 6;
            this.btnBookUpdate.Text = "Güncelle";
            this.btnBookUpdate.UseSelectable = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // btnBookSave
            // 
            this.btnBookSave.Location = new System.Drawing.Point(100, 10);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(75, 23);
            this.btnBookSave.TabIndex = 5;
            this.btnBookSave.Text = "Kaydet";
            this.btnBookSave.UseSelectable = true;
            this.btnBookSave.Click += new System.EventHandler(this.btnBookSave_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(19, 10);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBookDelete.TabIndex = 4;
            this.btnBookDelete.Text = "Sil";
            this.btnBookDelete.UseSelectable = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnBookSearch);
            this.metroPanel1.Controls.Add(this.txtBookSearch);
            this.metroPanel1.Controls.Add(this.btnBookRefresh);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(796, 44);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(379, 9);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBookSearch.TabIndex = 3;
            this.btnBookSearch.Text = "Ara";
            this.btnBookSearch.UseSelectable = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // txtBookSearch
            // 
            // 
            // 
            // 
            this.txtBookSearch.CustomButton.Image = null;
            this.txtBookSearch.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtBookSearch.CustomButton.Name = "";
            this.txtBookSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBookSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookSearch.CustomButton.TabIndex = 1;
            this.txtBookSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookSearch.CustomButton.UseSelectable = true;
            this.txtBookSearch.CustomButton.Visible = false;
            this.txtBookSearch.Lines = new string[0];
            this.txtBookSearch.Location = new System.Drawing.Point(90, 10);
            this.txtBookSearch.MaxLength = 32767;
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.PasswordChar = '\0';
            this.txtBookSearch.PromptText = "Ara...";
            this.txtBookSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookSearch.SelectedText = "";
            this.txtBookSearch.SelectionLength = 0;
            this.txtBookSearch.SelectionStart = 0;
            this.txtBookSearch.ShortcutsEnabled = true;
            this.txtBookSearch.Size = new System.Drawing.Size(283, 25);
            this.txtBookSearch.TabIndex = 2;
            this.txtBookSearch.UseSelectable = true;
            this.txtBookSearch.WaterMark = "Ara...";
            this.txtBookSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBookRefresh
            // 
            this.btnBookRefresh.Location = new System.Drawing.Point(9, 10);
            this.btnBookRefresh.Name = "btnBookRefresh";
            this.btnBookRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnBookRefresh.TabIndex = 1;
            this.btnBookRefresh.Text = "Yenile";
            this.btnBookRefresh.UseSelectable = true;
            this.btnBookRefresh.Click += new System.EventHandler(this.btnBookRefresh_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMember);
            this.tabPage2.Controls.Add(this.metroPanel6);
            this.tabPage2.Controls.Add(this.metroPanel5);
            this.tabPage2.Controls.Add(this.metroPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1148, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Üye";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(0, 50);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(798, 592);
            this.dgvMember.TabIndex = 12;
            this.dgvMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellDoubleClick);
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.mtxtMemberPhone);
            this.metroPanel6.Controls.Add(this.txtMemberSurname);
            this.metroPanel6.Controls.Add(this.label7);
            this.metroPanel6.Controls.Add(this.txtEmail);
            this.metroPanel6.Controls.Add(this.label8);
            this.metroPanel6.Controls.Add(this.label9);
            this.metroPanel6.Controls.Add(this.txtMemberName);
            this.metroPanel6.Controls.Add(this.label10);
            this.metroPanel6.Controls.Add(this.txtMemberMemberID);
            this.metroPanel6.Controls.Add(this.label11);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(802, 50);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(346, 592);
            this.metroPanel6.TabIndex = 11;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // mtxtMemberPhone
            // 
            this.mtxtMemberPhone.Location = new System.Drawing.Point(120, 217);
            this.mtxtMemberPhone.Mask = "(999) 000-0000";
            this.mtxtMemberPhone.Name = "mtxtMemberPhone";
            this.mtxtMemberPhone.Size = new System.Drawing.Size(204, 22);
            this.mtxtMemberPhone.TabIndex = 10;
            // 
            // txtMemberSurname
            // 
            // 
            // 
            // 
            this.txtMemberSurname.CustomButton.Image = null;
            this.txtMemberSurname.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtMemberSurname.CustomButton.Name = "";
            this.txtMemberSurname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMemberSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMemberSurname.CustomButton.TabIndex = 1;
            this.txtMemberSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMemberSurname.CustomButton.UseSelectable = true;
            this.txtMemberSurname.CustomButton.Visible = false;
            this.txtMemberSurname.Lines = new string[0];
            this.txtMemberSurname.Location = new System.Drawing.Point(120, 176);
            this.txtMemberSurname.MaxLength = 32767;
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.PasswordChar = '\0';
            this.txtMemberSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemberSurname.SelectedText = "";
            this.txtMemberSurname.SelectionLength = 0;
            this.txtMemberSurname.SelectionStart = 0;
            this.txtMemberSurname.ShortcutsEnabled = true;
            this.txtMemberSurname.Size = new System.Drawing.Size(204, 25);
            this.txtMemberSurname.TabIndex = 9;
            this.txtMemberSurname.UseSelectable = true;
            this.txtMemberSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemberSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(66, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Soyad:";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(120, 252);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(204, 25);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(68, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "E-mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(60, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefon:";
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
            this.txtMemberName.Location = new System.Drawing.Point(120, 138);
            this.txtMemberName.MaxLength = 32767;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PasswordChar = '\0';
            this.txtMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemberName.SelectedText = "";
            this.txtMemberName.SelectionLength = 0;
            this.txtMemberName.SelectionStart = 0;
            this.txtMemberName.ShortcutsEnabled = true;
            this.txtMemberName.Size = new System.Drawing.Size(204, 25);
            this.txtMemberName.TabIndex = 8;
            this.txtMemberName.UseSelectable = true;
            this.txtMemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemberName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(89, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ad:";
            // 
            // txtMemberMemberID
            // 
            // 
            // 
            // 
            this.txtMemberMemberID.CustomButton.Image = null;
            this.txtMemberMemberID.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtMemberMemberID.CustomButton.Name = "";
            this.txtMemberMemberID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMemberMemberID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMemberMemberID.CustomButton.TabIndex = 1;
            this.txtMemberMemberID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMemberMemberID.CustomButton.UseSelectable = true;
            this.txtMemberMemberID.CustomButton.Visible = false;
            this.txtMemberMemberID.Lines = new string[0];
            this.txtMemberMemberID.Location = new System.Drawing.Point(120, 100);
            this.txtMemberMemberID.MaxLength = 32767;
            this.txtMemberMemberID.Name = "txtMemberMemberID";
            this.txtMemberMemberID.PasswordChar = '\0';
            this.txtMemberMemberID.PromptText = "Otomatik Oluşturulur";
            this.txtMemberMemberID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemberMemberID.SelectedText = "";
            this.txtMemberMemberID.SelectionLength = 0;
            this.txtMemberMemberID.SelectionStart = 0;
            this.txtMemberMemberID.ShortcutsEnabled = true;
            this.txtMemberMemberID.Size = new System.Drawing.Size(204, 25);
            this.txtMemberMemberID.TabIndex = 7;
            this.txtMemberMemberID.UseSelectable = true;
            this.txtMemberMemberID.WaterMark = "Otomatik Oluşturulur";
            this.txtMemberMemberID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemberMemberID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(93, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID:";
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.btnMemberUpdate);
            this.metroPanel5.Controls.Add(this.btnMemberSave);
            this.metroPanel5.Controls.Add(this.btnMemberDelete);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(802, 0);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(346, 44);
            this.metroPanel5.TabIndex = 10;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // btnMemberUpdate
            // 
            this.btnMemberUpdate.Location = new System.Drawing.Point(181, 10);
            this.btnMemberUpdate.Name = "btnMemberUpdate";
            this.btnMemberUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnMemberUpdate.TabIndex = 6;
            this.btnMemberUpdate.Text = "Güncelle";
            this.btnMemberUpdate.UseSelectable = true;
            this.btnMemberUpdate.Click += new System.EventHandler(this.btnMemberUpdate_Click);
            // 
            // btnMemberSave
            // 
            this.btnMemberSave.Location = new System.Drawing.Point(100, 9);
            this.btnMemberSave.Name = "btnMemberSave";
            this.btnMemberSave.Size = new System.Drawing.Size(75, 23);
            this.btnMemberSave.TabIndex = 5;
            this.btnMemberSave.Text = "Kaydet";
            this.btnMemberSave.UseSelectable = true;
            this.btnMemberSave.Click += new System.EventHandler(this.btnMemberSave_Click);
            // 
            // btnMemberDelete
            // 
            this.btnMemberDelete.Location = new System.Drawing.Point(19, 10);
            this.btnMemberDelete.Name = "btnMemberDelete";
            this.btnMemberDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMemberDelete.TabIndex = 4;
            this.btnMemberDelete.Text = "Sil";
            this.btnMemberDelete.UseSelectable = true;
            this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.btnMemberSearch);
            this.metroPanel4.Controls.Add(this.txtMemberSearch);
            this.metroPanel4.Controls.Add(this.btnMemberRefresh);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(796, 44);
            this.metroPanel4.TabIndex = 9;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Location = new System.Drawing.Point(379, 9);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMemberSearch.TabIndex = 3;
            this.btnMemberSearch.Text = "Ara";
            this.btnMemberSearch.UseSelectable = true;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // txtMemberSearch
            // 
            // 
            // 
            // 
            this.txtMemberSearch.CustomButton.Image = null;
            this.txtMemberSearch.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtMemberSearch.CustomButton.Name = "";
            this.txtMemberSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMemberSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMemberSearch.CustomButton.TabIndex = 1;
            this.txtMemberSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMemberSearch.CustomButton.UseSelectable = true;
            this.txtMemberSearch.CustomButton.Visible = false;
            this.txtMemberSearch.Lines = new string[0];
            this.txtMemberSearch.Location = new System.Drawing.Point(90, 10);
            this.txtMemberSearch.MaxLength = 32767;
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.PasswordChar = '\0';
            this.txtMemberSearch.PromptText = "Ara...";
            this.txtMemberSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemberSearch.SelectedText = "";
            this.txtMemberSearch.SelectionLength = 0;
            this.txtMemberSearch.SelectionStart = 0;
            this.txtMemberSearch.ShortcutsEnabled = true;
            this.txtMemberSearch.Size = new System.Drawing.Size(283, 25);
            this.txtMemberSearch.TabIndex = 2;
            this.txtMemberSearch.UseSelectable = true;
            this.txtMemberSearch.WaterMark = "Ara...";
            this.txtMemberSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemberSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnMemberRefresh
            // 
            this.btnMemberRefresh.Location = new System.Drawing.Point(9, 10);
            this.btnMemberRefresh.Name = "btnMemberRefresh";
            this.btnMemberRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnMemberRefresh.TabIndex = 1;
            this.btnMemberRefresh.Text = "Yenile";
            this.btnMemberRefresh.UseSelectable = true;
            this.btnMemberRefresh.Click += new System.EventHandler(this.btnMemberRefresh_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvBorrow);
            this.tabPage3.Controls.Add(this.metroPanel9);
            this.tabPage3.Controls.Add(this.metroPanel7);
            this.tabPage3.Controls.Add(this.metroPanel8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1148, 642);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kitap Alıp-Verme";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(0, 50);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.RowTemplate.Height = 24;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(796, 592);
            this.dgvBorrow.TabIndex = 13;
            this.dgvBorrow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellDoubleClick);
            // 
            // metroPanel9
            // 
            this.metroPanel9.Controls.Add(this.rbReturn);
            this.metroPanel9.Controls.Add(this.rbBorrow);
            this.metroPanel9.Controls.Add(this.dtpReturnDate);
            this.metroPanel9.Controls.Add(this.dtpBorrowDate);
            this.metroPanel9.Controls.Add(this.txtBorrowMemberName);
            this.metroPanel9.Controls.Add(this.label12);
            this.metroPanel9.Controls.Add(this.label13);
            this.metroPanel9.Controls.Add(this.label14);
            this.metroPanel9.Controls.Add(this.txtBorrowBookName);
            this.metroPanel9.Controls.Add(this.label15);
            this.metroPanel9.Controls.Add(this.txtBorrowID);
            this.metroPanel9.Controls.Add(this.label16);
            this.metroPanel9.HorizontalScrollbarBarColor = true;
            this.metroPanel9.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel9.HorizontalScrollbarSize = 10;
            this.metroPanel9.Location = new System.Drawing.Point(802, 50);
            this.metroPanel9.Name = "metroPanel9";
            this.metroPanel9.Size = new System.Drawing.Size(346, 592);
            this.metroPanel9.TabIndex = 12;
            this.metroPanel9.VerticalScrollbarBarColor = true;
            this.metroPanel9.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel9.VerticalScrollbarSize = 10;
            // 
            // rbReturn
            // 
            this.rbReturn.AutoSize = true;
            this.rbReturn.Location = new System.Drawing.Point(132, 306);
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
            this.rbBorrow.Location = new System.Drawing.Point(132, 252);
            this.rbBorrow.Name = "rbBorrow";
            this.rbBorrow.Size = new System.Drawing.Size(117, 20);
            this.rbBorrow.TabIndex = 11;
            this.rbBorrow.TabStop = true;
            this.rbBorrow.Text = "Teslim Ediliyor";
            this.rbBorrow.UseVisualStyleBackColor = true;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(133, 278);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(204, 22);
            this.dtpReturnDate.TabIndex = 12;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(133, 224);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(204, 22);
            this.dtpBorrowDate.TabIndex = 10;
            // 
            // txtBorrowMemberName
            // 
            // 
            // 
            // 
            this.txtBorrowMemberName.CustomButton.Image = null;
            this.txtBorrowMemberName.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtBorrowMemberName.CustomButton.Name = "";
            this.txtBorrowMemberName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBorrowMemberName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBorrowMemberName.CustomButton.TabIndex = 1;
            this.txtBorrowMemberName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBorrowMemberName.CustomButton.UseSelectable = true;
            this.txtBorrowMemberName.CustomButton.Visible = false;
            this.txtBorrowMemberName.Lines = new string[0];
            this.txtBorrowMemberName.Location = new System.Drawing.Point(132, 185);
            this.txtBorrowMemberName.MaxLength = 32767;
            this.txtBorrowMemberName.Name = "txtBorrowMemberName";
            this.txtBorrowMemberName.PasswordChar = '\0';
            this.txtBorrowMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBorrowMemberName.SelectedText = "";
            this.txtBorrowMemberName.SelectionLength = 0;
            this.txtBorrowMemberName.SelectionStart = 0;
            this.txtBorrowMemberName.ShortcutsEnabled = true;
            this.txtBorrowMemberName.Size = new System.Drawing.Size(204, 25);
            this.txtBorrowMemberName.TabIndex = 9;
            this.txtBorrowMemberName.UseSelectable = true;
            this.txtBorrowMemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBorrowMemberName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(69, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Üye Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(5, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Teslim Alma Tarihi:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(5, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Teslim Etme Tarihi:";
            // 
            // txtBorrowBookName
            // 
            // 
            // 
            // 
            this.txtBorrowBookName.CustomButton.Image = null;
            this.txtBorrowBookName.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtBorrowBookName.CustomButton.Name = "";
            this.txtBorrowBookName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBorrowBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBorrowBookName.CustomButton.TabIndex = 1;
            this.txtBorrowBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBorrowBookName.CustomButton.UseSelectable = true;
            this.txtBorrowBookName.CustomButton.Visible = false;
            this.txtBorrowBookName.Lines = new string[0];
            this.txtBorrowBookName.Location = new System.Drawing.Point(132, 146);
            this.txtBorrowBookName.MaxLength = 32767;
            this.txtBorrowBookName.Name = "txtBorrowBookName";
            this.txtBorrowBookName.PasswordChar = '\0';
            this.txtBorrowBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBorrowBookName.SelectedText = "";
            this.txtBorrowBookName.SelectionLength = 0;
            this.txtBorrowBookName.SelectionStart = 0;
            this.txtBorrowBookName.ShortcutsEnabled = true;
            this.txtBorrowBookName.Size = new System.Drawing.Size(204, 25);
            this.txtBorrowBookName.TabIndex = 8;
            this.txtBorrowBookName.UseSelectable = true;
            this.txtBorrowBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBorrowBookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(64, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Kitap Adı:";
            // 
            // txtBorrowID
            // 
            // 
            // 
            // 
            this.txtBorrowID.CustomButton.Image = null;
            this.txtBorrowID.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtBorrowID.CustomButton.Name = "";
            this.txtBorrowID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBorrowID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBorrowID.CustomButton.TabIndex = 1;
            this.txtBorrowID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBorrowID.CustomButton.UseSelectable = true;
            this.txtBorrowID.CustomButton.Visible = false;
            this.txtBorrowID.Lines = new string[0];
            this.txtBorrowID.Location = new System.Drawing.Point(133, 107);
            this.txtBorrowID.MaxLength = 32767;
            this.txtBorrowID.Name = "txtBorrowID";
            this.txtBorrowID.PasswordChar = '\0';
            this.txtBorrowID.PromptText = "Otomatik Oluşturulur";
            this.txtBorrowID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBorrowID.SelectedText = "";
            this.txtBorrowID.SelectionLength = 0;
            this.txtBorrowID.SelectionStart = 0;
            this.txtBorrowID.ShortcutsEnabled = true;
            this.txtBorrowID.Size = new System.Drawing.Size(204, 25);
            this.txtBorrowID.TabIndex = 7;
            this.txtBorrowID.UseSelectable = true;
            this.txtBorrowID.WaterMark = "Otomatik Oluşturulur";
            this.txtBorrowID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBorrowID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(104, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "ID:";
            // 
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.btnBorrowSearch);
            this.metroPanel7.Controls.Add(this.txtBorrowSearch);
            this.metroPanel7.Controls.Add(this.btnBorrowRefresh);
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(0, 0);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(796, 44);
            this.metroPanel7.TabIndex = 10;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // btnBorrowSearch
            // 
            this.btnBorrowSearch.Location = new System.Drawing.Point(379, 12);
            this.btnBorrowSearch.Name = "btnBorrowSearch";
            this.btnBorrowSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBorrowSearch.TabIndex = 3;
            this.btnBorrowSearch.Text = "Ara";
            this.btnBorrowSearch.UseSelectable = true;
            this.btnBorrowSearch.Click += new System.EventHandler(this.btnBorrowSearch_Click);
            // 
            // txtBorrowSearch
            // 
            // 
            // 
            // 
            this.txtBorrowSearch.CustomButton.Image = null;
            this.txtBorrowSearch.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtBorrowSearch.CustomButton.Name = "";
            this.txtBorrowSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBorrowSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBorrowSearch.CustomButton.TabIndex = 1;
            this.txtBorrowSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBorrowSearch.CustomButton.UseSelectable = true;
            this.txtBorrowSearch.CustomButton.Visible = false;
            this.txtBorrowSearch.Lines = new string[0];
            this.txtBorrowSearch.Location = new System.Drawing.Point(90, 10);
            this.txtBorrowSearch.MaxLength = 32767;
            this.txtBorrowSearch.Name = "txtBorrowSearch";
            this.txtBorrowSearch.PasswordChar = '\0';
            this.txtBorrowSearch.PromptText = "Ara...";
            this.txtBorrowSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBorrowSearch.SelectedText = "";
            this.txtBorrowSearch.SelectionLength = 0;
            this.txtBorrowSearch.SelectionStart = 0;
            this.txtBorrowSearch.ShortcutsEnabled = true;
            this.txtBorrowSearch.Size = new System.Drawing.Size(283, 25);
            this.txtBorrowSearch.TabIndex = 2;
            this.txtBorrowSearch.UseSelectable = true;
            this.txtBorrowSearch.WaterMark = "Ara...";
            this.txtBorrowSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBorrowSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBorrowRefresh
            // 
            this.btnBorrowRefresh.Location = new System.Drawing.Point(9, 10);
            this.btnBorrowRefresh.Name = "btnBorrowRefresh";
            this.btnBorrowRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnBorrowRefresh.TabIndex = 1;
            this.btnBorrowRefresh.Text = "Yenile";
            this.btnBorrowRefresh.UseSelectable = true;
            this.btnBorrowRefresh.Click += new System.EventHandler(this.btnBorrowRefresh_Click);
            // 
            // metroPanel8
            // 
            this.metroPanel8.Controls.Add(this.btnBorrowDelete);
            this.metroPanel8.Controls.Add(this.btnReturn);
            this.metroPanel8.Controls.Add(this.btnBorrow);
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(802, 0);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(346, 44);
            this.metroPanel8.TabIndex = 11;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            // 
            // btnBorrowDelete
            // 
            this.btnBorrowDelete.Location = new System.Drawing.Point(255, 10);
            this.btnBorrowDelete.Name = "btnBorrowDelete";
            this.btnBorrowDelete.Size = new System.Drawing.Size(81, 23);
            this.btnBorrowDelete.TabIndex = 6;
            this.btnBorrowDelete.Text = "Kaydı Sil";
            this.btnBorrowDelete.UseSelectable = true;
            this.btnBorrowDelete.Click += new System.EventHandler(this.btnBorrowDelete_Click);
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 671);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Ekranı";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.metroPanel9.ResumeLayout(false);
            this.metroPanel9.PerformLayout();
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnBookSearch;
        private MetroFramework.Controls.MetroTextBox txtBookSearch;
        private MetroFramework.Controls.MetroButton btnBookRefresh;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnBookUpdate;
        private MetroFramework.Controls.MetroButton btnBookSave;
        private MetroFramework.Controls.MetroButton btnBookDelete;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox txtAuthor;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtPubisher;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtBookISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtBookBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBook;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton btnMemberSearch;
        private MetroFramework.Controls.MetroTextBox txtMemberSearch;
        private MetroFramework.Controls.MetroButton btnMemberRefresh;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroButton btnMemberUpdate;
        private MetroFramework.Controls.MetroButton btnMemberSave;
        private MetroFramework.Controls.MetroButton btnMemberDelete;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.MaskedTextBox mtxtMemberPhone;
        private MetroFramework.Controls.MetroTextBox txtMemberSurname;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtMemberName;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox txtMemberMemberID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvMember;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroButton btnBorrowSearch;
        private MetroFramework.Controls.MetroTextBox txtBorrowSearch;
        private MetroFramework.Controls.MetroButton btnBorrowRefresh;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private MetroFramework.Controls.MetroButton btnBorrowDelete;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Controls.MetroButton btnBorrow;
        private MetroFramework.Controls.MetroPanel metroPanel9;
        private System.Windows.Forms.RadioButton rbReturn;
        private System.Windows.Forms.RadioButton rbBorrow;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private MetroFramework.Controls.MetroTextBox txtBorrowMemberName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroTextBox txtBorrowBookName;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroTextBox txtBorrowID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvBorrow;
    }
}