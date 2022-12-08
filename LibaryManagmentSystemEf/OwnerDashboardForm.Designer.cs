namespace LibaryManagmentSystemEf
{
    partial class OwnerDashboardForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrow);
            this.groupBox2.Controls.Add(this.btnBook);
            this.groupBox2.Controls.Add(this.btnUser);
            this.groupBox2.Controls.Add(this.btnMember);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(189, 145);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(116, 69);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Kitap Yönetim Ekranı";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(67, 145);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(116, 69);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Kitap Ekranı";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(67, 70);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(116, 69);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Kullanıcı Ekranı";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(189, 70);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(116, 69);
            this.btnMember.TabIndex = 2;
            this.btnMember.Text = "Üye Ekranı";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // OwnerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 312);
            this.Controls.Add(this.groupBox2);
            this.Name = "OwnerDashboardForm";
            this.Text = "Owner Kontrol Ekranı";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnMember;
    }
}