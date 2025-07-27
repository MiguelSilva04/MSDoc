
namespace MSDOC
{
    partial class Ficheiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ficheiros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_return = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridView_files = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ficheirosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSDOCSCHOOLDataSetFicheiros = new MSDOC.MSDOCSCHOOLDataSetFicheiros();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.button_uploadFile = new System.Windows.Forms.Button();
            this.textBox_file = new System.Windows.Forms.TextBox();
            this.nameClassLabel = new System.Windows.Forms.Label();
            this.combobox_nameTurma = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.nameFileLabel = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.ficheirosTableAdapter = new MSDOC.MSDOCSCHOOLDataSetFicheirosTableAdapters.FicheirosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ficheiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficheirosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetFicheiros)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btn_return);
            this.panel1.Controls.Add(this.label1);
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
            // btn_return
            // 
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.Image = global::MSDOC.Properties.Resources.x_mark_4_256;
            this.btn_return.Location = new System.Drawing.Point(3, 3);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(30, 30);
            this.btn_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_return.TabIndex = 37;
            this.btn_return.TabStop = false;
            this.btn_return.Visible = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 36;
            this.label1.Visible = false;
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
            this.label7.Location = new System.Drawing.Point(502, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ficheiros";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_search);
            this.panel4.Controls.Add(this.textBox_search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1105, 44);
            this.panel4.TabIndex = 36;
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
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.axAcroPDF1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1105, 483);
            this.panel6.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGridView_files);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 269);
            this.panel2.TabIndex = 14;
            // 
            // DataGridView_files
            // 
            this.DataGridView_files.AllowUserToAddRows = false;
            this.DataGridView_files.AllowUserToDeleteRows = false;
            this.DataGridView_files.AllowUserToResizeColumns = false;
            this.DataGridView_files.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_files.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_files.AutoGenerateColumns = false;
            this.DataGridView_files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_files.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_files.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_files.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_files.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_files.ColumnHeadersHeight = 24;
            this.DataGridView_files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.professorIdDataGridViewTextBoxColumn,
            this.professorNomeDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.turmaDataGridViewTextBoxColumn,
            this.ficheiroDataGridViewTextBoxColumn});
            this.DataGridView_files.DataSource = this.ficheirosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_files.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_files.EnableHeadersVisualStyles = false;
            this.DataGridView_files.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_files.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_files.Name = "DataGridView_files";
            this.DataGridView_files.ReadOnly = true;
            this.DataGridView_files.RowHeadersVisible = false;
            this.DataGridView_files.RowTemplate.Height = 80;
            this.DataGridView_files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_files.Size = new System.Drawing.Size(1105, 269);
            this.DataGridView_files.TabIndex = 175;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_files.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_files.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_files.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_files.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_files.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_files.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_files.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_files.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_files.ThemeStyle.ReadOnly = true;
            this.DataGridView_files.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_files.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_files.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_files.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_files.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_files.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_files.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_files.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_files_CellContentClick_1);
            this.DataGridView_files.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_files_CellContentDoubleClick);
            // 
            // ficheirosBindingSource
            // 
            this.ficheirosBindingSource.DataMember = "Ficheiros";
            this.ficheirosBindingSource.DataSource = this.mSDOCSCHOOLDataSetFicheiros;
            // 
            // mSDOCSCHOOLDataSetFicheiros
            // 
            this.mSDOCSCHOOLDataSetFicheiros.DataSetName = "MSDOCSCHOOLDataSetFicheiros";
            this.mSDOCSCHOOLDataSetFicheiros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.textBox_fileName);
            this.panel7.Controls.Add(this.button_uploadFile);
            this.panel7.Controls.Add(this.textBox_file);
            this.panel7.Controls.Add(this.nameClassLabel);
            this.panel7.Controls.Add(this.combobox_nameTurma);
            this.panel7.Controls.Add(this.button_delete);
            this.panel7.Controls.Add(this.button_update);
            this.panel7.Controls.Add(this.fileLabel);
            this.panel7.Controls.Add(this.button_add);
            this.panel7.Controls.Add(this.button_clear);
            this.panel7.Controls.Add(this.nameFileLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 269);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1105, 214);
            this.panel7.TabIndex = 176;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1105, 10);
            this.panel8.TabIndex = 185;
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_fileName.Location = new System.Drawing.Point(183, 50);
            this.textBox_fileName.Multiline = true;
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(282, 29);
            this.textBox_fileName.TabIndex = 0;
            // 
            // button_uploadFile
            // 
            this.button_uploadFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_uploadFile.BackColor = System.Drawing.Color.Green;
            this.button_uploadFile.FlatAppearance.BorderSize = 0;
            this.button_uploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_uploadFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_uploadFile.ForeColor = System.Drawing.Color.White;
            this.button_uploadFile.Location = new System.Drawing.Point(964, 66);
            this.button_uploadFile.Name = "button_uploadFile";
            this.button_uploadFile.Size = new System.Drawing.Size(90, 53);
            this.button_uploadFile.TabIndex = 2;
            this.button_uploadFile.Text = "Carregar Ficheiro";
            this.button_uploadFile.UseVisualStyleBackColor = false;
            this.button_uploadFile.Click += new System.EventHandler(this.button_uploadFile_Click_1);
            // 
            // textBox_file
            // 
            this.textBox_file.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_file.Enabled = false;
            this.textBox_file.Location = new System.Drawing.Point(630, 50);
            this.textBox_file.Multiline = true;
            this.textBox_file.Name = "textBox_file";
            this.textBox_file.Size = new System.Drawing.Size(328, 78);
            this.textBox_file.TabIndex = 2;
            // 
            // nameClassLabel
            // 
            this.nameClassLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameClassLabel.AutoSize = true;
            this.nameClassLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameClassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.nameClassLabel.Location = new System.Drawing.Point(63, 106);
            this.nameClassLabel.Name = "nameClassLabel";
            this.nameClassLabel.Size = new System.Drawing.Size(114, 19);
            this.nameClassLabel.TabIndex = 180;
            this.nameClassLabel.Text = "Nome Turma:";
            // 
            // combobox_nameTurma
            // 
            this.combobox_nameTurma.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.combobox_nameTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_nameTurma.FormattingEnabled = true;
            this.combobox_nameTurma.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.combobox_nameTurma.Location = new System.Drawing.Point(183, 99);
            this.combobox_nameTurma.Name = "combobox_nameTurma";
            this.combobox_nameTurma.Size = new System.Drawing.Size(282, 29);
            this.combobox_nameTurma.TabIndex = 1;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Enabled = false;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(586, 160);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(118, 39);
            this.button_delete.TabIndex = 5;
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
            this.button_update.Location = new System.Drawing.Point(462, 160);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(118, 39);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Atualizar";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.fileLabel.Location = new System.Drawing.Point(542, 77);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(78, 19);
            this.fileLabel.TabIndex = 179;
            this.fileLabel.Text = "Ficheiro :";
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(710, 160);
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
            this.button_clear.Location = new System.Drawing.Point(338, 160);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(118, 39);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Limpar";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click_1);
            // 
            // nameFileLabel
            // 
            this.nameFileLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameFileLabel.AutoSize = true;
            this.nameFileLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.nameFileLabel.Location = new System.Drawing.Point(51, 56);
            this.nameFileLabel.Name = "nameFileLabel";
            this.nameFileLabel.Size = new System.Drawing.Size(126, 19);
            this.nameFileLabel.TabIndex = 177;
            this.nameFileLabel.Text = "Nome Ficheiro:";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1105, 483);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // ficheirosTableAdapter
            // 
            this.ficheirosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome Ficheiro";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professorIdDataGridViewTextBoxColumn
            // 
            this.professorIdDataGridViewTextBoxColumn.DataPropertyName = "ProfessorId";
            this.professorIdDataGridViewTextBoxColumn.HeaderText = "ProfessorId";
            this.professorIdDataGridViewTextBoxColumn.Name = "professorIdDataGridViewTextBoxColumn";
            this.professorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.professorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // professorNomeDataGridViewTextBoxColumn
            // 
            this.professorNomeDataGridViewTextBoxColumn.DataPropertyName = "ProfessorNome";
            this.professorNomeDataGridViewTextBoxColumn.HeaderText = "Nome Professor";
            this.professorNomeDataGridViewTextBoxColumn.Name = "professorNomeDataGridViewTextBoxColumn";
            this.professorNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data de Adição";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turmaDataGridViewTextBoxColumn
            // 
            this.turmaDataGridViewTextBoxColumn.DataPropertyName = "Turma";
            this.turmaDataGridViewTextBoxColumn.HeaderText = "Turma";
            this.turmaDataGridViewTextBoxColumn.Name = "turmaDataGridViewTextBoxColumn";
            this.turmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ficheiroDataGridViewTextBoxColumn
            // 
            this.ficheiroDataGridViewTextBoxColumn.DataPropertyName = "Ficheiro";
            this.ficheiroDataGridViewTextBoxColumn.HeaderText = "Ficheiro";
            this.ficheiroDataGridViewTextBoxColumn.Name = "ficheiroDataGridViewTextBoxColumn";
            this.ficheiroDataGridViewTextBoxColumn.ReadOnly = true;
            this.ficheiroDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ficheiroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Ficheiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 578);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ficheiros";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficheirosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetFicheiros)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Button button_uploadFile;
        private System.Windows.Forms.TextBox textBox_file;
        private System.Windows.Forms.Label nameClassLabel;
        private System.Windows.Forms.ComboBox combobox_nameTurma;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label nameFileLabel;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_files;
        private System.Windows.Forms.PictureBox btn_return;
        private MSDOCSCHOOLDataSetFicheiros mSDOCSCHOOLDataSetFicheiros;
        private System.Windows.Forms.BindingSource ficheirosBindingSource;
        private MSDOCSCHOOLDataSetFicheirosTableAdapters.FicheirosTableAdapter ficheirosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn ficheiroDataGridViewTextBoxColumn;
    }
}