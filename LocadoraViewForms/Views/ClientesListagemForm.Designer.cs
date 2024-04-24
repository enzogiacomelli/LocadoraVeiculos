namespace LocadoraViewForms.Views
{
    partial class ClientesListagemForm
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
            ButtonAtualizarLista = new Button();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            buttonNovo = new Button();
            dataGridViewClientes = new DataGridView();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnDocumento = new DataGridViewTextBoxColumn();
            ColumnTelefone = new DataGridViewTextBoxColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ButtonAtualizarLista);
            groupBox1.Controls.Add(buttonExcluir);
            groupBox1.Controls.Add(buttonEditar);
            groupBox1.Controls.Add(buttonNovo);
            groupBox1.Controls.Add(dataGridViewClientes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 294);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes Cadastrados";
            // 
            // ButtonAtualizarLista
            // 
            ButtonAtualizarLista.Location = new Point(441, 109);
            ButtonAtualizarLista.Name = "ButtonAtualizarLista";
            ButtonAtualizarLista.Size = new Size(75, 23);
            ButtonAtualizarLista.TabIndex = 4;
            ButtonAtualizarLista.Text = "Atualizar";
            ButtonAtualizarLista.UseVisualStyleBackColor = true;
            ButtonAtualizarLista.Click += ButtonAtualizarLista_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(441, 80);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(440, 51);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(440, 22);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 23);
            buttonNovo.TabIndex = 1;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { ColumnNome, ColumnDocumento, ColumnTelefone, ColumnId });
            dataGridViewClientes.Location = new Point(6, 22);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(428, 266);
            dataGridViewClientes.TabIndex = 0;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.Width = 150;
            // 
            // ColumnDocumento
            // 
            ColumnDocumento.HeaderText = "Documento";
            ColumnDocumento.Name = "ColumnDocumento";
            // 
            // ColumnTelefone
            // 
            ColumnTelefone.HeaderText = "Telefone";
            ColumnTelefone.Name = "ColumnTelefone";
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Visible = false;
            // 
            // ClientesListagemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 318);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "ClientesListagemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewClientes;
        private Button buttonNovo;
        private Button buttonExcluir;
        private Button buttonEditar;
        private Button ButtonAtualizarLista;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnDocumento;
        private DataGridViewTextBoxColumn ColumnTelefone;
        private DataGridViewTextBoxColumn ColumnId;
    }
}