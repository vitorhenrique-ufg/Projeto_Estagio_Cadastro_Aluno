namespace EM.WindowsForms
{
    partial class Form_Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro));
            this.tb_pesquisar = new System.Windows.Forms.TextBox();
            this.dgv_AlunosCadastrados = new System.Windows.Forms.DataGridView();
            this.PainelPrincipal = new System.Windows.Forms.Panel();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.tb_Cpf = new System.Windows.Forms.TextBox();
            this.tb_Matricula = new System.Windows.Forms.TextBox();
            this.tb_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.PainelSuperior = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_CadastroDeAlunos = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.lb_NovoAluno = new System.Windows.Forms.Label();
            this.btn_testePDF = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlunosCadastrados)).BeginInit();
            this.PainelPrincipal.SuspendLayout();
            this.PainelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_pesquisar
            // 
            this.tb_pesquisar.Location = new System.Drawing.Point(11, 223);
            this.tb_pesquisar.MaxLength = 100;
            this.tb_pesquisar.Name = "tb_pesquisar";
            this.tb_pesquisar.Size = new System.Drawing.Size(523, 20);
            this.tb_pesquisar.TabIndex = 7;
            this.tb_pesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pesquisar_KeyPress);
            this.tb_pesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_pesquisar_KeyUp);
            // 
            // dgv_AlunosCadastrados
            // 
            this.dgv_AlunosCadastrados.AllowUserToAddRows = false;
            this.dgv_AlunosCadastrados.AllowUserToDeleteRows = false;
            this.dgv_AlunosCadastrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AlunosCadastrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AlunosCadastrados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AlunosCadastrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_AlunosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AlunosCadastrados.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_AlunosCadastrados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_AlunosCadastrados.EnableHeadersVisualStyles = false;
            this.dgv_AlunosCadastrados.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_AlunosCadastrados.Location = new System.Drawing.Point(12, 253);
            this.dgv_AlunosCadastrados.MultiSelect = false;
            this.dgv_AlunosCadastrados.Name = "dgv_AlunosCadastrados";
            this.dgv_AlunosCadastrados.ReadOnly = true;
            this.dgv_AlunosCadastrados.RowHeadersVisible = false;
            this.dgv_AlunosCadastrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AlunosCadastrados.Size = new System.Drawing.Size(614, 167);
            this.dgv_AlunosCadastrados.TabIndex = 14;
            this.dgv_AlunosCadastrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AlunosCadastrados_CellClick);
            // 
            // PainelPrincipal
            // 
            this.PainelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelPrincipal.Controls.Add(this.btn_adicionar);
            this.PainelPrincipal.Controls.Add(this.btn_limpar);
            this.PainelPrincipal.Controls.Add(this.cb_Sexo);
            this.PainelPrincipal.Controls.Add(this.tb_Cpf);
            this.PainelPrincipal.Controls.Add(this.tb_Matricula);
            this.PainelPrincipal.Controls.Add(this.tb_DataNascimento);
            this.PainelPrincipal.Controls.Add(this.lblCPF);
            this.PainelPrincipal.Controls.Add(this.lblNascimento);
            this.PainelPrincipal.Controls.Add(this.lblSexo);
            this.PainelPrincipal.Controls.Add(this.tb_Nome);
            this.PainelPrincipal.Controls.Add(this.lblNome);
            this.PainelPrincipal.Controls.Add(this.lblMatricula);
            this.PainelPrincipal.Location = new System.Drawing.Point(12, 87);
            this.PainelPrincipal.Name = "PainelPrincipal";
            this.PainelPrincipal.Size = new System.Drawing.Size(614, 124);
            this.PainelPrincipal.TabIndex = 8;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adicionar.Location = new System.Drawing.Point(513, 81);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(90, 23);
            this.btn_adicionar.TabIndex = 6;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.Location = new System.Drawing.Point(420, 81);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(87, 23);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Location = new System.Drawing.Point(8, 84);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(108, 21);
            this.cb_Sexo.TabIndex = 2;
            // 
            // tb_Cpf
            // 
            this.tb_Cpf.Location = new System.Drawing.Point(279, 84);
            this.tb_Cpf.MaxLength = 11;
            this.tb_Cpf.Name = "tb_Cpf";
            this.tb_Cpf.Size = new System.Drawing.Size(135, 20);
            this.tb_Cpf.TabIndex = 4;
            this.tb_Cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cpf_KeyPress);
            // 
            // tb_Matricula
            // 
            this.tb_Matricula.Location = new System.Drawing.Point(12, 27);
            this.tb_Matricula.MaxLength = 9;
            this.tb_Matricula.Name = "tb_Matricula";
            this.tb_Matricula.Size = new System.Drawing.Size(104, 20);
            this.tb_Matricula.TabIndex = 0;
            this.tb_Matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Matricula_KeyPress);
            // 
            // tb_DataNascimento
            // 
            this.tb_DataNascimento.Location = new System.Drawing.Point(135, 84);
            this.tb_DataNascimento.Mask = "00/00/0000";
            this.tb_DataNascimento.Name = "tb_DataNascimento";
            this.tb_DataNascimento.Size = new System.Drawing.Size(135, 20);
            this.tb_DataNascimento.TabIndex = 3;
            this.tb_DataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCPF.Location = new System.Drawing.Point(276, 63);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 17);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblNascimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNascimento.Location = new System.Drawing.Point(132, 63);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(72, 17);
            this.lblNascimento.TabIndex = 9;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblSexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSexo.Location = new System.Drawing.Point(9, 63);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(35, 17);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(135, 27);
            this.tb_Nome.MaxLength = 100;
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(468, 20);
            this.tb_Nome.TabIndex = 1;
            this.tb_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(132, 7);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 17);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblMatricula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMatricula.Location = new System.Drawing.Point(9, 7);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(62, 17);
            this.lblMatricula.TabIndex = 3;
            this.lblMatricula.Text = "Matrícula";
            // 
            // PainelSuperior
            // 
            this.PainelSuperior.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PainelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelSuperior.Controls.Add(this.pb_logo);
            this.PainelSuperior.Controls.Add(this.lb_CadastroDeAlunos);
            this.PainelSuperior.Location = new System.Drawing.Point(2, 12);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.Size = new System.Drawing.Size(635, 54);
            this.PainelSuperior.TabIndex = 7;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(281, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(337, 45);
            this.pb_logo.TabIndex = 19;
            this.pb_logo.TabStop = false;
            // 
            // lb_CadastroDeAlunos
            // 
            this.lb_CadastroDeAlunos.AutoSize = true;
            this.lb_CadastroDeAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadastroDeAlunos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_CadastroDeAlunos.Location = new System.Drawing.Point(9, 12);
            this.lb_CadastroDeAlunos.Name = "lb_CadastroDeAlunos";
            this.lb_CadastroDeAlunos.Size = new System.Drawing.Size(161, 15);
            this.lb_CadastroDeAlunos.TabIndex = 18;
            this.lb_CadastroDeAlunos.Text = "CADASTRO DE ALUNOS";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Location = new System.Drawing.Point(541, 221);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(84, 23);
            this.btn_pesquisar.TabIndex = 8;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Location = new System.Drawing.Point(448, 426);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(87, 37);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Location = new System.Drawing.Point(541, 426);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(85, 37);
            this.btn_excluir.TabIndex = 10;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // lb_NovoAluno
            // 
            this.lb_NovoAluno.AutoSize = true;
            this.lb_NovoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NovoAluno.Location = new System.Drawing.Point(12, 69);
            this.lb_NovoAluno.Name = "lb_NovoAluno";
            this.lb_NovoAluno.Size = new System.Drawing.Size(95, 15);
            this.lb_NovoAluno.TabIndex = 19;
            this.lb_NovoAluno.Text = "NOVO ALUNO";
            // 
            // btn_testePDF
            // 
            this.btn_testePDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_testePDF.Location = new System.Drawing.Point(11, 443);
            this.btn_testePDF.Name = "btn_testePDF";
            this.btn_testePDF.Size = new System.Drawing.Size(52, 20);
            this.btn_testePDF.TabIndex = 20;
            this.btn_testePDF.Text = "Teste";
            this.btn_testePDF.UseVisualStyleBackColor = true;
            this.btn_testePDF.Click += new System.EventHandler(this.btn_testePDF_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(638, 471);
            this.Controls.Add(this.btn_testePDF);
            this.Controls.Add(this.lb_NovoAluno);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.tb_pesquisar);
            this.Controls.Add(this.dgv_AlunosCadastrados);
            this.Controls.Add(this.PainelPrincipal);
            this.Controls.Add(this.PainelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form_Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlunosCadastrados)).EndInit();
            this.PainelPrincipal.ResumeLayout(false);
            this.PainelPrincipal.PerformLayout();
            this.PainelSuperior.ResumeLayout(false);
            this.PainelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pesquisar;
        private System.Windows.Forms.DataGridView dgv_AlunosCadastrados;
        private System.Windows.Forms.Panel PainelPrincipal;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.ComboBox cb_Sexo;
        private System.Windows.Forms.TextBox tb_Cpf;
        private System.Windows.Forms.TextBox tb_Matricula;
        private System.Windows.Forms.MaskedTextBox tb_DataNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Panel PainelSuperior;
        private System.Windows.Forms.Label lb_CadastroDeAlunos;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label lb_NovoAluno;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_testePDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

