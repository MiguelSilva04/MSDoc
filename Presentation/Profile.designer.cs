
namespace MSDOC
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.panelchangepass = new System.Windows.Forms.Panel();
            this.checkBox_Show_Hide_ConfirmNewPass = new System.Windows.Forms.CheckBox();
            this.confirmnewpassErrorLabel = new System.Windows.Forms.Label();
            this.newpassErrorLabel = new System.Windows.Forms.Label();
            this.textBox_confirmnewpass = new System.Windows.Forms.TextBox();
            this.confirmnewpassLabel = new System.Windows.Forms.Label();
            this.textBox_newpass = new System.Windows.Forms.TextBox();
            this.newpassLabel = new System.Windows.Forms.Label();
            this.panelmain = new System.Windows.Forms.Panel();
            this.buttonchange = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.button_upload = new System.Windows.Forms.Button();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSDOCSCHOOLDataSetUsers = new MSDOC.MSDOCSCHOOLDataSetUsers();
            this.usersTableAdapter = new MSDOC.MSDOCSCHOOLDataSetUsersTableAdapters.UsersTableAdapter();
            this.textBox_NRegisto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelbutton.SuspendLayout();
            this.panelchangepass.SuspendLayout();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(3, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 34;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "O meu Perfil";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelbutton);
            this.panel2.Controls.Add(this.panelchangepass);
            this.panel2.Controls.Add(this.panelmain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 588);
            this.panel2.TabIndex = 14;
            // 
            // panelbutton
            // 
            this.panelbutton.Controls.Add(this.button_update);
            this.panelbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbutton.Location = new System.Drawing.Point(0, 536);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Size = new System.Drawing.Size(690, 58);
            this.panelbutton.TabIndex = 49;
            // 
            // button_update
            // 
            this.button_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_update.BackColor = System.Drawing.Color.OrangeRed;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(295, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(118, 39);
            this.button_update.TabIndex = 0;
            this.button_update.Text = "Atualizar";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // panelchangepass
            // 
            this.panelchangepass.Controls.Add(this.checkBox_Show_Hide_ConfirmNewPass);
            this.panelchangepass.Controls.Add(this.confirmnewpassErrorLabel);
            this.panelchangepass.Controls.Add(this.newpassErrorLabel);
            this.panelchangepass.Controls.Add(this.textBox_confirmnewpass);
            this.panelchangepass.Controls.Add(this.confirmnewpassLabel);
            this.panelchangepass.Controls.Add(this.textBox_newpass);
            this.panelchangepass.Controls.Add(this.newpassLabel);
            this.panelchangepass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelchangepass.Location = new System.Drawing.Point(0, 423);
            this.panelchangepass.Name = "panelchangepass";
            this.panelchangepass.Size = new System.Drawing.Size(690, 113);
            this.panelchangepass.TabIndex = 48;
            this.panelchangepass.Visible = false;
            // 
            // checkBox_Show_Hide_ConfirmNewPass
            // 
            this.checkBox_Show_Hide_ConfirmNewPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox_Show_Hide_ConfirmNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Show_Hide_ConfirmNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.checkBox_Show_Hide_ConfirmNewPass.Location = new System.Drawing.Point(603, 61);
            this.checkBox_Show_Hide_ConfirmNewPass.Name = "checkBox_Show_Hide_ConfirmNewPass";
            this.checkBox_Show_Hide_ConfirmNewPass.Size = new System.Drawing.Size(83, 23);
            this.checkBox_Show_Hide_ConfirmNewPass.TabIndex = 2;
            this.checkBox_Show_Hide_ConfirmNewPass.Text = "Mostrar";
            this.checkBox_Show_Hide_ConfirmNewPass.UseVisualStyleBackColor = true;
            this.checkBox_Show_Hide_ConfirmNewPass.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_ConfirmNewPass_CheckedChanged);
            // 
            // confirmnewpassErrorLabel
            // 
            this.confirmnewpassErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmnewpassErrorLabel.AutoSize = true;
            this.confirmnewpassErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmnewpassErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmnewpassErrorLabel.Location = new System.Drawing.Point(329, 91);
            this.confirmnewpassErrorLabel.Name = "confirmnewpassErrorLabel";
            this.confirmnewpassErrorLabel.Size = new System.Drawing.Size(250, 16);
            this.confirmnewpassErrorLabel.TabIndex = 49;
            this.confirmnewpassErrorLabel.Text = "As palavras passes não coincidem";
            this.confirmnewpassErrorLabel.Visible = false;
            // 
            // newpassErrorLabel
            // 
            this.newpassErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newpassErrorLabel.AutoSize = true;
            this.newpassErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newpassErrorLabel.Location = new System.Drawing.Point(329, 34);
            this.newpassErrorLabel.Name = "newpassErrorLabel";
            this.newpassErrorLabel.Size = new System.Drawing.Size(250, 16);
            this.newpassErrorLabel.TabIndex = 48;
            this.newpassErrorLabel.Text = "As palavras passes não coincidem";
            this.newpassErrorLabel.Visible = false;
            // 
            // textBox_confirmnewpass
            // 
            this.textBox_confirmnewpass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_confirmnewpass.Location = new System.Drawing.Point(305, 58);
            this.textBox_confirmnewpass.MaxLength = 20;
            this.textBox_confirmnewpass.Name = "textBox_confirmnewpass";
            this.textBox_confirmnewpass.Size = new System.Drawing.Size(296, 27);
            this.textBox_confirmnewpass.TabIndex = 1;
            this.textBox_confirmnewpass.UseSystemPasswordChar = true;
            // 
            // confirmnewpassLabel
            // 
            this.confirmnewpassLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmnewpassLabel.AutoSize = true;
            this.confirmnewpassLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmnewpassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.confirmnewpassLabel.Location = new System.Drawing.Point(5, 62);
            this.confirmnewpassLabel.Name = "confirmnewpassLabel";
            this.confirmnewpassLabel.Size = new System.Drawing.Size(295, 19);
            this.confirmnewpassLabel.TabIndex = 47;
            this.confirmnewpassLabel.Text = "Confirme a sua nova palavra-passe :";
            // 
            // textBox_newpass
            // 
            this.textBox_newpass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_newpass.Location = new System.Drawing.Point(305, 5);
            this.textBox_newpass.MaxLength = 20;
            this.textBox_newpass.Name = "textBox_newpass";
            this.textBox_newpass.Size = new System.Drawing.Size(296, 27);
            this.textBox_newpass.TabIndex = 0;
            this.textBox_newpass.UseSystemPasswordChar = true;
            // 
            // newpassLabel
            // 
            this.newpassLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newpassLabel.AutoSize = true;
            this.newpassLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.newpassLabel.Location = new System.Drawing.Point(5, 9);
            this.newpassLabel.Name = "newpassLabel";
            this.newpassLabel.Size = new System.Drawing.Size(296, 19);
            this.newpassLabel.TabIndex = 45;
            this.newpassLabel.Text = "Introduza a sua nova palavra-passe :";
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.textBox_NRegisto);
            this.panelmain.Controls.Add(this.buttonchange);
            this.panelmain.Controls.Add(this.textBox_password);
            this.panelmain.Controls.Add(this.label1);
            this.panelmain.Controls.Add(this.idLabel);
            this.panelmain.Controls.Add(this.textBox_Email);
            this.panelmain.Controls.Add(this.emailLabel);
            this.panelmain.Controls.Add(this.button_upload);
            this.panelmain.Controls.Add(this.pictureBox_user);
            this.panelmain.Controls.Add(this.textBox_Name);
            this.panelmain.Controls.Add(this.nameLabel);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(690, 423);
            this.panelmain.TabIndex = 47;
            // 
            // buttonchange
            // 
            this.buttonchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonchange.FlatAppearance.BorderSize = 0;
            this.buttonchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonchange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.buttonchange.Location = new System.Drawing.Point(604, 383);
            this.buttonchange.Name = "buttonchange";
            this.buttonchange.Size = new System.Drawing.Size(83, 27);
            this.buttonchange.TabIndex = 4;
            this.buttonchange.Text = "Mudar";
            this.buttonchange.UseVisualStyleBackColor = true;
            this.buttonchange.Click += new System.EventHandler(this.buttonchange_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_password.Enabled = false;
            this.textBox_password.Location = new System.Drawing.Point(306, 383);
            this.textBox_password.MaxLength = 20;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(296, 27);
            this.textBox_password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(6, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Palavra-passe:";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.idLabel.Location = new System.Drawing.Point(6, 285);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(93, 19);
            this.idLabel.TabIndex = 54;
            this.idLabel.Text = "Nº Registo :";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Email.Location = new System.Drawing.Point(306, 350);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(295, 27);
            this.textBox_Email.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.emailLabel.Location = new System.Drawing.Point(6, 354);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 19);
            this.emailLabel.TabIndex = 53;
            this.emailLabel.Text = "Email :";
            // 
            // button_upload
            // 
            this.button_upload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_upload.BackColor = System.Drawing.Color.Green;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(286, 204);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(118, 51);
            this.button_upload.TabIndex = 5;
            this.button_upload.Text = "Carregar Imagem";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click_1);
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_user.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_user.Location = new System.Drawing.Point(200, 12);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(291, 186);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_user.TabIndex = 52;
            this.pictureBox_user.TabStop = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Name.Location = new System.Drawing.Point(306, 317);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(295, 27);
            this.textBox_Name.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.nameLabel.Location = new System.Drawing.Point(6, 319);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(146, 19);
            this.nameLabel.TabIndex = 51;
            this.nameLabel.Text = "Nome Completo :";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.mSDOCSCHOOLDataSetUsers;
            // 
            // mSDOCSCHOOLDataSetUsers
            // 
            this.mSDOCSCHOOLDataSetUsers.DataSetName = "MSDOCSCHOOLDataSetUsers";
            this.mSDOCSCHOOLDataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_NRegisto
            // 
            this.textBox_NRegisto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_NRegisto.Enabled = false;
            this.textBox_NRegisto.Location = new System.Drawing.Point(307, 281);
            this.textBox_NRegisto.Name = "textBox_NRegisto";
            this.textBox_NRegisto.Size = new System.Drawing.Size(295, 27);
            this.textBox_NRegisto.TabIndex = 56;
            // 
            // Profile
            // 
            this.AcceptButton = this.button_update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.NewStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelbutton.ResumeLayout(false);
            this.panelchangepass.ResumeLayout(false);
            this.panelchangepass.PerformLayout();
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn;
        private System.Windows.Forms.PictureBox backButton;
        private MSDOCSCHOOLDataSetUsers mSDOCSCHOOLDataSetUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MSDOCSCHOOLDataSetUsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Panel panelbutton;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Panel panelchangepass;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide_ConfirmNewPass;
        private System.Windows.Forms.Label confirmnewpassErrorLabel;
        private System.Windows.Forms.Label newpassErrorLabel;
        private System.Windows.Forms.TextBox textBox_confirmnewpass;
        private System.Windows.Forms.Label confirmnewpassLabel;
        private System.Windows.Forms.TextBox textBox_newpass;
        private System.Windows.Forms.Label newpassLabel;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button buttonchange;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox_NRegisto;
    }
}