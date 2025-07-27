
namespace MSDOC
{
    partial class AttendanceStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceStudents));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_horafinal = new System.Windows.Forms.DateTimePicker();
            this.text_horacomeco = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTurmaId = new System.Windows.Forms.Label();
            this.labelTurma = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.finalhourdLabel = new System.Windows.Forms.Label();
            this.comboBox_Assiduidade = new System.Windows.Forms.ComboBox();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.comboBox_AlunoId = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.starthourLabel = new System.Windows.Forms.Label();
            this.idTeacherLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelAttendance = new System.Windows.Forms.Panel();
            this.countfaltasLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.faltasLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunosAssiduidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSDOCSCHOOLDataSetAlunosAssiduidade = new MSDOC.MSDOCSCHOOLDataSetAlunosAssiduidade();
            this.alunosAssiduidadeTableAdapter = new MSDOC.MSDOCSCHOOLDataSetAlunosAssiduidadeTableAdapters.AlunosAssiduidadeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelAttendance.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosAssiduidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetAlunosAssiduidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 51);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 177;
            this.label2.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(3, 4);
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
            this.label7.Location = new System.Drawing.Point(446, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Assiduidade Alunos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.text_horafinal);
            this.panel2.Controls.Add(this.text_horacomeco);
            this.panel2.Controls.Add(this.DateTimePicker);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelTurmaId);
            this.panel2.Controls.Add(this.labelTurma);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.finalhourdLabel);
            this.panel2.Controls.Add(this.comboBox_Assiduidade);
            this.panel2.Controls.Add(this.attendanceLabel);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_update);
            this.panel2.Controls.Add(this.comboBox_AlunoId);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Controls.Add(this.textBox_Name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.starthourLabel);
            this.panel2.Controls.Add(this.idTeacherLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 214);
            this.panel2.TabIndex = 14;
            // 
            // text_horafinal
            // 
            this.text_horafinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.text_horafinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.text_horafinal.Location = new System.Drawing.Point(727, 72);
            this.text_horafinal.MaxDate = new System.DateTime(2022, 7, 15, 0, 0, 0, 0);
            this.text_horafinal.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.text_horafinal.Name = "text_horafinal";
            this.text_horafinal.ShowUpDown = true;
            this.text_horafinal.Size = new System.Drawing.Size(263, 27);
            this.text_horafinal.TabIndex = 3;
            this.text_horafinal.Value = new System.DateTime(2022, 5, 27, 13, 35, 31, 0);
            // 
            // text_horacomeco
            // 
            this.text_horacomeco.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.text_horacomeco.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.text_horacomeco.Location = new System.Drawing.Point(256, 70);
            this.text_horacomeco.MaxDate = new System.DateTime(2022, 7, 15, 0, 0, 0, 0);
            this.text_horacomeco.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.text_horacomeco.Name = "text_horacomeco";
            this.text_horacomeco.ShowUpDown = true;
            this.text_horacomeco.Size = new System.Drawing.Size(267, 27);
            this.text_horacomeco.TabIndex = 2;
            this.text_horacomeco.Tag = "H";
            this.text_horacomeco.Value = new System.DateTime(2022, 5, 27, 13, 35, 31, 0);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePicker.Location = new System.Drawing.Point(256, 119);
            this.DateTimePicker.MaxDate = new System.DateTime(2022, 7, 15, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(267, 27);
            this.DateTimePicker.TabIndex = 4;
            this.DateTimePicker.Value = new System.DateTime(2022, 5, 27, 13, 35, 31, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 173;
            this.label1.Visible = false;
            // 
            // labelTurmaId
            // 
            this.labelTurmaId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTurmaId.AutoSize = true;
            this.labelTurmaId.Location = new System.Drawing.Point(86, 163);
            this.labelTurmaId.Name = "labelTurmaId";
            this.labelTurmaId.Size = new System.Drawing.Size(0, 21);
            this.labelTurmaId.TabIndex = 172;
            this.labelTurmaId.Visible = false;
            // 
            // labelTurma
            // 
            this.labelTurma.AutoSize = true;
            this.labelTurma.Location = new System.Drawing.Point(13, 163);
            this.labelTurma.Name = "labelTurma";
            this.labelTurma.Size = new System.Drawing.Size(0, 21);
            this.labelTurma.TabIndex = 171;
            this.labelTurma.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(111, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 170;
            this.label8.Text = "Dia da Falta :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1105, 10);
            this.panel4.TabIndex = 167;
            // 
            // finalhourdLabel
            // 
            this.finalhourdLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.finalhourdLabel.AutoSize = true;
            this.finalhourdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalhourdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.finalhourdLabel.Location = new System.Drawing.Point(586, 76);
            this.finalhourdLabel.Name = "finalhourdLabel";
            this.finalhourdLabel.Size = new System.Drawing.Size(95, 19);
            this.finalhourdLabel.TabIndex = 164;
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
            this.comboBox_Assiduidade.Location = new System.Drawing.Point(727, 115);
            this.comboBox_Assiduidade.Name = "comboBox_Assiduidade";
            this.comboBox_Assiduidade.Size = new System.Drawing.Size(263, 29);
            this.comboBox_Assiduidade.TabIndex = 5;
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.attendanceLabel.Location = new System.Drawing.Point(588, 119);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(113, 19);
            this.attendanceLabel.TabIndex = 37;
            this.attendanceLabel.Text = "Assiduidade :";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Enabled = false;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(603, 163);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(118, 39);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Apagar";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_update.BackColor = System.Drawing.Color.OrangeRed;
            this.button_update.Enabled = false;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(479, 163);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(118, 39);
            this.button_update.TabIndex = 7;
            this.button_update.Text = "Atualizar";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // comboBox_AlunoId
            // 
            this.comboBox_AlunoId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_AlunoId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_AlunoId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_AlunoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AlunoId.FormattingEnabled = true;
            this.comboBox_AlunoId.Location = new System.Drawing.Point(257, 26);
            this.comboBox_AlunoId.Name = "comboBox_AlunoId";
            this.comboBox_AlunoId.Size = new System.Drawing.Size(267, 29);
            this.comboBox_AlunoId.TabIndex = 0;
            this.comboBox_AlunoId.SelectionChangeCommitted += new System.EventHandler(this.combobox_IdStudent_SelectionChangeCommitted);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(13, -42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 10);
            this.panel3.TabIndex = 32;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(727, 163);
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
            this.button_clear.Location = new System.Drawing.Point(355, 163);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(118, 39);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "Limpar";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Location = new System.Drawing.Point(727, 26);
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(263, 29);
            this.textBox_Name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(586, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nome Aluno :";
            // 
            // starthourLabel
            // 
            this.starthourLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.starthourLabel.AutoSize = true;
            this.starthourLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starthourLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.starthourLabel.Location = new System.Drawing.Point(111, 72);
            this.starthourLabel.Name = "starthourLabel";
            this.starthourLabel.Size = new System.Drawing.Size(126, 19);
            this.starthourLabel.TabIndex = 19;
            this.starthourLabel.Text = "Hora Começo :";
            // 
            // idTeacherLabel
            // 
            this.idTeacherLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idTeacherLabel.AutoSize = true;
            this.idTeacherLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTeacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.idTeacherLabel.Location = new System.Drawing.Point(111, 30);
            this.idTeacherLabel.Name = "idTeacherLabel";
            this.idTeacherLabel.Size = new System.Drawing.Size(139, 19);
            this.idTeacherLabel.TabIndex = 15;
            this.idTeacherLabel.Text = "Nº Registo Aluno:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelAttendance);
            this.panel5.Controls.Add(this.button_search);
            this.panel5.Controls.Add(this.textBox_search);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1105, 45);
            this.panel5.TabIndex = 36;
            // 
            // panelAttendance
            // 
            this.panelAttendance.BackColor = System.Drawing.Color.White;
            this.panelAttendance.Controls.Add(this.countfaltasLabel);
            this.panelAttendance.Controls.Add(this.label9);
            this.panelAttendance.Controls.Add(this.label6);
            this.panelAttendance.Controls.Add(this.button3);
            this.panelAttendance.Controls.Add(this.button2);
            this.panelAttendance.Controls.Add(this.button1);
            this.panelAttendance.Controls.Add(this.faltasLabel);
            this.panelAttendance.Controls.Add(this.label5);
            this.panelAttendance.Location = new System.Drawing.Point(0, 0);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(777, 45);
            this.panelAttendance.TabIndex = 5;
            // 
            // countfaltasLabel
            // 
            this.countfaltasLabel.AutoSize = true;
            this.countfaltasLabel.BackColor = System.Drawing.Color.Black;
            this.countfaltasLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countfaltasLabel.Location = new System.Drawing.Point(163, 12);
            this.countfaltasLabel.Name = "countfaltasLabel";
            this.countfaltasLabel.Size = new System.Drawing.Size(0, 19);
            this.countfaltasLabel.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(626, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Passou o limite (>6)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quase a passar o limite (>3)";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(594, 11);
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
            this.button2.Location = new System.Drawing.Point(356, 11);
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
            this.button1.Location = new System.Drawing.Point(208, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // faltasLabel
            // 
            this.faltasLabel.AutoSize = true;
            this.faltasLabel.Location = new System.Drawing.Point(3, 2);
            this.faltasLabel.Name = "faltasLabel";
            this.faltasLabel.Size = new System.Drawing.Size(144, 42);
            this.faltasLabel.TabIndex = 10;
            this.faltasLabel.Text = "Número de faltas\r\nInjustificadas: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Aceitável (<3)";
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.Color.Orange;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(975, 3);
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
            this.textBox_search.Location = new System.Drawing.Point(813, 10);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(156, 27);
            this.textBox_search.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DataGridView_student);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1105, 268);
            this.panel6.TabIndex = 37;
            // 
            // DataGridView_student
            // 
            this.DataGridView_student.AllowUserToAddRows = false;
            this.DataGridView_student.AllowUserToDeleteRows = false;
            this.DataGridView_student.AllowUserToResizeColumns = false;
            this.DataGridView_student.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_student.AutoGenerateColumns = false;
            this.DataGridView_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_student.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView_student.ColumnHeadersHeight = 24;
            this.DataGridView_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.alunoIdDataGridViewTextBoxColumn,
            this.alunoNomeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.dataInicialDataGridViewTextBoxColumn,
            this.dataFinalDataGridViewTextBoxColumn});
            this.DataGridView_student.DataSource = this.alunosAssiduidadeBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_student.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView_student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_student.EnableHeadersVisualStyles = false;
            this.DataGridView_student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_student.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_student.Name = "DataGridView_student";
            this.DataGridView_student.ReadOnly = true;
            this.DataGridView_student.RowHeadersVisible = false;
            this.DataGridView_student.RowTemplate.Height = 80;
            this.DataGridView_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_student.Size = new System.Drawing.Size(1105, 268);
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
            this.DataGridView_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_student_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // alunoIdDataGridViewTextBoxColumn
            // 
            this.alunoIdDataGridViewTextBoxColumn.DataPropertyName = "AlunoId";
            this.alunoIdDataGridViewTextBoxColumn.HeaderText = "Nº Registo Aluno";
            this.alunoIdDataGridViewTextBoxColumn.Name = "alunoIdDataGridViewTextBoxColumn";
            this.alunoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alunoNomeDataGridViewTextBoxColumn
            // 
            this.alunoNomeDataGridViewTextBoxColumn.DataPropertyName = "AlunoNome";
            this.alunoNomeDataGridViewTextBoxColumn.HeaderText = "Nome Aluno";
            this.alunoNomeDataGridViewTextBoxColumn.Name = "alunoNomeDataGridViewTextBoxColumn";
            this.alunoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Assiduidade";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data da falta";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInicialDataGridViewTextBoxColumn
            // 
            this.dataInicialDataGridViewTextBoxColumn.DataPropertyName = "DataInicial";
            this.dataInicialDataGridViewTextBoxColumn.HeaderText = "Hora Começo";
            this.dataInicialDataGridViewTextBoxColumn.Name = "dataInicialDataGridViewTextBoxColumn";
            this.dataInicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFinalDataGridViewTextBoxColumn
            // 
            this.dataFinalDataGridViewTextBoxColumn.DataPropertyName = "DataFinal";
            this.dataFinalDataGridViewTextBoxColumn.HeaderText = "Hora Final";
            this.dataFinalDataGridViewTextBoxColumn.Name = "dataFinalDataGridViewTextBoxColumn";
            this.dataFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alunosAssiduidadeBindingSource
            // 
            this.alunosAssiduidadeBindingSource.DataMember = "AlunosAssiduidade";
            this.alunosAssiduidadeBindingSource.DataSource = this.mSDOCSCHOOLDataSetAlunosAssiduidade;
            // 
            // mSDOCSCHOOLDataSetAlunosAssiduidade
            // 
            this.mSDOCSCHOOLDataSetAlunosAssiduidade.DataSetName = "MSDOCSCHOOLDataSetAlunosAssiduidade";
            this.mSDOCSCHOOLDataSetAlunosAssiduidade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosAssiduidadeTableAdapter
            // 
            this.alunosAssiduidadeTableAdapter.ClearBeforeFill = true;
            // 
            // AttendanceStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 578);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AttendanceStudents";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelAttendance.ResumeLayout(false);
            this.panelAttendance.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosAssiduidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetAlunosAssiduidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label starthourLabel;
        private System.Windows.Forms.Label idTeacherLabel;
        private System.Windows.Forms.ComboBox comboBox_AlunoId;
        private System.Windows.Forms.ComboBox comboBox_Assiduidade;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label finalhourdLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private System.Windows.Forms.PictureBox backButton;
        private MSDOCSCHOOLDataSetAlunosAssiduidade mSDOCSCHOOLDataSetAlunosAssiduidade;
        private System.Windows.Forms.BindingSource alunosAssiduidadeBindingSource;
        private MSDOCSCHOOLDataSetAlunosAssiduidadeTableAdapters.AlunosAssiduidadeTableAdapter alunosAssiduidadeTableAdapter;
        private System.Windows.Forms.Label labelTurma;
        private System.Windows.Forms.Label labelTurmaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.DateTimePicker text_horafinal;
        private System.Windows.Forms.DateTimePicker text_horacomeco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAttendance;
        private System.Windows.Forms.Label countfaltasLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label faltasLabel;
        private System.Windows.Forms.Label label5;
    }
}