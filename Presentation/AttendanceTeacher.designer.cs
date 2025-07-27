
namespace MSDOC
{
    partial class AttendanceTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceTeacher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.text_horafinal = new System.Windows.Forms.DateTimePicker();
            this.text_horacomeco = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerDay = new System.Windows.Forms.DateTimePicker();
            this.dayLabel = new System.Windows.Forms.Label();
            this.finalhourdLabel = new System.Windows.Forms.Label();
            this.comboBox_Assiduidade = new System.Windows.Forms.ComboBox();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.comboBox_ProfessorId = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.starthourLabel = new System.Windows.Forms.Label();
            this.idTeacherLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelAttendance = new System.Windows.Forms.Panel();
            this.countfaltasLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.faltasLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DataGridView_teachers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorAssiduidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSDOCSCHOOLDataSetProfessoresAssiduidade = new MSDOC.MSDOCSCHOOLDataSetProfessoresAssiduidade();
            this.professorAssiduidadeTableAdapter = new MSDOC.MSDOCSCHOOLDataSetProfessoresAssiduidadeTableAdapters.ProfessorAssiduidadeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelAttendance.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorAssiduidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetProfessoresAssiduidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 51);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 35;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(383, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Assiduidade dos Professores";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 15;
            this.label1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 214);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.text_horafinal);
            this.panel4.Controls.Add(this.text_horacomeco);
            this.panel4.Controls.Add(this.DateTimePickerDay);
            this.panel4.Controls.Add(this.dayLabel);
            this.panel4.Controls.Add(this.finalhourdLabel);
            this.panel4.Controls.Add(this.comboBox_Assiduidade);
            this.panel4.Controls.Add(this.attendanceLabel);
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Controls.Add(this.comboBox_ProfessorId);
            this.panel4.Controls.Add(this.btn_add);
            this.panel4.Controls.Add(this.btn_clear);
            this.panel4.Controls.Add(this.textBox_Name);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.starthourLabel);
            this.panel4.Controls.Add(this.idTeacherLabel);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1105, 214);
            this.panel4.TabIndex = 172;
            // 
            // text_horafinal
            // 
            this.text_horafinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.text_horafinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.text_horafinal.Location = new System.Drawing.Point(729, 63);
            this.text_horafinal.MaxDate = new System.DateTime(2022, 7, 15, 0, 0, 0, 0);
            this.text_horafinal.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.text_horafinal.Name = "text_horafinal";
            this.text_horafinal.ShowUpDown = true;
            this.text_horafinal.Size = new System.Drawing.Size(262, 32);
            this.text_horafinal.TabIndex = 3;
            this.text_horafinal.Tag = "H";
            this.text_horafinal.Value = new System.DateTime(2022, 5, 27, 13, 35, 31, 0);
            // 
            // text_horacomeco
            // 
            this.text_horacomeco.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.text_horacomeco.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.text_horacomeco.Location = new System.Drawing.Point(277, 63);
            this.text_horacomeco.MaxDate = new System.DateTime(2022, 7, 15, 0, 0, 0, 0);
            this.text_horacomeco.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.text_horacomeco.Name = "text_horacomeco";
            this.text_horacomeco.ShowUpDown = true;
            this.text_horacomeco.Size = new System.Drawing.Size(267, 32);
            this.text_horacomeco.TabIndex = 2;
            this.text_horacomeco.Tag = "H";
            this.text_horacomeco.Value = new System.DateTime(2022, 5, 27, 13, 35, 31, 0);
            // 
            // DateTimePickerDay
            // 
            this.DateTimePickerDay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePickerDay.Location = new System.Drawing.Point(276, 109);
            this.DateTimePickerDay.MaxDate = new System.DateTime(2022, 7, 15, 0, 0, 0, 0);
            this.DateTimePickerDay.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerDay.Name = "DateTimePickerDay";
            this.DateTimePickerDay.Size = new System.Drawing.Size(268, 32);
            this.DateTimePickerDay.TabIndex = 4;
            this.DateTimePickerDay.Value = new System.DateTime(2022, 5, 27, 0, 0, 0, 0);
            // 
            // dayLabel
            // 
            this.dayLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.dayLabel.Location = new System.Drawing.Point(126, 115);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(139, 23);
            this.dayLabel.TabIndex = 190;
            this.dayLabel.Text = "Dia da Falta :";
            // 
            // finalhourdLabel
            // 
            this.finalhourdLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.finalhourdLabel.AutoSize = true;
            this.finalhourdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalhourdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.finalhourdLabel.Location = new System.Drawing.Point(601, 69);
            this.finalhourdLabel.Name = "finalhourdLabel";
            this.finalhourdLabel.Size = new System.Drawing.Size(119, 23);
            this.finalhourdLabel.TabIndex = 189;
            this.finalhourdLabel.Text = "Hora Final :";
            // 
            // comboBox_Assiduidade
            // 
            this.comboBox_Assiduidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_Assiduidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Assiduidade.FormattingEnabled = true;
            this.comboBox_Assiduidade.Items.AddRange(new object[] {
            "Falta Justificada",
            "Falta Injustificada"});
            this.comboBox_Assiduidade.Location = new System.Drawing.Point(729, 105);
            this.comboBox_Assiduidade.Name = "comboBox_Assiduidade";
            this.comboBox_Assiduidade.Size = new System.Drawing.Size(263, 31);
            this.comboBox_Assiduidade.TabIndex = 5;
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.attendanceLabel.Location = new System.Drawing.Point(602, 109);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(142, 23);
            this.attendanceLabel.TabIndex = 188;
            this.attendanceLabel.Text = "Assiduidade :";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Enabled = false;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(605, 156);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 39);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Apagar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(481, 156);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 39);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Atualizar";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // comboBox_ProfessorId
            // 
            this.comboBox_ProfessorId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_ProfessorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProfessorId.FormattingEnabled = true;
            this.comboBox_ProfessorId.Items.AddRange(new object[] {
            ""});
            this.comboBox_ProfessorId.Location = new System.Drawing.Point(277, 19);
            this.comboBox_ProfessorId.Name = "comboBox_ProfessorId";
            this.comboBox_ProfessorId.Size = new System.Drawing.Size(267, 31);
            this.comboBox_ProfessorId.TabIndex = 0;
            this.comboBox_ProfessorId.SelectionChangeCommitted += new System.EventHandler(this.comboBox_ProfessorId_SelectionChangeCommitted);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(729, 156);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 39);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_clear.BackColor = System.Drawing.Color.Orange;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(357, 156);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 39);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Location = new System.Drawing.Point(729, 19);
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(263, 29);
            this.textBox_Name.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label14.Location = new System.Drawing.Point(588, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 23);
            this.label14.TabIndex = 186;
            this.label14.Text = "Nome Professor :";
            // 
            // starthourLabel
            // 
            this.starthourLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.starthourLabel.AutoSize = true;
            this.starthourLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starthourLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.starthourLabel.Location = new System.Drawing.Point(126, 66);
            this.starthourLabel.Name = "starthourLabel";
            this.starthourLabel.Size = new System.Drawing.Size(161, 23);
            this.starthourLabel.TabIndex = 185;
            this.starthourLabel.Text = "Hora Começo :";
            // 
            // idTeacherLabel
            // 
            this.idTeacherLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idTeacherLabel.AutoSize = true;
            this.idTeacherLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTeacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.idTeacherLabel.Location = new System.Drawing.Point(113, 23);
            this.idTeacherLabel.Name = "idTeacherLabel";
            this.idTeacherLabel.Size = new System.Drawing.Size(207, 23);
            this.idTeacherLabel.TabIndex = 184;
            this.idTeacherLabel.Text = "Nº Registo Professor:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1105, 10);
            this.panel5.TabIndex = 167;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel6.Location = new System.Drawing.Point(13, -42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1080, 10);
            this.panel6.TabIndex = 32;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panelAttendance);
            this.panel7.Controls.Add(this.button_search);
            this.panel7.Controls.Add(this.textBox_search);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 51);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1105, 44);
            this.panel7.TabIndex = 36;
            // 
            // panelAttendance
            // 
            this.panelAttendance.BackColor = System.Drawing.Color.White;
            this.panelAttendance.Controls.Add(this.countfaltasLabel);
            this.panelAttendance.Controls.Add(this.label9);
            this.panelAttendance.Controls.Add(this.label8);
            this.panelAttendance.Controls.Add(this.button3);
            this.panelAttendance.Controls.Add(this.button2);
            this.panelAttendance.Controls.Add(this.button1);
            this.panelAttendance.Controls.Add(this.faltasLabel);
            this.panelAttendance.Controls.Add(this.label10);
            this.panelAttendance.Location = new System.Drawing.Point(0, 0);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(777, 45);
            this.panelAttendance.TabIndex = 6;
            // 
            // countfaltasLabel
            // 
            this.countfaltasLabel.AutoSize = true;
            this.countfaltasLabel.BackColor = System.Drawing.Color.Black;
            this.countfaltasLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countfaltasLabel.Location = new System.Drawing.Point(163, 13);
            this.countfaltasLabel.Name = "countfaltasLabel";
            this.countfaltasLabel.Size = new System.Drawing.Size(0, 23);
            this.countfaltasLabel.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(626, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Passou o limite (>7)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(384, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quase a passar o limite (>4)";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(594, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(356, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(208, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // faltasLabel
            // 
            this.faltasLabel.AutoSize = true;
            this.faltasLabel.Location = new System.Drawing.Point(11, 12);
            this.faltasLabel.Name = "faltasLabel";
            this.faltasLabel.Size = new System.Drawing.Size(192, 23);
            this.faltasLabel.TabIndex = 10;
            this.faltasLabel.Text = "Número de faltas: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "Aceitável (<4)";
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.Color.Orange;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(975, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(118, 39);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "Pesquisar";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click_1);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(813, 9);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(156, 32);
            this.textBox_search.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.DataGridView_teachers);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 95);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1105, 269);
            this.panel8.TabIndex = 37;
            // 
            // DataGridView_teachers
            // 
            this.DataGridView_teachers.AllowUserToAddRows = false;
            this.DataGridView_teachers.AllowUserToDeleteRows = false;
            this.DataGridView_teachers.AllowUserToResizeColumns = false;
            this.DataGridView_teachers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_teachers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_teachers.AutoGenerateColumns = false;
            this.DataGridView_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_teachers.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_teachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_teachers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_teachers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_teachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_teachers.ColumnHeadersHeight = 24;
            this.DataGridView_teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.professorNomeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DataGridView_teachers.DataSource = this.professorAssiduidadeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_teachers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_teachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_teachers.EnableHeadersVisualStyles = false;
            this.DataGridView_teachers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_teachers.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_teachers.Name = "DataGridView_teachers";
            this.DataGridView_teachers.ReadOnly = true;
            this.DataGridView_teachers.RowHeadersVisible = false;
            this.DataGridView_teachers.RowHeadersWidth = 51;
            this.DataGridView_teachers.RowTemplate.Height = 80;
            this.DataGridView_teachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_teachers.Size = new System.Drawing.Size(1105, 269);
            this.DataGridView_teachers.TabIndex = 4;
            this.DataGridView_teachers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_teachers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_teachers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_teachers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_teachers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_teachers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_teachers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_teachers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_teachers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_teachers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_teachers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_teachers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_teachers.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_teachers.ThemeStyle.ReadOnly = true;
            this.DataGridView_teachers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_teachers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_teachers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_teachers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_teachers.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_teachers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_teachers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_teachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_teachers_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProfessorId";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nº Registo Professor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // professorNomeDataGridViewTextBoxColumn
            // 
            this.professorNomeDataGridViewTextBoxColumn.DataPropertyName = "ProfessorNome";
            this.professorNomeDataGridViewTextBoxColumn.HeaderText = "Nome Professor";
            this.professorNomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.professorNomeDataGridViewTextBoxColumn.Name = "professorNomeDataGridViewTextBoxColumn";
            this.professorNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Assiduidade";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data da falta";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataInicial";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora Começo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataFinal";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora Final";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // professorAssiduidadeBindingSource
            // 
            this.professorAssiduidadeBindingSource.DataMember = "ProfessorAssiduidade";
            this.professorAssiduidadeBindingSource.DataSource = this.mSDOCSCHOOLDataSetProfessoresAssiduidade;
            // 
            // mSDOCSCHOOLDataSetProfessoresAssiduidade
            // 
            this.mSDOCSCHOOLDataSetProfessoresAssiduidade.DataSetName = "MSDOCSCHOOLDataSetProfessoresAssiduidade";
            this.mSDOCSCHOOLDataSetProfessoresAssiduidade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professorAssiduidadeTableAdapter
            // 
            this.professorAssiduidadeTableAdapter.ClearBeforeFill = true;
            // 
            // AttendanceTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 578);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AttendanceTeacher";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelAttendance.ResumeLayout(false);
            this.panelAttendance.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorAssiduidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetProfessoresAssiduidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_teachers;
        private System.Windows.Forms.PictureBox backButton;
        private MSDOCSCHOOLDataSetProfessoresAssiduidade mSDOCSCHOOLDataSetProfessoresAssiduidade;
        private System.Windows.Forms.BindingSource professorAssiduidadeBindingSource;
        private MSDOCSCHOOLDataSetProfessoresAssiduidadeTableAdapters.ProfessorAssiduidadeTableAdapter professorAssiduidadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panelAttendance;
        private System.Windows.Forms.Label countfaltasLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label faltasLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker text_horafinal;
        private System.Windows.Forms.DateTimePicker text_horacomeco;
        private System.Windows.Forms.DateTimePicker DateTimePickerDay;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label finalhourdLabel;
        private System.Windows.Forms.ComboBox comboBox_Assiduidade;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox comboBox_ProfessorId;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label starthourLabel;
        private System.Windows.Forms.Label idTeacherLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}