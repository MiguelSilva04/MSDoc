namespace Presentation
{
    partial class CoursesStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesStudent));
            this.BackBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.classNameTb = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TNameTb = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IdCb = new MetroFramework.Controls.MetroComboBox();
            this.CoursesStudentsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.alunosTurmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTxt = new MetroFramework.Controls.MetroTextBox();
            this.courseNameTb = new MetroFramework.Controls.MetroComboBox();
            this.idErrorLabel = new System.Windows.Forms.Label();
            this.tnameErrorLabel = new System.Windows.Forms.Label();
            this.courseErrorLabel = new System.Windows.Forms.Label();
            this.classErrorLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesStudentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosTurmasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.BackBtn.Location = new System.Drawing.Point(760, 227);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(116, 35);
            this.BackBtn.TabIndex = 63;
            this.BackBtn.Text = "VOLTAR";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Gold;
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.FlatAppearance.BorderSize = 0;
            this.ResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.Black;
            this.ResetBtn.Location = new System.Drawing.Point(587, 227);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(116, 35);
            this.ResetBtn.TabIndex = 62;
            this.ResetBtn.Text = "APAGAR";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.EditBtn.Location = new System.Drawing.Point(429, 227);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(116, 35);
            this.EditBtn.TabIndex = 60;
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
            this.AddBtn.Location = new System.Drawing.Point(256, 227);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 35);
            this.AddBtn.TabIndex = 59;
            this.AddBtn.Text = "ADICIONAR";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(778, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 58;
            this.label6.Text = "&Turma";
            // 
            // classNameTb
            // 
            this.classNameTb.FormattingEnabled = true;
            this.classNameTb.ItemHeight = 23;
            this.classNameTb.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Excused"});
            this.classNameTb.Location = new System.Drawing.Point(775, 175);
            this.classNameTb.Name = "classNameTb";
            this.classNameTb.Size = new System.Drawing.Size(202, 29);
            this.classNameTb.TabIndex = 57;
            this.classNameTb.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(551, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 56;
            this.label5.Text = "&Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(43, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 54;
            this.label3.Text = "&Id Aluno";
            // 
            // TNameTb
            // 
            // 
            // 
            // 
            this.TNameTb.CustomButton.Image = null;
            this.TNameTb.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.TNameTb.CustomButton.Name = "";
            this.TNameTb.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TNameTb.CustomButton.TabIndex = 1;
            this.TNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TNameTb.CustomButton.UseSelectable = true;
            this.TNameTb.CustomButton.Visible = false;
            this.TNameTb.Enabled = false;
            this.TNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TNameTb.Lines = new string[0];
            this.TNameTb.Location = new System.Drawing.Point(287, 175);
            this.TNameTb.MaxLength = 32767;
            this.TNameTb.Name = "TNameTb";
            this.TNameTb.PasswordChar = '\0';
            this.TNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TNameTb.SelectedText = "";
            this.TNameTb.SelectionLength = 0;
            this.TNameTb.SelectionStart = 0;
            this.TNameTb.ShortcutsEnabled = true;
            this.TNameTb.Size = new System.Drawing.Size(220, 29);
            this.TNameTb.TabIndex = 50;
            this.TNameTb.UseSelectable = true;
            this.TNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(290, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "&Nome Aluno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 48);
            this.panel1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cursos Alunos";
            // 
            // IdCb
            // 
            this.IdCb.FormattingEnabled = true;
            this.IdCb.ItemHeight = 23;
            this.IdCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.IdCb.Location = new System.Drawing.Point(40, 175);
            this.IdCb.Name = "IdCb";
            this.IdCb.Size = new System.Drawing.Size(202, 29);
            this.IdCb.TabIndex = 53;
            this.IdCb.UseSelectable = true;
            this.IdCb.SelectionChangeCommitted += new System.EventHandler(this.StIdCb_SelectionChangeCommitted);
            // 
            // CoursesStudentsDGV
            // 
            this.CoursesStudentsDGV.AllowUserToAddRows = false;
            this.CoursesStudentsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.CoursesStudentsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CoursesStudentsDGV.AutoGenerateColumns = false;
            this.CoursesStudentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoursesStudentsDGV.BackgroundColor = System.Drawing.Color.White;
            this.CoursesStudentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CoursesStudentsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CoursesStudentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CoursesStudentsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CoursesStudentsDGV.ColumnHeadersHeight = 25;
            this.CoursesStudentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.dataGridViewTextBoxColumn1,
            this.alunoIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.CoursesStudentsDGV.DataSource = this.alunosTurmasBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CoursesStudentsDGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.CoursesStudentsDGV.EnableHeadersVisualStyles = false;
            this.CoursesStudentsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CoursesStudentsDGV.Location = new System.Drawing.Point(10, 297);
            this.CoursesStudentsDGV.Name = "CoursesStudentsDGV";
            this.CoursesStudentsDGV.ReadOnly = true;
            this.CoursesStudentsDGV.RowHeadersVisible = false;
            this.CoursesStudentsDGV.RowHeadersWidth = 54;
            this.CoursesStudentsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CoursesStudentsDGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.CoursesStudentsDGV.RowTemplate.Height = 50;
            this.CoursesStudentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CoursesStudentsDGV.Size = new System.Drawing.Size(1125, 298);
            this.CoursesStudentsDGV.TabIndex = 101;
            this.CoursesStudentsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CoursesStudentsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CoursesStudentsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CoursesStudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CoursesStudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CoursesStudentsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CoursesStudentsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CoursesStudentsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.CoursesStudentsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CoursesStudentsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesStudentsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Blue;
            this.CoursesStudentsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CoursesStudentsDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.CoursesStudentsDGV.ThemeStyle.ReadOnly = true;
            this.CoursesStudentsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CoursesStudentsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CoursesStudentsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesStudentsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CoursesStudentsDGV.ThemeStyle.RowsStyle.Height = 50;
            this.CoursesStudentsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CoursesStudentsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CoursesStudentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesTeachersDGV_CellContentClick);
            // 
            // alunosTurmasBindingSource
            // 
            this.alunosTurmasBindingSource.DataMember = "AlunosTurmas";
            // 
            // mSDOCSCHOOLDataSetCursosAlunos
            // 
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTxt);
            this.groupBox1.Location = new System.Drawing.Point(429, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(304, 47);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchTxt
            // 
            // 
            // 
            // 
            this.searchTxt.CustomButton.Image = null;
            this.searchTxt.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.searchTxt.CustomButton.Name = "";
            this.searchTxt.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.searchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTxt.CustomButton.TabIndex = 1;
            this.searchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTxt.CustomButton.UseSelectable = true;
            this.searchTxt.CustomButton.Visible = false;
            this.searchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchTxt.Lines = new string[0];
            this.searchTxt.Location = new System.Drawing.Point(3, 23);
            this.searchTxt.MaxLength = 32767;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTxt.SelectedText = "";
            this.searchTxt.SelectionLength = 0;
            this.searchTxt.SelectionStart = 0;
            this.searchTxt.ShortcutsEnabled = true;
            this.searchTxt.Size = new System.Drawing.Size(298, 21);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.UseSelectable = true;
            this.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // courseNameTb
            // 
            this.courseNameTb.FormattingEnabled = true;
            this.courseNameTb.ItemHeight = 23;
            this.courseNameTb.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Excused"});
            this.courseNameTb.Location = new System.Drawing.Point(551, 175);
            this.courseNameTb.Name = "courseNameTb";
            this.courseNameTb.Size = new System.Drawing.Size(202, 29);
            this.courseNameTb.TabIndex = 155;
            this.courseNameTb.UseSelectable = true;
            // 
            // idErrorLabel
            // 
            this.idErrorLabel.AutoSize = true;
            this.idErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.idErrorLabel.Location = new System.Drawing.Point(218, 148);
            this.idErrorLabel.Name = "idErrorLabel";
            this.idErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.idErrorLabel.TabIndex = 156;
            this.idErrorLabel.Text = "*";
            this.idErrorLabel.Visible = false;
            // 
            // tnameErrorLabel
            // 
            this.tnameErrorLabel.AutoSize = true;
            this.tnameErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnameErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.tnameErrorLabel.Location = new System.Drawing.Point(483, 148);
            this.tnameErrorLabel.Name = "tnameErrorLabel";
            this.tnameErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.tnameErrorLabel.TabIndex = 157;
            this.tnameErrorLabel.Text = "*";
            this.tnameErrorLabel.Visible = false;
            // 
            // courseErrorLabel
            // 
            this.courseErrorLabel.AutoSize = true;
            this.courseErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.courseErrorLabel.Location = new System.Drawing.Point(729, 148);
            this.courseErrorLabel.Name = "courseErrorLabel";
            this.courseErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.courseErrorLabel.TabIndex = 158;
            this.courseErrorLabel.Text = "*";
            this.courseErrorLabel.Visible = false;
            // 
            // classErrorLabel
            // 
            this.classErrorLabel.AutoSize = true;
            this.classErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.classErrorLabel.Location = new System.Drawing.Point(953, 148);
            this.classErrorLabel.Name = "classErrorLabel";
            this.classErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.classErrorLabel.TabIndex = 159;
            this.classErrorLabel.Text = "*";
            this.classErrorLabel.Visible = false;
            // 
            // alunosTurmasTableAdapter
            // 
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1125, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // alunoIdDataGridViewTextBoxColumn
            // 
            this.alunoIdDataGridViewTextBoxColumn.DataPropertyName = "AlunoId";
            this.alunoIdDataGridViewTextBoxColumn.HeaderText = "Nº Registo Aluno";
            this.alunoIdDataGridViewTextBoxColumn.Name = "alunoIdDataGridViewTextBoxColumn";
            this.alunoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TurmaNome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Da Turma";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CursoNome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome Do Curso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // CoursesStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 607);
            this.Controls.Add(this.classErrorLabel);
            this.Controls.Add(this.courseErrorLabel);
            this.Controls.Add(this.tnameErrorLabel);
            this.Controls.Add(this.idErrorLabel);
            this.Controls.Add(this.courseNameTb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CoursesStudentsDGV);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classNameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IdCb);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CoursesStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendances";
            this.Load += new System.EventHandler(this.AttendancesTeachers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesStudentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosTurmasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox classNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox TNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox IdCb;
        private Guna.UI2.WinForms.Guna2DataGridView CoursesStudentsDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox searchTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmaNomeDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroComboBox courseNameTb;
        private System.Windows.Forms.Label idErrorLabel;
        private System.Windows.Forms.Label tnameErrorLabel;
        private System.Windows.Forms.Label courseErrorLabel;
        private System.Windows.Forms.Label classErrorLabel;
        private System.Windows.Forms.BindingSource alunosTurmasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}