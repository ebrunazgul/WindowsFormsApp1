namespace WindowsFormsApp1.Admin
{
    partial class frmAuthor
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
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.Label();
            this.textMemberSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rchDes = new System.Windows.Forms.RichTextBox();
            this.rchdescription = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(162, 40);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(187, 20);
            this.txtAuthorName.TabIndex = 7;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.AutoSize = true;
            this.txtCategoryName.Location = new System.Drawing.Point(28, 43);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(51, 13);
            this.txtCategoryName.TabIndex = 6;
            this.txtCategoryName.Text = "Yazar adı";
            // 
            // textMemberSurname
            // 
            this.textMemberSurname.Location = new System.Drawing.Point(162, 83);
            this.textMemberSurname.Name = "textMemberSurname";
            this.textMemberSurname.Size = new System.Drawing.Size(187, 20);
            this.textMemberSurname.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Soyadı";
            // 
            // rchDes
            // 
            this.rchDes.Location = new System.Drawing.Point(162, 154);
            this.rchDes.Name = "rchDes";
            this.rchDes.Size = new System.Drawing.Size(187, 155);
            this.rchDes.TabIndex = 11;
            this.rchDes.Text = "";
            // 
            // rchdescription
            // 
            this.rchdescription.AutoSize = true;
            this.rchdescription.Location = new System.Drawing.Point(28, 141);
            this.rchdescription.Name = "rchdescription";
            this.rchdescription.Size = new System.Drawing.Size(50, 13);
            this.rchdescription.TabIndex = 10;
            this.rchdescription.Text = "Açıklama";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(162, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rchDes);
            this.Controls.Add(this.rchdescription);
            this.Controls.Add(this.textMemberSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "frmAuthor";
            this.Text = "frmAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label txtCategoryName;
        private System.Windows.Forms.TextBox textMemberSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchDes;
        private System.Windows.Forms.Label rchdescription;
        private System.Windows.Forms.Button btnSave;
    }
}