
namespace MSDOC
{
    partial class AddAdminUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdminUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_Show_Hide_ConfirmNewPass = new System.Windows.Forms.CheckBox();
            this.confirmnewpassErrorLabel = new System.Windows.Forms.Label();
            this.newpassErrorLabel = new System.Windows.Forms.Label();
            this.textBox_confirmnewpass = new System.Windows.Forms.TextBox();
            this.confirmnewpassLabel = new System.Windows.Forms.Label();
            this.textBox_NRegisto = new System.Windows.Forms.MaskedTextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBox_newpass = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newpassLabel = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridView_users = new Guna.UI2.WinForms.Guna2DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSDOCSCHOOLDataSetUsers = new MSDOC.MSDOCSCHOOLDataSetUsers();
            this.usersTableAdapter = new MSDOC.MSDOCSCHOOLDataSetUsersTableAdapters.UsersTableAdapter();
            this.button_delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 61);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(3, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 34;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1105, 10);
            this.panel5.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adicionar Utilizador";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.checkBox_Show_Hide_ConfirmNewPass);
            this.panel2.Controls.Add(this.confirmnewpassErrorLabel);
            this.panel2.Controls.Add(this.newpassErrorLabel);
            this.panel2.Controls.Add(this.textBox_confirmnewpass);
            this.panel2.Controls.Add(this.confirmnewpassLabel);
            this.panel2.Controls.Add(this.textBox_NRegisto);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.textBox_newpass);
            this.panel2.Controls.Add(this.textBox_Email);
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.newpassLabel);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Controls.Add(this.button_upload);
            this.panel2.Controls.Add(this.pictureBox_user);
            this.panel2.Controls.Add(this.textBox_Name);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 259);
            this.panel2.TabIndex = 14;
            // 
            // checkBox_Show_Hide_ConfirmNewPass
            // 
            this.checkBox_Show_Hide_ConfirmNewPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox_Show_Hide_ConfirmNewPass.AutoSize = true;
            this.checkBox_Show_Hide_ConfirmNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Show_Hide_ConfirmNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.checkBox_Show_Hide_ConfirmNewPass.Location = new System.Drawing.Point(834, 145);
            this.checkBox_Show_Hide_ConfirmNewPass.Name = "checkBox_Show_Hide_ConfirmNewPass";
            this.checkBox_Show_Hide_ConfirmNewPass.Size = new System.Drawing.Size(83, 23);
            this.checkBox_Show_Hide_ConfirmNewPass.TabIndex = 9;
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
            this.confirmnewpassErrorLabel.Location = new System.Drawing.Point(556, 175);
            this.confirmnewpassErrorLabel.Name = "confirmnewpassErrorLabel";
            this.confirmnewpassErrorLabel.Size = new System.Drawing.Size(250, 16);
            this.confirmnewpassErrorLabel.TabIndex = 41;
            this.confirmnewpassErrorLabel.Text = "As palavras passes não coincidem";
            this.confirmnewpassErrorLabel.Visible = false;
            // 
            // newpassErrorLabel
            // 
            this.newpassErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newpassErrorLabel.AutoSize = true;
            this.newpassErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newpassErrorLabel.Location = new System.Drawing.Point(556, 118);
            this.newpassErrorLabel.Name = "newpassErrorLabel";
            this.newpassErrorLabel.Size = new System.Drawing.Size(250, 16);
            this.newpassErrorLabel.TabIndex = 40;
            this.newpassErrorLabel.Text = "As palavras passes não coincidem";
            this.newpassErrorLabel.Visible = false;
            // 
            // textBox_confirmnewpass
            // 
            this.textBox_confirmnewpass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_confirmnewpass.Location = new System.Drawing.Point(532, 142);
            this.textBox_confirmnewpass.MaxLength = 20;
            this.textBox_confirmnewpass.Name = "textBox_confirmnewpass";
            this.textBox_confirmnewpass.Size = new System.Drawing.Size(296, 27);
            this.textBox_confirmnewpass.TabIndex = 4;
            this.textBox_confirmnewpass.UseSystemPasswordChar = true;
            // 
            // confirmnewpassLabel
            // 
            this.confirmnewpassLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmnewpassLabel.AutoSize = true;
            this.confirmnewpassLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmnewpassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.confirmnewpassLabel.Location = new System.Drawing.Point(230, 146);
            this.confirmnewpassLabel.Name = "confirmnewpassLabel";
            this.confirmnewpassLabel.Size = new System.Drawing.Size(295, 19);
            this.confirmnewpassLabel.TabIndex = 39;
            this.confirmnewpassLabel.Text = "Confirme a sua nova palavra-passe :";
            // 
            // textBox_NRegisto
            // 
            this.textBox_NRegisto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_NRegisto.Location = new System.Drawing.Point(113, 39);
            this.textBox_NRegisto.Mask = "\\Ad00000";
            this.textBox_NRegisto.Name = "textBox_NRegisto";
            this.textBox_NRegisto.Size = new System.Drawing.Size(125, 27);
            this.textBox_NRegisto.TabIndex = 0;
            this.textBox_NRegisto.ValidatingType = typeof(int);
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.idLabel.Location = new System.Drawing.Point(19, 43);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(93, 19);
            this.idLabel.TabIndex = 37;
            this.idLabel.Text = "Nº Registo :";
            // 
            // textBox_newpass
            // 
            this.textBox_newpass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_newpass.Location = new System.Drawing.Point(532, 89);
            this.textBox_newpass.MaxLength = 20;
            this.textBox_newpass.Name = "textBox_newpass";
            this.textBox_newpass.Size = new System.Drawing.Size(296, 27);
            this.textBox_newpass.TabIndex = 3;
            this.textBox_newpass.UseSystemPasswordChar = true;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Email.Location = new System.Drawing.Point(742, 39);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(221, 27);
            this.textBox_Email.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.emailLabel.Location = new System.Drawing.Point(676, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 19);
            this.emailLabel.TabIndex = 34;
            this.emailLabel.Text = "Email :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 10);
            this.panel3.TabIndex = 32;
            // 
            // newpassLabel
            // 
            this.newpassLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newpassLabel.AutoSize = true;
            this.newpassLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.newpassLabel.Location = new System.Drawing.Point(230, 93);
            this.newpassLabel.Name = "newpassLabel";
            this.newpassLabel.Size = new System.Drawing.Size(296, 19);
            this.newpassLabel.TabIndex = 30;
            this.newpassLabel.Text = "Introduza a sua nova palavra-passe :";
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(555, 212);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(118, 39);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Adicionar";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_clear.BackColor = System.Drawing.Color.Orange;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(431, 212);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(118, 39);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Limpar";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_upload
            // 
            this.button_upload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_upload.BackColor = System.Drawing.Color.Green;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(979, 140);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(118, 51);
            this.button_upload.TabIndex = 5;
            this.button_upload.Text = "Carregar Imagem";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_user.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_user.Location = new System.Drawing.Point(979, 24);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(118, 110);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_user.TabIndex = 26;
            this.pictureBox_user.TabStop = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Name.Location = new System.Drawing.Point(405, 41);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(254, 27);
            this.textBox_Name.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.nameLabel.Location = new System.Drawing.Point(253, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(146, 19);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Nome Completo :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DataGridView_users);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1105, 307);
            this.panel4.TabIndex = 15;
            // 
            // DataGridView_users
            // 
            this.DataGridView_users.AllowUserToAddRows = false;
            this.DataGridView_users.AllowUserToDeleteRows = false;
            this.DataGridView_users.AllowUserToResizeColumns = false;
            this.DataGridView_users.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_users.AutoGenerateColumns = false;
            this.DataGridView_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_users.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_users.ColumnHeadersHeight = 24;
            this.DataGridView_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.posicaoDataGridViewTextBoxColumn,
            this.dataGridViewImageColumn1});
            this.DataGridView_users.DataSource = this.usersBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_users.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_users.EnableHeadersVisualStyles = false;
            this.DataGridView_users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_users.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_users.Name = "DataGridView_users";
            this.DataGridView_users.ReadOnly = true;
            this.DataGridView_users.RowHeadersVisible = false;
            this.DataGridView_users.RowTemplate.Height = 80;
            this.DataGridView_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_users.Size = new System.Drawing.Size(1105, 307);
            this.DataGridView_users.TabIndex = 5;
            this.DataGridView_users.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_users.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_users.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_users.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_users.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_users.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_users.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_users.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_users.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_users.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_users.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_users.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_users.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_users.ThemeStyle.ReadOnly = true;
            this.DataGridView_users.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_users.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_users.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_users.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_users.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_users.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_users.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_student_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "Nº Registo Utilizador";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // posicaoDataGridViewTextBoxColumn
            // 
            this.posicaoDataGridViewTextBoxColumn.DataPropertyName = "Posicao";
            this.posicaoDataGridViewTextBoxColumn.HeaderText = "Posicao";
            this.posicaoDataGridViewTextBoxColumn.Name = "posicaoDataGridViewTextBoxColumn";
            this.posicaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.posicaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Imagem";
            this.dataGridViewImageColumn1.HeaderText = "Imagem";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
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
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Enabled = false;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(679, 212);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(118, 39);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Apagar";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // AddAdminUser
            // 
            this.AcceptButton = this.button_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 627);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddAdminUser";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.NewStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_users;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBox_newpass;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label newpassLabel;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.MaskedTextBox textBox_NRegisto;
        private System.Windows.Forms.TextBox textBox_confirmnewpass;
        private System.Windows.Forms.Label confirmnewpassLabel;
        private MSDOCSCHOOLDataSetUsers mSDOCSCHOOLDataSetUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MSDOCSCHOOLDataSetUsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label confirmnewpassErrorLabel;
        private System.Windows.Forms.Label newpassErrorLabel;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide_ConfirmNewPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button button_delete;
    }
}