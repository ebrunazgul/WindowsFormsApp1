namespace WindowsFormsApp1.Admin
{
    partial class frmRegister
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
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.Label();
            this.txtMemberSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfilePhoto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.mtbPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(161, 39);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(187, 20);
            this.txtMemberName.TabIndex = 5;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.AutoSize = true;
            this.txtCategoryName.Location = new System.Drawing.Point(27, 42);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(43, 13);
            this.txtCategoryName.TabIndex = 4;
            this.txtCategoryName.Text = "Üye adı";
            // 
            // txtMemberSurname
            // 
            this.txtMemberSurname.Location = new System.Drawing.Point(161, 79);
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.Size = new System.Drawing.Size(187, 20);
            this.txtMemberSurname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doğum tarihi";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(161, 156);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(187, 20);
            this.txtMail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mail adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefon ";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(161, 232);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(187, 20);
            this.txtpassword.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şifre";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(161, 268);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(187, 20);
            this.txtconfirm.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Şifre tekrar";
            // 
            // txtProfilePhoto
            // 
            this.txtProfilePhoto.Location = new System.Drawing.Point(161, 306);
            this.txtProfilePhoto.Name = "txtProfilePhoto";
            this.txtProfilePhoto.Size = new System.Drawing.Size(187, 20);
            this.txtProfilePhoto.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Profil resmi";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(161, 343);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(187, 23);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Kayıt ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(161, 122);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(187, 20);
            this.dtpBirthDate.TabIndex = 21;
            // 
            // mtbPhoneNo
            // 
            this.mtbPhoneNo.Location = new System.Drawing.Point(161, 190);
            this.mtbPhoneNo.Mask = "(999) 000-0000";
            this.mtbPhoneNo.Name = "mtbPhoneNo";
            this.mtbPhoneNo.Size = new System.Drawing.Size(187, 20);
            this.mtbPhoneNo.TabIndex = 22;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtbPhoneNo);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtProfilePhoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemberSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label txtCategoryName;
        private System.Windows.Forms.TextBox txtMemberSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfilePhoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNo;
    }
}