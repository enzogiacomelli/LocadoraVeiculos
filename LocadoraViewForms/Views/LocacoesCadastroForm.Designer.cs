namespace LocadoraViewForms.Views
{
    partial class LocacoesCadastroForm
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
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFim = new DateTimePicker();
            groupBox1 = new GroupBox();
            textBoxDiarias = new TextBox();
            label9 = new Label();
            label8 = new Label();
            button2 = new Button();
            textBoxPlaca = new TextBox();
            buttonSalvar = new Button();
            textBoxDesconto = new TextBox();
            textBoxValorTotal = new TextBox();
            textBoxValorDiaria = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBoxVeiculo = new ComboBox();
            comboBoxCliente = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(6, 88);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(259, 23);
            dateTimePickerInicio.TabIndex = 0;
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.Location = new Point(6, 141);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(259, 23);
            dateTimePickerFim.TabIndex = 1;
            dateTimePickerFim.ValueChanged += dateTimePickerFim_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxDiarias);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBoxPlaca);
            groupBox1.Controls.Add(buttonSalvar);
            groupBox1.Controls.Add(textBoxDesconto);
            groupBox1.Controls.Add(textBoxValorTotal);
            groupBox1.Controls.Add(textBoxValorDiaria);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxVeiculo);
            groupBox1.Controls.Add(comboBoxCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePickerInicio);
            groupBox1.Controls.Add(dateTimePickerFim);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 349);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nova Locação";
            // 
            // textBoxDiarias
            // 
            textBoxDiarias.Location = new Point(144, 204);
            textBoxDiarias.Name = "textBoxDiarias";
            textBoxDiarias.ReadOnly = true;
            textBoxDiarias.Size = new Size(121, 23);
            textBoxDiarias.TabIndex = 19;
            textBoxDiarias.TextChanged += textBoxDiarias_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(144, 186);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 18;
            label9.Text = "Diárias";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(283, 19);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 17;
            label8.Text = "Placa";
            // 
            // button2
            // 
            button2.Location = new Point(87, 320);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(283, 37);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.ReadOnly = true;
            textBoxPlaca.Size = new Size(121, 23);
            textBoxPlaca.TabIndex = 16;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(6, 320);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 4;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBoxDesconto
            // 
            textBoxDesconto.Location = new Point(6, 264);
            textBoxDesconto.Name = "textBoxDesconto";
            textBoxDesconto.ReadOnly = true;
            textBoxDesconto.Size = new Size(121, 23);
            textBoxDesconto.TabIndex = 15;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.Location = new Point(144, 264);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(121, 23);
            textBoxValorTotal.TabIndex = 14;
            textBoxValorTotal.TextChanged += textBoxValorTotal_TextChanged;
            // 
            // textBoxValorDiaria
            // 
            textBoxValorDiaria.Location = new Point(6, 204);
            textBoxValorDiaria.Name = "textBoxValorDiaria";
            textBoxValorDiaria.ReadOnly = true;
            textBoxValorDiaria.Size = new Size(121, 23);
            textBoxValorDiaria.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 246);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 12;
            label7.Text = "Desconto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 246);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 11;
            label6.Text = "Valor Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 186);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 10;
            label5.Text = "Valor da diária";
            // 
            // comboBoxVeiculo
            // 
            comboBoxVeiculo.FormattingEnabled = true;
            comboBoxVeiculo.Location = new Point(144, 37);
            comboBoxVeiculo.Name = "comboBoxVeiculo";
            comboBoxVeiculo.Size = new Size(121, 23);
            comboBoxVeiculo.TabIndex = 9;
            comboBoxVeiculo.SelectedIndexChanged += comboBoxVeiculo_SelectedIndexChanged;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(6, 37);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(121, 23);
            comboBoxCliente.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 19);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Veículo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 123);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "Fim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Inicio";
            // 
            // LocacoesCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 373);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "LocacoesCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locações";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFim;
        private GroupBox groupBox1;
        private Label label3;
        private Button button2;
        private Button buttonSalvar;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label8;
        private TextBox textBoxPlaca;
        private TextBox textBoxDesconto;
        private TextBox textBoxValorTotal;
        private TextBox textBoxValorDiaria;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxVeiculo;
        private ComboBox comboBoxCliente;
        private TextBox textBoxDiarias;
        private Label label9;
    }
}