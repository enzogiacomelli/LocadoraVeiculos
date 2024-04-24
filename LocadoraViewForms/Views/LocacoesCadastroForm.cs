using LocadoraRepositorios.Controller;
using LocadoraRepositorios.Models;

namespace LocadoraViewForms.Views
{
    public partial class LocacoesCadastroForm : Form
    {
        IVeiculoController veiculoController;
        IClienteController clienteController;
        ILocacoesController locacoesController;
        public LocacoesCadastroForm()
        {
            InitializeComponent();
            veiculoController = new VeiculoController();
            clienteController = new ClienteController();
            locacoesController = new LocacoesController();
            CarregarListagemVeiculos();
            CarregarListagemClientes();
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)comboBoxCliente.SelectedItem;
            var veiculo = (Veiculo)comboBoxVeiculo.SelectedItem;
            var diarias = Convert.ToInt32(textBoxDiarias.Text);
            var valorFinal = Convert.ToDecimal(textBoxValorTotal.Text);
            var inicio = dateTimePickerInicio.Value;
            var fim = dateTimePickerFim.Value;

            var locacao = new Locacao();
            locacao.ClienteId = cliente.Id;
            locacao.VeiculoId = veiculo.Id;
            locacao.Diarias = diarias;
            locacao.ValorFinal = valorFinal;
            locacao.Inicio = inicio;
            locacao.Fim = fim;

            locacoesController.Cadastrar(locacao);

            MessageBox.Show("Locação cadastrada com sucesso!");
            this.Close();
        }

        private void CarregarListagemClientes()
        {
            comboBoxCliente.Items.Clear();
            comboBoxCliente.DisplayMember = "Nome";
            var clientes = clienteController.ObterTodos();

            foreach (Cliente cliente in clientes)
            {
                comboBoxCliente.Items.Add(cliente);
            }
        }
        private void CarregarListagemVeiculos()
        {
            comboBoxVeiculo.Items.Clear();
            comboBoxVeiculo.DisplayMember = "Nome";
            var veiculos = veiculoController.ObterTodos();

            foreach (Veiculo veiculo in veiculos)
            {
                comboBoxVeiculo.Items.Add(veiculo);
            }
        }

        private void comboBoxVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var veiculo = (Veiculo)comboBoxVeiculo.SelectedItem;
            textBoxPlaca.Text = veiculo.Placa;
            textBoxValorDiaria.Text = veiculo.ValorDiaria.ToString();
        }

        private void textBoxValorTotal_TextChanged(object sender, EventArgs e)
        {
            var diaria = Convert.ToDecimal(textBoxValorDiaria.Text);
            var total = Convert.ToDecimal(textBoxValorTotal.Text);
            var inicio = dateTimePickerInicio.Value;
            var fim = dateTimePickerFim.Value;
            var totalSemDesconto = diaria * Convert.ToDecimal((fim - inicio).TotalDays);

            if (total < totalSemDesconto)
            {
                textBoxDesconto.Text = (total - totalSemDesconto).ToString();
            }
        }

        private void dateTimePickerFim_ValueChanged(object sender, EventArgs e)
        {
            var inicio = dateTimePickerInicio.Value;
            var fim = dateTimePickerFim.Value;

            var diariasHoras = fim - inicio;
            var diarias = Convert.ToInt32(diariasHoras.TotalDays);

            textBoxDiarias.Text = diarias.ToString();
        }

        private void textBoxDiarias_TextChanged(object sender, EventArgs e)
        {
            var diarias = Convert.ToInt32(textBoxDiarias.Text);
            var valorDiaria = Convert.ToDecimal(textBoxValorDiaria.Text);
            var valorTotal = diarias * valorDiaria;

            textBoxValorTotal.Text = valorTotal.ToString();
        }
    }
}