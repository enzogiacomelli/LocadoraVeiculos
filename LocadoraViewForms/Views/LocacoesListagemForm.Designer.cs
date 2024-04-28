namespace LocadoraViewForms.Views
{
    partial class LocacoesListagemForm
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
            groupBox1 = new GroupBox();
            buttonCadastrar = new Button();
            dataGridViewLocacoes = new DataGridView();
            ColumnCliente = new DataGridViewTextBoxColumn();
            ColumnVeiculo = new DataGridViewTextBoxColumn();
            ColumnDiarias = new DataGridViewTextBoxColumn();
            ColumnValor = new DataGridViewTextBoxColumn();
            ColumnInicio = new DataGridViewTextBoxColumn();
            ColumnFim = new DataGridViewTextBoxColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocacoes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonExcluir);
            groupBox1.Controls.Add(buttonEditar);
            groupBox1.Controls.Add(buttonCadastrar);
            groupBox1.Controls.Add(dataGridViewLocacoes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(689, 270);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Locações";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(605, 22);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 1;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // dataGridViewLocacoes
            // 
            dataGridViewLocacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocacoes.Columns.AddRange(new DataGridViewColumn[] { ColumnCliente, ColumnVeiculo, ColumnDiarias, ColumnValor, ColumnInicio, ColumnFim, ColumnId });
            dataGridViewLocacoes.Location = new Point(6, 22);
            dataGridViewLocacoes.Name = "dataGridViewLocacoes";
            dataGridViewLocacoes.Size = new Size(593, 242);
            dataGridViewLocacoes.TabIndex = 0;
            // 
            // ColumnCliente
            // 
            ColumnCliente.HeaderText = "Cliente";
            ColumnCliente.Name = "ColumnCliente";
            ColumnCliente.ReadOnly = true;
            // 
            // ColumnVeiculo
            // 
            ColumnVeiculo.HeaderText = "Veículo";
            ColumnVeiculo.Name = "ColumnVeiculo";
            ColumnVeiculo.ReadOnly = true;
            // 
            // ColumnDiarias
            // 
            ColumnDiarias.HeaderText = "Diárias";
            ColumnDiarias.MinimumWidth = 3;
            ColumnDiarias.Name = "ColumnDiarias";
            ColumnDiarias.ReadOnly = true;
            ColumnDiarias.Width = 50;
            // 
            // ColumnValor
            // 
            ColumnValor.HeaderText = "Valor";
            ColumnValor.Name = "ColumnValor";
            ColumnValor.ReadOnly = true;
            ColumnValor.Width = 70;
            // 
            // ColumnInicio
            // 
            ColumnInicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnInicio.HeaderText = "Inicio";
            ColumnInicio.Name = "ColumnInicio";
            ColumnInicio.ReadOnly = true;
            // 
            // ColumnFim
            // 
            ColumnFim.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnFim.HeaderText = "Fim";
            ColumnFim.Name = "ColumnFim";
            ColumnFim.ReadOnly = true;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Visible = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(605, 51);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(605, 80);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // LocacoesListagemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 294);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "LocacoesListagemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locações";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocacoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonCadastrar;
        private DataGridView dataGridViewLocacoes;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnVeiculo;
        private DataGridViewTextBoxColumn ColumnDiarias;
        private DataGridViewTextBoxColumn ColumnValor;
        private DataGridViewTextBoxColumn ColumnInicio;
        private DataGridViewTextBoxColumn ColumnFim;
        private DataGridViewTextBoxColumn ColumnId;
        private Button buttonExcluir;
        private Button buttonEditar;
    }
}