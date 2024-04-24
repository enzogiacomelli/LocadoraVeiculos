namespace LocadoraViewForms.Views
{
    partial class ClientesCadastroForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNome = new TextBox();
            textBoxDocumento = new TextBox();
            textBoxTelefone = new TextBox();
            buttonCadastrar = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 125);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(6, 36);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(245, 23);
            textBoxNome.TabIndex = 3;
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.Location = new Point(6, 90);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.Size = new Size(160, 23);
            textBoxDocumento.TabIndex = 4;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(6, 143);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(160, 23);
            textBoxTelefone.TabIndex = 5;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(176, 143);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 6;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTelefone);
            groupBox1.Controls.Add(buttonCadastrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxDocumento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 185);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 208);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "ClientesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNome;
        private TextBox textBoxDocumento;
        private TextBox textBoxTelefone;
        private Button buttonCadastrar;
        private GroupBox groupBox1;
    }
}