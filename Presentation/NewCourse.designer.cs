
namespace MSDOC
{
    partial class NewCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCourse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSDOCSCHOOLDataSetCursoNovo = new MSDOC.MSDOCSCHOOLDataSetCursoNovo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.coursetypeLabel = new System.Windows.Forms.Label();
            this.textBox_Curso = new System.Windows.Forms.TextBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.cursosTableAdapter = new MSDOC.MSDOCSCHOOLDataSetCursoNovoTableAdapters.CursosTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DataGridView_classes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cursoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetCursoNovo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 61);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1116, 10);
            this.panel4.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Novo Curso";
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.mSDOCSCHOOLDataSetCursoNovo;
            // 
            // mSDOCSCHOOLDataSetCursoNovo
            // 
            this.mSDOCSCHOOLDataSetCursoNovo.DataSetName = "MSDOCSCHOOLDataSetCursoNovo";
            this.mSDOCSCHOOLDataSetCursoNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxTipo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Controls.Add(this.coursetypeLabel);
            this.panel2.Controls.Add(this.textBox_Curso);
            this.panel2.Controls.Add(this.courseLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 162);
            this.panel2.TabIndex = 14;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Regular",
            "Profissional"});
            this.comboBoxTipo.Location = new System.Drawing.Point(697, 38);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(212, 29);
            this.comboBoxTipo.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
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
            this.button_add.Location = new System.Drawing.Point(578, 86);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(118, 39);
            this.button_add.TabIndex = 3;
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
            this.button_clear.Location = new System.Drawing.Point(454, 86);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(118, 39);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "Limpar";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // coursetypeLabel
            // 
            this.coursetypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.coursetypeLabel.AutoSize = true;
            this.coursetypeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursetypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.coursetypeLabel.Location = new System.Drawing.Point(552, 42);
            this.coursetypeLabel.Name = "coursetypeLabel";
            this.coursetypeLabel.Size = new System.Drawing.Size(117, 19);
            this.coursetypeLabel.TabIndex = 19;
            this.coursetypeLabel.Text = "Tipo de Curso:";
            // 
            // textBox_Curso
            // 
            this.textBox_Curso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Curso.Location = new System.Drawing.Point(344, 40);
            this.textBox_Curso.Name = "textBox_Curso";
            this.textBox_Curso.Size = new System.Drawing.Size(187, 27);
            this.textBox_Curso.TabIndex = 0;
            // 
            // courseLabel
            // 
            this.courseLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.courseLabel.Location = new System.Drawing.Point(208, 44);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(133, 19);
            this.courseLabel.TabIndex = 15;
            this.courseLabel.Text = "Nome do Curso:";
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DataGridView_classes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1116, 404);
            this.panel5.TabIndex = 16;
            // 
            // DataGridView_classes
            // 
            this.DataGridView_classes.AllowUserToAddRows = false;
            this.DataGridView_classes.AllowUserToDeleteRows = false;
            this.DataGridView_classes.AllowUserToResizeColumns = false;
            this.DataGridView_classes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_classes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_classes.AutoGenerateColumns = false;
            this.DataGridView_classes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_classes.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_classes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_classes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_classes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_classes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_classes.ColumnHeadersHeight = 24;
            this.DataGridView_classes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cursoIdDataGridViewTextBoxColumn,
            this.cursoNomeDataGridViewTextBoxColumn,
            this.tipoCursoDataGridViewTextBoxColumn});
            this.DataGridView_classes.DataSource = this.cursosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_classes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_classes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_classes.EnableHeadersVisualStyles = false;
            this.DataGridView_classes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_classes.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_classes.Name = "DataGridView_classes";
            this.DataGridView_classes.ReadOnly = true;
            this.DataGridView_classes.RowHeadersVisible = false;
            this.DataGridView_classes.RowTemplate.Height = 80;
            this.DataGridView_classes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_classes.Size = new System.Drawing.Size(1116, 404);
            this.DataGridView_classes.TabIndex = 4;
            this.DataGridView_classes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_classes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_classes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_classes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_classes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_classes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_classes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_classes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_classes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_classes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_classes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_classes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_classes.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_classes.ThemeStyle.ReadOnly = true;
            this.DataGridView_classes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_classes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_classes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_classes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_classes.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_classes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_classes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cursoIdDataGridViewTextBoxColumn
            // 
            this.cursoIdDataGridViewTextBoxColumn.DataPropertyName = "CursoId";
            this.cursoIdDataGridViewTextBoxColumn.HeaderText = "NºRegisto";
            this.cursoIdDataGridViewTextBoxColumn.Name = "cursoIdDataGridViewTextBoxColumn";
            this.cursoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoNomeDataGridViewTextBoxColumn
            // 
            this.cursoNomeDataGridViewTextBoxColumn.DataPropertyName = "CursoNome";
            this.cursoNomeDataGridViewTextBoxColumn.HeaderText = "Nome do Curso";
            this.cursoNomeDataGridViewTextBoxColumn.Name = "cursoNomeDataGridViewTextBoxColumn";
            this.cursoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoCursoDataGridViewTextBoxColumn
            // 
            this.tipoCursoDataGridViewTextBoxColumn.DataPropertyName = "TipoCurso";
            this.tipoCursoDataGridViewTextBoxColumn.HeaderText = "Tipo de Curso";
            this.tipoCursoDataGridViewTextBoxColumn.Name = "tipoCursoDataGridViewTextBoxColumn";
            this.tipoCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NewCourse
            // 
            this.AcceptButton = this.button_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 627);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewCourse";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSDOCSCHOOLDataSetCursoNovo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_classes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_Curso;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label coursetypeLabel;
        private MSDOCSCHOOLDataSetCursoNovo mSDOCSCHOOLDataSetCursoNovo;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private MSDOCSCHOOLDataSetCursoNovoTableAdapters.CursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_classes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCursoDataGridViewTextBoxColumn;
    }
}