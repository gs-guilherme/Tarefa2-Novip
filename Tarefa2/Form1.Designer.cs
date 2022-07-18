namespace Tarefa2
{
    partial class CadastroClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.dgvTelefonesCadastrados = new System.Windows.Forms.DataGridView();
            this.clTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTelefone = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvClientesCadastrados = new System.Windows.Forms.DataGridView();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDtNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonesCadastrados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.lbRG);
            this.groupBox1.Controls.Add(this.btnAdicionarCliente);
            this.groupBox1.Controls.Add(this.dgvTelefonesCadastrados);
            this.groupBox1.Controls.Add(this.btnAddTelefone);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtNascimento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar novo cliente";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(43, 354);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(321, 27);
            this.txtRG.TabIndex = 12;
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(6, 357);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(31, 20);
            this.lbRG.TabIndex = 11;
            this.lbRG.Text = "RG:";
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Location = new System.Drawing.Point(6, 387);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(356, 29);
            this.btnAdicionarCliente.TabIndex = 10;
            this.btnAdicionarCliente.Text = "Adicionar Cliente";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // dgvTelefonesCadastrados
            // 
            this.dgvTelefonesCadastrados.AllowUserToAddRows = false;
            this.dgvTelefonesCadastrados.AllowUserToDeleteRows = false;
            this.dgvTelefonesCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonesCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTelefone});
            this.dgvTelefonesCadastrados.Location = new System.Drawing.Point(6, 160);
            this.dgvTelefonesCadastrados.Name = "dgvTelefonesCadastrados";
            this.dgvTelefonesCadastrados.ReadOnly = true;
            this.dgvTelefonesCadastrados.RowHeadersVisible = false;
            this.dgvTelefonesCadastrados.RowHeadersWidth = 51;
            this.dgvTelefonesCadastrados.RowTemplate.Height = 29;
            this.dgvTelefonesCadastrados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTelefonesCadastrados.Size = new System.Drawing.Size(356, 188);
            this.dgvTelefonesCadastrados.TabIndex = 9;
            // 
            // clTelefone
            // 
            this.clTelefone.HeaderText = "Telefone";
            this.clTelefone.MinimumWidth = 6;
            this.clTelefone.Name = "clTelefone";
            this.clTelefone.ReadOnly = true;
            this.clTelefone.Width = 326;
            // 
            // btnAddTelefone
            // 
            this.btnAddTelefone.Location = new System.Drawing.Point(328, 125);
            this.btnAddTelefone.Name = "btnAddTelefone";
            this.btnAddTelefone.Size = new System.Drawing.Size(34, 29);
            this.btnAddTelefone.TabIndex = 8;
            this.btnAddTelefone.Text = "+";
            this.btnAddTelefone.UseVisualStyleBackColor = true;
            this.btnAddTelefone.Click += new System.EventHandler(this.btnAddTelefone_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(81, 127);
            this.txtTelefone.Mask = "(00) 00000000#";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(241, 27);
            this.txtTelefone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(157, 92);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(205, 27);
            this.dtNascimento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de nascimento:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(65, 59);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(297, 27);
            this.txtCPF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 27);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvClientesCadastrados);
            this.groupBox2.Location = new System.Drawing.Point(386, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 430);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes cadastrados";
            // 
            // dgvClientesCadastrados
            // 
            this.dgvClientesCadastrados.AllowUserToAddRows = false;
            this.dgvClientesCadastrados.AllowUserToDeleteRows = false;
            this.dgvClientesCadastrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientesCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNome,
            this.clnCPF,
            this.clnUF,
            this.clnDtNascimento,
            this.clnDataCadastro,
            this.clnTelefone,
            this.clnRG});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientesCadastrados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientesCadastrados.Location = new System.Drawing.Point(12, 26);
            this.dgvClientesCadastrados.Name = "dgvClientesCadastrados";
            this.dgvClientesCadastrados.ReadOnly = true;
            this.dgvClientesCadastrados.RowHeadersVisible = false;
            this.dgvClientesCadastrados.RowHeadersWidth = 51;
            this.dgvClientesCadastrados.RowTemplate.Height = 29;
            this.dgvClientesCadastrados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClientesCadastrados.Size = new System.Drawing.Size(1010, 390);
            this.dgvClientesCadastrados.TabIndex = 10;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "Nome";
            this.clnNome.MinimumWidth = 6;
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnNome.Width = 240;
            // 
            // clnCPF
            // 
            this.clnCPF.HeaderText = "CPF";
            this.clnCPF.MinimumWidth = 6;
            this.clnCPF.Name = "clnCPF";
            this.clnCPF.ReadOnly = true;
            this.clnCPF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCPF.Width = 150;
            // 
            // clnUF
            // 
            this.clnUF.HeaderText = "UF";
            this.clnUF.MinimumWidth = 6;
            this.clnUF.Name = "clnUF";
            this.clnUF.ReadOnly = true;
            this.clnUF.Width = 125;
            // 
            // clnDtNascimento
            // 
            this.clnDtNascimento.HeaderText = "Data de Nascimento";
            this.clnDtNascimento.MinimumWidth = 6;
            this.clnDtNascimento.Name = "clnDtNascimento";
            this.clnDtNascimento.ReadOnly = true;
            this.clnDtNascimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnDtNascimento.Width = 125;
            // 
            // clnDataCadastro
            // 
            this.clnDataCadastro.HeaderText = "Data de Cadastro";
            this.clnDataCadastro.MinimumWidth = 6;
            this.clnDataCadastro.Name = "clnDataCadastro";
            this.clnDataCadastro.ReadOnly = true;
            this.clnDataCadastro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnDataCadastro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnDataCadastro.Width = 125;
            // 
            // clnTelefone
            // 
            this.clnTelefone.HeaderText = "Telefones";
            this.clnTelefone.MinimumWidth = 6;
            this.clnTelefone.Name = "clnTelefone";
            this.clnTelefone.ReadOnly = true;
            this.clnTelefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnTelefone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnTelefone.Width = 125;
            // 
            // clnRG
            // 
            this.clnRG.HeaderText = "RG";
            this.clnRG.MinimumWidth = 6;
            this.clnRG.Name = "clnRG";
            this.clnRG.ReadOnly = true;
            this.clnRG.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnRG.Width = 125;
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonesCadastrados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddTelefone;
        private MaskedTextBox txtTelefone;
        private Label label4;
        private DateTimePicker dtNascimento;
        private Label label3;
        private MaskedTextBox txtCPF;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnAdicionarCliente;
        private DataGridView dgvTelefonesCadastrados;
        private GroupBox groupBox2;
        private DataGridView dgvClientesCadastrados;
        private TextBox txtRG;
        private Label lbRG;
        private DataGridViewTextBoxColumn clTelefone;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCPF;
        private DataGridViewTextBoxColumn clnUF;
        private DataGridViewTextBoxColumn clnDtNascimento;
        private DataGridViewTextBoxColumn clnDataCadastro;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnRG;
    }
}