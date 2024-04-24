namespace LocadoraViewForms
{
    partial class VeiculoCadastroForm
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
            buttonNovaFabricante = new Button();
            btnSalvar = new Button();
            textBoxValorDiaria = new TextBox();
            label4 = new Label();
            textBoxKm = new TextBox();
            textBoxPlaca = new TextBox();
            checkBoxEhMoto = new CheckBox();
            checkBoxEhCarro = new CheckBox();
            comboBoxFabricante = new ComboBox();
            textBoxNome = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonNovaFabricante);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(textBoxValorDiaria);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxKm);
            groupBox1.Controls.Add(textBoxPlaca);
            groupBox1.Controls.Add(checkBoxEhMoto);
            groupBox1.Controls.Add(checkBoxEhCarro);
            groupBox1.Controls.Add(comboBoxFabricante);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Veículo";
            // 
            // buttonNovaFabricante
            // 
            buttonNovaFabricante.Location = new Point(168, 36);
            buttonNovaFabricante.Name = "buttonNovaFabricante";
            buttonNovaFabricante.Size = new Size(75, 23);
            buttonNovaFabricante.TabIndex = 15;
            buttonNovaFabricante.Text = "Nova";
            buttonNovaFabricante.UseVisualStyleBackColor = true;
            buttonNovaFabricante.Click += buttonNovaFabricante_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(168, 175);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // textBoxValorDiaria
            // 
            textBoxValorDiaria.Location = new Point(126, 132);
            textBoxValorDiaria.Name = "textBoxValorDiaria";
            textBoxValorDiaria.Size = new Size(117, 23);
            textBoxValorDiaria.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 114);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 12;
            label4.Text = "Valor da Diária";
            // 
            // textBoxKm
            // 
            textBoxKm.Location = new Point(6, 132);
            textBoxKm.Name = "textBoxKm";
            textBoxKm.Size = new Size(117, 23);
            textBoxKm.TabIndex = 11;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(6, 176);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(91, 23);
            textBoxPlaca.TabIndex = 10;
            // 
            // checkBoxEhMoto
            // 
            checkBoxEhMoto.AutoSize = true;
            checkBoxEhMoto.Location = new Point(107, 183);
            checkBoxEhMoto.Name = "checkBoxEhMoto";
            checkBoxEhMoto.Size = new Size(55, 19);
            checkBoxEhMoto.TabIndex = 9;
            checkBoxEhMoto.Text = "Moto";
            checkBoxEhMoto.UseVisualStyleBackColor = true;
            // 
            // checkBoxEhCarro
            // 
            checkBoxEhCarro.AutoSize = true;
            checkBoxEhCarro.Location = new Point(107, 158);
            checkBoxEhCarro.Name = "checkBoxEhCarro";
            checkBoxEhCarro.Size = new Size(55, 19);
            checkBoxEhCarro.TabIndex = 8;
            checkBoxEhCarro.Text = "Carro";
            checkBoxEhCarro.UseVisualStyleBackColor = true;
            // 
            // comboBoxFabricante
            // 
            comboBoxFabricante.FormattingEnabled = true;
            comboBoxFabricante.Location = new Point(6, 37);
            comboBoxFabricante.Name = "comboBoxFabricante";
            comboBoxFabricante.Size = new Size(156, 23);
            comboBoxFabricante.TabIndex = 7;
            comboBoxFabricante.DropDown += comboBoxFabricante_DropDown;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(6, 85);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(237, 23);
            textBoxNome.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 114);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 5;
            label6.Text = "Quilometragem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 158);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Fabricante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 67);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // VeiculoCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 230);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VeiculoCadastroForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Veículo";
            Load += VeiculoCadastroForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxFabricante;
        private TextBox textBoxNome;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxValorDiaria;
        private Label label4;
        private TextBox textBoxKm;
        private TextBox textBoxPlaca;
        private CheckBox checkBoxEhMoto;
        private CheckBox checkBoxEhCarro;
        private Button btnSalvar;
        private Button buttonNovaFabricante;
    }
}