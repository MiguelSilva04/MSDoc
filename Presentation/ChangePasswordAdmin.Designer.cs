namespace MSDOC
{
    partial class ChangePasswordAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.text_newpass = new System.Windows.Forms.TextBox();
            this.text_confirmnewpass = new System.Windows.Forms.TextBox();
            this.comboBox_email = new System.Windows.Forms.ComboBox();
            this.text_oldpass = new System.Windows.Forms.TextBox();
            this.checkBox_Show_Hide_ConfirmNewPass = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.submitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.confirmnewpassErrorLabel = new System.Windows.Forms.Label();
            this.newpassErrorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSDOCSCHOOLDataSetEmail = new MSDOC.MSDOCSCHOOLDataSetEmail();
            this.usersTableAdapter = new MSDOC.MSDOCSCHOOLDataSetEmailTableAdapters.UsersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 316);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MSDOC.Properties.Resources._360_F_465915770_HsbKRqP7PQnoGnNn5dyYRlODYZQI9PNu;
            this.pictureBox1.Location = new System.Drawing.Point(53, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 38);
            this.panel2.TabIndex = 14;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(233, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mudar Palavra-Passe";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 316);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 501);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.text_newpass);
            this.panel4.Controls.Add(this.text_confirmnewpass);
            this.panel4.Controls.Add(this.comboBox_email);
            this.panel4.Controls.Add(this.text_oldpass);
            this.panel4.Controls.Add(this.checkBox_Show_Hide_ConfirmNewPass);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.errorLabel);
            this.panel4.Controls.Add(this.submitBtn);
            this.panel4.Controls.Add(this.confirmnewpassErrorLabel);
            this.panel4.Controls.Add(this.newpassErrorLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 501);
            this.panel4.TabIndex = 0;
            // 
            // text_newpass
            // 
            this.text_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_newpass.Location = new System.Drawing.Point(41, 210);
            this.text_newpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_newpass.Name = "text_newpass";
            this.text_newpass.Size = new System.Drawing.Size(532, 26);
            this.text_newpass.TabIndex = 2;
            this.text_newpass.UseSystemPasswordChar = true;
            // 
            // text_confirmnewpass
            // 
            this.text_confirmnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_confirmnewpass.Location = new System.Drawing.Point(41, 304);
            this.text_confirmnewpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_confirmnewpass.Name = "text_confirmnewpass";
            this.text_confirmnewpass.Size = new System.Drawing.Size(532, 26);
            this.text_confirmnewpass.TabIndex = 3;
            this.text_confirmnewpass.UseSystemPasswordChar = true;
            // 
            // comboBox_email
            // 
            this.comboBox_email.BackColor = System.Drawing.Color.White;
            this.comboBox_email.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_email.FormattingEnabled = true;
            this.comboBox_email.IntegralHeight = false;
            this.comboBox_email.ItemHeight = 20;
            this.comboBox_email.Location = new System.Drawing.Point(40, 47);
            this.comboBox_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_email.Name = "comboBox_email";
            this.comboBox_email.Size = new System.Drawing.Size(529, 28);
            this.comboBox_email.TabIndex = 0;
            this.comboBox_email.SelectionChangeCommitted += new System.EventHandler(this.comboBox_email_SelectionChangeCommitted);
            // 
            // text_oldpass
            // 
            this.text_oldpass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.text_oldpass.BackColor = System.Drawing.Color.White;
            this.text_oldpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_oldpass.Location = new System.Drawing.Point(40, 129);
            this.text_oldpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_oldpass.MaxLength = 20;
            this.text_oldpass.Multiline = true;
            this.text_oldpass.Name = "text_oldpass";
            this.text_oldpass.Size = new System.Drawing.Size(528, 34);
            this.text_oldpass.TabIndex = 1;
            this.text_oldpass.UseSystemPasswordChar = true;
            // 
            // checkBox_Show_Hide_ConfirmNewPass
            // 
            this.checkBox_Show_Hide_ConfirmNewPass.AutoSize = true;
            this.checkBox_Show_Hide_ConfirmNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Show_Hide_ConfirmNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.checkBox_Show_Hide_ConfirmNewPass.Location = new System.Drawing.Point(579, 308);
            this.checkBox_Show_Hide_ConfirmNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Show_Hide_ConfirmNewPass.Name = "checkBox_Show_Hide_ConfirmNewPass";
            this.checkBox_Show_Hide_ConfirmNewPass.Size = new System.Drawing.Size(83, 23);
            this.checkBox_Show_Hide_ConfirmNewPass.TabIndex = 4;
            this.checkBox_Show_Hide_ConfirmNewPass.Text = "Mostrar";
            this.checkBox_Show_Hide_ConfirmNewPass.UseVisualStyleBackColor = true;
            this.checkBox_Show_Hide_ConfirmNewPass.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_ConfirmNewPass_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MSDOC.Properties.Resources.arrow_87_256__1_;
            this.pictureBox2.Location = new System.Drawing.Point(7, 471);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(81, 459);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 24);
            this.errorLabel.TabIndex = 6;
            // 
            // submitBtn
            // 
            this.submitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(231, 363);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(240, 55);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submeter";
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // confirmnewpassErrorLabel
            // 
            this.confirmnewpassErrorLabel.AutoSize = true;
            this.confirmnewpassErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmnewpassErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmnewpassErrorLabel.Location = new System.Drawing.Point(41, 340);
            this.confirmnewpassErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmnewpassErrorLabel.Name = "confirmnewpassErrorLabel";
            this.confirmnewpassErrorLabel.Size = new System.Drawing.Size(250, 16);
            this.confirmnewpassErrorLabel.TabIndex = 31;
            this.confirmnewpassErrorLabel.Text = "As palavras passes não coincidem";
            this.confirmnewpassErrorLabel.Visible = false;
            // 
            // newpassErrorLabel
            // 
            this.newpassErrorLabel.AutoSize = true;
            this.newpassErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newpassErrorLabel.Location = new System.Drawing.Point(37, 246);
            this.newpassErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newpassErrorLabel.Name = "newpassErrorLabel";
            this.newpassErrorLabel.Size = new System.Drawing.Size(250, 16);
            this.newpassErrorLabel.TabIndex = 30;
            this.newpassErrorLabel.Text = "As palavras passes não coincidem";
            this.newpassErrorLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Confirme a sua nova palavra passe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Insira a sua nova palavra passe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Insira a sua antiga palavra passe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Insira o email:";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.mSDOCSCHOOLDataSetEmail;
            // 
            // mSDOCSCHOOLDataSetEmail
            // 
            this.mSDOCSCHOOLDataSetEmail.DataSetName = "MSDOCSCHOOLDataSetEmail";
            this.mSDOCSCHOOLDataSetEmail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ChangePasswordAdmin
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 817);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ChangePasswordAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePasswordAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private MSDOCSCHOOLDataSetEmail mSDOCSCHOOLDataSetEmail;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MSDOCSCHOOLDataSetEmailTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label errorLabel;
        private Guna.UI2.WinForms.Guna2Button submitBtn;
        private System.Windows.Forms.Label confirmnewpassErrorLabel;
        private System.Windows.Forms.Label newpassErrorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide_ConfirmNewPass;
        private System.Windows.Forms.TextBox text_oldpass;
        private System.Windows.Forms.ComboBox comboBox_email;
        private System.Windows.Forms.TextBox text_confirmnewpass;
        private System.Windows.Forms.TextBox text_newpass;
    }
}