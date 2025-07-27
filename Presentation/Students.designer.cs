namespace Presentation
{
    partial class Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTxt = new MetroFramework.Controls.MetroTextBox();
            this.AddressTb = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DOBPicker = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.StGenderCb = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StNameTb = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.genderErrorLabel = new System.Windows.Forms.Label();
            this.dobErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.PhoneTb = new MetroFramework.Controls.MetroTextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.StlastNameTb = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.imageErrorLabel = new System.Windows.Forms.Label();
            this.pictureBox_student = new Guna.UI2.WinForms.Guna2PictureBox();
            this.quitBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.quitBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 48);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alunos";
            // 
            // StudentsDGV
            // 
            this.StudentsDGV.AllowUserToAddRows = false;
            this.StudentsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsDGV.AutoGenerateColumns = false;
            this.StudentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsDGV.BackgroundColor = System.Drawing.Color.White;
            this.StudentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsDGV.ColumnHeadersHeight = 25;
            this.StudentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.StudentsDGV.DataSource = this.alunosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentsDGV.EnableHeadersVisualStyles = false;
            this.StudentsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentsDGV.Location = new System.Drawing.Point(0, 309);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.ReadOnly = true;
            this.StudentsDGV.RowHeadersVisible = false;
            this.StudentsDGV.RowHeadersWidth = 54;
            this.StudentsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentsDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StudentsDGV.RowTemplate.Height = 50;
            this.StudentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsDGV.Size = new System.Drawing.Size(1235, 370);
            this.StudentsDGV.TabIndex = 25;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StudentsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.StudentsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StudentsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Blue;
            this.StudentsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentsDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.StudentsDGV.ThemeStyle.ReadOnly = true;
            this.StudentsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentsDGV.ThemeStyle.RowsStyle.Height = 50;
            this.StudentsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDGV_CellContentClick);
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            // 
            // mSDOCSCHOOLDataSetAlunos
            // 
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTxt);
            this.groupBox1.Location = new System.Drawing.Point(480, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(251, 42);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchTxt
            // 
            // 
            // 
            // 
            this.searchTxt.CustomButton.Image = null;
            this.searchTxt.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.searchTxt.CustomButton.Name = "";
            this.searchTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTxt.CustomButton.TabIndex = 1;
            this.searchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTxt.CustomButton.UseSelectable = true;
            this.searchTxt.CustomButton.Visible = false;
            this.searchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchTxt.Lines = new string[0];
            this.searchTxt.Location = new System.Drawing.Point(3, 16);
            this.searchTxt.MaxLength = 32767;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTxt.SelectedText = "";
            this.searchTxt.SelectionLength = 0;
            this.searchTxt.SelectionStart = 0;
            this.searchTxt.ShortcutsEnabled = true;
            this.searchTxt.Size = new System.Drawing.Size(245, 23);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.UseSelectable = true;
            this.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // AddressTb
            // 
            // 
            // 
            // 
            this.AddressTb.CustomButton.Image = null;
            this.AddressTb.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.AddressTb.CustomButton.Name = "";
            this.AddressTb.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.AddressTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddressTb.CustomButton.TabIndex = 1;
            this.AddressTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddressTb.CustomButton.UseSelectable = true;
            this.AddressTb.CustomButton.Visible = false;
            this.AddressTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.AddressTb.Lines = new string[0];
            this.AddressTb.Location = new System.Drawing.Point(674, 138);
            this.AddressTb.MaxLength = 32767;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.PasswordChar = '\0';
            this.AddressTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddressTb.SelectedText = "";
            this.AddressTb.SelectionLength = 0;
            this.AddressTb.SelectionStart = 0;
            this.AddressTb.ShortcutsEnabled = true;
            this.AddressTb.Size = new System.Drawing.Size(273, 29);
            this.AddressTb.TabIndex = 81;
            this.AddressTb.UseSelectable = true;
            this.AddressTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddressTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(677, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 26);
            this.label8.TabIndex = 80;
            this.label8.Text = "&Morada";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Gold;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.Black;
            this.BackBtn.Location = new System.Drawing.Point(763, 254);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(116, 35);
            this.BackBtn.TabIndex = 79;
            this.BackBtn.Text = "VOLTAR";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Gold;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.Location = new System.Drawing.Point(623, 254);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(116, 35);
            this.DeleteBtn.TabIndex = 78;
            this.DeleteBtn.Text = "APAGAR";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Gold;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.Black;
            this.EditBtn.Location = new System.Drawing.Point(488, 254);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(116, 35);
            this.EditBtn.TabIndex = 77;
            this.EditBtn.Text = "EDITAR";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Gold;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(314, 254);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(133, 35);
            this.AddBtn.TabIndex = 76;
            this.AddBtn.Text = "ADICIONAR";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(677, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 26);
            this.label5.TabIndex = 73;
            this.label5.Text = "&Data de Nascimento";
            // 
            // DOBPicker
            // 
            this.DOBPicker.Location = new System.Drawing.Point(674, 208);
            this.DOBPicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(273, 29);
            this.DOBPicker.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(428, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 71;
            this.label3.Text = "&Género";
            // 
            // StGenderCb
            // 
            this.StGenderCb.FormattingEnabled = true;
            this.StGenderCb.ItemHeight = 23;
            this.StGenderCb.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.StGenderCb.Location = new System.Drawing.Point(426, 208);
            this.StGenderCb.Name = "StGenderCb";
            this.StGenderCb.Size = new System.Drawing.Size(210, 29);
            this.StGenderCb.TabIndex = 70;
            this.StGenderCb.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(190, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 68;
            this.label1.Text = "&Telefone";
            // 
            // StNameTb
            // 
            // 
            // 
            // 
            this.StNameTb.CustomButton.Image = null;
            this.StNameTb.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.StNameTb.CustomButton.Name = "";
            this.StNameTb.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.StNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StNameTb.CustomButton.TabIndex = 1;
            this.StNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StNameTb.CustomButton.UseSelectable = true;
            this.StNameTb.CustomButton.Visible = false;
            this.StNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.StNameTb.Lines = new string[0];
            this.StNameTb.Location = new System.Drawing.Point(187, 138);
            this.StNameTb.MaxLength = 32767;
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.PasswordChar = '\0';
            this.StNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StNameTb.SelectedText = "";
            this.StNameTb.SelectionLength = 0;
            this.StNameTb.SelectionStart = 0;
            this.StNameTb.ShortcutsEnabled = true;
            this.StNameTb.Size = new System.Drawing.Size(203, 29);
            this.StNameTb.Style = MetroFramework.MetroColorStyle.Silver;
            this.StNameTb.TabIndex = 67;
            this.StNameTb.UseSelectable = true;
            this.StNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(190, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 66;
            this.label4.Text = "&Nome";
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.nameErrorLabel.Location = new System.Drawing.Point(364, 115);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.nameErrorLabel.TabIndex = 82;
            this.nameErrorLabel.Text = "*";
            this.nameErrorLabel.Visible = false;
            // 
            // genderErrorLabel
            // 
            this.genderErrorLabel.AutoSize = true;
            this.genderErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.genderErrorLabel.Location = new System.Drawing.Point(612, 185);
            this.genderErrorLabel.Name = "genderErrorLabel";
            this.genderErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.genderErrorLabel.TabIndex = 83;
            this.genderErrorLabel.Text = "*";
            this.genderErrorLabel.Visible = false;
            // 
            // dobErrorLabel
            // 
            this.dobErrorLabel.AutoSize = true;
            this.dobErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.dobErrorLabel.Location = new System.Drawing.Point(923, 185);
            this.dobErrorLabel.Name = "dobErrorLabel";
            this.dobErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.dobErrorLabel.TabIndex = 84;
            this.dobErrorLabel.Text = "*";
            this.dobErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.phoneErrorLabel.Location = new System.Drawing.Point(366, 185);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.phoneErrorLabel.TabIndex = 86;
            this.phoneErrorLabel.Text = "*";
            this.phoneErrorLabel.Visible = false;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.addressErrorLabel.Location = new System.Drawing.Point(923, 115);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.addressErrorLabel.TabIndex = 88;
            this.addressErrorLabel.Text = "*";
            this.addressErrorLabel.Visible = false;
            // 
            // PhoneTb
            // 
            // 
            // 
            // 
            this.PhoneTb.CustomButton.Image = null;
            this.PhoneTb.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.PhoneTb.CustomButton.Name = "";
            this.PhoneTb.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.PhoneTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PhoneTb.CustomButton.TabIndex = 1;
            this.PhoneTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PhoneTb.CustomButton.UseSelectable = true;
            this.PhoneTb.CustomButton.Visible = false;
            this.PhoneTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PhoneTb.Lines = new string[0];
            this.PhoneTb.Location = new System.Drawing.Point(190, 208);
            this.PhoneTb.MaxLength = 32767;
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.PasswordChar = '\0';
            this.PhoneTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneTb.SelectedText = "";
            this.PhoneTb.SelectionLength = 0;
            this.PhoneTb.SelectionStart = 0;
            this.PhoneTb.ShortcutsEnabled = true;
            this.PhoneTb.Size = new System.Drawing.Size(204, 29);
            this.PhoneTb.TabIndex = 69;
            this.PhoneTb.UseSelectable = true;
            this.PhoneTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PhoneTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.Gold;
            this.uploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.Black;
            this.uploadBtn.Location = new System.Drawing.Point(1036, 231);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(116, 58);
            this.uploadBtn.TabIndex = 94;
            this.uploadBtn.Text = "Carregar Imagem";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // StlastNameTb
            // 
            // 
            // 
            // 
            this.StlastNameTb.CustomButton.Image = null;
            this.StlastNameTb.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.StlastNameTb.CustomButton.Name = "";
            this.StlastNameTb.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.StlastNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StlastNameTb.CustomButton.TabIndex = 1;
            this.StlastNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StlastNameTb.CustomButton.UseSelectable = true;
            this.StlastNameTb.CustomButton.Visible = false;
            this.StlastNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.StlastNameTb.Lines = new string[0];
            this.StlastNameTb.Location = new System.Drawing.Point(426, 138);
            this.StlastNameTb.MaxLength = 32767;
            this.StlastNameTb.Name = "StlastNameTb";
            this.StlastNameTb.PasswordChar = '\0';
            this.StlastNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StlastNameTb.SelectedText = "";
            this.StlastNameTb.SelectionLength = 0;
            this.StlastNameTb.SelectionStart = 0;
            this.StlastNameTb.ShortcutsEnabled = true;
            this.StlastNameTb.Size = new System.Drawing.Size(210, 29);
            this.StlastNameTb.Style = MetroFramework.MetroColorStyle.Silver;
            this.StlastNameTb.TabIndex = 96;
            this.StlastNameTb.UseSelectable = true;
            this.StlastNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StlastNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(429, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 26);
            this.label7.TabIndex = 95;
            this.label7.Text = "&Ultimo Nome";
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(612, 115);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.lastNameErrorLabel.TabIndex = 97;
            this.lastNameErrorLabel.Text = "*";
            this.lastNameErrorLabel.Visible = false;
            // 
            // imageErrorLabel
            // 
            this.imageErrorLabel.AutoSize = true;
            this.imageErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.imageErrorLabel.Location = new System.Drawing.Point(1155, 233);
            this.imageErrorLabel.Name = "imageErrorLabel";
            this.imageErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.imageErrorLabel.TabIndex = 98;
            this.imageErrorLabel.Text = "*";
            this.imageErrorLabel.Visible = false;
            // 
            // alunosTableAdapter
            // 
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.BackColor = System.Drawing.Color.Blue;
            this.pictureBox_student.FillColor = System.Drawing.Color.Blue;
            this.pictureBox_student.ImageRotate = 0F;
            this.pictureBox_student.Location = new System.Drawing.Point(995, 79);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.Size = new System.Drawing.Size(200, 146);
            this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_student.TabIndex = 93;
            this.pictureBox_student.TabStop = false;
            // 
            // quitBtn
            // 
            this.quitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitBtn.Image = ((System.Drawing.Image)(resources.GetObject("quitBtn.Image")));
            this.quitBtn.Location = new System.Drawing.Point(1215, 2);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(20, 20);
            this.quitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quitBtn.TabIndex = 12;
            this.quitBtn.TabStop = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // snoGV
            // 
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AlunoId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº Registo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UltimoNome";
            this.dataGridViewTextBoxColumn3.HeaderText = "ÚltimoNome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data de Nascimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn5.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn7.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Imagem";
            this.dataGridViewImageColumn1.HeaderText = "Imagem";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1237, 695);
            this.Controls.Add(this.imageErrorLabel);
            this.Controls.Add(this.StlastNameTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.pictureBox_student);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StGenderCb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.genderErrorLabel);
            this.Controls.Add(this.dobErrorLabel);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.StudentsDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addressErrorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox quitBtn;
        private Guna.UI2.WinForms.Guna2DataGridView StudentsDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox searchTxt;
        private MetroFramework.Controls.MetroTextBox AddressTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime DOBPicker;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox StGenderCb;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox StNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label genderErrorLabel;
        private System.Windows.Forms.Label dobErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private MetroFramework.Controls.MetroTextBox PhoneTb;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_student;
        private System.Windows.Forms.Button uploadBtn;
        private MetroFramework.Controls.MetroTextBox StlastNameTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label imageErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}