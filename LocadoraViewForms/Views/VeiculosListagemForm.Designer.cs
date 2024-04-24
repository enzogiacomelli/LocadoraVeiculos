namespace LocadoraViewForms.Views
{
    partial class VeiculosListagemForm
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
            dataGridViewVeiculos = new DataGridView();
            ColumnFabricante = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnPlaca = new DataGridViewTextBoxColumn();
            ColumnQuilometragem = new DataGridViewTextBoxColumn();
            ColumnValorDiaria = new DataGridViewTextBoxColumn();
            ColumnTipo = new DataGridViewTextBoxColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            buttonNovo = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            buttonAtualizar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVeiculos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewVeiculos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Veiculos Cadastrados";
            // 
            // dataGridViewVeiculos
            // 
            dataGridViewVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVeiculos.Columns.AddRange(new DataGridViewColumn[] { ColumnFabricante, ColumnNome, ColumnPlaca, ColumnQuilometragem, ColumnValorDiaria, ColumnTipo, ColumnId });
            dataGridViewVeiculos.Location = new Point(6, 22);
            dataGridViewVeiculos.Name = "dataGridViewVeiculos";
            dataGridViewVeiculos.Size = new Size(542, 315);
            dataGridViewVeiculos.TabIndex = 0;
            // 
            // ColumnFabricante
            // 
            ColumnFabricante.HeaderText = "Fabricante";
            ColumnFabricante.Name = "ColumnFabricante";
            ColumnFabricante.ReadOnly = true;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Veículo";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnPlaca
            // 
            ColumnPlaca.HeaderText = "Placa";
            ColumnPlaca.Name = "ColumnPlaca";
            ColumnPlaca.ReadOnly = true;
            // 
            // ColumnQuilometragem
            // 
            ColumnQuilometragem.HeaderText = "Quilometragem";
            ColumnQuilometragem.Name = "ColumnQuilometragem";
            ColumnQuilometragem.ReadOnly = true;
            // 
            // ColumnValorDiaria
            // 
            ColumnValorDiaria.HeaderText = "Diária";
            ColumnValorDiaria.Name = "ColumnValorDiaria";
            ColumnValorDiaria.ReadOnly = true;
            // 
            // ColumnTipo
            // 
            ColumnTipo.HeaderText = "Tipo";
            ColumnTipo.Name = "ColumnTipo";
            ColumnTipo.ReadOnly = true;
            ColumnTipo.Visible = false;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.Visible = false;
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(571, 59);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 23);
            buttonNovo.TabIndex = 1;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(571, 88);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(571, 117);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(571, 146);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(75, 23);
            buttonAtualizar.TabIndex = 4;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // VeiculosListagemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 367);
            Controls.Add(buttonAtualizar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNovo);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "VeiculosListagemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veiculos";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVeiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewVeiculos;
        private Button buttonNovo;
        private Button buttonEditar;
        private Button buttonExcluir;
        private Button buttonAtualizar;
        private DataGridViewTextBoxColumn ColumnFabricante;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnPlaca;
        private DataGridViewTextBoxColumn ColumnQuilometragem;
        private DataGridViewTextBoxColumn ColumnValorDiaria;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnId;
    }
}