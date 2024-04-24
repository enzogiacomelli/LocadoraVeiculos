namespace LocadoraViewForms.Views
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoClienteToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            veículosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            veículosToolStripMenuItem1 = new ToolStripMenuItem();
            locaçõesToolStripMenuItem = new ToolStripMenuItem();
            novaToolStripMenuItem = new ToolStripMenuItem();
            locaçõesToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            labelVeiculosDisponiveis = new Label();
            labelLocacoesAtivas = new Label();
            labelTotalClientes = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, veículosToolStripMenuItem, locaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(376, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoClienteToolStripMenuItem, clientesToolStripMenuItem1 });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoClienteToolStripMenuItem
            // 
            novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            novoClienteToolStripMenuItem.Size = new Size(116, 22);
            novoClienteToolStripMenuItem.Text = "Novo";
            novoClienteToolStripMenuItem.Click += novoClienteToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(116, 22);
            clientesToolStripMenuItem1.Text = "Clientes";
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            // 
            // veículosToolStripMenuItem
            // 
            veículosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, veículosToolStripMenuItem1 });
            veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            veículosToolStripMenuItem.Size = new Size(62, 20);
            veículosToolStripMenuItem.Text = "Veículos";
            veículosToolStripMenuItem.Click += veículosToolStripMenuItem_Click;
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(117, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // veículosToolStripMenuItem1
            // 
            veículosToolStripMenuItem1.Name = "veículosToolStripMenuItem1";
            veículosToolStripMenuItem1.Size = new Size(117, 22);
            veículosToolStripMenuItem1.Text = "Veículos";
            veículosToolStripMenuItem1.Click += veículosToolStripMenuItem1_Click;
            // 
            // locaçõesToolStripMenuItem
            // 
            locaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaToolStripMenuItem, locaçõesToolStripMenuItem1 });
            locaçõesToolStripMenuItem.Name = "locaçõesToolStripMenuItem";
            locaçõesToolStripMenuItem.Size = new Size(68, 20);
            locaçõesToolStripMenuItem.Text = "Locações";
            locaçõesToolStripMenuItem.Click += locaçõesToolStripMenuItem_Click;
            // 
            // novaToolStripMenuItem
            // 
            novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            novaToolStripMenuItem.Size = new Size(180, 22);
            novaToolStripMenuItem.Text = "Nova";
            novaToolStripMenuItem.Click += novaToolStripMenuItem_Click;
            // 
            // locaçõesToolStripMenuItem1
            // 
            locaçõesToolStripMenuItem1.Name = "locaçõesToolStripMenuItem1";
            locaçõesToolStripMenuItem1.Size = new Size(180, 22);
            locaçõesToolStripMenuItem1.Text = "Locações";
            locaçõesToolStripMenuItem1.Click += locaçõesToolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Total de clientes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Veículos disponiveis:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 44);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 3;
            label3.Text = "Locações Ativas:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelVeiculosDisponiveis);
            groupBox1.Controls.Add(labelLocacoesAtivas);
            groupBox1.Controls.Add(labelTotalClientes);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 103);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // labelVeiculosDisponiveis
            // 
            labelVeiculosDisponiveis.AutoSize = true;
            labelVeiculosDisponiveis.Location = new Point(127, 70);
            labelVeiculosDisponiveis.Name = "labelVeiculosDisponiveis";
            labelVeiculosDisponiveis.Size = new Size(13, 15);
            labelVeiculosDisponiveis.TabIndex = 6;
            labelVeiculosDisponiveis.Text = "0";
            // 
            // labelLocacoesAtivas
            // 
            labelLocacoesAtivas.AutoSize = true;
            labelLocacoesAtivas.Location = new Point(106, 44);
            labelLocacoesAtivas.Name = "labelLocacoesAtivas";
            labelLocacoesAtivas.Size = new Size(13, 15);
            labelLocacoesAtivas.TabIndex = 5;
            labelLocacoesAtivas.Text = "0";
            // 
            // labelTotalClientes
            // 
            labelTotalClientes.AutoSize = true;
            labelTotalClientes.Location = new Point(106, 19);
            labelTotalClientes.Name = "labelTotalClientes";
            labelTotalClientes.Size = new Size(13, 15);
            labelTotalClientes.TabIndex = 4;
            labelTotalClientes.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(14, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 225);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ultimas locações cadastradas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(333, 197);
            dataGridView1.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 373);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem veículosToolStripMenuItem;
        private ToolStripMenuItem locaçõesToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label labelVeiculosDisponiveis;
        private Label labelLocacoesAtivas;
        private Label labelTotalClientes;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem novoClienteToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem veículosToolStripMenuItem1;
        private ToolStripMenuItem novaToolStripMenuItem;
        private ToolStripMenuItem locaçõesToolStripMenuItem1;
    }
}