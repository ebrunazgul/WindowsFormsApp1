namespace WindowsFormsApp1.Admin
{
    partial class frmComment
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
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb6 = new System.Windows.Forms.RadioButton();
            this.rdb7 = new System.Windows.Forms.RadioButton();
            this.rdb8 = new System.Windows.Forms.RadioButton();
            this.rdb9 = new System.Windows.Forms.RadioButton();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rchComment = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(174, 50);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(290, 20);
            this.txtBookName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap adı";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(174, 94);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(290, 20);
            this.txtMemberName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Üye adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puan";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(174, 134);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(31, 17);
            this.rdb1.TabIndex = 7;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "1";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(211, 134);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(31, 17);
            this.rdb2.TabIndex = 8;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "2";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(322, 134);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(31, 17);
            this.rdb5.TabIndex = 9;
            this.rdb5.TabStop = true;
            this.rdb5.Text = "5";
            this.rdb5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(285, 134);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(248, 134);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(31, 17);
            this.rdb3.TabIndex = 11;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "3";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb6
            // 
            this.rdb6.AutoSize = true;
            this.rdb6.Location = new System.Drawing.Point(359, 134);
            this.rdb6.Name = "rdb6";
            this.rdb6.Size = new System.Drawing.Size(31, 17);
            this.rdb6.TabIndex = 12;
            this.rdb6.TabStop = true;
            this.rdb6.Text = "6";
            this.rdb6.UseVisualStyleBackColor = true;
            // 
            // rdb7
            // 
            this.rdb7.AutoSize = true;
            this.rdb7.Location = new System.Drawing.Point(396, 134);
            this.rdb7.Name = "rdb7";
            this.rdb7.Size = new System.Drawing.Size(31, 17);
            this.rdb7.TabIndex = 13;
            this.rdb7.TabStop = true;
            this.rdb7.Text = "7";
            this.rdb7.UseVisualStyleBackColor = true;
            // 
            // rdb8
            // 
            this.rdb8.AutoSize = true;
            this.rdb8.Location = new System.Drawing.Point(433, 134);
            this.rdb8.Name = "rdb8";
            this.rdb8.Size = new System.Drawing.Size(31, 17);
            this.rdb8.TabIndex = 14;
            this.rdb8.TabStop = true;
            this.rdb8.Text = "8";
            this.rdb8.UseVisualStyleBackColor = true;
            // 
            // rdb9
            // 
            this.rdb9.AutoSize = true;
            this.rdb9.Location = new System.Drawing.Point(470, 134);
            this.rdb9.Name = "rdb9";
            this.rdb9.Size = new System.Drawing.Size(31, 17);
            this.rdb9.TabIndex = 15;
            this.rdb9.TabStop = true;
            this.rdb9.Text = "9";
            this.rdb9.UseVisualStyleBackColor = true;
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Location = new System.Drawing.Point(507, 134);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(37, 17);
            this.rdb10.TabIndex = 16;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "10";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Yorumunuz";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rchComment
            // 
            this.rchComment.Location = new System.Drawing.Point(174, 199);
            this.rchComment.Name = "rchComment";
            this.rchComment.Size = new System.Drawing.Size(290, 185);
            this.rchComment.TabIndex = 18;
            this.rchComment.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(174, 413);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(290, 23);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // frmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rchComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdb10);
            this.Controls.Add(this.rdb9);
            this.Controls.Add(this.rdb8);
            this.Controls.Add(this.rdb7);
            this.Controls.Add(this.rdb6);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.rdb5);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Name = "frmComment";
            this.Text = "frmComment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb6;
        private System.Windows.Forms.RadioButton rdb7;
        private System.Windows.Forms.RadioButton rdb8;
        private System.Windows.Forms.RadioButton rdb9;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchComment;
        private System.Windows.Forms.Button btnSend;
    }
}