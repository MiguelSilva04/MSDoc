namespace Presentation
{
    partial class Turmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turmas));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTxt = new MetroFramework.Controls.MetroTextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.classNameTb = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.ClassesDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseNameTb = new MetroFramework.Controls.MetroComboBox();
            this.quitBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turmaNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turmas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTxt);
            this.groupBox1.Location = new System.Drawing.Point(105, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(304, 47);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchTxt
            // 
            // 
            // 
            // 
            this.searchTxt.CustomButton.Image = null;
            this.searchTxt.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.searchTxt.CustomButton.Name = "";
            this.searchTxt.CustomButton.Size = new System.Drawing.Size(23, 23);
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
            this.searchTxt.Size = new System.Drawing.Size(298, 28);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.UseSelectable = true;
            this.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
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
            this.DeleteBtn.Location = new System.Drawing.Point(105, 245);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 35);
            this.DeleteBtn.TabIndex = 145;
            this.DeleteBtn.Text = "APAGAR";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.BackBtn.Location = new System.Drawing.Point(276, 245);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(116, 35);
            this.BackBtn.TabIndex = 146;
            this.BackBtn.Text = "VOLTAR";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.EditBtn.Location = new System.Drawing.Point(276, 192);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(116, 35);
            this.EditBtn.TabIndex = 144;
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
            this.AddBtn.Location = new System.Drawing.Point(105, 192);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 35);
            this.AddBtn.TabIndex = 143;
            this.AddBtn.Text = "ADICIONAR";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // classNameTb
            // 
            // 
            // 
            // 
            this.classNameTb.CustomButton.Image = null;
            this.classNameTb.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.classNameTb.CustomButton.Name = "";
            this.classNameTb.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.classNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.classNameTb.CustomButton.TabIndex = 1;
            this.classNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.classNameTb.CustomButton.UseSelectable = true;
            this.classNameTb.CustomButton.Visible = false;
            this.classNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.classNameTb.Lines = new string[0];
            this.classNameTb.Location = new System.Drawing.Point(18, 142);
            this.classNameTb.MaxLength = 32767;
            this.classNameTb.Name = "classNameTb";
            this.classNameTb.PasswordChar = '\0';
            this.classNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.classNameTb.SelectedText = "";
            this.classNameTb.SelectionLength = 0;
            this.classNameTb.SelectionStart = 0;
            this.classNameTb.ShortcutsEnabled = true;
            this.classNameTb.Size = new System.Drawing.Size(217, 29);
            this.classNameTb.Style = MetroFramework.MetroColorStyle.Silver;
            this.classNameTb.TabIndex = 136;
            this.classNameTb.UseSelectable = true;
            this.classNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.classNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 26);
            this.label4.TabIndex = 135;
            this.label4.Text = "&Nome do Turma";
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.nameErrorLabel.Location = new System.Drawing.Point(207, 113);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(24, 27);
            this.nameErrorLabel.TabIndex = 149;
            this.nameErrorLabel.Text = "*";
            this.nameErrorLabel.Visible = false;
            // 
            // ClassesDGV
            // 
            this.ClassesDGV.AllowUserToAddRows = false;
            this.ClassesDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ClassesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassesDGV.AutoGenerateColumns = false;
            this.ClassesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassesDGV.BackgroundColor = System.Drawing.Color.White;
            this.ClassesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClassesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClassesDGV.ColumnHeadersHeight = 25;
            this.ClassesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.turmaNomeDataGridViewTextBoxColumn,
            this.cursoNomeDataGridViewTextBoxColumn});
            this.ClassesDGV.DataSource = this.turmasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassesDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClassesDGV.EnableHeadersVisualStyles = false;
            this.ClassesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClassesDGV.Location = new System.Drawing.Point(10, 313);
            this.ClassesDGV.Name = "ClassesDGV";
            this.ClassesDGV.ReadOnly = true;
            this.ClassesDGV.RowHeadersVisible = false;
            this.ClassesDGV.RowHeadersWidth = 54;
            this.ClassesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassesDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ClassesDGV.RowTemplate.Height = 50;
            this.ClassesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassesDGV.Size = new System.Drawing.Size(492, 370);
            this.ClassesDGV.TabIndex = 134;
            this.ClassesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ClassesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClassesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClassesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClassesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClassesDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClassesDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClassesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.ClassesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClassesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Blue;
            this.ClassesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClassesDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ClassesDGV.ThemeStyle.ReadOnly = true;
            this.ClassesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ClassesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClassesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClassesDGV.ThemeStyle.RowsStyle.Height = 50;
            this.ClassesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClassesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClassesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassesDGV_CellContentClick);
            // 
            // turmasBindingSource
            // 
            this.turmasBindingSource.DataMember = "Turmas";
            // 
            // mSDOCSCHOOLDataSetTurmas
            // 
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
            this.panel1.Size = new System.Drawing.Size(514, 48);
            this.panel1.TabIndex = 133;
            // 
            // turmasTableAdapter
            // 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(471, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 27);
            this.label1.TabIndex = 156;
            this.label1.Text = "*";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(288, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 26);
            this.label3.TabIndex = 154;
            this.label3.Text = "&Nome do Curso";
            // 
            // courseNameTb
            // 
            this.courseNameTb.FormattingEnabled = true;
            this.courseNameTb.ItemHeight = 23;
            this.courseNameTb.Items.AddRange(new object[] {
            "8Th",
            "9Th",
            "10Th",
            "11Th"});
            this.courseNameTb.Location = new System.Drawing.Point(293, 143);
            this.courseNameTb.Name = "courseNameTb";
            this.courseNameTb.Size = new System.Drawing.Size(205, 29);
            this.courseNameTb.TabIndex = 157;
            this.courseNameTb.UseSelectable = true;
            // 
            // quitBtn
            // 
            this.quitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitBtn.Image = ((System.Drawing.Image)(resources.GetObject("quitBtn.Image")));
            this.quitBtn.Location = new System.Drawing.Point(492, 2);
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
            // turmaNomeDataGridViewTextBoxColumn
            // 
            this.turmaNomeDataGridViewTextBoxColumn.DataPropertyName = "TurmaNome";
            this.turmaNomeDataGridViewTextBoxColumn.HeaderText = "TurmaNome";
            this.turmaNomeDataGridViewTextBoxColumn.Name = "turmaNomeDataGridViewTextBoxColumn";
            this.turmaNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoNomeDataGridViewTextBoxColumn
            // 
            this.cursoNomeDataGridViewTextBoxColumn.DataPropertyName = "CursoNome";
            this.cursoNomeDataGridViewTextBoxColumn.HeaderText = "CursoNome";
            this.cursoNomeDataGridViewTextBoxColumn.Name = "cursoNomeDataGridViewTextBoxColumn";
            this.cursoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Turmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 695);
            this.Controls.Add(this.courseNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.classNameTb);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.ClassesDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Turmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.Turmas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox quitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox searchTxt;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private MetroFramework.Controls.MetroTextBox classNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameErrorLabel;
        private Guna.UI2.WinForms.Guna2DataGridView ClassesDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource turmasBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox courseNameTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmaNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoNomeDataGridViewTextBoxColumn;
    }
}