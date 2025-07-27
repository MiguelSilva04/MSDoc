
namespace MSDOC
{
    partial class NewTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTeacher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSDOCSCHOOLDataSetProfessorNovo = new MSDOC.MSDOCSCHOOLDataSetProfessorNovo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_NRegisto = new System.Windows.Forms.MaskedTextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.genderLabel = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.pictureBox_student = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.professoresTableAdapter = new MSDOC.MSDOCSCHOOLDataSetProfessorNovoTableAdapters.ProfessoresTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetProfessorNovo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1116, 51);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 14;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(473, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Novo Professor";
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.mSDOCSCHOOLDataSetProfessorNovo;
            // 
            // mSDOCSCHOOLDataSetProfessorNovo
            // 
            this.mSDOCSCHOOLDataSetProfessorNovo.DataSetName = "MSDOCSCHOOLDataSetProfessorNovo";
            this.mSDOCSCHOOLDataSetProfessorNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_NRegisto);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.textBox_phone);
            this.panel2.Controls.Add(this.textBox_Email);
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.comboBoxGender);
            this.panel2.Controls.Add(this.phoneLabel);
            this.panel2.Controls.Add(this.textBox_address);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.genderLabel);
            this.panel2.Controls.Add(this.textBox_Name);
            this.panel2.Controls.Add(this.addressLabel);
            this.panel2.Controls.Add(this.dobLabel);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Controls.Add(this.button_upload);
            this.panel2.Controls.Add(this.pictureBox_student);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 257);
            this.panel2.TabIndex = 14;
            // 
            // textBox_NRegisto
            // 
            this.textBox_NRegisto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_NRegisto.Location = new System.Drawing.Point(120, 19);
            this.textBox_NRegisto.Mask = "\\Pr00000";
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
            this.idLabel.Location = new System.Drawing.Point(26, 23);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(93, 19);
            this.idLabel.TabIndex = 52;
            this.idLabel.Text = "Nº Registo :";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_phone.Location = new System.Drawing.Point(391, 69);
            this.textBox_phone.MaxLength = 9;
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(152, 27);
            this.textBox_phone.TabIndex = 4;
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phone_KeyPress);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Email.Location = new System.Drawing.Point(749, 19);
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
            this.emailLabel.Location = new System.Drawing.Point(683, 23);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 19);
            this.emailLabel.TabIndex = 50;
            this.emailLabel.Text = "Email :";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBoxGender.Location = new System.Drawing.Point(120, 67);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(180, 29);
            this.comboBoxGender.TabIndex = 3;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.phoneLabel.Location = new System.Drawing.Point(308, 72);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(82, 19);
            this.phoneLabel.TabIndex = 49;
            this.phoneLabel.Text = "Telefone :";
            // 
            // textBox_address
            // 
            this.textBox_address.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_address.Location = new System.Drawing.Point(120, 123);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(850, 65);
            this.textBox_address.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker1.Location = new System.Drawing.Point(737, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.genderLabel.Location = new System.Drawing.Point(26, 71);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(75, 19);
            this.genderLabel.TabIndex = 48;
            this.genderLabel.Text = "Género :";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Name.Location = new System.Drawing.Point(406, 21);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(254, 27);
            this.textBox_Name.TabIndex = 1;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.addressLabel.Location = new System.Drawing.Point(26, 127);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(79, 19);
            this.addressLabel.TabIndex = 46;
            this.addressLabel.Text = "Morada :";
            // 
            // dobLabel
            // 
            this.dobLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.dobLabel.Location = new System.Drawing.Point(558, 71);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(176, 19);
            this.dobLabel.TabIndex = 47;
            this.dobLabel.Text = "Data de Nascimento :";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.nameLabel.Location = new System.Drawing.Point(254, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(146, 19);
            this.nameLabel.TabIndex = 45;
            this.nameLabel.Text = "Nome Completo :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(893, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "restrições";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 10);
            this.panel3.TabIndex = 32;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(561, 210);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(118, 39);
            this.button_add.TabIndex = 9;
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
            this.button_clear.Location = new System.Drawing.Point(437, 210);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(118, 39);
            this.button_clear.TabIndex = 8;
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
            this.button_upload.Location = new System.Drawing.Point(986, 137);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(118, 51);
            this.button_upload.TabIndex = 7;
            this.button_upload.Text = "Carregar Imagem";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_student.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_student.Location = new System.Drawing.Point(986, 21);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.Size = new System.Drawing.Size(118, 110);
            this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_student.TabIndex = 26;
            this.pictureBox_student.TabStop = false;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1116, 10);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DataGridView_student);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1116, 309);
            this.panel5.TabIndex = 16;
            // 
            // DataGridView_student
            // 
            this.DataGridView_student.AllowUserToAddRows = false;
            this.DataGridView_student.AllowUserToDeleteRows = false;
            this.DataGridView_student.AllowUserToResizeColumns = false;
            this.DataGridView_student.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_student.AutoGenerateColumns = false;
            this.DataGridView_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_student.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_student.ColumnHeadersHeight = 24;
            this.DataGridView_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.emailDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.DataGridView_student.DataSource = this.professoresBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_student.EnableHeadersVisualStyles = false;
            this.DataGridView_student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_student.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_student.Name = "DataGridView_student";
            this.DataGridView_student.ReadOnly = true;
            this.DataGridView_student.RowHeadersVisible = false;
            this.DataGridView_student.RowTemplate.Height = 80;
            this.DataGridView_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_student.Size = new System.Drawing.Size(1116, 309);
            this.DataGridView_student.TabIndex = 4;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_student.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_student.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_student.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_student.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_student.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_student.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_student.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_student.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_student.ThemeStyle.ReadOnly = true;
            this.DataGridView_student.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_student.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_student.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_student.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_student.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_student.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_student.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProfessorId";
            this.dataGridViewTextBoxColumn1.HeaderText = "NºRegisto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 108;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Nascimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn4.HeaderText = "Género";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 92;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn6.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Imagem";
            this.dataGridViewImageColumn1.HeaderText = "Imagem";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // NewTeacher
            // 
            this.AcceptButton = this.button_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 627);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewTeacher";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetProfessorNovo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private MSDOCSCHOOLDataSetProfessorNovo mSDOCSCHOOLDataSetProfessorNovo;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private MSDOCSCHOOLDataSetProfessorNovoTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.MaskedTextBox textBox_NRegisto;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}