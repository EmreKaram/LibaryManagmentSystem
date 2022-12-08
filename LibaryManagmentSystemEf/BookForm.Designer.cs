namespace LibaryManagmentSystemEf
{
    partial class BookForm
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
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
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnUpdate);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.Controls.Add(this.btnDelete);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(807, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(346, 44);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(181, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.metroPanel3.Controls.Add(this.txtID);
            this.metroPanel3.Controls.Add(this.label1);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(807, 53);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(346, 615);
            this.metroPanel3.TabIndex = 6;
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
            this.txtID.Location = new System.Drawing.Point(120, 100);
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
            this.label1.Location = new System.Drawing.Point(91, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
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
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(379, 9);
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
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(3, 53);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(798, 615);
            this.dgvBook.TabIndex = 8;
            this.dgvBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellDoubleClick);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 671);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekranı";
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox txtBookISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtID;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtPubisher;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroTextBox txtAuthor;
    }
}

